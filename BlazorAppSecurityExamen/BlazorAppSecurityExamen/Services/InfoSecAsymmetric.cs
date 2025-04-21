using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace BlazorAppSecurityExamen.Services
{
    public class RsaEncryptionService
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RsaEncryptionService()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }

        public string GetPublicKey()
        {
            return JsonSerializer.Serialize(_publicKey);
        }

        public string GetPrivateKey()
        {
            return JsonSerializer.Serialize(_privateKey);
        }

        public string AsymmetricEncrypt(string plainText)
        {
            using (var encryptCsp = new RSACryptoServiceProvider())
            {
                encryptCsp.ImportParameters(_publicKey);
                var dataBytes = Encoding.Unicode.GetBytes(plainText);
                var cypherData = encryptCsp.Encrypt(dataBytes, true);
                return Convert.ToBase64String(cypherData);
            }
        }

        public string AsymmetricDecrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_privateKey);
            var plainTextBytes = csp.Decrypt(dataBytes, true);
            return Encoding.Unicode.GetString(plainTextBytes);
        }

        // Creates a signature using the private key
        public string CreateSignature(string plainText)
        {
            var bytesToSign = Encoding.UTF8.GetBytes(plainText);
            csp.ImportParameters(_privateKey);
            var signatureBytes = csp.SignData(bytesToSign, "SHA256");
            return Convert.ToBase64String(signatureBytes);
        }

        // Verifies the signature using the public key
        public bool CheckSignature(string plainText, string signature)
        {
            var bytesToCheck = Encoding.UTF8.GetBytes(plainText);
            var signatureBytes = Convert.FromBase64String(signature);
            csp.ImportParameters(_publicKey);
            return csp.VerifyData(bytesToCheck, "SHA256", signatureBytes);
        }

        public string GetPublicKeyModulusBase64()
        {
            return Convert.ToBase64String(_publicKey.Modulus);
        }

        public string GetPublicKeyExponentBase64()
        {
            return Convert.ToBase64String(_publicKey.Exponent);
        }
    }
}