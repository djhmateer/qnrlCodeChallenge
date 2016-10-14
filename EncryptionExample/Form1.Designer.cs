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
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendFileCaesar = new System.Windows.Forms.Button();
            this.btnReadDecyrptCaesarWrite = new System.Windows.Forms.Button();
            this.btnEncryptRijndael = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnSendMessageAndDB = new System.Windows.Forms.Button();
            this.txtDBData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(19, 121);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(146, 21);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "SendMessageUsingStream";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessageUsingStream_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 70);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 70);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User2";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(19, 192);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(165, 25);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "EncryptCaesarSendDecrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncryptCaesarSendDecrypt_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(50, 617);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(100, 20);
            this.btnSendFile.TabIndex = 7;
            this.btnSendFile.Text = "SendFileNoCrypto";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFileNoCrypto_Click);
            // 
            // btnSendFileCaesar
            // 
            this.btnSendFileCaesar.Location = new System.Drawing.Point(9, 641);
            this.btnSendFileCaesar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendFileCaesar.Name = "btnSendFileCaesar";
            this.btnSendFileCaesar.Size = new System.Drawing.Size(141, 20);
            this.btnSendFileCaesar.TabIndex = 8;
            this.btnSendFileCaesar.Text = "ReadEncryptCaesarWrite";
            this.btnSendFileCaesar.UseVisualStyleBackColor = true;
            this.btnSendFileCaesar.Click += new System.EventHandler(this.btnSendFileCaesar_Click);
            // 
            // btnReadDecyrptCaesarWrite
            // 
            this.btnReadDecyrptCaesarWrite.Location = new System.Drawing.Point(202, 635);
            this.btnReadDecyrptCaesarWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadDecyrptCaesarWrite.Name = "btnReadDecyrptCaesarWrite";
            this.btnReadDecyrptCaesarWrite.Size = new System.Drawing.Size(139, 25);
            this.btnReadDecyrptCaesarWrite.TabIndex = 9;
            this.btnReadDecyrptCaesarWrite.Text = "ReadDecryptCaesarWrite";
            this.btnReadDecyrptCaesarWrite.UseVisualStyleBackColor = true;
            this.btnReadDecyrptCaesarWrite.Click += new System.EventHandler(this.btnReadDecyrptCaesarWrite_Click);
            // 
            // btnEncryptRijndael
            // 
            this.btnEncryptRijndael.Location = new System.Drawing.Point(22, 242);
            this.btnEncryptRijndael.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncryptRijndael.Name = "btnEncryptRijndael";
            this.btnEncryptRijndael.Size = new System.Drawing.Size(162, 25);
            this.btnEncryptRijndael.TabIndex = 10;
            this.btnEncryptRijndael.Text = "EncryptRijndaelSendDecrypt";
            this.btnEncryptRijndael.UseVisualStyleBackColor = true;
            this.btnEncryptRijndael.Click += new System.EventHandler(this.btnEncryptRijndael_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expects c:\\temp\\user1.txt and will \'send\' to user2.txt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "symmetric key is \'secret\'";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 65);
            this.button1.TabIndex = 13;
            this.button1.Text = "PublicKeyUser2EncryptSymmetricKey then SendToUser2 then DecryptWithUser2PrivateKe" +
    "y then DecryptWithSymmetricKey ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPublicKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "public key:";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(286, 296);
            this.btnGenerateKeys.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(200, 25);
            this.btnGenerateKeys.TabIndex = 15;
            this.btnGenerateKeys.Text = "GenerateUser2PublicAndPrivateKeys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "private key:";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(358, 332);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(583, 67);
            this.txtPublicKey.TabIndex = 17;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(358, 440);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(589, 142);
            this.txtPrivateKey.TabIndex = 18;
            // 
            // btnSendMessageAndDB
            // 
            this.btnSendMessageAndDB.Location = new System.Drawing.Point(9, 680);
            this.btnSendMessageAndDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMessageAndDB.Name = "btnSendMessageAndDB";
            this.btnSendMessageAndDB.Size = new System.Drawing.Size(267, 21);
            this.btnSendMessageAndDB.TabIndex = 19;
            this.btnSendMessageAndDB.Text = "SendMessageUsingStreamWriteToDBAndSelectAll";
            this.btnSendMessageAndDB.UseVisualStyleBackColor = true;
            this.btnSendMessageAndDB.Click += new System.EventHandler(this.btnSendMessageAndDB_Click);
            // 
            // txtDBData
            // 
            this.txtDBData.Location = new System.Drawing.Point(358, 680);
            this.txtDBData.Multiline = true;
            this.txtDBData.Name = "txtDBData";
            this.txtDBData.ReadOnly = true;
            this.txtDBData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDBData.Size = new System.Drawing.Size(589, 142);
            this.txtDBData.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 719);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Messages table";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 762);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 21);
            this.button2.TabIndex = 22;
            this.button2.Text = "SendMessageUsingStreamWriteToDBEntityFramework";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 836);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDBData);
            this.Controls.Add(this.btnSendMessageAndDB);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncryptRijndael);
            this.Controls.Add(this.btnReadDecyrptCaesarWrite);
            this.Controls.Add(this.btnSendFileCaesar);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSendFileCaesar;
        private System.Windows.Forms.Button btnReadDecyrptCaesarWrite;
        private System.Windows.Forms.Button btnEncryptRijndael;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Button btnSendMessageAndDB;
        private System.Windows.Forms.TextBox txtDBData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

