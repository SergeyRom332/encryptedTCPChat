using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using EncryptedChat.Forms;
using EncryptedChat.Models;

namespace EncryptedChat
{
    public partial class MainForm : Form
    {
        public ChatServer chatServer;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                chatServer = new ChatServer();
                chatServer.Start();

                lblLocalAddress.Text = $"{chatServer.ServerEndPoint}";

                dgvContacts.DataSource = ContactsService.Contacts;
                MessageHeandler.MainDgv = dgvContacts;
                MessageHeandler.RtbMessages = rtbMessages;

                SetColumnsVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private async void SendMessage()
        {
            if (string.IsNullOrEmpty(tbSend.Text)) return;

            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("To send choose contact first");
                return;
            }

            var selectedContact = dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            if (selectedContact == null) throw new Exception("Cant find bound data");

            await chatServer.SendMessageAsync(selectedContact, tbSend.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatServer.Stop();
        }

        private void SetColumnsVisibility()
        {
            dgvContacts.Columns["EndPoint"].Visible = false;
            dgvContacts.Columns["Unread"].Visible = false;

            dgvContacts.Columns["UserName"].HeaderText = "Contact";
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                var addContactForm = new AddContactForm(ContactsService.Contacts);
                addContactForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            try
            {
                var setKeyForm = new SetKeyForm(EncriptionService.Passsword);
                setKeyForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void btnCopyAddress_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText($"{chatServer.ServerEndPoint}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var selectedRow = dgvContacts.Rows[e.RowIndex];
                var currentContact = selectedRow.DataBoundItem as Contact;
                if (currentContact == null) throw new Exception("Cant find bound data");

                currentContact.Unread = false;
                MessageHeandler.DisplayMessages(currentContact);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void tbSend_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendMessage();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }
    }
}
