namespace EncryptedChat.Forms
{
    partial class AddContactForm
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
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            tbPort = new TextBox();
            tbAddress = new TextBox();
            tbContactName = new TextBox();
            label3 = new Label();
            btnAddContact = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(163, 46);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 7;
            label1.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 29);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 8;
            label4.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 27);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 10;
            label2.Text = "Contact IpAddress";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(177, 45);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(46, 23);
            tbPort.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(50, 45);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(109, 23);
            tbAddress.TabIndex = 6;
            // 
            // tbContactName
            // 
            tbContactName.Location = new Point(50, 105);
            tbContactName.Name = "tbContactName";
            tbContactName.Size = new Size(173, 23);
            tbContactName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 87);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 10;
            label3.Text = "Contact name";
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(79, 170);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(106, 34);
            btnAddContact.TabIndex = 11;
            btnAddContact.Text = "Add contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 239);
            Controls.Add(btnAddContact);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPort);
            Controls.Add(tbContactName);
            Controls.Add(tbAddress);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddContactForm";
            Text = "Add Contact";
            Load += AddContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox tbPort;
        private TextBox tbAddress;
        private TextBox tbContactName;
        private Label label3;
        private Button btnAddContact;
    }
}