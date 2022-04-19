namespace BACSender
{
    partial class DeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OBJECT_IDENTIFIER_label = new System.Windows.Forms.Label();
            this.OBJECT_IDENTIFIER_textBox = new System.Windows.Forms.TextBox();
            this.OBJECT_NAME_textBox = new System.Windows.Forms.TextBox();
            this.OBJECT_NAME_label = new System.Windows.Forms.Label();
            this.OBJECT_TYPE_textBox = new System.Windows.Forms.TextBox();
            this.OBJECT_TYPE_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SYSTEM_STATUS_textBox = new System.Windows.Forms.TextBox();
            this.SYSTEM_STATUS_label = new System.Windows.Forms.Label();
            this.VENDOR_NAME_textBox = new System.Windows.Forms.TextBox();
            this.VENDOR_NAME_label = new System.Windows.Forms.Label();
            this.VENDOR_IDENTIFIER_textBox = new System.Windows.Forms.TextBox();
            this.VENDOR_IDENTIFIER_label = new System.Windows.Forms.Label();
            this.MODEL_NAME_textBox = new System.Windows.Forms.TextBox();
            this.MODEL_NAME_label = new System.Windows.Forms.Label();
            this.FIRMWARE_REVISION_textBox = new System.Windows.Forms.TextBox();
            this.FIRMWARE_REVISION_label = new System.Windows.Forms.Label();
            this.APPLICATION_SOFTWARE_VERSION_textBox = new System.Windows.Forms.TextBox();
            this.APPLICATION_SOFTWARE_VERSION_label = new System.Windows.Forms.Label();
            this.PROTOCOL_VERSION_textBox = new System.Windows.Forms.TextBox();
            this.PROTOCOL_VERSION_label = new System.Windows.Forms.Label();
            this.PROTOCOL_REVISION_textBox = new System.Windows.Forms.TextBox();
            this.PROTOCOL_REVISION_label = new System.Windows.Forms.Label();
            this.PROTOCOL_SERVICES_SUPPORTED_textBox = new System.Windows.Forms.TextBox();
            this.PROTOCOL_SERVICES_SUPPORTED_label = new System.Windows.Forms.Label();
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox = new System.Windows.Forms.TextBox();
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label = new System.Windows.Forms.Label();
            this.MAX_APDU_LENGTH_ACCEPTED_textBox = new System.Windows.Forms.TextBox();
            this.MAX_APDU_LENGTH_ACCEPTED_label = new System.Windows.Forms.Label();
            this.SEGMENTATION_SUPPORTED_textBox = new System.Windows.Forms.TextBox();
            this.SEGMENTATION_SUPPORTED_label = new System.Windows.Forms.Label();
            this.APDU_TIMEOUT_textBox = new System.Windows.Forms.TextBox();
            this.APDU_TIMEOUT_label = new System.Windows.Forms.Label();
            this.NUMBER_OF_APDU_RETRIES_textBox = new System.Windows.Forms.TextBox();
            this.NUMBER_OF_APDU_RETRIES_label = new System.Windows.Forms.Label();
            this.DATABASE_REVISION_textBox = new System.Windows.Forms.TextBox();
            this.DATABASE_REVISION_label = new System.Windows.Forms.Label();
            this.DESCRIPTION_textBox = new System.Windows.Forms.TextBox();
            this.DESCRIPTION_label = new System.Windows.Forms.Label();
            this.LOCATION_textBox = new System.Windows.Forms.TextBox();
            this.LOCATION_label = new System.Windows.Forms.Label();
            this.OBJECT_LIST_label = new System.Windows.Forms.Label();
            this.DEVICE_ADDRESS_BINDING_label = new System.Windows.Forms.Label();
            this.createDeviceButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bacObjectListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteObjectButton = new System.Windows.Forms.Button();
            this.writeXMLButton = new System.Windows.Forms.Button();
            this.changeServicesSupportedButton = new System.Windows.Forms.Button();
            this.changeObjectTypesSupportedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OBJECT_IDENTIFIER_label
            // 
            this.OBJECT_IDENTIFIER_label.AutoSize = true;
            this.OBJECT_IDENTIFIER_label.Location = new System.Drawing.Point(12, 9);
            this.OBJECT_IDENTIFIER_label.Name = "OBJECT_IDENTIFIER_label";
            this.OBJECT_IDENTIFIER_label.Size = new System.Drawing.Size(109, 15);
            this.OBJECT_IDENTIFIER_label.TabIndex = 0;
            this.OBJECT_IDENTIFIER_label.Text = "OBJECT_IDENTIFIER";
            // 
            // OBJECT_IDENTIFIER_textBox
            // 
            this.OBJECT_IDENTIFIER_textBox.Location = new System.Drawing.Point(12, 27);
            this.OBJECT_IDENTIFIER_textBox.Name = "OBJECT_IDENTIFIER_textBox";
            this.OBJECT_IDENTIFIER_textBox.Size = new System.Drawing.Size(164, 23);
            this.OBJECT_IDENTIFIER_textBox.TabIndex = 1;
            this.OBJECT_IDENTIFIER_textBox.Text = "123456";
            // 
            // OBJECT_NAME_textBox
            // 
            this.OBJECT_NAME_textBox.Location = new System.Drawing.Point(12, 80);
            this.OBJECT_NAME_textBox.Name = "OBJECT_NAME_textBox";
            this.OBJECT_NAME_textBox.Size = new System.Drawing.Size(164, 23);
            this.OBJECT_NAME_textBox.TabIndex = 3;
            this.OBJECT_NAME_textBox.Text = "HelloDevice";
            // 
            // OBJECT_NAME_label
            // 
            this.OBJECT_NAME_label.AutoSize = true;
            this.OBJECT_NAME_label.Location = new System.Drawing.Point(12, 62);
            this.OBJECT_NAME_label.Name = "OBJECT_NAME_label";
            this.OBJECT_NAME_label.Size = new System.Drawing.Size(86, 15);
            this.OBJECT_NAME_label.TabIndex = 2;
            this.OBJECT_NAME_label.Text = "OBJECT_NAME";
            // 
            // OBJECT_TYPE_textBox
            // 
            this.OBJECT_TYPE_textBox.Location = new System.Drawing.Point(12, 133);
            this.OBJECT_TYPE_textBox.Name = "OBJECT_TYPE_textBox";
            this.OBJECT_TYPE_textBox.Size = new System.Drawing.Size(164, 23);
            this.OBJECT_TYPE_textBox.TabIndex = 5;
            this.OBJECT_TYPE_textBox.Text = "8";
            // 
            // OBJECT_TYPE_label
            // 
            this.OBJECT_TYPE_label.AutoSize = true;
            this.OBJECT_TYPE_label.Location = new System.Drawing.Point(12, 115);
            this.OBJECT_TYPE_label.Name = "OBJECT_TYPE_label";
            this.OBJECT_TYPE_label.Size = new System.Drawing.Size(78, 15);
            this.OBJECT_TYPE_label.TabIndex = 4;
            this.OBJECT_TYPE_label.Text = "OBJECT_TYPE";
            // 
            // SYSTEM_STATUS_textBox
            // 
            this.SYSTEM_STATUS_textBox.Location = new System.Drawing.Point(12, 186);
            this.SYSTEM_STATUS_textBox.Name = "SYSTEM_STATUS_textBox";
            this.SYSTEM_STATUS_textBox.Size = new System.Drawing.Size(164, 23);
            this.SYSTEM_STATUS_textBox.TabIndex = 7;
            this.SYSTEM_STATUS_textBox.Text = "0";
            // 
            // SYSTEM_STATUS_label
            // 
            this.SYSTEM_STATUS_label.AutoSize = true;
            this.SYSTEM_STATUS_label.Location = new System.Drawing.Point(12, 168);
            this.SYSTEM_STATUS_label.Name = "SYSTEM_STATUS_label";
            this.SYSTEM_STATUS_label.Size = new System.Drawing.Size(92, 15);
            this.SYSTEM_STATUS_label.TabIndex = 6;
            this.SYSTEM_STATUS_label.Text = "SYSTEM_STATUS";
            // 
            // VENDOR_NAME_textBox
            // 
            this.VENDOR_NAME_textBox.Location = new System.Drawing.Point(12, 239);
            this.VENDOR_NAME_textBox.Name = "VENDOR_NAME_textBox";
            this.VENDOR_NAME_textBox.ReadOnly = true;
            this.VENDOR_NAME_textBox.Size = new System.Drawing.Size(164, 23);
            this.VENDOR_NAME_textBox.TabIndex = 9;
            // 
            // VENDOR_NAME_label
            // 
            this.VENDOR_NAME_label.AutoSize = true;
            this.VENDOR_NAME_label.Location = new System.Drawing.Point(12, 221);
            this.VENDOR_NAME_label.Name = "VENDOR_NAME_label";
            this.VENDOR_NAME_label.Size = new System.Drawing.Size(92, 15);
            this.VENDOR_NAME_label.TabIndex = 8;
            this.VENDOR_NAME_label.Text = "VENDOR_NAME";
            // 
            // VENDOR_IDENTIFIER_textBox
            // 
            this.VENDOR_IDENTIFIER_textBox.Location = new System.Drawing.Point(12, 292);
            this.VENDOR_IDENTIFIER_textBox.Name = "VENDOR_IDENTIFIER_textBox";
            this.VENDOR_IDENTIFIER_textBox.Size = new System.Drawing.Size(164, 23);
            this.VENDOR_IDENTIFIER_textBox.TabIndex = 11;
            this.VENDOR_IDENTIFIER_textBox.Text = "9";
            this.VENDOR_IDENTIFIER_textBox.TextChanged += new System.EventHandler(this.VENDOR_IDENTIFIER_textBox_TextChanged);
            // 
            // VENDOR_IDENTIFIER_label
            // 
            this.VENDOR_IDENTIFIER_label.AutoSize = true;
            this.VENDOR_IDENTIFIER_label.Location = new System.Drawing.Point(12, 274);
            this.VENDOR_IDENTIFIER_label.Name = "VENDOR_IDENTIFIER_label";
            this.VENDOR_IDENTIFIER_label.Size = new System.Drawing.Size(115, 15);
            this.VENDOR_IDENTIFIER_label.TabIndex = 10;
            this.VENDOR_IDENTIFIER_label.Text = "VENDOR_IDENTIFIER";
            // 
            // MODEL_NAME_textBox
            // 
            this.MODEL_NAME_textBox.Location = new System.Drawing.Point(12, 345);
            this.MODEL_NAME_textBox.Name = "MODEL_NAME_textBox";
            this.MODEL_NAME_textBox.Size = new System.Drawing.Size(164, 23);
            this.MODEL_NAME_textBox.TabIndex = 13;
            this.MODEL_NAME_textBox.Text = "Test_Modell";
            // 
            // MODEL_NAME_label
            // 
            this.MODEL_NAME_label.AutoSize = true;
            this.MODEL_NAME_label.Location = new System.Drawing.Point(12, 327);
            this.MODEL_NAME_label.Name = "MODEL_NAME_label";
            this.MODEL_NAME_label.Size = new System.Drawing.Size(86, 15);
            this.MODEL_NAME_label.TabIndex = 12;
            this.MODEL_NAME_label.Text = "MODEL_NAME";
            // 
            // FIRMWARE_REVISION_textBox
            // 
            this.FIRMWARE_REVISION_textBox.Location = new System.Drawing.Point(12, 398);
            this.FIRMWARE_REVISION_textBox.Name = "FIRMWARE_REVISION_textBox";
            this.FIRMWARE_REVISION_textBox.Size = new System.Drawing.Size(164, 23);
            this.FIRMWARE_REVISION_textBox.TabIndex = 15;
            this.FIRMWARE_REVISION_textBox.Text = "0";
            // 
            // FIRMWARE_REVISION_label
            // 
            this.FIRMWARE_REVISION_label.AutoSize = true;
            this.FIRMWARE_REVISION_label.Location = new System.Drawing.Point(12, 380);
            this.FIRMWARE_REVISION_label.Name = "FIRMWARE_REVISION_label";
            this.FIRMWARE_REVISION_label.Size = new System.Drawing.Size(121, 15);
            this.FIRMWARE_REVISION_label.TabIndex = 14;
            this.FIRMWARE_REVISION_label.Text = "FIRMWARE_REVISION";
            // 
            // APPLICATION_SOFTWARE_VERSION_textBox
            // 
            this.APPLICATION_SOFTWARE_VERSION_textBox.Location = new System.Drawing.Point(12, 451);
            this.APPLICATION_SOFTWARE_VERSION_textBox.Name = "APPLICATION_SOFTWARE_VERSION_textBox";
            this.APPLICATION_SOFTWARE_VERSION_textBox.Size = new System.Drawing.Size(164, 23);
            this.APPLICATION_SOFTWARE_VERSION_textBox.TabIndex = 17;
            this.APPLICATION_SOFTWARE_VERSION_textBox.Text = "0";
            // 
            // APPLICATION_SOFTWARE_VERSION_label
            // 
            this.APPLICATION_SOFTWARE_VERSION_label.AutoSize = true;
            this.APPLICATION_SOFTWARE_VERSION_label.Location = new System.Drawing.Point(12, 433);
            this.APPLICATION_SOFTWARE_VERSION_label.Name = "APPLICATION_SOFTWARE_VERSION_label";
            this.APPLICATION_SOFTWARE_VERSION_label.Size = new System.Drawing.Size(169, 15);
            this.APPLICATION_SOFTWARE_VERSION_label.TabIndex = 16;
            this.APPLICATION_SOFTWARE_VERSION_label.Text = "APPLICATION_SOFTWARE_VER";
            // 
            // PROTOCOL_VERSION_textBox
            // 
            this.PROTOCOL_VERSION_textBox.Location = new System.Drawing.Point(12, 504);
            this.PROTOCOL_VERSION_textBox.Name = "PROTOCOL_VERSION_textBox";
            this.PROTOCOL_VERSION_textBox.Size = new System.Drawing.Size(164, 23);
            this.PROTOCOL_VERSION_textBox.TabIndex = 19;
            this.PROTOCOL_VERSION_textBox.Text = "1";
            // 
            // PROTOCOL_VERSION_label
            // 
            this.PROTOCOL_VERSION_label.AutoSize = true;
            this.PROTOCOL_VERSION_label.Location = new System.Drawing.Point(12, 486);
            this.PROTOCOL_VERSION_label.Name = "PROTOCOL_VERSION_label";
            this.PROTOCOL_VERSION_label.Size = new System.Drawing.Size(118, 15);
            this.PROTOCOL_VERSION_label.TabIndex = 18;
            this.PROTOCOL_VERSION_label.Text = "PROTOCOL_VERSION";
            this.PROTOCOL_VERSION_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PROTOCOL_REVISION_textBox
            // 
            this.PROTOCOL_REVISION_textBox.Location = new System.Drawing.Point(182, 27);
            this.PROTOCOL_REVISION_textBox.Name = "PROTOCOL_REVISION_textBox";
            this.PROTOCOL_REVISION_textBox.Size = new System.Drawing.Size(160, 23);
            this.PROTOCOL_REVISION_textBox.TabIndex = 21;
            this.PROTOCOL_REVISION_textBox.Text = "14";
            // 
            // PROTOCOL_REVISION_label
            // 
            this.PROTOCOL_REVISION_label.AutoSize = true;
            this.PROTOCOL_REVISION_label.Location = new System.Drawing.Point(185, 9);
            this.PROTOCOL_REVISION_label.Name = "PROTOCOL_REVISION_label";
            this.PROTOCOL_REVISION_label.Size = new System.Drawing.Size(121, 15);
            this.PROTOCOL_REVISION_label.TabIndex = 20;
            this.PROTOCOL_REVISION_label.Text = "PROTOCOL_REVISION";
            this.PROTOCOL_REVISION_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PROTOCOL_SERVICES_SUPPORTED_textBox
            // 
            this.PROTOCOL_SERVICES_SUPPORTED_textBox.Location = new System.Drawing.Point(182, 80);
            this.PROTOCOL_SERVICES_SUPPORTED_textBox.Name = "PROTOCOL_SERVICES_SUPPORTED_textBox";
            this.PROTOCOL_SERVICES_SUPPORTED_textBox.Size = new System.Drawing.Size(75, 23);
            this.PROTOCOL_SERVICES_SUPPORTED_textBox.TabIndex = 23;
            this.PROTOCOL_SERVICES_SUPPORTED_textBox.Text = "0000000000001011000000000010000100100000";
            // 
            // PROTOCOL_SERVICES_SUPPORTED_label
            // 
            this.PROTOCOL_SERVICES_SUPPORTED_label.AutoSize = true;
            this.PROTOCOL_SERVICES_SUPPORTED_label.Location = new System.Drawing.Point(185, 62);
            this.PROTOCOL_SERVICES_SUPPORTED_label.Name = "PROTOCOL_SERVICES_SUPPORTED_label";
            this.PROTOCOL_SERVICES_SUPPORTED_label.Size = new System.Drawing.Size(124, 15);
            this.PROTOCOL_SERVICES_SUPPORTED_label.TabIndex = 22;
            this.PROTOCOL_SERVICES_SUPPORTED_label.Text = "SERVICES_SUPPORTED";
            this.PROTOCOL_SERVICES_SUPPORTED_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox
            // 
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Location = new System.Drawing.Point(182, 133);
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Name = "PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox";
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Size = new System.Drawing.Size(75, 23);
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.TabIndex = 25;
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox.Text = "101000001000000000000000000000000000000000000000000";
            // 
            // PROTOCOL_OBJECT_TYPES_SUPPORTED_label
            // 
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.AutoSize = true;
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.Location = new System.Drawing.Point(185, 115);
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.Name = "PROTOCOL_OBJECT_TYPES_SUPPORTED_label";
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.Size = new System.Drawing.Size(152, 15);
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.TabIndex = 24;
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.Text = "OBJECT_TYPES_SUPPORTED";
            this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MAX_APDU_LENGTH_ACCEPTED_textBox
            // 
            this.MAX_APDU_LENGTH_ACCEPTED_textBox.Location = new System.Drawing.Point(182, 186);
            this.MAX_APDU_LENGTH_ACCEPTED_textBox.Name = "MAX_APDU_LENGTH_ACCEPTED_textBox";
            this.MAX_APDU_LENGTH_ACCEPTED_textBox.Size = new System.Drawing.Size(160, 23);
            this.MAX_APDU_LENGTH_ACCEPTED_textBox.TabIndex = 27;
            this.MAX_APDU_LENGTH_ACCEPTED_textBox.Text = "1476";
            // 
            // MAX_APDU_LENGTH_ACCEPTED_label
            // 
            this.MAX_APDU_LENGTH_ACCEPTED_label.AutoSize = true;
            this.MAX_APDU_LENGTH_ACCEPTED_label.Location = new System.Drawing.Point(185, 168);
            this.MAX_APDU_LENGTH_ACCEPTED_label.Name = "MAX_APDU_LENGTH_ACCEPTED_label";
            this.MAX_APDU_LENGTH_ACCEPTED_label.Size = new System.Drawing.Size(180, 15);
            this.MAX_APDU_LENGTH_ACCEPTED_label.TabIndex = 26;
            this.MAX_APDU_LENGTH_ACCEPTED_label.Text = "MAX_APDU_LENGTH_ACCEPTED";
            this.MAX_APDU_LENGTH_ACCEPTED_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SEGMENTATION_SUPPORTED_textBox
            // 
            this.SEGMENTATION_SUPPORTED_textBox.Location = new System.Drawing.Point(182, 239);
            this.SEGMENTATION_SUPPORTED_textBox.Name = "SEGMENTATION_SUPPORTED_textBox";
            this.SEGMENTATION_SUPPORTED_textBox.Size = new System.Drawing.Size(160, 23);
            this.SEGMENTATION_SUPPORTED_textBox.TabIndex = 29;
            this.SEGMENTATION_SUPPORTED_textBox.Text = "3";
            // 
            // SEGMENTATION_SUPPORTED_label
            // 
            this.SEGMENTATION_SUPPORTED_label.AutoSize = true;
            this.SEGMENTATION_SUPPORTED_label.Location = new System.Drawing.Point(185, 221);
            this.SEGMENTATION_SUPPORTED_label.Name = "SEGMENTATION_SUPPORTED_label";
            this.SEGMENTATION_SUPPORTED_label.Size = new System.Drawing.Size(160, 15);
            this.SEGMENTATION_SUPPORTED_label.TabIndex = 28;
            this.SEGMENTATION_SUPPORTED_label.Text = "SEGMENTATION_SUPPORTED";
            this.SEGMENTATION_SUPPORTED_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // APDU_TIMEOUT_textBox
            // 
            this.APDU_TIMEOUT_textBox.Location = new System.Drawing.Point(182, 292);
            this.APDU_TIMEOUT_textBox.Name = "APDU_TIMEOUT_textBox";
            this.APDU_TIMEOUT_textBox.Size = new System.Drawing.Size(160, 23);
            this.APDU_TIMEOUT_textBox.TabIndex = 31;
            this.APDU_TIMEOUT_textBox.Text = "3000";
            // 
            // APDU_TIMEOUT_label
            // 
            this.APDU_TIMEOUT_label.AutoSize = true;
            this.APDU_TIMEOUT_label.Location = new System.Drawing.Point(185, 274);
            this.APDU_TIMEOUT_label.Name = "APDU_TIMEOUT_label";
            this.APDU_TIMEOUT_label.Size = new System.Drawing.Size(92, 15);
            this.APDU_TIMEOUT_label.TabIndex = 30;
            this.APDU_TIMEOUT_label.Text = "APDU_TIMEOUT";
            this.APDU_TIMEOUT_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUMBER_OF_APDU_RETRIES_textBox
            // 
            this.NUMBER_OF_APDU_RETRIES_textBox.Location = new System.Drawing.Point(182, 345);
            this.NUMBER_OF_APDU_RETRIES_textBox.Name = "NUMBER_OF_APDU_RETRIES_textBox";
            this.NUMBER_OF_APDU_RETRIES_textBox.Size = new System.Drawing.Size(160, 23);
            this.NUMBER_OF_APDU_RETRIES_textBox.TabIndex = 33;
            this.NUMBER_OF_APDU_RETRIES_textBox.Text = "3";
            // 
            // NUMBER_OF_APDU_RETRIES_label
            // 
            this.NUMBER_OF_APDU_RETRIES_label.AutoSize = true;
            this.NUMBER_OF_APDU_RETRIES_label.Location = new System.Drawing.Point(185, 327);
            this.NUMBER_OF_APDU_RETRIES_label.Name = "NUMBER_OF_APDU_RETRIES_label";
            this.NUMBER_OF_APDU_RETRIES_label.Size = new System.Drawing.Size(84, 15);
            this.NUMBER_OF_APDU_RETRIES_label.TabIndex = 32;
            this.NUMBER_OF_APDU_RETRIES_label.Text = "APDU_RETRIES";
            this.NUMBER_OF_APDU_RETRIES_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DATABASE_REVISION_textBox
            // 
            this.DATABASE_REVISION_textBox.Location = new System.Drawing.Point(182, 398);
            this.DATABASE_REVISION_textBox.Name = "DATABASE_REVISION_textBox";
            this.DATABASE_REVISION_textBox.Size = new System.Drawing.Size(160, 23);
            this.DATABASE_REVISION_textBox.TabIndex = 35;
            this.DATABASE_REVISION_textBox.Text = "0";
            // 
            // DATABASE_REVISION_label
            // 
            this.DATABASE_REVISION_label.AutoSize = true;
            this.DATABASE_REVISION_label.Location = new System.Drawing.Point(185, 380);
            this.DATABASE_REVISION_label.Name = "DATABASE_REVISION_label";
            this.DATABASE_REVISION_label.Size = new System.Drawing.Size(117, 15);
            this.DATABASE_REVISION_label.TabIndex = 34;
            this.DATABASE_REVISION_label.Text = "DATABASE_REVISION";
            this.DATABASE_REVISION_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DESCRIPTION_textBox
            // 
            this.DESCRIPTION_textBox.Location = new System.Drawing.Point(182, 451);
            this.DESCRIPTION_textBox.Name = "DESCRIPTION_textBox";
            this.DESCRIPTION_textBox.Size = new System.Drawing.Size(160, 23);
            this.DESCRIPTION_textBox.TabIndex = 37;
            this.DESCRIPTION_textBox.Text = "test_Description";
            // 
            // DESCRIPTION_label
            // 
            this.DESCRIPTION_label.AutoSize = true;
            this.DESCRIPTION_label.Location = new System.Drawing.Point(185, 433);
            this.DESCRIPTION_label.Name = "DESCRIPTION_label";
            this.DESCRIPTION_label.Size = new System.Drawing.Size(79, 15);
            this.DESCRIPTION_label.TabIndex = 36;
            this.DESCRIPTION_label.Text = "DESCRIPTION";
            this.DESCRIPTION_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LOCATION_textBox
            // 
            this.LOCATION_textBox.Location = new System.Drawing.Point(182, 504);
            this.LOCATION_textBox.Name = "LOCATION_textBox";
            this.LOCATION_textBox.Size = new System.Drawing.Size(160, 23);
            this.LOCATION_textBox.TabIndex = 39;
            this.LOCATION_textBox.Text = "DE";
            // 
            // LOCATION_label
            // 
            this.LOCATION_label.AutoSize = true;
            this.LOCATION_label.Location = new System.Drawing.Point(185, 486);
            this.LOCATION_label.Name = "LOCATION_label";
            this.LOCATION_label.Size = new System.Drawing.Size(64, 15);
            this.LOCATION_label.TabIndex = 38;
            this.LOCATION_label.Text = "LOCATION";
            this.LOCATION_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OBJECT_LIST_label
            // 
            this.OBJECT_LIST_label.AutoSize = true;
            this.OBJECT_LIST_label.Location = new System.Drawing.Point(12, 539);
            this.OBJECT_LIST_label.Name = "OBJECT_LIST_label";
            this.OBJECT_LIST_label.Size = new System.Drawing.Size(105, 15);
            this.OBJECT_LIST_label.TabIndex = 40;
            this.OBJECT_LIST_label.Text = "OBJECT_LIST: soon";
            this.OBJECT_LIST_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DEVICE_ADDRESS_BINDING_label
            // 
            this.DEVICE_ADDRESS_BINDING_label.AutoSize = true;
            this.DEVICE_ADDRESS_BINDING_label.Location = new System.Drawing.Point(185, 539);
            this.DEVICE_ADDRESS_BINDING_label.Name = "DEVICE_ADDRESS_BINDING_label";
            this.DEVICE_ADDRESS_BINDING_label.Size = new System.Drawing.Size(194, 15);
            this.DEVICE_ADDRESS_BINDING_label.TabIndex = 41;
            this.DEVICE_ADDRESS_BINDING_label.Text = "DEVICE_ADDRESS_BINDING: hidden";
            this.DEVICE_ADDRESS_BINDING_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createDeviceButton
            // 
            this.createDeviceButton.Location = new System.Drawing.Point(16, 575);
            this.createDeviceButton.Name = "createDeviceButton";
            this.createDeviceButton.Size = new System.Drawing.Size(160, 23);
            this.createDeviceButton.TabIndex = 42;
            this.createDeviceButton.Text = "Create Device";
            this.createDeviceButton.UseVisualStyleBackColor = true;
            this.createDeviceButton.Click += new System.EventHandler(this.createXMLButton_Click);
            // 
            // bacObjectListView
            // 
            this.bacObjectListView.Location = new System.Drawing.Point(389, 12);
            this.bacObjectListView.Name = "bacObjectListView";
            this.bacObjectListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bacObjectListView.Size = new System.Drawing.Size(312, 542);
            this.bacObjectListView.TabIndex = 43;
            this.bacObjectListView.UseCompatibleStateImageBehavior = false;
            this.bacObjectListView.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addObjectButton_Click);
            // 
            // deleteObjectButton
            // 
            this.deleteObjectButton.Location = new System.Drawing.Point(555, 567);
            this.deleteObjectButton.Name = "deleteObjectButton";
            this.deleteObjectButton.Size = new System.Drawing.Size(146, 23);
            this.deleteObjectButton.TabIndex = 45;
            this.deleteObjectButton.Text = "-";
            this.deleteObjectButton.UseVisualStyleBackColor = true;
            this.deleteObjectButton.Click += new System.EventHandler(this.deleteObjectButton_Click);
            // 
            // writeXMLButton
            // 
            this.writeXMLButton.Location = new System.Drawing.Point(182, 575);
            this.writeXMLButton.Name = "writeXMLButton";
            this.writeXMLButton.Size = new System.Drawing.Size(160, 23);
            this.writeXMLButton.TabIndex = 46;
            this.writeXMLButton.Text = "Write XML-File";
            this.writeXMLButton.UseVisualStyleBackColor = true;
            this.writeXMLButton.Click += new System.EventHandler(this.writeXMLButton_Click);
            // 
            // changeServicesSupportedButton
            // 
            this.changeServicesSupportedButton.Location = new System.Drawing.Point(267, 80);
            this.changeServicesSupportedButton.Name = "changeServicesSupportedButton";
            this.changeServicesSupportedButton.Size = new System.Drawing.Size(75, 23);
            this.changeServicesSupportedButton.TabIndex = 47;
            this.changeServicesSupportedButton.Text = "Change";
            this.changeServicesSupportedButton.UseVisualStyleBackColor = true;
            this.changeServicesSupportedButton.Click += new System.EventHandler(this.changeServicesSupportedButton_Click);
            // 
            // changeObjectTypesSupportedButton
            // 
            this.changeObjectTypesSupportedButton.Location = new System.Drawing.Point(267, 133);
            this.changeObjectTypesSupportedButton.Name = "changeObjectTypesSupportedButton";
            this.changeObjectTypesSupportedButton.Size = new System.Drawing.Size(75, 23);
            this.changeObjectTypesSupportedButton.TabIndex = 48;
            this.changeObjectTypesSupportedButton.Text = "Change";
            this.changeObjectTypesSupportedButton.UseVisualStyleBackColor = true;
            this.changeObjectTypesSupportedButton.Click += new System.EventHandler(this.changeObjectTypesSupportedButton_Click);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 610);
            this.Controls.Add(this.changeObjectTypesSupportedButton);
            this.Controls.Add(this.changeServicesSupportedButton);
            this.Controls.Add(this.writeXMLButton);
            this.Controls.Add(this.deleteObjectButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bacObjectListView);
            this.Controls.Add(this.createDeviceButton);
            this.Controls.Add(this.DEVICE_ADDRESS_BINDING_label);
            this.Controls.Add(this.OBJECT_LIST_label);
            this.Controls.Add(this.LOCATION_textBox);
            this.Controls.Add(this.LOCATION_label);
            this.Controls.Add(this.DESCRIPTION_textBox);
            this.Controls.Add(this.DESCRIPTION_label);
            this.Controls.Add(this.DATABASE_REVISION_textBox);
            this.Controls.Add(this.DATABASE_REVISION_label);
            this.Controls.Add(this.NUMBER_OF_APDU_RETRIES_textBox);
            this.Controls.Add(this.NUMBER_OF_APDU_RETRIES_label);
            this.Controls.Add(this.APDU_TIMEOUT_textBox);
            this.Controls.Add(this.APDU_TIMEOUT_label);
            this.Controls.Add(this.SEGMENTATION_SUPPORTED_textBox);
            this.Controls.Add(this.SEGMENTATION_SUPPORTED_label);
            this.Controls.Add(this.MAX_APDU_LENGTH_ACCEPTED_textBox);
            this.Controls.Add(this.MAX_APDU_LENGTH_ACCEPTED_label);
            this.Controls.Add(this.PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox);
            this.Controls.Add(this.PROTOCOL_OBJECT_TYPES_SUPPORTED_label);
            this.Controls.Add(this.PROTOCOL_SERVICES_SUPPORTED_textBox);
            this.Controls.Add(this.PROTOCOL_SERVICES_SUPPORTED_label);
            this.Controls.Add(this.PROTOCOL_REVISION_textBox);
            this.Controls.Add(this.PROTOCOL_REVISION_label);
            this.Controls.Add(this.PROTOCOL_VERSION_textBox);
            this.Controls.Add(this.PROTOCOL_VERSION_label);
            this.Controls.Add(this.APPLICATION_SOFTWARE_VERSION_textBox);
            this.Controls.Add(this.APPLICATION_SOFTWARE_VERSION_label);
            this.Controls.Add(this.FIRMWARE_REVISION_textBox);
            this.Controls.Add(this.FIRMWARE_REVISION_label);
            this.Controls.Add(this.MODEL_NAME_textBox);
            this.Controls.Add(this.MODEL_NAME_label);
            this.Controls.Add(this.VENDOR_IDENTIFIER_textBox);
            this.Controls.Add(this.VENDOR_IDENTIFIER_label);
            this.Controls.Add(this.VENDOR_NAME_textBox);
            this.Controls.Add(this.VENDOR_NAME_label);
            this.Controls.Add(this.SYSTEM_STATUS_textBox);
            this.Controls.Add(this.SYSTEM_STATUS_label);
            this.Controls.Add(this.OBJECT_TYPE_textBox);
            this.Controls.Add(this.OBJECT_TYPE_label);
            this.Controls.Add(this.OBJECT_NAME_textBox);
            this.Controls.Add(this.OBJECT_NAME_label);
            this.Controls.Add(this.OBJECT_IDENTIFIER_textBox);
            this.Controls.Add(this.OBJECT_IDENTIFIER_label);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OBJECT_IDENTIFIER_label;
        private TextBox OBJECT_IDENTIFIER_textBox;
        private TextBox OBJECT_NAME_textBox;
        private Label OBJECT_NAME_label;
        private TextBox OBJECT_TYPE_textBox;
        private Label OBJECT_TYPE_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox SYSTEM_STATUS_textBox;
        private Label SYSTEM_STATUS_label;
        private TextBox VENDOR_NAME_textBox;
        private Label VENDOR_NAME_label;
        private TextBox VENDOR_IDENTIFIER_textBox;
        private Label VENDOR_IDENTIFIER_label;
        private TextBox MODEL_NAME_textBox;
        private Label MODEL_NAME_label;
        private TextBox FIRMWARE_REVISION_textBox;
        private Label FIRMWARE_REVISION_label;
        private TextBox APPLICATION_SOFTWARE_VERSION_textBox;
        private Label APPLICATION_SOFTWARE_VERSION_label;
        private TextBox PROTOCOL_VERSION_textBox;
        private Label PROTOCOL_VERSION_label;
        private TextBox PROTOCOL_REVISION_textBox;
        private Label PROTOCOL_REVISION_label;
        private TextBox PROTOCOL_SERVICES_SUPPORTED_textBox;
        private Label PROTOCOL_SERVICES_SUPPORTED_label;
        private TextBox PROTOCOL_OBJECT_TYPES_SUPPORTED_textBox;
        private Label PROTOCOL_OBJECT_TYPES_SUPPORTED_label;
        private TextBox MAX_APDU_LENGTH_ACCEPTED_textBox;
        private Label MAX_APDU_LENGTH_ACCEPTED_label;
        private TextBox SEGMENTATION_SUPPORTED_textBox;
        private Label SEGMENTATION_SUPPORTED_label;
        private TextBox APDU_TIMEOUT_textBox;
        private Label APDU_TIMEOUT_label;
        private TextBox NUMBER_OF_APDU_RETRIES_textBox;
        private Label NUMBER_OF_APDU_RETRIES_label;
        private TextBox DATABASE_REVISION_textBox;
        private Label DATABASE_REVISION_label;
        private TextBox DESCRIPTION_textBox;
        private Label DESCRIPTION_label;
        private TextBox LOCATION_textBox;
        private Label LOCATION_label;
        private Label OBJECT_LIST_label;
        private Label DEVICE_ADDRESS_BINDING_label;
        private Button createDeviceButton;
        private SaveFileDialog saveFileDialog1;
        private ListView bacObjectListView;
        private Button button1;
        private Button deleteObjectButton;
        private Button writeXMLButton;
        private Button changeServicesSupportedButton;
        private Button changeObjectTypesSupportedButton;
    }
}