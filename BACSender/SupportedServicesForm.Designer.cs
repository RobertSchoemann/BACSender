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
            this.label1 = new System.Windows.Forms.Label();
            this.supportedServicesListBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // supportedServicesListBox
            // 
            this.supportedServicesListBox.FormattingEnabled = true;
            this.supportedServicesListBox.ItemHeight = 15;
            this.supportedServicesListBox.Location = new System.Drawing.Point(314, 9);
            this.supportedServicesListBox.Name = "supportedServicesListBox";
            this.supportedServicesListBox.Size = new System.Drawing.Size(155, 184);
            this.supportedServicesListBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // SupportedServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 203);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.supportedServicesListBox);
            this.Controls.Add(this.label1);
            this.Name = "SupportedServicesForm";
            this.Text = "SupportedServicesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox supportedServicesListBox;
        private ComboBox comboBox1;
    }
}