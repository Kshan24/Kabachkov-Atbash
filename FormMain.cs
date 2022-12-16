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
using System.Security.Cryptography;
using System.IO;

namespace Шифр_Атбаш
{
    public partial class FormMain : Form
    {
        Atbash tr = new Atbash();
        Atbash trr = new Atbash();
        public FormMain(SQLiteConnection db)
        {
            Db = db;
            InitializeComponent();
        }
        private void Приложение_Load(object sender, EventArgs e)
        {
        }

        private SQLiteConnection Db;

        private void Buttonzashifr_Click(object sender, EventArgs e)
        {
            tr.EncryptText(textBoxNachalo.Text);
            textBoxvevod.Text = tr.EncryptText(textBoxNachalo.Text);


            try
            {
                SQLiteCommand cnd = Db.CreateCommand();
                cnd.CommandText = "INSERT INTO messages (message) VALUES (@message)";
                cnd.Parameters.Add("@message", System.Data.DbType.String).Value = textBoxvevod.Text;
                SQLiteDataReader sqlreader = cnd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления в БД:" + ex.Message);
            }

            using (StreamWriter sw = new StreamWriter("trtr.txt")) sw.WriteLine(textBoxvevod.Text);

        }

        private void FormMain1_Load(object sender, EventArgs e)
        {

        }

        private void Buttondeshifr_Click(object sender, EventArgs e)
        {
            textBoxNachalo.Text = trr.DecryptText(textBoxvevod.Text);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cnd = Db.CreateCommand();
                cnd.CommandText = "SELECT id, message FROM messages WHERE ID like @id";
                cnd.Parameters.Add("@id", System.Data.DbType.String).Value = SearchID.Text;
                SQLiteDataReader sqlreader = cnd.ExecuteReader(); if (sqlreader.HasRows)
                {
                    while (sqlreader.Read())
                    {
                        textBoxvevod.Text = sqlreader[1].ToString(); textBoxNachalo.Text = trr.DecryptText(textBoxvevod.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Сообщения с таким id не найдено");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в БД");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vevod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nachalo_TextChanged(object sender, EventArgs e)
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
