using System;
using System.Windows.Forms;

namespace StringEncryption
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Encrypts the input string using a simple cipher with a provided key
        private string Encrypt(string input, int key)
        {
            char[] encryptedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                // Shift each character based on the key
                encryptedChars[i] = (char)(input[i] + key);
            }

            return new string(encryptedChars);
        }

        // Decrypts the encrypted string using the same key
        private string Decrypt(string encrypted, int key)
        {
            char[] decryptedChars = new char[encrypted.Length];

            for (int i = 0; i < encrypted.Length; i++)
            {
                // Reverse the shift to decrypt
                decryptedChars[i] = (char)(encrypted[i] - key);
            }

            return new string(decryptedChars);
        }

 


        private void btnDecrypt_Click_Click(object sender, EventArgs e)
        {
            // Get the encrypted text and key from the textboxes
            string encryptedText = txtEncrypted.Text;
            int key = Convert.ToInt32(txtKey.Text);

            // Decrypt the string
            string decryptedText = Decrypt(encryptedText, key);

            // Display the decrypted text
            txtDecrypted.Text = decryptedText;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Get the input text and key from the textboxes
            string plainText = Input.Text;
            int key = Convert.ToInt32(txtKey.Text);

            // Encrypt the string
            string encryptedText = Encrypt(plainText, key);

            // Display the encrypted text
            txtEncrypted.Text = encryptedText;
        }
    }
}
