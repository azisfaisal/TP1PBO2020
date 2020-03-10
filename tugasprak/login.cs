using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasprak
{
    public partial class login : Form
    {
        private object tbUsername;

        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user user = new user();
            string username = tbusername.Text;
            string password = tbpassword.Text;

            user.Username = Convert.ToString(username);
            user.Password = Convert.ToString(password);

            if (username.Trim() == string.Empty || password.Trim() == string.Empty)
            {
                _ = MessageBox.Show("Harap isi Username/Password");
            }
            else
            {
                if (password == "azisganteng123")
                {
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Maaf Password Salah");
                }
            }
        }
    }
}
