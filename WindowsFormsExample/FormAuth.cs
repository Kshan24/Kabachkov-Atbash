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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (userAuthSucceess())
                this.DialogResult = DialogResult.OK;
            else
                return;
        }

        private bool userAuthSucceess()
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Не корректные поля на форме");
                return false;
            }


            if (hasUser(textBoxLogin.Text, textBoxPassword.Text))
                return true;
            else
            {
                MessageBox.Show("Не верный логин или пароль");
                return false;
            }
        }

        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBoxLogin.Text) || isUnCorrectField(textBoxPassword.Text))
                return true;


            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }

        private bool hasUser(string login, string password)
        {
            User user = new User(login, password);

            return user.IsCorrect();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            DialogResult authDialogResult = new FormRegistration().ShowDialog();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
       
        }
    }
