using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedChat.Models
{
    public static class MessageHeandler
    {
        public const string MY_MESSAGES_MARK = "Me";
        public static DataGridView MainDgv { get; set; }
        public static RichTextBox RtbMessages { get; set; }

        public static void AddMessage(Contact contact, ChatMessage message)
        {
            MainDgv.Invoke(() =>
            {
                contact.Messages.Add(message);
                if(message.UserName != MY_MESSAGES_MARK) contact.Unread = true;

                MainDgv.Refresh();

                var selectedContact = MainDgv.SelectedRows[0].DataBoundItem as Contact;
                if (selectedContact == null) return;

                if (selectedContact.EndPoint.ToString() == contact.EndPoint.ToString())
                {
                    DisplayMessage(message);
                }
            });
        }

        public static void DisplayMessages(Contact contact)
        {
            RtbMessages.Clear();

            foreach (var msg in contact.Messages.OrderBy(i => i.Time))
            {
                DisplayMessage(msg);
            }

            RtbMessages.SelectionStart = RtbMessages.Text.Length;
            RtbMessages.ScrollToCaret();
        }

        public static void DisplayMessage(IMessage message)
        {
            RtbMessages.Text += $"[{message.UserName}] {message.Text}\n\n";
        }

        public static void AddContact(Contact contact)
        {
            MainDgv.Invoke(() => ContactsService.Contacts.Add(contact));
        }

    }
}
