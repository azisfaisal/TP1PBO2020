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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            login lgn = new login();
            lgn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
