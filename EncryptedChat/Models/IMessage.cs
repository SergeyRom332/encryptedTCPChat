using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedChat.Models
{
    public interface IMessage
    {
        public string Text { get; set; }
        public string SenderAddress { get; set; }
        public int SenderPort { get; set; }
        public DateTime Time { get; set; }
        public string UserName { get; set; }
    }
}
