using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EncryptedChat.Models
{
    public class Contact
    {
        private const string UNREAD_POSTFIX = " - (new)";
        private bool unread = false;
        private string userName;
        public IPEndPoint EndPoint { get; set; }
        public string UserName
        {
            get
            {
                return string.IsNullOrEmpty(userName) ? $"{EndPoint.Address}:{EndPoint.Port}" : userName;
            }
            set
            {
                userName = value;
            }
        }
        public List<IMessage> Messages { get; set; } = new List<IMessage>();
        public bool Unread
        {
            get
            {
                return unread;
            }
            set
            {
                unread = value;

                if (value)
                {
                    if(!UserName.Contains(UNREAD_POSTFIX)) UserName = UserName += UNREAD_POSTFIX;
                }
                else
                {
                    UserName = UserName.Replace(UNREAD_POSTFIX, "");
                }
            }
        }
    }
}
