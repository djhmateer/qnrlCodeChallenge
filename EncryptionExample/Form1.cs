using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
//http://stackoverflow.com/a/1246594/26086 - naming convention.. only time I use Hungarian

namespace EncryptionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Attack at dawn";
        }
        private void btnSendMessageUsingStream_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            // Write whatever is in the textBox1 to memoryStream
            writer.Write(textBox1.Text);
            writer.Flush();
            ms.Position = 0;

            var sr = new StreamReader(ms);
            // Read from memoryStream and put into textBox2
            textBox2.Text = sr.ReadToEnd();
        }

        private void btnEncryptCaesarSendDecrypt_Click(object sender, EventArgs e)
        {
            var clearText = textBox1.Text;
            var cypherText = "";

            // Use Caesar shift
            foreach (char c in clearText)
            {
                // if add 1 to a char, it goes to next letter
                // eg A is 65, B is 66
                // implicit conversion to int and add 1
                int x = c + 1;
                // convert int to char
                cypherText += (char)x;
            }
            textBox1.Text = cypherText;

            // send to text2 via memoryStream
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            // Write whatever is in the textBox1 to memoryStream
            writer.Write(textBox1.Text);
            writer.Flush();
            ms.Position = 0;
            var sr = new StreamReader(ms);
            // Read from memoryStream and put into textBox2
            textBox2.Text = sr.ReadToEnd();


            var clearText2 = "";
            var cypherText2 = textBox2.Text;
            foreach (char c in cypherText2)
            {
                int x = c - 1;
                clearText2 += (char)x;
            }
            textBox2.Text = clearText2;
        }
       

        void btnSendFileNoCrypto_Click(object sender, EventArgs e)
        {
            // read file to a memoryStream 
            var ms = new MemoryStream();
            using (var file = new FileStream(@"c:\temp\user1.txt", FileMode.Open, FileAccess.Read))
            {
                var bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
                ms.Write(bytes, 0, (int)file.Length);
            }
            ms.Position = 0;

            // no encryption

            // write file from memoryStream
            using (var file = new FileStream(@"c:\temp\user2.txt", FileMode.Create, FileAccess.Write))
            {
                var bytes = new byte[ms.Length];
                ms.Read(bytes, 0, (int)ms.Length);
                file.Write(bytes, 0, bytes.Length);
                ms.Close();
            }
        }

        void btnSendFileCaesar_Click(object sender, EventArgs e)
        {
            // read file to a memoryStream 
            var ms = new MemoryStream();
            using (var file = new FileStream(@"c:\temp\user1.txt", FileMode.Open, FileAccess.Read))
            {
                var bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
                ms.Write(bytes, 0, (int)file.Length);
            }
            ms.Position = 0;

            // write file from memoryStream
            using (var file = new FileStream(@"c:\temp\user2.txt", FileMode.Create, FileAccess.Write))
            {
                var bytes = new byte[ms.Length];
                ms.Read(bytes, 0, (int)ms.Length);

                // Caesar shift encryption on memory stream bytes
                var cypherBytes = new byte[ms.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    byte b = bytes[i];
                    int x = b + 1;
                    cypherBytes[i] = (byte)x;
                }
                file.Write(cypherBytes, 0, cypherBytes.Length);
                ms.Close();
            }
        }

        void btnReadDecyrptCaesarWrite_Click(object sender, EventArgs e)
        {
            // read file 
            var ms = new MemoryStream();
            using (var file = new FileStream(@"c:\temp\user2.txt", FileMode.Open, FileAccess.Read))
            {
                var cypherBytes = new byte[file.Length];
                file.Read(cypherBytes, 0, (int)file.Length);
                ms.Write(cypherBytes, 0, (int)file.Length);

                // decrypt
                var clearBytes = new byte[ms.Length];
                for (int i = 0; i < cypherBytes.Length; i++)
                {
                    byte b = cypherBytes[i];
                    int x = b - 1;
                    clearBytes[i] = (byte)x;
                }
                ms.Position = 0;

                // write clearBytes back to memory stream
                ms.Write(clearBytes, 0, (int)file.Length);
            }
            ms.Position = 0;

            // write clearBytes from memoryStream to file
            using (var file = new FileStream(@"c:\temp\user2.txt", FileMode.Create, FileAccess.Write))
            {
                var bytes = new byte[ms.Length];
                ms.Read(bytes, 0, (int)ms.Length);
                file.Write(bytes, 0, bytes.Length);
                ms.Close();
            }
        }

        void btnEncryptRijndael_Click(object sender, EventArgs e)
        {
            var clearText = textBox1.Text;
            var cypherBytes = Encrypt(Encoding.UTF8.GetBytes(clearText), "secret");
            // displaying the encrypted data in textbox1
            var cypherText = Encoding.UTF8.GetString(cypherBytes);
            textBox1.Text = cypherText;

            // send bytes via Stream
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            //writer.Write(cypherBytes);
            //http://stackoverflow.com/a/27269283/26086
            writer.BaseStream.Write(cypherBytes, 0, cypherBytes.Length);
            writer.Flush();
            ms.Position = 0;

            // get bytes from stream
            var bytes = new byte[ms.Length];
            ms.Read(bytes, 0, (int)ms.Length);
            var cypherBytes2 = Decrypt(bytes, "secret");
            var cypherText2 = Encoding.UTF8.GetString(cypherBytes2);

            textBox2.Text = cypherText2;
            ms.Close();
        }

        //http://stackoverflow.com/a/6544082/26086
        static readonly byte[] Salt = { 0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c };
        public static byte[] Encrypt(byte[] plain, string password)
        {
            var rijndael = Rijndael.Create();
            var pdb = new Rfc2898DeriveBytes(password, Salt);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(plain, 0, plain.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        public static byte[] Decrypt(byte[] cipher, string password)
        {
            var rijndael = Rijndael.Create();
            var pdb = new Rfc2898DeriveBytes(password, Salt);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(cipher, 0, cipher.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        
    }
}
