using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class UserAccount
    {
        private string username; 
        private string password;

        public UserAccount(string username)
        {
            this.username = username;
        }

        public bool SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return false;
            }

            this.password = password;
            return true;
        }

        public bool Login(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            return this.password == password;
        }
    }
}
