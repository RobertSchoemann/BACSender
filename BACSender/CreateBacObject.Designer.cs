using BACSender.Base.Enums;

namespace BACSender
{
    partial class CreateBacObject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBacObject));
            this.supportedBacObjectsLabel = new System.Windows.Forms.Label();
            this.analogInputRadioButton = new System.Windows.Forms.RadioButton();
            this.binaryInputRadioButton = new System.Windows.Forms.RadioButton();
            this.analogValueRadioButton = new System.Windows.Forms.RadioButton();
            this.binaryOutputRadioButton = new System.Windows.Forms.RadioButton();
            this.DESCRIPTION_label = new System.Windows.Forms.Label();
            this.DESCRIPTION_textBox = new System.Windows.Forms.TextBox();
            this.EVENT_STATE_label = new System.Windows.Forms.Label();
            this.OBJECT_NAME_textBox = new System.Windows.Forms.TextBox();
            this.OBJECT_NAME_label = new System.Windows.Forms.Label();
            this.OBJECT_IDENTIFIER_textBox = new System.Windows.Forms.TextBox();
            this.OBJECT_IDENTIFIER_label = new System.Windows.Forms.Label();
            this.PRESENT_VALUE_textBox = new System.Windows.Forms.TextBox();
            this.PRESENT_VALUE_label = new System.Windows.Forms.Label();
            this.POLARITY_textBox = new System.Windows.Forms.TextBox();
            this.POLARITY_label = new System.Windows.Forms.Label();
            this.OUT_OF_SERVICE_label = new System.Windows.Forms.Label();
            this.OBJECT_TYPE_textBox = new System.Windows.Forms.TextBox();
            this.OBJECT_TYPE_label = new System.Windows.Forms.Label();
            this.UNITS_label = new System.Windows.Forms.Label();
            this.STATUS_FLAGS_textBox = new System.Windows.Forms.TextBox();
            this.STATUS_FLAGS_label = new System.Windows.Forms.Label();
            this.RELIABILITY_label = new System.Windows.Forms.Label();
            this.RELINQUISH_DEFAULT_label = new System.Windows.Forms.Label();
            this.PRIORITY_ARRAY_textBox = new System.Windows.Forms.TextBox();
            this.PRIORITY_ARRAY_label = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNITS_comboBox = new System.Windows.Forms.ComboBox();
            this.RELIABILITY_comboBox = new System.Windows.Forms.ComboBox();
            this.RELINQUISH_DEFAULT_textBox = new System.Windows.Forms.TextBox();
            this.EVENT_STATE_comboBox = new System.Windows.Forms.ComboBox();
            this.characterStringValueRadioButton = new System.Windows.Forms.RadioButton();
            this.OUT_OF_SERVICE_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supportedBacObjectsLabel
            // 
            this.supportedBacObjectsLabel.AutoSize = true;
            this.supportedBacObjectsLabel.Location = new System.Drawing.Point(9, 9);
            this.supportedBacObjectsLabel.Name = "supportedBacObjectsLabel";
            this.supportedBacObjectsLabel.Size = new System.Drawing.Size(129, 15);
            this.supportedBacObjectsLabel.TabIndex = 0;
            this.supportedBacObjectsLabel.Text = "Supported Bac-Objects";
            // 
            // analogInputRadioButton
            // 
            this.analogInputRadioButton.AutoSize = true;
            this.analogInputRadioButton.Location = new System.Drawing.Point(12, 29);
            this.analogInputRadioButton.Name = "analogInputRadioButton";
            this.analogInputRadioButton.Size = new System.Drawing.Size(94, 19);
            this.analogInputRadioButton.TabIndex = 1;
            this.analogInputRadioButton.TabStop = true;
            this.analogInputRadioButton.Text = "Analog Input";
            this.analogInputRadioButton.UseVisualStyleBackColor = true;
            this.analogInputRadioButton.CheckedChanged += new System.EventHandler(this.analogInputRadioButton_CheckedChanged);
            // 
            // binaryInputRadioButton
            // 
            this.binaryInputRadioButton.AutoSize = true;
            this.binaryInputRadioButton.Location = new System.Drawing.Point(12, 54);
            this.binaryInputRadioButton.Name = "binaryInputRadioButton";
            this.binaryInputRadioButton.Size = new System.Drawing.Size(89, 19);
            this.binaryInputRadioButton.TabIndex = 2;
            this.binaryInputRadioButton.TabStop = true;
            this.binaryInputRadioButton.Text = "Binary Input";
            this.binaryInputRadioButton.UseVisualStyleBackColor = true;
            this.binaryInputRadioButton.CheckedChanged += new System.EventHandler(this.binaryInputRadioButton_CheckedChanged);
            // 
            // analogValueRadioButton
            // 
            this.analogValueRadioButton.AutoSize = true;
            this.analogValueRadioButton.Location = new System.Drawing.Point(12, 104);
            this.analogValueRadioButton.Name = "analogValueRadioButton";
            this.analogValueRadioButton.Size = new System.Drawing.Size(94, 19);
            this.analogValueRadioButton.TabIndex = 4;
            this.analogValueRadioButton.TabStop = true;
            this.analogValueRadioButton.Text = "Analog Value";
            this.analogValueRadioButton.UseVisualStyleBackColor = true;
            this.analogValueRadioButton.CheckedChanged += new System.EventHandler(this.analogValueRadioButton_CheckedChanged);
            // 
            // binaryOutputRadioButton
            // 
            this.binaryOutputRadioButton.AutoSize = true;
            this.binaryOutputRadioButton.Location = new System.Drawing.Point(12, 79);
            this.binaryOutputRadioButton.Name = "binaryOutputRadioButton";
            this.binaryOutputRadioButton.Size = new System.Drawing.Size(99, 19);
            this.binaryOutputRadioButton.TabIndex = 3;
            this.binaryOutputRadioButton.TabStop = true;
            this.binaryOutputRadioButton.Text = "Binary Output";
            this.binaryOutputRadioButton.UseVisualStyleBackColor = true;
            this.binaryOutputRadioButton.CheckedChanged += new System.EventHandler(this.binaryOutputRadioButton_CheckedChanged);
            // 
            // DESCRIPTION_label
            // 
            this.DESCRIPTION_label.AutoSize = true;
            this.DESCRIPTION_label.Location = new System.Drawing.Point(183, 9);
            this.DESCRIPTION_label.Name = "DESCRIPTION_label";
            this.DESCRIPTION_label.Size = new System.Drawing.Size(79, 15);
            this.DESCRIPTION_label.TabIndex = 5;
            this.DESCRIPTION_label.Text = "DESCRIPTION";
            // 
            // DESCRIPTION_textBox
            // 
            this.DESCRIPTION_textBox.Location = new System.Drawing.Point(183, 27);
            this.DESCRIPTION_textBox.Name = "DESCRIPTION_textBox";
            this.DESCRIPTION_textBox.Size = new System.Drawing.Size(150, 23);
            this.DESCRIPTION_textBox.TabIndex = 6;
            this.DESCRIPTION_textBox.Text = "Test Description";
            // 
            // EVENT_STATE_label
            // 
            this.EVENT_STATE_label.AutoSize = true;
            this.EVENT_STATE_label.Location = new System.Drawing.Point(183, 62);
            this.EVENT_STATE_label.Name = "EVENT_STATE_label";
            this.EVENT_STATE_label.Size = new System.Drawing.Size(76, 15);
            this.EVENT_STATE_label.TabIndex = 7;
            this.EVENT_STATE_label.Text = "EVENT_STATE";
            // 
            // OBJECT_NAME_textBox
            // 
            this.OBJECT_NAME_textBox.Location = new System.Drawing.Point(183, 186);
            this.OBJECT_NAME_textBox.Name = "OBJECT_NAME_textBox";
            this.OBJECT_NAME_textBox.Size = new System.Drawing.Size(150, 23);
            this.OBJECT_NAME_textBox.TabIndex = 12;
            this.OBJECT_NAME_textBox.Text = "TestName";
            // 
            // OBJECT_NAME_label
            // 
            this.OBJECT_NAME_label.AutoSize = true;
            this.OBJECT_NAME_label.Location = new System.Drawing.Point(183, 168);
            this.OBJECT_NAME_label.Name = "OBJECT_NAME_label";
            this.OBJECT_NAME_label.Size = new System.Drawing.Size(86, 15);
            this.OBJECT_NAME_label.TabIndex = 11;
            this.OBJECT_NAME_label.Text = "OBJECT_NAME";
            // 
            // OBJECT_IDENTIFIER_textBox
            // 
            this.OBJECT_IDENTIFIER_textBox.Location = new System.Drawing.Point(183, 133);
            this.OBJECT_IDENTIFIER_textBox.Name = "OBJECT_IDENTIFIER_textBox";
            this.OBJECT_IDENTIFIER_textBox.Size = new System.Drawing.Size(150, 23);
            this.OBJECT_IDENTIFIER_textBox.TabIndex = 10;
            // 
            // OBJECT_IDENTIFIER_label
            // 
            this.OBJECT_IDENTIFIER_label.AutoSize = true;
            this.OBJECT_IDENTIFIER_label.Location = new System.Drawing.Point(183, 115);
            this.OBJECT_IDENTIFIER_label.Name = "OBJECT_IDENTIFIER_label";
            this.OBJECT_IDENTIFIER_label.Size = new System.Drawing.Size(109, 15);
            this.OBJECT_IDENTIFIER_label.TabIndex = 9;
            this.OBJECT_IDENTIFIER_label.Text = "OBJECT_IDENTIFIER";
            // 
            // PRESENT_VALUE_textBox
            // 
            this.PRESENT_VALUE_textBox.Location = new System.Drawing.Point(346, 27);
            this.PRESENT_VALUE_textBox.Name = "PRESENT_VALUE_textBox";
            this.PRESENT_VALUE_textBox.Size = new System.Drawing.Size(150, 23);
            this.PRESENT_VALUE_textBox.TabIndex = 20;
            this.PRESENT_VALUE_textBox.Text = "0.0";
            // 
            // PRESENT_VALUE_label
            // 
            this.PRESENT_VALUE_label.AutoSize = true;
            this.PRESENT_VALUE_label.Location = new System.Drawing.Point(346, 9);
            this.PRESENT_VALUE_label.Name = "PRESENT_VALUE_label";
            this.PRESENT_VALUE_label.Size = new System.Drawing.Size(93, 15);
            this.PRESENT_VALUE_label.TabIndex = 19;
            this.PRESENT_VALUE_label.Text = "PRESENT_VALUE";
            // 
            // POLARITY_textBox
            // 
            this.POLARITY_textBox.Location = new System.Drawing.Point(183, 342);
            this.POLARITY_textBox.Name = "POLARITY_textBox";
            this.POLARITY_textBox.Size = new System.Drawing.Size(150, 23);
            this.POLARITY_textBox.TabIndex = 18;
            // 
            // POLARITY_label
            // 
            this.POLARITY_label.AutoSize = true;
            this.POLARITY_label.Location = new System.Drawing.Point(183, 324);
            this.POLARITY_label.Name = "POLARITY_label";
            this.POLARITY_label.Size = new System.Drawing.Size(60, 15);
            this.POLARITY_label.TabIndex = 17;
            this.POLARITY_label.Text = "POLARITY";
            // 
            // OUT_OF_SERVICE_label
            // 
            this.OUT_OF_SERVICE_label.AutoSize = true;
            this.OUT_OF_SERVICE_label.Location = new System.Drawing.Point(183, 271);
            this.OUT_OF_SERVICE_label.Name = "OUT_OF_SERVICE_label";
            this.OUT_OF_SERVICE_label.Size = new System.Drawing.Size(98, 15);
            this.OUT_OF_SERVICE_label.TabIndex = 15;
            this.OUT_OF_SERVICE_label.Text = "OUT_OF_SERVICE";
            // 
            // OBJECT_TYPE_textBox
            // 
            this.OBJECT_TYPE_textBox.Location = new System.Drawing.Point(183, 236);
            this.OBJECT_TYPE_textBox.Name = "OBJECT_TYPE_textBox";
            this.OBJECT_TYPE_textBox.Size = new System.Drawing.Size(150, 23);
            this.OBJECT_TYPE_textBox.TabIndex = 14;
            // 
            // OBJECT_TYPE_label
            // 
            this.OBJECT_TYPE_label.AutoSize = true;
            this.OBJECT_TYPE_label.Location = new System.Drawing.Point(183, 218);
            this.OBJECT_TYPE_label.Name = "OBJECT_TYPE_label";
            this.OBJECT_TYPE_label.Size = new System.Drawing.Size(78, 15);
            this.OBJECT_TYPE_label.TabIndex = 13;
            this.OBJECT_TYPE_label.Text = "OBJECT_TYPE";
            // 
            // UNITS_label
            // 
            this.UNITS_label.AutoSize = true;
            this.UNITS_label.Location = new System.Drawing.Point(346, 271);
            this.UNITS_label.Name = "UNITS_label";
            this.UNITS_label.Size = new System.Drawing.Size(39, 15);
            this.UNITS_label.TabIndex = 29;
            this.UNITS_label.Text = "UNITS";
            // 
            // STATUS_FLAGS_textBox
            // 
            this.STATUS_FLAGS_textBox.Location = new System.Drawing.Point(346, 236);
            this.STATUS_FLAGS_textBox.Name = "STATUS_FLAGS_textBox";
            this.STATUS_FLAGS_textBox.ReadOnly = true;
            this.STATUS_FLAGS_textBox.Size = new System.Drawing.Size(150, 23);
            this.STATUS_FLAGS_textBox.TabIndex = 28;
            this.STATUS_FLAGS_textBox.Text = "0000";
            // 
            // STATUS_FLAGS_label
            // 
            this.STATUS_FLAGS_label.AutoSize = true;
            this.STATUS_FLAGS_label.Location = new System.Drawing.Point(346, 218);
            this.STATUS_FLAGS_label.Name = "STATUS_FLAGS_label";
            this.STATUS_FLAGS_label.Size = new System.Drawing.Size(84, 15);
            this.STATUS_FLAGS_label.TabIndex = 27;
            this.STATUS_FLAGS_label.Text = "STATUS_FLAGS";
            // 
            // RELIABILITY_label
            // 
            this.RELIABILITY_label.AutoSize = true;
            this.RELIABILITY_label.Location = new System.Drawing.Point(346, 165);
            this.RELIABILITY_label.Name = "RELIABILITY_label";
            this.RELIABILITY_label.Size = new System.Drawing.Size(69, 15);
            this.RELIABILITY_label.TabIndex = 25;
            this.RELIABILITY_label.Text = "RELIABILITY";
            // 
            // RELINQUISH_DEFAULT_label
            // 
            this.RELINQUISH_DEFAULT_label.AutoSize = true;
            this.RELINQUISH_DEFAULT_label.Location = new System.Drawing.Point(346, 115);
            this.RELINQUISH_DEFAULT_label.Name = "RELINQUISH_DEFAULT_label";
            this.RELINQUISH_DEFAULT_label.Size = new System.Drawing.Size(124, 15);
            this.RELINQUISH_DEFAULT_label.TabIndex = 23;
            this.RELINQUISH_DEFAULT_label.Text = "RELINQUISH_DEFAULT";
            // 
            // PRIORITY_ARRAY_textBox
            // 
            this.PRIORITY_ARRAY_textBox.Location = new System.Drawing.Point(346, 80);
            this.PRIORITY_ARRAY_textBox.Name = "PRIORITY_ARRAY_textBox";
            this.PRIORITY_ARRAY_textBox.Size = new System.Drawing.Size(150, 23);
            this.PRIORITY_ARRAY_textBox.TabIndex = 22;
            // 
            // PRIORITY_ARRAY_label
            // 
            this.PRIORITY_ARRAY_label.AutoSize = true;
            this.PRIORITY_ARRAY_label.Location = new System.Drawing.Point(346, 62);
            this.PRIORITY_ARRAY_label.Name = "PRIORITY_ARRAY_label";
            this.PRIORITY_ARRAY_label.Size = new System.Drawing.Size(97, 15);
            this.PRIORITY_ARRAY_label.TabIndex = 21;
            this.PRIORITY_ARRAY_label.Text = "PRIORITY_ARRAY";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(346, 382);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 23);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Confirm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(183, 382);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(150, 23);
            this.abortButton.TabIndex = 33;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // UNITS_comboBox
            // 
            this.UNITS_comboBox.DisplayMember = "Key + Value";
            this.UNITS_comboBox.FormattingEnabled = true;
            this.UNITS_comboBox.Items.AddRange(new object[] {
            ((object)(resources.GetObject("UNITS_comboBox.Items"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items1"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items2"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items3"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items4"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items5"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items6"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items7"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items8"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items9"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items10"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items11"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items12"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items13"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items14"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items15"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items16"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items17"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items18"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items19"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items20"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items21"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items22"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items23"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items24"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items25"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items26"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items27"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items28"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items29"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items30"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items31"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items32"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items33"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items34"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items35"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items36"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items37"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items38"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items39"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items40"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items41"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items42"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items43"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items44"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items45"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items46"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items47"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items48"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items49"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items50"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items51"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items52"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items53"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items54"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items55"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items56"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items57"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items58"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items59"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items60"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items61"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items62"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items63"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items64"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items65"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items66"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items67"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items68"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items69"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items70"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items71"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items72"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items73"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items74"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items75"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items76"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items77"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items78"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items79"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items80"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items81"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items82"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items83"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items84"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items85"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items86"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items87"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items88"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items89"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items90"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items91"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items92"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items93"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items94"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items95"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items96"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items97"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items98"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items99"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items100"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items101"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items102"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items103"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items104"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items105"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items106"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items107"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items108"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items109"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items110"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items111"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items112"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items113"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items114"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items115"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items116"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items117"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items118"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items119"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items120"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items121"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items122"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items123"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items124"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items125"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items126"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items127"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items128"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items129"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items130"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items131"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items132"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items133"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items134"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items135"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items136"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items137"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items138"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items139"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items140"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items141"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items142"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items143"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items144"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items145"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items146"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items147"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items148"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items149"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items150"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items151"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items152"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items153"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items154"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items155"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items156"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items157"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items158"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items159"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items160"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items161"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items162"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items163"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items164"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items165"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items166"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items167"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items168"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items169"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items170"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items171"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items172"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items173"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items174"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items175"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items176"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items177"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items178"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items179"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items180"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items181"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items182"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items183"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items184"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items185"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items186"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items187"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items188"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items189"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items190"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items191"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items192"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items193"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items194"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items195"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items196"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items197"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items198"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items199"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items200"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items201"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items202"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items203"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items204"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items205"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items206"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items207"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items208"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items209"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items210"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items211"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items212"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items213"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items214"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items215"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items216"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items217"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items218"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items219"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items220"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items221"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items222"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items223"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items224"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items225"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items226"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items227"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items228"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items229"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items230"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items231"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items232"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items233"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items234"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items235"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items236"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items237"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items238"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items239"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items240"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items241"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items242"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items243"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items244"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items245"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items246"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items247"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items248"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items249"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items250"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items251"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items252"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items253"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items254"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items255"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items256"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items257"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items258"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items259"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items260"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items261"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items262"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items263"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items264"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items265"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items266"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items267"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items268"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items269"))),
            ((object)(resources.GetObject("UNITS_comboBox.Items270")))});
            this.UNITS_comboBox.Location = new System.Drawing.Point(346, 289);
            this.UNITS_comboBox.Name = "UNITS_comboBox";
            this.UNITS_comboBox.Size = new System.Drawing.Size(150, 23);
            this.UNITS_comboBox.TabIndex = 34;
            this.UNITS_comboBox.ValueMember = "Value";
            // 
            // RELIABILITY_comboBox
            // 
            this.RELIABILITY_comboBox.DisplayMember = "Key + Value";
            this.RELIABILITY_comboBox.FormattingEnabled = true;
            this.RELIABILITY_comboBox.Items.AddRange(new object[] {
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items1"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items2"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items3"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items4"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items5"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items6"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items7"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items8"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items9"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items10"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items11"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items12"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items13"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items14"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items15"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items16"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items17"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items18"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items19"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items20"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items21"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items22"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items23"))),
            ((object)(resources.GetObject("RELIABILITY_comboBox.Items24")))});
            this.RELIABILITY_comboBox.Location = new System.Drawing.Point(346, 186);
            this.RELIABILITY_comboBox.Name = "RELIABILITY_comboBox";
            this.RELIABILITY_comboBox.Size = new System.Drawing.Size(150, 23);
            this.RELIABILITY_comboBox.TabIndex = 35;
            this.RELIABILITY_comboBox.ValueMember = "Value";
            this.RELIABILITY_comboBox.SelectedIndexChanged += new System.EventHandler(this.RELIABILITY_comboBox_SelectedIndexChanged);
            // 
            // RELINQUISH_DEFAULT_textBox
            // 
            this.RELINQUISH_DEFAULT_textBox.Location = new System.Drawing.Point(346, 133);
            this.RELINQUISH_DEFAULT_textBox.Name = "RELINQUISH_DEFAULT_textBox";
            this.RELINQUISH_DEFAULT_textBox.Size = new System.Drawing.Size(150, 23);
            this.RELINQUISH_DEFAULT_textBox.TabIndex = 24;
            // 
            // EVENT_STATE_comboBox
            // 
            this.EVENT_STATE_comboBox.DisplayMember = "Key + Value";
            this.EVENT_STATE_comboBox.FormattingEnabled = true;
            this.EVENT_STATE_comboBox.DataSource = new BindingSource(BacnetDicationarys.BACnetEventState, null);
            this.EVENT_STATE_comboBox.Location = new System.Drawing.Point(183, 80);
            this.EVENT_STATE_comboBox.Name = "EVENT_STATE_comboBox";
            this.EVENT_STATE_comboBox.Size = new System.Drawing.Size(150, 23);
            this.EVENT_STATE_comboBox.TabIndex = 36;
            this.EVENT_STATE_comboBox.ValueMember = "Value";
            this.EVENT_STATE_comboBox.SelectedIndexChanged += new System.EventHandler(this.EVENT_STATE_comboBox_SelectedIndexChanged);
            // 
            // characterStringValueRadioButton
            // 
            this.characterStringValueRadioButton.AutoSize = true;
            this.characterStringValueRadioButton.Location = new System.Drawing.Point(12, 129);
            this.characterStringValueRadioButton.Name = "characterStringValueRadioButton";
            this.characterStringValueRadioButton.Size = new System.Drawing.Size(141, 19);
            this.characterStringValueRadioButton.TabIndex = 37;
            this.characterStringValueRadioButton.TabStop = true;
            this.characterStringValueRadioButton.Text = "Character String Value";
            this.characterStringValueRadioButton.UseVisualStyleBackColor = true;
            this.characterStringValueRadioButton.CheckedChanged += new System.EventHandler(this.characterStringValueRadioButton_CheckedChanged);
            // 
            // OUT_OF_SERVICE_comboBox
            // 
            this.OUT_OF_SERVICE_comboBox.FormattingEnabled = true;
            this.OUT_OF_SERVICE_comboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.OUT_OF_SERVICE_comboBox.Location = new System.Drawing.Point(183, 289);
            this.OUT_OF_SERVICE_comboBox.Name = "OUT_OF_SERVICE_comboBox";
            this.OUT_OF_SERVICE_comboBox.Size = new System.Drawing.Size(150, 23);
            this.OUT_OF_SERVICE_comboBox.TabIndex = 38;
            this.OUT_OF_SERVICE_comboBox.SelectedIndexChanged += new System.EventHandler(this.OUT_OF_SERVICE_comboBox_SelectedIndexChanged);
            // 
            // CreateBacObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.OUT_OF_SERVICE_comboBox);
            this.Controls.Add(this.characterStringValueRadioButton);
            this.Controls.Add(this.EVENT_STATE_comboBox);
            this.Controls.Add(this.RELIABILITY_comboBox);
            this.Controls.Add(this.UNITS_comboBox);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.UNITS_label);
            this.Controls.Add(this.STATUS_FLAGS_textBox);
            this.Controls.Add(this.STATUS_FLAGS_label);
            this.Controls.Add(this.RELIABILITY_label);
            this.Controls.Add(this.RELINQUISH_DEFAULT_textBox);
            this.Controls.Add(this.RELINQUISH_DEFAULT_label);
            this.Controls.Add(this.PRIORITY_ARRAY_textBox);
            this.Controls.Add(this.PRIORITY_ARRAY_label);
            this.Controls.Add(this.PRESENT_VALUE_textBox);
            this.Controls.Add(this.PRESENT_VALUE_label);
            this.Controls.Add(this.POLARITY_textBox);
            this.Controls.Add(this.POLARITY_label);
            this.Controls.Add(this.OUT_OF_SERVICE_label);
            this.Controls.Add(this.OBJECT_TYPE_textBox);
            this.Controls.Add(this.OBJECT_TYPE_label);
            this.Controls.Add(this.OBJECT_NAME_textBox);
            this.Controls.Add(this.OBJECT_NAME_label);
            this.Controls.Add(this.OBJECT_IDENTIFIER_textBox);
            this.Controls.Add(this.OBJECT_IDENTIFIER_label);
            this.Controls.Add(this.EVENT_STATE_label);
            this.Controls.Add(this.DESCRIPTION_textBox);
            this.Controls.Add(this.DESCRIPTION_label);
            this.Controls.Add(this.analogValueRadioButton);
            this.Controls.Add(this.binaryOutputRadioButton);
            this.Controls.Add(this.binaryInputRadioButton);
            this.Controls.Add(this.analogInputRadioButton);
            this.Controls.Add(this.supportedBacObjectsLabel);
            this.Name = "CreateBacObject";
            this.Text = "CreateBacObject";
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label supportedBacObjectsLabel;
        private RadioButton analogInputRadioButton;
        private RadioButton binaryInputRadioButton;
        private RadioButton analogValueRadioButton;
        private RadioButton binaryOutputRadioButton;
        private Label DESCRIPTION_label;
        private TextBox DESCRIPTION_textBox;
        private Label EVENT_STATE_label;
        private TextBox OBJECT_NAME_textBox;
        private Label OBJECT_NAME_label;
        private TextBox OBJECT_IDENTIFIER_textBox;
        private Label OBJECT_IDENTIFIER_label;
        private TextBox PRESENT_VALUE_textBox;
        private Label PRESENT_VALUE_label;
        private TextBox POLARITY_textBox;
        private Label POLARITY_label;
        private Label OUT_OF_SERVICE_label;
        private TextBox OBJECT_TYPE_textBox;
        private Label OBJECT_TYPE_label;
        private Label UNITS_label;
        private TextBox STATUS_FLAGS_textBox;
        private Label STATUS_FLAGS_label;
        private Label RELIABILITY_label;
        private Label RELINQUISH_DEFAULT_label;
        private TextBox PRIORITY_ARRAY_textBox;
        private Label PRIORITY_ARRAY_label;
        private Button addButton;
        private Button abortButton;
        private BindingSource objectsBindingSource;
        private ComboBox UNITS_comboBox;
        private ComboBox RELIABILITY_comboBox;
        private TextBox RELINQUISH_DEFAULT_textBox;
        private ComboBox EVENT_STATE_comboBox;
        private RadioButton characterStringValueRadioButton;
        private ComboBox OUT_OF_SERVICE_comboBox;
    }
}