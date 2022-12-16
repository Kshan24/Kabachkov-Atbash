using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsExample
{
    public partial class FormMain : Form
    {
        Atbash tr = new Atbash();
        Atbash trr = new Atbash();
        public FormMain()
        {
            
            InitializeComponent();
        }
   
        private void FormMain_Load(object sender, EventArgs e)
        {
            DialogResult authDialogResult = new FormAuth().ShowDialog();

            if (authDialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Вы не авторизовались!");
                Close();
            }
        }

        private void textBoxnachalo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxvevod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttonzashifr_Click(object sender, EventArgs e)
        {
            tr.EncryptText(textBoxnachalo.Text);
            textBoxvevod.Text = tr.EncryptText(textBoxnachalo.Text);


        }

        private void Buttondeshifr_Click(object sender, EventArgs e)
        {
            textBoxnachalo.Text = trr.DecryptText(textBoxvevod.Text);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public class Atbash
        {

            private const string alphabet = "abcdefghijklmnopqrstuvwxyz";


            private string Reverse(string inputText)
            {

                var reversedText = string.Empty;
                foreach (var s in inputText)
                {

                    reversedText = s + reversedText;
                }

                return reversedText;
            }


            private string EncryptDecrypt(string text, string symbols, string cipher)
            {

                text = text.ToLower();

                var outputText = string.Empty;
                for (var i = 0; i < text.Length; i++)
                {

                    var index = symbols.IndexOf(text[i]);
                    if (index >= 0)
                    {

                        outputText += cipher[index].ToString();
                    }
                }

                return outputText;
            }


            public string EncryptText(string plainText)
            {
                return EncryptDecrypt(plainText, alphabet, Reverse(alphabet));
            }


            public string DecryptText(string encryptedText)
            {
                return EncryptDecrypt(encryptedText, Reverse(alphabet), alphabet);
            }

        }
    }
}
