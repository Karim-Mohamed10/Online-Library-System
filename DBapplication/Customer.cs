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
    
    public partial class Customer : Form
    {
        Controller controllerObj;
        public Customer(string ID)//CustomerID as parameter
        {
            InitializeComponent();
            controllerObj = new Controller();
            IDtxt.Text = ID;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books b=new Books(IDtxt.Text);//open books form
            b.Show();
           
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Fnamebox.Text = controllerObj.CustomerFname(IDtxt.Text)+" "+controllerObj.CustomerLname(IDtxt.Text);//put fname with lname
            Phonebox.Text = "0"+controllerObj.CustomerPhone(IDtxt.Text); //put 0*phone
            Gendertxt.Text = controllerObj.SelectGender(IDtxt.Text);//gender box
            Agetxt.Text =controllerObj.SelectAge(IDtxt.Text).ToString(); //age box
        }

        private void Ownedbtn_Click(object sender, EventArgs e)
        {
            CUOwnedBooks b=new CUOwnedBooks(IDtxt.Text);//open owned books form
            b.Show();
        }

        private void reviewbtn_Click(object sender, EventArgs e)
        {
            Review r = new Review(IDtxt.Text);//open review form
            r.Show();   
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();//logout closes customer form
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            CUpdateInfo u=new CUpdateInfo(IDtxt.Text);//open updateinfo form
            u.Show();
        }

  
    }
}
