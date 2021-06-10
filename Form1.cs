using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int iAttempt = 0;

            if(this.txtUser.Text == "User" && this.txtPass.Text == "Password")
            {
                iAttempt = 0;
                MessageBox.Show("Login granted");
                this.Close();

            }
            else if(iAttempt < 3)
            {
                MessageBox.Show("Incorrect Login, please try again");
                iAttempt += 1;
            }
            else
            {
                MessageBox.Show("Incorrect Login, you are now locked out");
            }
        }
    }
}
