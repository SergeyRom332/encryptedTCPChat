namespace EncryptedChat.Forms
{
    partial class SetKeyForm
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
            label3 = new Label();
            tbKey = new TextBox();
            btnSetKey = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 41);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Encryption key";
            // 
            // tbKey
            // 
            tbKey.Location = new Point(57, 59);
            tbKey.Name = "tbKey";
            tbKey.PasswordChar = '*';
            tbKey.Size = new Size(232, 23);
            tbKey.TabIndex = 3;
            // 
            // btnSetKey
            // 
            btnSetKey.Location = new Point(104, 129);
            btnSetKey.Name = "btnSetKey";
            btnSetKey.Size = new Size(119, 43);
            btnSetKey.TabIndex = 5;
            btnSetKey.Text = "Set key";
            btnSetKey.UseVisualStyleBackColor = true;
            btnSetKey.Click += btnSetKey_Click;
            // 
            // SetKeyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 239);
            Controls.Add(btnSetKey);
            Controls.Add(label3);
            Controls.Add(tbKey);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SetKeyForm";
            Text = "Set Key";
            Load += SetKeyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tbKey;
        private Button btnSetKey;
    }
}