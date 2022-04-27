using BACSender.Base.Enums;
using System.ComponentModel;

namespace BACSender
{
    public partial class SupportedObjectTypesForm : Form
    {
        private BindingList<string> supportedList = new BindingList<string>();
        private BindingList<string> notsupportedList = new BindingList<string>();
        private string supportedObjectTypes;
        public string NewSupportedObjectTypes { get; set; }
        public SupportedObjectTypesForm(string _supportedObjectType)
        {
            InitializeComponent();
            supportedObjectTypes = _supportedObjectType;
            supportedObjectTypesListBox.DataSource = supportedList;
            objectTypesListBox.DataSource = notsupportedList;
            DisplayObjectTypes();
        }
        private void DisplayObjectTypes()
        {
            List<BACObjectTypes> objectTypesList = new List<BACObjectTypes>();
            List<BACObjectTypes> supportedObjectTypesList = DecodeSupportedObjectTypes(out objectTypesList);


            foreach (BACObjectTypes service in objectTypesList)
            {
                notsupportedList.Add(service.ToString().Replace("SERVICE_SUPPORTED_", ""));
            }

            foreach (BACObjectTypes service in supportedObjectTypesList)
            {
                supportedList.Add(service.ToString().Replace("SERVICE_SUPPORTED_", ""));
            }

            //TODO: needed?!
            objectTypesListBox.DataSource = notsupportedList;
            supportedObjectTypesListBox.DataSource = supportedList;

            objectTypesListBox.Refresh();
            supportedObjectTypesListBox.Refresh();
        }
        private List<BACObjectTypes> DecodeSupportedObjectTypes(out List<BACObjectTypes> ObjectTypes)
        {
            List<BACObjectTypes> supportedObjectTypesList = new List<BACObjectTypes>();
            ObjectTypes = new List<BACObjectTypes>();

            for (int i = 0; i < 40; i++)
            {
                if (supportedObjectTypes[i] == '1')
                {
                    supportedObjectTypesList.Add((BACObjectTypes)i);
                }
                else
                {
                    ObjectTypes.Add((BACObjectTypes)i);
                }
            }

            return supportedObjectTypesList;
        }

        private void EncodeSupportedObjectTypes()
        {
            string retVal = "0000000000000000000000000000000000000000";

            for (int i = 0; i < 40; i++)
            {
                foreach (string service in supportedList)
                {
                    if (service == ((BACObjectTypes)i).ToString())
                    {
                        retVal = retVal.Remove(i, 1);
                        retVal = retVal.Insert(i, "1");
                        supportedList.Remove(service);
                        break;
                    }
                }
            }
            NewSupportedObjectTypes = retVal;
        }

        private void addObjectTypesButton_Click(object sender, EventArgs e)
        {
            if (objectTypesListBox.SelectedIndex != null)
            {
                supportedList.Add(notsupportedList[objectTypesListBox.SelectedIndex]);
                notsupportedList.RemoveAt(objectTypesListBox.SelectedIndex);
            }
        }

        private void cancelObjectTypesButton_Click(object sender, EventArgs e)
        {
            if (supportedObjectTypesListBox.SelectedIndex != null)
            {
                notsupportedList.Add(supportedList[supportedObjectTypesListBox.SelectedIndex]);
                supportedList.RemoveAt(supportedObjectTypesListBox.SelectedIndex);
            }
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            EncodeSupportedObjectTypes();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
