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
    public partial class CustomerSignup : Form
    {
        Controller controllerObj;
        public CustomerSignup()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerSignIn cust1 = new CustomerSignIn();
            cust1.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controllerObj.CheckuniqueID(IDtxt.Text)==2)
            {
                int r = controllerObj.InsertCustomer(Convert.ToInt32(IDtxt.Text), Fnametxt.Text, Lnametxt.Text, Convert.ToInt32(phonetxt.Text));
                int s = controllerObj.InsertCustomerSigninInfo(Convert.ToInt32(IDtxt.Text), passtxt.Text);
            }
            else
            {
                MessageBox.Show("This ID is taken,please try another one");
            }
        }
    }
}
