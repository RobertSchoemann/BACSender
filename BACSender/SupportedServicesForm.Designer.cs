using BACSender.Base.Enums;

namespace BACSender
{
    partial class SupportedServicesForm
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
            this.supportedServicesListBox = new System.Windows.Forms.ListBox();
            this.servicesListBox = new System.Windows.Forms.ListBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.cancelServiceButton = new System.Windows.Forms.Button();
            this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supportedServicesListBox
            // 
            this.supportedServicesListBox.FormattingEnabled = true;
            this.supportedServicesListBox.ItemHeight = 15;
            this.supportedServicesListBox.Location = new System.Drawing.Point(282, 12);
            this.supportedServicesListBox.Name = "supportedServicesListBox";
            this.supportedServicesListBox.Size = new System.Drawing.Size(187, 559);
            this.supportedServicesListBox.TabIndex = 1;
            // 
            // servicesListBox
            // 
            this.servicesListBox.FormattingEnabled = true;
            this.servicesListBox.ItemHeight = 15;
            this.servicesListBox.Location = new System.Drawing.Point(12, 12);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(183, 559);
            this.servicesListBox.TabIndex = 2;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(201, 263);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceButton.TabIndex = 3;
            this.addServiceButton.Text = ">>";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // cancelServiceButton
            // 
            this.cancelServiceButton.Location = new System.Drawing.Point(201, 292);
            this.cancelServiceButton.Name = "cancelServiceButton";
            this.cancelServiceButton.Size = new System.Drawing.Size(75, 23);
            this.cancelServiceButton.TabIndex = 4;
            this.cancelServiceButton.Text = "<<";
            this.cancelServiceButton.UseVisualStyleBackColor = true;
            this.cancelServiceButton.Click += new System.EventHandler(this.cancelServiceButton_Click);
            // 
            // objectsBindingSource
            // 
            this.objectsBindingSource.DataSource = typeof(BACSender.XMLHandler.Types.Objects);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(201, 321);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "OK";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SupportedServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 604);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cancelServiceButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.servicesListBox);
            this.Controls.Add(this.supportedServicesListBox);
            this.Name = "SupportedServicesForm";
            this.Text = "SupportedServicesForm";
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox supportedServicesListBox;
        private ListBox servicesListBox;
        private Button addServiceButton;
        private Button cancelServiceButton;
        private BindingSource objectsBindingSource;
        private Button closeButton;
    }
}