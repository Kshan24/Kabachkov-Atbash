using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExample
{
    public class User
    {
        private string login;
        private string name;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login { get => login; }
        public string Password { get => password; }

        public bool IsCorrect()
        {
            Database database = new Database("Data Source=dataBase.db;Version=3;");
            
            if (database.CheckUser(this))
                return true;

            return false;
        }
    }
}
