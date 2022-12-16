using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SQLite;
namespace WindowsFormsExample
{
    public partial class FormRegistration : Form
    {
        public SQLiteConnection DataBase1;
        public FormRegistration()
        {
            InitializeComponent();
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            new Database("Data Source=dataBase.db;Version=3;").createUser(textBoxLogin.Text, textBoxPassword.Text);
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));
             if (textBoxPassword.Text == textBoxPasswordConfirmation.Text)
             {
            int temp_login = 0;
            SQLiteCommand commandvar = DataBase1.CreateCommand();
            commandvar.CommandText = "select * from users";
            SQLiteDataReader SQL = commandvar.ExecuteReader();
            while (SQL.Read())

            {

                if (textBoxLogin.Text == SQL[1].ToString())
                {
                    MessageBox.Show($"Такой пользователь уже существует");
                    temp_login = 1;
                    break;
                }

               
            }
            if (temp_login == 0)
            {
                SQLiteCommand commandvarreg = DataBase1.CreateCommand();
                commandvarreg.CommandText = "insert into users(Login, Password) values(@login, @password)";
                commandvarreg.Parameters.Add("@login", DbType.String).Value = textBoxLogin.Text;
                commandvarreg.Parameters.Add("@password", DbType.String).Value = Convert.ToBase64String(hash);
                commandvarreg.ExecuteNonQuery();
                MessageBox.Show($"Поздравляем с регистрацией, {textBoxLogin.Text}");
            }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                }
            }
           

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            DataBase1 = new SQLiteConnection("DataSource=dataBase1.db; Version = 3");
            DataBase1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordConfirmation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
