﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    class User
    {
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

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
