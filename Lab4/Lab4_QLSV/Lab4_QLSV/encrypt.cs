using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_QLSV
{
    internal class encrypt
    {
        private string _keyShare = "20120083";
        private static byte[] key = new byte[32]; // 256-bit key
        private static byte[] iv = new byte[16]; // 128-bit IV

        public encrypt(string keyShare = "20120083")
        {
            this._keyShare = keyShare;
            byte[] ivBytes = Encoding.UTF8.GetBytes(keyShare);

            key = _ConvertStringTo256BitKey(keyShare);
            Array.Copy(ivBytes, iv, Math.Min(ivBytes.Length, 16));
        }

        public string _ewithAES(string plainText)
        {
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }

                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        public string _dwithAES(string cipherText)
        {
            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private static byte[] _ConvertStringTo256BitKey(string key)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));

            byte[] keyBytes = new byte[32];
            Array.Copy(hashedPassword, keyBytes, 32);

            return keyBytes;
        }

        //public encrypt(string keyShare = "20120083")
        //{
        //    _keyShare = keyShare;

        //    byte[] ivBytes = Encoding.UTF8.GetBytes(keyShare);

        //    key = ConvertStringTo256BitKey(_keyShare);
        //    Array.Copy(ivBytes, iv, Math.Min(ivBytes.Length, 16));
        //}

        public string ewithHASH1(string plainText)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                return Convert.ToBase64String(hash);
            }
        }

        public Tuple<string, byte[], byte[]> ewithAES(string plainText, CipherMode mode = CipherMode.CBC, bool auto = true)
        {
            using (Aes aes = Aes.Create())
            {
                if (auto)
                {
                    key = aes.Key;
                    iv = aes.IV;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                }

                aes.Mode = mode;

                // Encrypt the plaintext
                byte[] encrypted = EncryptStringToBytes_Aes(plainText, key, iv);

                return Tuple.Create(Convert.ToBase64String(encrypted), key, iv);
            }
        }

        public string dwithAES(string cipherText)
        {
            return DecryptStringFromBytes_Aes(Convert.FromBase64String(cipherText), key, iv);
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        public static byte[] ConvertStringTo256BitKey(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(inputBytes);

                // Truncate hash to 256 bits
                byte[] key = new byte[32];
                Array.Copy(hash, 0, key, 0, key.Length);

                return key;
            }
        }
    }
}
