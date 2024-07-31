namespace EncryptedChat
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbMessages = new RichTextBox();
            btnSend = new Button();
            dgvContacts = new DataGridView();
            lblLocalAddress = new Label();
            tbSend = new TextBox();
            label5 = new Label();
            btnCopyAddress = new Button();
            btnAddContact = new Button();
            btnSetKey = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(246, 9);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(533, 489);
            rtbMessages.TabIndex = 0;
            rtbMessages.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(730, 504);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(49, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.AllowUserToResizeColumns = false;
            dgvContacts.AllowUserToResizeRows = false;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.BackgroundColor = SystemColors.Control;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvContacts.Location = new Point(8, 9);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowHeadersVisible = false;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(232, 446);
            dgvContacts.TabIndex = 4;
            dgvContacts.CellClick += dgvContacts_CellClick;
            // 
            // lblLocalAddress
            // 
            lblLocalAddress.AutoSize = true;
            lblLocalAddress.Font = new Font("Segoe UI", 9F);
            lblLocalAddress.Location = new Point(8, 512);
            lblLocalAddress.Name = "lblLocalAddress";
            lblLocalAddress.Size = new Size(12, 15);
            lblLocalAddress.TabIndex = 2;
            lblLocalAddress.Text = "_";
            // 
            // tbSend
            // 
            tbSend.Location = new Point(246, 504);
            tbSend.Name = "tbSend";
            tbSend.Size = new Size(478, 23);
            tbSend.TabIndex = 5;
            tbSend.KeyDown += tbSend_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 497);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 2;
            label5.Text = "Your address";
            // 
            // btnCopyAddress
            // 
            btnCopyAddress.Location = new Point(188, 504);
            btnCopyAddress.Name = "btnCopyAddress";
            btnCopyAddress.Size = new Size(52, 23);
            btnCopyAddress.TabIndex = 3;
            btnCopyAddress.Text = "Copy";
            btnCopyAddress.UseVisualStyleBackColor = true;
            btnCopyAddress.Click += btnCopyAddress_Click;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(8, 461);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(113, 23);
            btnAddContact.TabIndex = 3;
            btnAddContact.Text = "Add contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnSetKey
            // 
            btnSetKey.Location = new Point(127, 461);
            btnSetKey.Name = "btnSetKey";
            btnSetKey.Size = new Size(113, 23);
            btnSetKey.TabIndex = 3;
            btnSetKey.Text = "Set key";
            btnSetKey.UseVisualStyleBackColor = true;
            btnSetKey.Click += btnSetKey_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 535);
            Controls.Add(tbSend);
            Controls.Add(dgvContacts);
            Controls.Add(btnCopyAddress);
            Controls.Add(btnSetKey);
            Controls.Add(btnAddContact);
            Controls.Add(btnSend);
            Controls.Add(lblLocalAddress);
            Controls.Add(label5);
            Controls.Add(rtbMessages);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "TCP Encrypted chat";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbMessages;
        private Button btnSend;
        private DataGridView dgvContacts;
        private Label lblLocalAddress;
        private TextBox tbSend;
        private Label label5;
        private Button btnCopyAddress;
        private Button btnAddContact;
        private Button btnSetKey;
    }
}
