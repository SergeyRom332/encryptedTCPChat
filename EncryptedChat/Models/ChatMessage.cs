using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EncryptedChat.Models
{
    public class ChatMessage : IMessage
    {
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string SenderAddress { get; set; }
        public int SenderPort { get; set; }
        [JsonIgnore]
        public string UserName { get; set; }
    }
}
