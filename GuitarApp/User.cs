using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    public class User
    {
        private string email;
        private string login;
        private string password;

        public string Login
        {
            get { return login; }
        }

        public string Password
        {
            get { return password; }
        }

        public string Email { get { return email; } }

        public User(string login, string password, string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public bool Equals(User user)
        {
            if (this.Login == user.login && this.password == user.password)
            {
                return true;
            }
            return false;
        }

    }
}
