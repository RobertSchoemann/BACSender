namespace BACSender
{
    partial class SupportedObjectTypesForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.cancelObjectTypesButton = new System.Windows.Forms.Button();
            this.addObjectTypesButton = new System.Windows.Forms.Button();
            this.objectTypesListBox = new System.Windows.Forms.ListBox();
            this.supportedObjectTypesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(201, 321);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "OK";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // cancelObjectTypesButton
            // 
            this.cancelObjectTypesButton.Location = new System.Drawing.Point(201, 292);
            this.cancelObjectTypesButton.Name = "cancelObjectTypesButton";
            this.cancelObjectTypesButton.Size = new System.Drawing.Size(75, 23);
            this.cancelObjectTypesButton.TabIndex = 9;
            this.cancelObjectTypesButton.Text = "<<";
            this.cancelObjectTypesButton.UseVisualStyleBackColor = true;
            this.cancelObjectTypesButton.Click += new System.EventHandler(this.cancelObjectTypesButton_Click);
            // 
            // addObjectTypesButton
            // 
            this.addObjectTypesButton.Location = new System.Drawing.Point(201, 263);
            this.addObjectTypesButton.Name = "addObjectTypesButton";
            this.addObjectTypesButton.Size = new System.Drawing.Size(75, 23);
            this.addObjectTypesButton.TabIndex = 8;
            this.addObjectTypesButton.Text = ">>";
            this.addObjectTypesButton.UseVisualStyleBackColor = true;
            this.addObjectTypesButton.Click += new System.EventHandler(this.addObjectTypesButton_Click);
            // 
            // objectTypesListBox
            // 
            this.objectTypesListBox.FormattingEnabled = true;
            this.objectTypesListBox.ItemHeight = 15;
            this.objectTypesListBox.Location = new System.Drawing.Point(12, 12);
            this.objectTypesListBox.Name = "objectTypesListBox";
            this.objectTypesListBox.Size = new System.Drawing.Size(183, 559);
            this.objectTypesListBox.TabIndex = 7;
            // 
            // supportedObjectTypesListBox
            // 
            this.supportedObjectTypesListBox.FormattingEnabled = true;
            this.supportedObjectTypesListBox.ItemHeight = 15;
            this.supportedObjectTypesListBox.Location = new System.Drawing.Point(282, 12);
            this.supportedObjectTypesListBox.Name = "supportedObjectTypesListBox";
            this.supportedObjectTypesListBox.Size = new System.Drawing.Size(187, 559);
            this.supportedObjectTypesListBox.TabIndex = 6;
            // 
            // SupportedObjectTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 588);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cancelObjectTypesButton);
            this.Controls.Add(this.addObjectTypesButton);
            this.Controls.Add(this.objectTypesListBox);
            this.Controls.Add(this.supportedObjectTypesListBox);
            this.Name = "SupportedObjectTypesForm";
            this.Text = "SupportedObjectTypesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button closeButton;
        private Button cancelObjectTypesButton;
        private Button addObjectTypesButton;
        private ListBox objectTypesListBox;
        private ListBox supportedObjectTypesListBox;
    }
}