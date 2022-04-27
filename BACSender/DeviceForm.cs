using BACSender.Base.Enums;
using BACSender.XMLHandler.Types;

namespace BACSender
{
    public partial class DeviceForm : Form
    {
        DeviceStorage deviceStorage;
        public DeviceForm()
        {
            InitializeComponent();
            VENDOR_NAME_textBox.Text = BacnetDicationarys.BacnetVendorIdentifier[9];
        }

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            createDeviceStorageWithDeviceObject();
            createDeviceButton.Text = "Reset Device";
            updateListView();
        }

        private void VENDOR_IDENTIFIER_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VENDOR_NAME_textBox.Text = BacnetDicationarys.BacnetVendorIdentifier[Convert.ToInt16(VENDOR_IDENTIFIER_textBox.Text)];
            }
            catch
            {
                VENDOR_IDENTIFIER_textBox.Text = "0";
            }
            finally
            {
                VENDOR_NAME_textBox.Text = BacnetDicationarys.BacnetVendorIdentifier[Convert.ToInt16(VENDOR_IDENTIFIER_textBox.Text)];
            }
        }

        private void addObjectButton_Click(object sender, EventArgs e)
        {
            if (deviceStorage != null)
            {
                CreateBacObject newForm = new CreateBacObject(deviceStorage);
                newForm.ShowDialog();
                updateListView();
            }
            else
                MessageBox.Show("yet no device created");
        }

        private void writeXMLButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem line in bacObjectListView.Items)
            {
                deviceStorage.Objects.Object[0].Properties.Property[1].Value.Add(line.Text);
            }

            if (deviceStorage != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "XML | *.xml";
                saveFileDialog1.Title = "Save the output XML-File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Creates the File via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();

                    XMLHandler.XMLHandler.Serialize(deviceStorage, saveFileDialog1.FileName);
                }
                else
                    MessageBox.Show("yet no device created");
            }
        }
        private void updateListView()
        {
            removeListViewItems();
            foreach (var s in deviceStorage.Objects.Object)
            {
                bacObjectListView.Items.Add(s.Type + ":" + s.Instance);
            }
        }
        private void removeListViewItems()
        {
            foreach (ListViewItem s in bacObjectListView.Items)
            {
                bacObjectListView.Items.Remove(s);
            }
        }
        private void createDeviceStorageWithDeviceObject()
        {
            deviceStorage = new DeviceStorage();
            deviceStorage.Objects = new Objects();
            deviceStorage.Objects.Object = new List<XMLHandler.Types.Object>();
            deviceStorage.Objects.Object.Add(new XMLHandler.Types.Object());
            deviceStorage.Objects.Object[0].Type = "OBJECT_DEVICE";
            deviceStorage.Objects.Object[0].Instance = Convert.ToInt32(OBJECT_IDENTIFIER_textBox.Text);
            deviceStorage.Objects.Object[0].Properties = new Properties();
            deviceStorage.Objects.Object[0].Properties.Property = new List<Property>();

            // 22 Properties for the Device Object
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { new string("OBJECT_DEVICE:" + deviceStorage.Objects.Object[0].Instance.ToString()) }));
            /*TODO maybe decline, or change the comment*/
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_LIST", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() /*{ new string("OBJECT_DEVICE:" + deviceStorage.Objects.Object[0].Instance.ToString()) }*/));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(OBJECT_NAME_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { new string(OBJECT_TYPE_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_SYSTEM_STATUS", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { new string(SYSTEM_STATUS_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_VENDOR_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(VENDOR_NAME_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_VENDOR_IDENTIFIER", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(VENDOR_IDENTIFIER_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_MODEL_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(MODEL_NAME_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_FIRMWARE_REVISION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(FIRMWARE_REVISION_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_APPLICATION_SOFTWARE_VERSION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(APPLICATION_SOFTWARE_VERSION_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_VERSION", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(PROTOCOL_VERSION_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_REVISION", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(PROTOCOL_REVISION_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_SERVICES_SUPPORTED", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { new string(PROTOCOL_SERVICES_SUPPORTED_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_OBJECT_TYPES_SUPPORTED", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { new string(PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_MAX_APDU_LENGTH_ACCEPTED", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(MAX_APDU_LENGTH_ACCEPTED_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_SEGMENTATION_SUPPORTED", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { new string(SEGMENTATION_SUPPORTED_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_APDU_TIMEOUT", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(APDU_TIMEOUT_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_NUMBER_OF_APDU_RETRIES", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(NUMBER_OF_APDU_RETRIES_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_DEVICE_ADDRESS_BINDING", "BACNET_APPLICATION_TAG_NULL", new List<string>())); // always has a null value
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_DATABASE_REVISION", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string(DATABASE_REVISION_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(DESCRIPTION_textBox.Text) }));
            deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_LOCATION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string(LOCATION_textBox.Text) }));
        }

        private void deleteObjectButton_Click(object sender, EventArgs e)
        {
            if (bacObjectListView.SelectedItems != null)
            {
                foreach (var bacObject in deviceStorage.Objects.Object)
                {
                    int i;
                    bool propFound = false;
                    for (i = 0; i < bacObject.Properties.Property.Count; i++)
                    {
                        if (bacObject.Properties.Property[i].Id == "PROP_OBJECT_IDENTIFIER")
                        {
                            propFound = true;
                            break;
                        }
                    }

                    if (propFound)
                    {
                        foreach (var selectedItem in bacObjectListView.SelectedItems)
                        {
                            if (bacObject.Properties.Property[i].Value[0] == (selectedItem as ListViewItem).Text)
                            {
                                if (bacObject.Type == "OBJECT_DEVICE")
                                {
                                    deviceStorage = null;
                                    createDeviceButton.Text = "Create Device";
                                    removeListViewItems();
                                    return;
                                }
                                else
                                {
                                    deviceStorage.Objects.Object.Remove(bacObject);
                                    updateListView();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void changeServicesSupportedButton_Click(object sender, EventArgs e)
        {
            //SupportedServicesForm newForm = new SupportedServicesForm(PROTOCOL_SERVICES_SUPPORTED_textBox.Text);
            //newForm.ShowDialog();
            using (var form = new SupportedServicesForm(PROTOCOL_SERVICES_SUPPORTED_textBox.Text))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.NewSupportedServices;

                    //Do something here with these values
                    PROTOCOL_SERVICES_SUPPORTED_textBox.Text = val;
                }
            }
        }

        private void changeObjectTypesSupportedButton_Click(object sender, EventArgs e)
        {
            using (var form = new SupportedObjectTypesForm(PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Text))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.NewSupportedObjectTypes;

                    //Do something here with these values
                    PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Text = val;
                }
            }
        }
    }
}
//// Properties for the Device Object
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { new string("OBJECT_DEVICE:314159") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_LIST", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_SYSTEM_STATUS", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_VENDOR_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_VENDOR_IDENTIFIER", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_MODEL_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_FIRMWARE_REVISION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_APPLICATION_SOFTWARE_VERSION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_VERSION", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_REVISION", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_SERVICES_SUPPORTED", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_PROTOCOL_OBJECT_TYPES_SUPPORTED", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_MAX_APDU_LENGTH_ACCEPTED", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_SEGMENTATION_SUPPORTED", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_APDU_TIMEOUT", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_NUMBER_OF_APDU_RETRIES", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_DEVICE_ADDRESS_BINDING", "BACNET_APPLICATION_TAG_NULL", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_DATABASE_REVISION", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));
//deviceStorage.Objects.Object[0].Properties.Property.Add(new Property("PROP_LOCATION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { new string("") }));