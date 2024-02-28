using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class CustomerSignIn : Form
    {
        Controller controllerObj;
        public CustomerSignIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

      
        private void Signinbtn_Click_1(object sender, EventArgs e)
        {
            if (passtxt.Text == controllerObj.password(UserIDtxt.Text))
            {
                Customer cust = new Customer(UserIDtxt.Text);
                cust.Show();
            }
            else
            {
                MessageBox.Show("Wrong your username or password");
            }
        }

        private void visiblepassbtn_Click(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
