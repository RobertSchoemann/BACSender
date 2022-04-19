using BACSender.Base.Enums;
using System.ComponentModel;

namespace BACSender
{
    public partial class SupportedServicesForm : Form
    {
        private string supportedServices;
        private BindingList<string> someList = new BindingList<string>();
        public SupportedServicesForm(string _supportedServices)
        {
            InitializeComponent();
            supportedServices = _supportedServices;
            label1.Text = "0000000000001011000000000010000100100000".Length.ToString();
            supportedServicesListBox.DataSource = someList;
            DisplaySupportedServices();
        }
        private void DisplaySupportedServices()
        {
            List<BacnetSupportedServices> supportedServicesList = DecodeSupportedServices("0000000000001011000000000010000000100000");

            foreach (BacnetSupportedServices service in supportedServicesList)
            {
                someList.Add(service.ToString());
            }
            supportedServicesListBox.DataSource = someList;
            supportedServicesListBox.Refresh();
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
    }
}
