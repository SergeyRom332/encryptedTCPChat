using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace EncryptedChat.Models
{
    public class ChatServer
    {
        private TcpListener listener;
        private bool started;
        public IPEndPoint ServerEndPoint {get;set;}

        public ChatServer()
        {
            string localIp = GetLocalIPAddress();
            IPAddress localAddress = IPAddress.Parse(localIp);

            listener = new TcpListener(localAddress, 0);
        }

        public async Task Start()
        {
            listener.Start();
            started = true;
            ServerEndPoint = (IPEndPoint)listener.LocalEndpoint;

            while (started)
            {
                var tcpClient = await listener.AcceptTcpClientAsync();

                try
                {
                    await Task.Run(() => ProcessClientAsync(tcpClient));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during processing message: {ex.Message}");
                }
            }
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork && ip.ToString() != "127.0.0.1")
                {
                    return ip.ToString();
                }
            }

            throw new Exception("Local IP Address Not Found!");
        }

        private async Task ProcessClientAsync(TcpClient tcpClient)
        {
            try
            {
                NetworkStream stream = tcpClient.GetStream();

                var incomeData = new byte[512];
                var strIncomeData = new StringBuilder();
                var bytes = 0;

                do
                {
                    bytes = await stream.ReadAsync(incomeData);
                    strIncomeData.Append(Encoding.UTF8.GetString(incomeData, 0, bytes));
                }
                while (bytes > 0);

                tcpClient.Close();

                var data = EncriptionService.Decrypt(strIncomeData.ToString());

                var message = JsonSerializer.Deserialize<ChatMessage>(data);
                if (message == null) throw new Exception("Cant deserialize income data. Check encryption key");

                var sender = ContactsService.Contacts.Where(c => c.EndPoint.ToString() == $"{message.SenderAddress}:{message.SenderPort}").FirstOrDefault();

                if (sender == null)
                {
                    sender = new Contact()
                    {
                        EndPoint = new IPEndPoint(IPAddress.Parse(message.SenderAddress).Address, message.SenderPort)
                    };

                    MessageHeandler.AddContact(sender);
                }

                message.UserName = sender.UserName;
                MessageHeandler.AddMessage(sender, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during processing contact {tcpClient.Client.RemoteEndPoint}, error text: {ex.Message}");
            }
        }

        public async Task<IMessage> SendMessageAsync(Contact contact, string text)
        {
            TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync(contact.EndPoint);
            var stream = tcpClient.GetStream();

            var message = new ChatMessage()
            {
                Text = text,
                SenderAddress = ServerEndPoint.Address.ToString(),
                SenderPort = ServerEndPoint.Port,
                Time = DateTime.Now,
                UserName = MessageHeandler.MY_MESSAGES_MARK
            };

            var strData = JsonSerializer.Serialize(message);
            var encryptedData = EncriptionService.Encrypt(strData);
            var requestData = Encoding.UTF8.GetBytes(encryptedData);

            await stream.WriteAsync(requestData);
            tcpClient.Close();

            MessageHeandler.AddMessage(contact, message);

            return message;
        }

        public void Stop()
        {
            listener.Stop();
            started = false;
        }
    }
}
