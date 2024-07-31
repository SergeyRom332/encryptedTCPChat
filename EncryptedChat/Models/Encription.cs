using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedChat.Models
{
    public static class EncriptionService
    {

        private static string password = "StrongPass_123";
        public static string Passsword
        {
            get
            {
                return password;
            }
            set
            {
                if(!string.IsNullOrEmpty(value)) password = value;
            }
        }

        public static string Encrypt(string message)
        {
            using (Aes aes = Aes.Create())
            {
                var key = Encoding.UTF8.GetBytes(password);
                Array.Resize(ref key, 32);
                aes.Key = key;

                aes.GenerateIV();

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(aes.IV, 0, aes.IV.Length);

                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(message);
                        }
                    }

                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }

        public static string Decrypt(string message)
        {
            using (Aes aes = Aes.Create())
            {
                var key = Encoding.UTF8.GetBytes(password);
                Array.Resize(ref key, 32);
                aes.Key = key;

                var fullCipher = Convert.FromBase64String(message);
                var iv = new byte[aes.BlockSize / 8];
                var cipherText = new byte[fullCipher.Length - iv.Length];

                Array.Copy(fullCipher, iv, iv.Length);
                Array.Copy(fullCipher, iv.Length, cipherText, 0, cipherText.Length);

                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
