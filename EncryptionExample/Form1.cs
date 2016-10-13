using System;
using System.IO;
using System.Windows.Forms;

namespace EncryptionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Attack at dawn";
        }

        void btnSendMessage_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(textBox1.Text);
            writer.Flush();
            ms.Position = 0;

            var sr = new StreamReader(ms);
            var x = sr.ReadToEnd();
            textBox2.Text = x;
        }

        void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Use Caesar shift
            var clearText = textBox1.Text;
            var cypherText = "";
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
        }

        void btnDecrypt_Click(object sender, EventArgs e)
        {
            var clearText = "";
            var cypherText = textBox2.Text;
            foreach (char c in cypherText)
            {
                int x = c - 1;
                clearText += (char)x;
            }
            textBox2.Text = clearText;
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
            // no encryption here

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

                //// Caesar shift encryption on memory stream bytes
                var cypherBytes = new byte[ms.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    byte b = bytes[i];
                    // if add 1 to a char, it goes to next letter
                    // eg A is 65, B is 66
                    // implicit conversion to int and add 1
                    int x = b + 1;
                    // convert int to byte
                    cypherBytes[i] = (byte)x;
                }
                //file.Write(bytes, 0, bytes.Length);
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
    }
}
