using BACSender.Base.Enums;
using System.ComponentModel;

namespace BACSender
{
    //TODO implement this
    public partial class SupportedServicesForm : Form
    {
        //private string supportedServices;
        private BindingList<string> supportedList = new BindingList<string>();
        private BindingList<string> notsupportedList = new BindingList<string>();
        private string supportedServices;
        public string NewSupportedServices { get; set; }



        public SupportedServicesForm(string _supportedServices)
        {
            InitializeComponent();
            supportedServices = _supportedServices;
            supportedServicesListBox.DataSource = supportedList;
            servicesListBox.DataSource = notsupportedList;
            DisplayServices();
        }

        private void DisplayServices()
        {
            List<BacnetSupportedServices> servicesList = new List<BacnetSupportedServices>();
            List<BacnetSupportedServices> supportedServicesList = DecodeSupportedServices(out servicesList);

            foreach (BacnetServicesSupported service in servicesList)
            {
                notsupportedList.Add(service.ToString().Replace("SERVICE_SUPPORTED_", ""));
            }

            foreach (BacnetSupportedServices service in supportedServicesList)
            {
                supportedList.Add(service.ToString().Replace("SERVICE_SUPPORTED_", ""));
            }

            //TODO: needed?!
            servicesListBox.DataSource = notsupportedList;
            supportedServicesListBox.DataSource = supportedList;

            servicesListBox.Refresh();
            supportedServicesListBox.Refresh();
        }

        private List<BacnetSupportedServices> DecodeSupportedServices(out List<BacnetSupportedServices> services)
        {
            List<BacnetSupportedServices> supportedServicesList = new List<BacnetSupportedServices>();
            services = new List<BacnetSupportedServices>();

            for (int i = 0; i < 40; i++)
            {
                if (supportedServices[i] == '1')
                {
                    supportedServicesList.Add((BacnetSupportedServices)i);
                }
                else
                {
                    services.Add((BacnetSupportedServices)i);
                }
            }

            return supportedServicesList;
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex != null)
            {
                supportedList.Add(notsupportedList[servicesListBox.SelectedIndex]);
                notsupportedList.RemoveAt(servicesListBox.SelectedIndex);
            }
        }

        private void cancelServiceButton_Click(object sender, EventArgs e)
        {
            if (supportedServicesListBox.SelectedIndex != null)
            {
                notsupportedList.Add(supportedList[supportedServicesListBox.SelectedIndex]);
                supportedList.RemoveAt(supportedServicesListBox.SelectedIndex);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //this.supportedList;
            //this.notsupportedList;
            EncodeSupportedServices();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EncodeSupportedServices()
        {
            string retVal = "0000000000000000000000000000000000000000";

            for (int i = 0; i < 40; i++)
            {
                foreach (string service in supportedList)
                {
                    if (service == ((BacnetSupportedServices)i).ToString())
                    {
                        retVal = retVal.Remove(i, 1);
                        retVal = retVal.Insert(i, "1");
                        supportedList.Remove(service);
                        break;
                    }
                }
            }
            NewSupportedServices = retVal;
        }
    }
}
