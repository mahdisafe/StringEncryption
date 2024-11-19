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

        
         
        public string Encrypt(string inputText, int key)
        {
            char[] encryptedChars = new char[inputText.Length];
            for (int i = 0; i < inputText.Length; i++)
            {
                encryptedChars[i] = (char)(inputText[i] + key);  
            }
            return new string(encryptedChars);
        }

   
        public string Decrypt(string encryptedText, int key)
        {
             
            if (string.IsNullOrEmpty(encryptedText))
            {
                return encryptedText;
            }

            char[] decryptedChars = new char[encryptedText.Length];
            for (int i = 0; i < encryptedText.Length; i++)
            {
                decryptedChars[i] = (char)(encryptedText[i] - key); 
            }
            return new string(decryptedChars);
        }




        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
              
                string encryptedText = txtEncrypted.Text;

               
                if (string.IsNullOrEmpty(encryptedText))
                {
                    MessageBox.Show("Please provide an encrypted text to decrypt.");
                    return;
                }

              
                if (int.TryParse(txtKey.Text, out int key))
                {
                   
                    string decryptedText = Decrypt(encryptedText, key);

                   
                    txtDecrypted.Text = decryptedText;
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric key.");
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("Error during decryption: " + ex.Message);
            }
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
             
            string plainText = Input.Text;
            int key = Convert.ToInt32(txtKey.Text);

          
            string encryptedText = Encrypt(plainText, key);

            
            txtEncrypted.Text = encryptedText;
        }
    }
}
