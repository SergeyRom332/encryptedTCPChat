using EncryptedChat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedChat.Forms
{
    public partial class AddContactForm : Form
    {
        private BindingList<Contact> _contacts = new BindingList<Contact>();

        public AddContactForm(BindingList<Contact> contacts)
        {
            InitializeComponent();
            _contacts = contacts;
        }
        private void AddContactForm_Load(object sender, EventArgs e)
        {
            tbAddress.TabIndex = 0;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Enter address");
                return;
            }

            if (string.IsNullOrEmpty(tbPort.Text))
            {
                MessageBox.Show("Enter port");
                return;
            }

            if (string.IsNullOrEmpty(tbContactName.Text))
            {
                MessageBox.Show("Enter Contact Name");
                return;
            }

            IPEndPoint endPoint = null;
            try
            {
                var address = IPAddress.Parse(tbAddress.Text);
                endPoint = new IPEndPoint(address.Address, Convert.ToInt32(tbPort.Text));
            }
            catch
            {
                MessageBox.Show("Cant convert Ip or port value to number");
                return;
            }

            Contact contact = new Contact()
            {
                EndPoint = endPoint,
                UserName = tbContactName.Text
            };

            _contacts.Add(contact);

            Close();
        }

        
    }
}
