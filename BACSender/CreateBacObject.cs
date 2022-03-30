using BACSender.Base.Enums;
using BACSender.XMLHandler.Types;


namespace BACSender
{
    public partial class CreateBacObject : Form
    {
        DeviceStorage deviceStorage;
        public CreateBacObject(DeviceStorage _deviceStorage)
        {
            InitializeComponent();
            deviceStorage = _deviceStorage;
        }
        /// <summary>
        /// Sets the writabillity of object properties of the analog input object.
        /// </summary>
        private void analogInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeObjectIdentifierTextBox(sender);
            writeObjectTypeTextBox(sender);
            DESCRIPTION_textBox.ReadOnly = false;
            OBJECT_IDENTIFIER_textBox.ReadOnly = true;
            OBJECT_NAME_textBox.ReadOnly = false;
            OBJECT_TYPE_textBox.ReadOnly = true;
            POLARITY_textBox.ReadOnly = true;
            PRESENT_VALUE_textBox.ReadOnly = false;
            PRIORITY_ARRAY_textBox.ReadOnly = true;
            RELINQUISH_DEFAULT_textBox.ReadOnly = true;
            STATUS_FLAGS_textBox.ReadOnly = false;

            //careful, inverted logic
            RELIABILITY_comboBox.Enabled = true;
            UNITS_comboBox.Enabled = true;
            OUT_OF_SERVICE_comboBox.Enabled = true;
        }
        /// <summary>
        /// Sets the writabillity of object properties of the binary input object.
        /// </summary>
        private void binaryInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeObjectIdentifierTextBox(sender);
            writeObjectTypeTextBox(sender);
            DESCRIPTION_textBox.ReadOnly = false;
            OBJECT_IDENTIFIER_textBox.ReadOnly = true;
            OBJECT_NAME_textBox.ReadOnly = false;
            OBJECT_TYPE_textBox.ReadOnly = true;
            POLARITY_textBox.ReadOnly = false;
            PRESENT_VALUE_textBox.ReadOnly = false;
            PRIORITY_ARRAY_textBox.ReadOnly = true;
            RELINQUISH_DEFAULT_textBox.ReadOnly = true;
            STATUS_FLAGS_textBox.ReadOnly = false;

