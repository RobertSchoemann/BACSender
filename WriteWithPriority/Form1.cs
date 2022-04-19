using System.Diagnostics;
using System.IO.BACnet;

namespace WriteWithPriority
{
    public partial class Form1 : Form
    {
        static BacnetClient bacnet_client;

        // All the present Bacnet Device List
        static List<BacNode> DevicesList = new List<BacNode>();
        public Form1()
        {
            InitializeComponent();
            Trace.Listeners.Add(new ConsoleTraceListener());

            try
            {
                StartActivity();
                Console.WriteLine("Started");

                Thread.Sleep(1000); // Wait a fiew time for WhoIs responses (managed in handler_OnIam)

                ReadWriteExample();
            }
            catch { }
        }
        static void StartActivity()
        {
            // Bacnet on UDP/IP/Ethernet
            bacnet_client = new BacnetClient(new BacnetIpUdpProtocolTransport(0xBAC0, false));
            bacnet_client.Start();    // go

            // Send WhoIs in order to get back all the Iam responses :  
            bacnet_client.OnIam += new BacnetClient.IamHandler(handler_OnIam);

            bacnet_client.WhoIs();
        }
        static void ReadWriteExample()
        {

            BacnetValue Value;
            bool ret;
            // Read Present_Value property on the object ANALOG_INPUT:0 provided by the device 12345
            // Scalar value only
            ret = ReadScalarValue(12738, new BacnetObjectId(BacnetObjectTypes.OBJECT_ANALOG_INPUT, 0), BacnetPropertyIds.PROP_PRESENT_VALUE, out Value);

            if (ret == true)
            {
                Console.WriteLine("Read value : " + Value.Value.ToString());

                // Write Present_Value property on the object ANALOG_OUTPUT:0 provided by the device 4000
                BacnetValue newValue = new BacnetValue(Convert.ToSingle(Value.Value));   // expect it's a float
                ret = WriteScalarValue(4000, new BacnetObjectId(BacnetObjectTypes.OBJECT_ANALOG_OUTPUT, 0), BacnetPropertyIds.PROP_PRESENT_VALUE, newValue);

                Console.WriteLine("Write feedback : " + ret.ToString());
            }
            else
                Console.WriteLine("Error somewhere !");
        }

        /*****************************************************************************************************/
        static void handler_OnIam(BacnetClient sender, BacnetAddress adr, uint device_id, uint max_apdu, BacnetSegmentations segmentation, ushort vendor_id)
        {
            lock (DevicesList)
            {
                // Device already registred ?
                foreach (BacNode bn in DevicesList)
                    if (bn.getAdd(device_id) != null) return;   // Yes

                // Not already in the list
                DevicesList.Add(new BacNode(adr, device_id));   // add it
            }
        }

        /*****************************************************************************************************/
        static bool ReadScalarValue(int device_id, BacnetObjectId BacnetObjet, BacnetPropertyIds Propriete, out BacnetValue Value)
        {
            BacnetAddress adr;
            IList<BacnetValue> NoScalarValue;

            Value = new BacnetValue(null);

            // Looking for the device
            adr = DeviceAddr((uint)device_id);
            if (adr == null) return false;  // not found

            // Property Read
            if (bacnet_client.ReadPropertyRequest(adr, BacnetObjet, Propriete, out NoScalarValue) == false)
                return false;

            Value = NoScalarValue[0];
            return true;
        }

        /*****************************************************************************************************/
        static bool WriteScalarValue(int device_id, BacnetObjectId BacnetObjet, BacnetPropertyIds Propriete, BacnetValue Value)
        {
            BacnetAddress adr;

            // Looking for the device
            adr = DeviceAddr((uint)device_id);
            if (adr == null) return false;  // not found

            // Property Write
            BacnetValue[] NoScalarValue = { Value };
            if (bacnet_client.WritePropertyRequest(adr, BacnetObjet, Propriete, NoScalarValue) == false)
                return false;

            return true;
        }

        /*****************************************************************************************************/
        static BacnetAddress DeviceAddr(uint device_id)
        {
            BacnetAddress ret;

            lock (DevicesList)
            {
                foreach (BacNode bn in DevicesList)
                {
                    ret = bn.getAdd(device_id);
                    if (ret != null) return ret;
                }
                // not in the list
                return null;
            }
        }
    }
    class BacNode
    {
        BacnetAddress adr;
        uint device_id;

        public BacNode(BacnetAddress adr, uint device_id)
        {
            this.adr = adr;
            this.device_id = device_id;
        }

        public BacnetAddress getAdd(uint device_id)
        {
            if (this.device_id == device_id)
                return adr;
            else
                return null;
        }
    }
}