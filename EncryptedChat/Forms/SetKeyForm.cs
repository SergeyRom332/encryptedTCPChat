using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedChat.Forms
{
    public partial class SetKeyForm : Form
    {
        private string _password;

        public SetKeyForm(string password)
        {
            InitializeComponent();
            _password = password;
        }

        private void SetKeyForm_Load(object sender, EventArgs e)
        {
            tbKey.Text = _password;
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKey.Text))
            {
                MessageBox.Show("Enter key");
                return;
            }

            _password = tbKey.Text;
            Close();
        }

    }
}
