
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasprak
{
    class user
    {
        public string username, password;


        public string Password
        {
            set { password = value; }
            get { return password; }

        }

        public string Username
        {
            set { username = value; }
            get { return username; }

        }
    }
}