            //careful, inverted logic
            RELIABILITY_comboBox.Enabled = true;
            UNITS_comboBox.Enabled = false;
            OUT_OF_SERVICE_comboBox.Enabled = true;
        }
        /// <summary>
        /// Sets the writabillity of object properties of the binary output object.
        /// </summary>
        private void binaryOutputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeObjectIdentifierTextBox(sender);
            writeObjectTypeTextBox(sender);
            DESCRIPTION_textBox.ReadOnly = false;
            OBJECT_IDENTIFIER_textBox.ReadOnly = true;
            OBJECT_NAME_textBox.ReadOnly = false;
            OBJECT_TYPE_textBox.ReadOnly = true;
            POLARITY_textBox.ReadOnly = true;
            PRESENT_VALUE_textBox.ReadOnly = false;
            PRIORITY_ARRAY_textBox.ReadOnly = false;
            RELINQUISH_DEFAULT_textBox.ReadOnly = false;
            STATUS_FLAGS_textBox.ReadOnly = false;

            //careful, inverted logic
            RELIABILITY_comboBox.Enabled = true;
            UNITS_comboBox.Enabled = false;
            OUT_OF_SERVICE_comboBox.Enabled = true;
        }
        /// <summary>
        /// Sets the writabillity of object properties of the analog value object.
        /// </summary>
        private void analogValueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeObjectIdentifierTextBox(sender);
            writeObjectTypeTextBox(sender);
            DESCRIPTION_textBox.ReadOnly = false;
            OBJECT_IDENTIFIER_textBox.ReadOnly = true;
            OBJECT_NAME_textBox.ReadOnly = false;
            OBJECT_TYPE_textBox.ReadOnly = true;
            POLARITY_textBox.ReadOnly = true;
            PRESENT_VALUE_textBox.ReadOnly = false;
            PRIORITY_ARRAY_textBox.ReadOnly = true;
            RELINQUISH_DEFAULT_textBox.ReadOnly = true;
            STATUS_FLAGS_textBox.ReadOnly = false;

            //careful, inverted logic
            RELIABILITY_comboBox.Enabled = true;
            UNITS_comboBox.Enabled = true;
            OUT_OF_SERVICE_comboBox.Enabled = true;
        }
        /// <summary>
        /// Sets the writabillity of object properties of the characterstring object.
        /// </summary>
        private void characterStringValueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            writeObjectIdentifierTextBox(sender);
            writeObjectTypeTextBox(sender);
            DESCRIPTION_textBox.ReadOnly = false;
            OBJECT_IDENTIFIER_textBox.ReadOnly = true;
            OBJECT_NAME_textBox.ReadOnly = false;
            OBJECT_TYPE_textBox.ReadOnly = true;
            POLARITY_textBox.ReadOnly = true;
            PRESENT_VALUE_textBox.ReadOnly = false;
            PRIORITY_ARRAY_textBox.ReadOnly = true;
            RELINQUISH_DEFAULT_textBox.ReadOnly = true;
            STATUS_FLAGS_textBox.ReadOnly = false;

            //careful, inverted logic
            RELIABILITY_comboBox.Enabled = true;
            UNITS_comboBox.Enabled = false;
            OUT_OF_SERVICE_comboBox.Enabled = true;
        }
        /// <summary>
        /// Counts the number of specified objects inside of the global device descriptor.
        /// </summary>
        /// <param name="objectType">Bacnet-Type of the objects to count</param>
        /// <returns>Number of specific Bacnet objects inside the global device descriptor.</returns>
        /// <example>GetSpecificInstanceCount("OBJECT_ANALOG_INPUT")</example>
        private int GetSpecificInstanceCount(string objectType)
        {
            int specificObjectCount = 0;
            foreach (var obj in deviceStorage.Objects.Object)
            {
                if (obj.Type == objectType)
                {
                    specificObjectCount++;
                }
            }
            return specificObjectCount;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            createObject();
            this.Close(); //close the form, after creating the new object
        }

        private void createObject()
        {
            // differ between object tpyes
            if (analogInputRadioButton.Checked)
            {
                int objectCount = deviceStorage.Objects.Object.Count();
                deviceStorage.Objects.Object.Add(new XMLHandler.Types.Object());
                deviceStorage.Objects.Object[objectCount].Instance = Convert.ToInt32(GetSpecificInstanceCount("OBJECT_ANALOG_INPUT")); //TODO: fix Instance is always 0
                deviceStorage.Objects.Object[objectCount].Type = "OBJECT_ANALOG_INPUT";
                deviceStorage.Objects.Object[objectCount].Properties = new Properties
                {
                    Property = new List<Property>
                    {
                        new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { DESCRIPTION_textBox.Text }),
                        new Property("PROP_EVENT_STATE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { EVENT_STATE_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { deviceStorage.Objects.Object[objectCount].Type + ":" + deviceStorage.Objects.Object[objectCount].Instance }),
                        new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { OBJECT_NAME_textBox.Text }),
                        new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { OBJECT_TYPE_textBox.Text }),
                        new Property("PROP_OUT_OF_SERVICE", "BACNET_APPLICATION_TAG_BOOLEAN", new List<string>() { OUT_OF_SERVICE_comboBox.Text }),
                        new Property("PROP_PRESENT_VALUE", "BACNET_APPLICATION_TAG_DOUBLE", new List<string>() { PRESENT_VALUE_textBox.Text }),
                        new Property("PROP_RELIABILITY", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { RELIABILITY_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_STATUS_FLAGS", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { STATUS_FLAGS_textBox.Text }),
                        new Property("PROP_UNITS", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { UNITS_comboBox.SelectedIndex.ToString() })
                    }
                };
            }
            else if (binaryInputRadioButton.Checked)
            {
                int objectCount = deviceStorage.Objects.Object.Count();
                deviceStorage.Objects.Object.Add(new XMLHandler.Types.Object());
                deviceStorage.Objects.Object[objectCount].Instance = Convert.ToInt32(GetSpecificInstanceCount("OBJECT_BINARY_INPUT"));
                deviceStorage.Objects.Object[objectCount].Type = "OBJECT_BINARY_INPUT";
                deviceStorage.Objects.Object[objectCount].Properties = new Properties
                {
                    Property = new List<Property>
                    {
                        new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { DESCRIPTION_textBox.Text }),
                        new Property("PROP_EVENT_STATE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { EVENT_STATE_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { deviceStorage.Objects.Object[objectCount].Type + ":" + deviceStorage.Objects.Object[objectCount].Instance }),
                        new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { OBJECT_NAME_textBox.Text }),
                        new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { BacnetDicationarys.BACnetObjectType[Convert.ToInt16(OBJECT_TYPE_textBox.Text)] }),
                        new Property("PROP_OUT_OF_SERVICE", "BACNET_APPLICATION_TAG_BOOLEAN", new List<string>() { OUT_OF_SERVICE_comboBox.Text }),
                        new Property("PROP_PRESENT_VALUE", "BACNET_APPLICATION_TAG_DOUBLE", new List<string>() { PRESENT_VALUE_textBox.Text }),
                        new Property("PROP_RELIABILITY", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { RELIABILITY_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_STATUS_FLAGS", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { STATUS_FLAGS_textBox.Text })
                    }
                };
            }
            else if (binaryOutputRadioButton.Checked)
            {
                int objectCount = deviceStorage.Objects.Object.Count();
                deviceStorage.Objects.Object.Add(new XMLHandler.Types.Object());
                deviceStorage.Objects.Object[objectCount].Instance = Convert.ToInt32(GetSpecificInstanceCount("OBJECT_BINARY_OUTPUT"));
                deviceStorage.Objects.Object[objectCount].Type = "OBJECT_BINARY_OUTPUT";
                deviceStorage.Objects.Object[objectCount].Properties = new Properties
                {
                    Property = new List<Property>
                    {
                        new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { DESCRIPTION_textBox.Text }),
                        new Property("PROP_EVENT_STATE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { EVENT_STATE_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { deviceStorage.Objects.Object[objectCount].Type + ":" + deviceStorage.Objects.Object[objectCount].Instance }),
                        new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { OBJECT_NAME_textBox.Text }),
                        new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { BacnetDicationarys.BACnetObjectType[Convert.ToInt16(OBJECT_TYPE_textBox.Text)] }),
                        new Property("PROP_OUT_OF_SERVICE", "BACNET_APPLICATION_TAG_BOOLEAN", new List<string>() { OUT_OF_SERVICE_comboBox.Text }),
                        new Property("PROP_PRESENT_VALUE", "BACNET_APPLICATION_TAG_DOUBLE", new List<string>() { PRESENT_VALUE_textBox.Text }),
                        new Property("PROP_PRIORITY_ARRAY", "BACNET_APPLICATION_TAG_NULL", new List<string>() { "", "", "", "", "", "", "", "","", "", "", "", "", "", "", "" }),
                        new Property("PROP_RELINQUISH_DEFAULT", "BACNET_APPLICATION_TAG_UNSIGNED_INT", new List<string>() { RELINQUISH_DEFAULT_textBox.Text }),
                        new Property("PROP_RELIABILITY", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { RELIABILITY_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_STATUS_FLAGS", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { STATUS_FLAGS_textBox.Text })
                    }
                };
            }
            else if (analogValueRadioButton.Checked)
            {
                int objectCount = deviceStorage.Objects.Object.Count();
                deviceStorage.Objects.Object.Add(new XMLHandler.Types.Object());
                deviceStorage.Objects.Object[objectCount].Instance = Convert.ToInt32(GetSpecificInstanceCount("OBJECT_ANALOG_INPUT")); //TODO: fix Instance is always 0
                deviceStorage.Objects.Object[objectCount].Type = "OBJECT_ANALOG_INPUT";
                deviceStorage.Objects.Object[objectCount].Properties = new Properties
                {
                    Property = new List<Property>
                    {
                        new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { DESCRIPTION_textBox.Text }),
                        new Property("PROP_EVENT_STATE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { EVENT_STATE_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { deviceStorage.Objects.Object[objectCount].Type + ":" + deviceStorage.Objects.Object[objectCount].Instance }),
                        new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { OBJECT_NAME_textBox.Text }),
                        new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { OBJECT_TYPE_textBox.Text }),
                        new Property("PROP_OUT_OF_SERVICE", "BACNET_APPLICATION_TAG_BOOLEAN", new List<string>() { OUT_OF_SERVICE_comboBox.Text }),
                        new Property("PROP_PRESENT_VALUE", "BACNET_APPLICATION_TAG_DOUBLE", new List<string>() { PRESENT_VALUE_textBox.Text }),
                        new Property("PROP_RELIABILITY", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { RELIABILITY_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_STATUS_FLAGS", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { STATUS_FLAGS_textBox.Text }),
                        new Property("PROP_UNITS", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { UNITS_comboBox.SelectedIndex.ToString() })
                    }
                };
            }
            else if (characterStringValueRadioButton.Checked)
            {
                int objectCount = deviceStorage.Objects.Object.Count();
                deviceStorage.Objects.Object.Add(new XMLHandler.Types.Object());
                deviceStorage.Objects.Object[objectCount].Instance = Convert.ToInt32(GetSpecificInstanceCount("OBJECT_CHARACTERSTRING_VALUE")); //TODO: fix Instance is always 0
                deviceStorage.Objects.Object[objectCount].Type = "OBJECT_CHARACTERSTRING_VALUE";
                deviceStorage.Objects.Object[objectCount].Properties = new Properties
                {
                    Property = new List<Property>
                    {
                        new Property("PROP_DESCRIPTION", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { DESCRIPTION_textBox.Text }),
                        new Property("PROP_EVENT_STATE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { EVENT_STATE_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_OBJECT_IDENTIFIER", "BACNET_APPLICATION_TAG_OBJECT_ID", new List<string>() { deviceStorage.Objects.Object[objectCount].Type + ":" + deviceStorage.Objects.Object[objectCount].Instance }),
                        new Property("PROP_OBJECT_NAME", "BACNET_APPLICATION_TAG_CHARACTER_STRING", new List<string>() { OBJECT_NAME_textBox.Text }),
                        new Property("PROP_OBJECT_TYPE", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { OBJECT_TYPE_textBox.Text }),
                        new Property("PROP_OUT_OF_SERVICE", "BACNET_APPLICATION_TAG_BOOLEAN", new List<string>() { OUT_OF_SERVICE_comboBox.Text }),
                        new Property("PROP_PRESENT_VALUE", "BACNET_APPLICATION_TAG_DOUBLE", new List<string>() { PRESENT_VALUE_textBox.Text }),
                        new Property("PROP_RELIABILITY", "BACNET_APPLICATION_TAG_ENUMERATED", new List<string>() { RELIABILITY_comboBox.SelectedIndex.ToString() }),
                        new Property("PROP_STATUS_FLAGS", "BACNET_APPLICATION_TAG_BIT_STRING", new List<string>() { STATUS_FLAGS_textBox.Text })
                    }
                };
            }
        }

        private void writeObjectIdentifierTextBox(object sender)
        {
            OBJECT_IDENTIFIER_textBox.Text = ("OBJECT_" + (sender as RadioButton).Text + ":" + GetSpecificInstanceCount((sender as RadioButton).Text)).Replace(" ", "_").ToUpper();
        }

        private void writeObjectTypeTextBox(object sender)
        {
            for (int i = 0; i < BacnetDicationarys.BACnetObjectType.Count; i++)
            {
                if (BacnetDicationarys.BACnetObjectType[i] == (sender as RadioButton).Text.Replace(" ", "-").ToLower())
                {
                    OBJECT_TYPE_textBox.Text = i.ToString();
                }
            }
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Changes the status flag at a certain position.
        /// </summary>
        /// <param name="position">Position of the flag that needs to be changed.</param>
        private void changeStatusFlags(int position, char value)
        {
            char[] statusFlags = new char[4];

            int i = 0;
            foreach (char statusFlag in STATUS_FLAGS_textBox.Text)
            {
                statusFlags[i++] = statusFlag;
            }

            STATUS_FLAGS_textBox.Text = string.Empty;
            statusFlags[position] = value;

            foreach (char status in statusFlags)
            {
                STATUS_FLAGS_textBox.Text += status;
            }
        }
        private void RELIABILITY_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RELIABILITY_comboBox.Text == BacnetDicationarys.BACnetReliability[0])
            {
                changeStatusFlags(1, '0');
            }
            else
            {
                changeStatusFlags(1, '1');
            }
        }
        private void EVENT_STATE_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EVENT_STATE_comboBox.Text == BacnetDicationarys.BACnetEventState[2])
            {
                changeStatusFlags(0, '0');
            }
            else
            {
                changeStatusFlags(0, '1');
            }
        }

        private void OUT_OF_SERVICE_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OUT_OF_SERVICE_comboBox.SelectedIndex == 0)
            {
                changeStatusFlags(3, '0');
            }
            else
            {
                changeStatusFlags(3, '1');
            }
        }
    }
}
