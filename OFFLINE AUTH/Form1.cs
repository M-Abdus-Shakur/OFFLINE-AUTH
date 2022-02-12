using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFLINE_AUTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (License_TB.Text == "YOURLICENSE")
                MessageBox.Show("License is Valid");
            else
            {
                MessageBox.Show("License is Not Valid");
            }
        }
    }
}
