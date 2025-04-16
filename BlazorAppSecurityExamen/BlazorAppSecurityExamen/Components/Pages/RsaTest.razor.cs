using Microsoft.AspNetCore.Components;
using BlazorAppSecurityExamen.Services;

namespace BlazorAppSecurityExamen.Pages
{
    public class RsaTestBase : ComponentBase
    {
        [Inject]
        protected RsaEncryptionService RsaService { get; set; }

        protected string message = "";
        protected string encrypted = "";
        protected string decrypted = "";
        protected string signature = "";
        protected bool signatureValid = false;
        protected string signatureValidText = "";

        // Public key as Base64 string (Modulus + Exponent)
        protected string publicKey = "";

        protected override void OnInitialized()
        {
            publicKey = RsaService.GetPublicKeyBase64();
        }

        protected void EncryptMessage()
        {
            encrypted = RsaService.AsymmetricEncrypt(message);
        }

        protected void DecryptMessage()
        {
            decrypted = RsaService.AsymmetricDecrypt(encrypted);
        }

        protected void SignMessage()
        {
            signature = RsaService.CreateSignature(message);
        }

        protected void VerifySignature()
        {
            signatureValid = RsaService.CheckSignature(message, signature);
            signatureValidText = signatureValid ? "✅ Valid" : "❌ Invalid";
        }
    }
}
