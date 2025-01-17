using System;
using System.Security.Cryptography;

namespace ReadingTime6.Web.Services
{
    public class SecurityService
    {
        public static byte[] encryptString()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = new byte[] { 16, 22, 240, 11, 18, 150, 192, 21, 16, 22, 240, 11, 18, 150, 192, 21 };
                aesAlg.IV = new byte[] { 21, 192, 150, 18, 11, 240, 22, 16, 21, 192, 150, 18, 11, 240, 22, 16 };

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                string message = "Hello World";
                byte[] messageB = System.Text.Encoding.ASCII.GetBytes(message);
                return encryptor.TransformFinalBlock(messageB, 0, messageB.Length);
            }
        }
    }
}
