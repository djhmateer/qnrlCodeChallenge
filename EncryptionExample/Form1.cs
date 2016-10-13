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

        void button1_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(textBox1.Text);
            writer.Flush();
            stream.Position = 0;

            var sr = new StreamReader(stream);
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
    }
}
