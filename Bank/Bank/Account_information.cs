using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account_information
    {
        string accnum;

        public string Accnum
        {
            get { return accnum; }
            set { accnum = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string balance;

        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

    }
}
