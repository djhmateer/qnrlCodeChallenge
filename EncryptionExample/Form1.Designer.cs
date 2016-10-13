namespace EncryptionExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendFileCaesar = new System.Windows.Forms.Button();
            this.btnReadDecyrptCaesarWrite = new System.Windows.Forms.Button();
            this.btnEncryptRijndael = new System.Windows.Forms.Button();
            this.btnDecryptRijndael = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(80, 159);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(114, 24);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "SendMessage";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 85);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 85);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "User2";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(25, 198);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(113, 31);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "EncryptCaesar";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(282, 198);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(120, 31);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "DecryptCaesar";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(67, 439);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(133, 24);
            this.btnSendFile.TabIndex = 7;
            this.btnSendFile.Text = "SendFileNoCrypto";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFileNoCrypto_Click);
            // 
            // btnSendFileCaesar
            // 
            this.btnSendFileCaesar.Location = new System.Drawing.Point(12, 469);
            this.btnSendFileCaesar.Name = "btnSendFileCaesar";
            this.btnSendFileCaesar.Size = new System.Drawing.Size(188, 24);
            this.btnSendFileCaesar.TabIndex = 8;
            this.btnSendFileCaesar.Text = "ReadEncryptCaesarWrite";
            this.btnSendFileCaesar.UseVisualStyleBackColor = true;
            this.btnSendFileCaesar.Click += new System.EventHandler(this.btnSendFileCaesar_Click);
            // 
            // btnReadDecyrptCaesarWrite
            // 
            this.btnReadDecyrptCaesarWrite.Location = new System.Drawing.Point(269, 462);
            this.btnReadDecyrptCaesarWrite.Name = "btnReadDecyrptCaesarWrite";
            this.btnReadDecyrptCaesarWrite.Size = new System.Drawing.Size(185, 31);
            this.btnReadDecyrptCaesarWrite.TabIndex = 9;
            this.btnReadDecyrptCaesarWrite.Text = "ReadDecryptCaesarWrite";
            this.btnReadDecyrptCaesarWrite.UseVisualStyleBackColor = true;
            this.btnReadDecyrptCaesarWrite.Click += new System.EventHandler(this.btnReadDecyrptCaesarWrite_Click);
            // 
            // btnEncryptRijndael
            // 
            this.btnEncryptRijndael.Location = new System.Drawing.Point(25, 251);
            this.btnEncryptRijndael.Name = "btnEncryptRijndael";
            this.btnEncryptRijndael.Size = new System.Drawing.Size(113, 31);
            this.btnEncryptRijndael.TabIndex = 10;
            this.btnEncryptRijndael.Text = "EncryptRijndael";
            this.btnEncryptRijndael.UseVisualStyleBackColor = true;
            this.btnEncryptRijndael.Click += new System.EventHandler(this.btnEncryptRijndael_Click);
            // 
            // btnDecryptRijndael
            // 
            this.btnDecryptRijndael.Location = new System.Drawing.Point(282, 251);
            this.btnDecryptRijndael.Name = "btnDecryptRijndael";
            this.btnDecryptRijndael.Size = new System.Drawing.Size(113, 31);
            this.btnDecryptRijndael.TabIndex = 11;
            this.btnDecryptRijndael.Text = "DecryptRijndael";
            this.btnDecryptRijndael.UseVisualStyleBackColor = true;
            this.btnDecryptRijndael.Click += new System.EventHandler(this.btnDecryptRijndael_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 546);
            this.Controls.Add(this.btnDecryptRijndael);
            this.Controls.Add(this.btnEncryptRijndael);
            this.Controls.Add(this.btnReadDecyrptCaesarWrite);
            this.Controls.Add(this.btnSendFileCaesar);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSendFileCaesar;
        private System.Windows.Forms.Button btnReadDecyrptCaesarWrite;
        private System.Windows.Forms.Button btnEncryptRijndael;
        private System.Windows.Forms.Button btnDecryptRijndael;
    }
}

