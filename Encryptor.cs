using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingEncryption
{
    public static class Encryptor
    {
        public static async Task EncryptREDOC(CancellationToken token, Action<string> updateTextBox)
        {
            while (!token.IsCancellationRequested)
            {
                string randomString = Helpers.GenerateRandomString();
                // Реалізація алгоритму REDOC
                string encryptedString = "REDOC: " + randomString; // замінити на реальний алгоритм
                updateTextBox(encryptedString);
                await Task.Delay(1000); // Затримка для симуляції роботи
            }
        }

        public static async Task EncryptSHA(CancellationToken token, Action<string> updateTextBox)
        {
            while (!token.IsCancellationRequested)
            {
                string randomString = Helpers.GenerateRandomString();
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(randomString));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    string encryptedString = "SHA: " + builder.ToString();
                    updateTextBox(encryptedString);
                }
                await Task.Delay(1000); // Затримка для симуляції роботи
            }
        }

        public static async Task EncryptLUC(CancellationToken token, Action<string> updateTextBox)
        {
            while (!token.IsCancellationRequested)
            {
                string randomString = Helpers.GenerateRandomString();
                // Реалізація алгоритму LUC
                string encryptedString = "LUC: " + randomString; // замінити на реальний алгоритм
                updateTextBox(encryptedString);
                await Task.Delay(1000); // Затримка для симуляції роботи
            }
        }
    }
}