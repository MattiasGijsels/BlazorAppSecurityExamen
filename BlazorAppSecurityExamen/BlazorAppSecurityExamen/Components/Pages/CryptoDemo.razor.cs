using Microsoft.AspNetCore.Components;
using BlazorAppSecurityExamen.Services;

namespace BlazorAppSecurityExamen.Components.Pages
{
    public class CryptoDemoBase : ComponentBase
    {
        protected string AESKey = "";
        protected string PlainText = "";
        protected string IVKey = "";
        protected string CipherText = "";
        protected string DecryptedText = "";
        //check bracketing functions
        protected void GenerateKey()
        {
            Console.WriteLine("test");
            AESKey = InfoSec.GenerateKey();
            IVKey = CipherText = DecryptedText = "";
        }

        protected void EncryptData()
        {
            if (!string.IsNullOrWhiteSpace(AESKey) && !string.IsNullOrWhiteSpace(PlainText))
            {
                CipherText = InfoSec.Encrypt(PlainText, AESKey, out string iv);
                IVKey = iv;
                DecryptedText = "";
            }
        }

        protected void DecryptData()
        {
            if (!string.IsNullOrWhiteSpace(CipherText) && !string.IsNullOrWhiteSpace(AESKey) && !string.IsNullOrWhiteSpace(IVKey))
            {
                DecryptedText = InfoSec.Decrypt(CipherText, AESKey, IVKey);
            }
        }
    }
}
