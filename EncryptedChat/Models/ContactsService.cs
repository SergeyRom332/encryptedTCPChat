using EncryptedChat.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedChat.Models
{
    public static class ContactsService
    {
        public static BindingList<Contact> Contacts { get; set; } = new BindingList<Contact>();

        //public static void LoadContacts()
        //{

        //}
    }
}
