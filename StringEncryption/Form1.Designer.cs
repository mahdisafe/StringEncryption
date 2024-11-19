namespace StringEncryption
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEncrypted = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Input = new Label();
            txtKey = new TextBox();
            label2 = new Label();
            txtDecrypted = new TextBox();
            label3 = new Label();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            SuspendLayout();
            // 
            // txtEncrypted
            // 
            txtEncrypted.Location = new Point(12, 32);
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.ReadOnly = true;
            txtEncrypted.Size = new Size(503, 27);
            txtEncrypted.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Encrypted";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 27);
            textBox1.TabIndex = 2;
            // 
            // Input
            // 
            Input.AutoSize = true;
            Input.Location = new Point(12, 62);
            Input.Name = "Input";
            Input.Size = new Size(43, 20);
            Input.TabIndex = 3;
            Input.Text = "Input";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(12, 141);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(503, 27);
            txtKey.TabIndex = 4;
            txtKey.Text = "20252025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "Encript Key";
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(12, 199);
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.ReadOnly = true;
            txtDecrypted.Size = new Size(503, 27);
            txtDecrypted.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 7;
            label3.Text = "Decrypted";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(182, 244);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(191, 29);
            btnDecrypt.TabIndex = 8;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(12, 244);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(145, 29);
            btnEncrypt.TabIndex = 9;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 294);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(label3);
            Controls.Add(txtDecrypted);
            Controls.Add(label2);
            Controls.Add(txtKey);
            Controls.Add(Input);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtEncrypted);
            Name = "FrmMain";
            Text = "Encript App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEncrypted;
        private Label label1;
        private TextBox textBox1;
        private Label Input;
        private TextBox txtKey;
        private Label label2;
        private TextBox txtDecrypted;
        private Label label3;
        private Button btnDecrypt;
        private Button btnEncrypt;
    }
}
