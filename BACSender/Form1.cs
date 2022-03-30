using BACSender.Base.Enums;
using BACSender.XMLHandler.Types;

namespace BACSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0000000000001010000000000010000000100000".Count().ToString();
            DisplaySupportedServices();

            List<BacnetSupportedServices> bacnetSupportedServices = new List<BacnetSupportedServices>();
            bacnetSupportedServices.Add(BacnetSupportedServices.WRITE_PROPERTY);
            bacnetSupportedServices.Add(BacnetSupportedServices.I_AM);
            bacnetSupportedServices.Add(BacnetSupportedServices.WHO_IS);

            richTextBox1.Text = EncodeSupportedServices(bacnetSupportedServices);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = richTextBox1.Text.ToUpper();
            //richTextBox1.Text = richTextBox1.Text.Replace("-", "_");
            //richTextBox1.Text = richTextBox1.Text.Replace("(", "=");
            //richTextBox1.Text = richTextBox1.Text.Replace(")", "");
            //richTextBox1.Text = richTextBox1.Text.Replace("__", "");
            //richTextBox1.Text = richTextBox1.Text.Replace("SEE", "");


            //richTextBox1.Text = richTextBox1.Text.Replace("ü", "deviceStorage.Objects.Object[0].Properties.Property.Add(new Property(\"");
            //richTextBox1.Text = richTextBox1.Text.Replace("ä", "\", \"");
            //richTextBox1.Text = richTextBox1.Text.Replace("ö", "\", new List<string>() { new string(\"\") })); ");

            //richTextBox1.Text = richTextBox1.Text.Replace("{", "");
            //richTextBox1.Text = richTextBox1.Text.Replace("},", ",");
            //richTextBox1.Text = richTextBox1.Text.Replace(", ", "=");

            foreach (var s in richTextBox1.Lines)
            {
                string[] p = s.Split(new char[] { '"' });
                richTextBox2.Text += p[1] + ",\n";
            }
        }
        private List<BacnetSupportedServices> DecodeSupportedServices(string supportedServices)
        {
            List<BacnetSupportedServices> supportedServicesList = new List<BacnetSupportedServices>();

            for (int i = 39; i > 0; i--)
            {
                if (supportedServices[i] == '1')
                {
                    supportedServicesList.Add((BacnetSupportedServices)i);
                }
            }
            return supportedServicesList;
        }
        private void DisplaySupportedServices()
        {
            List<BacnetSupportedServices> supportedServicesList = DecodeSupportedServices("0000000000001011000000000010000000100000");

            foreach (BacnetSupportedServices service in supportedServicesList)
            {
                richTextBox1.Text += service.ToString() + "\n";
            }
        }
        private string EncodeSupportedServices(List<BacnetSupportedServices> supportedServices)
        {
            char[] supportedServicesArr = "0000000000000000000000000000000000000000".ToCharArray();

            foreach (BacnetSupportedServices service in supportedServices)
            {
                supportedServicesArr[(int)service] = '1';
            }
            return new string(supportedServicesArr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeviceStorage myDevice = XMLHandler.XMLHandler.DeserializeDeviceDescriptor(richTextBox2.Text);
            richTextBox2.Text = "done";
        }
    }
}