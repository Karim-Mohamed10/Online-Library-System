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
    public partial class Review : Form
    {
        string ID;
        Controller controllerObj;
        public Review(string s)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ID = s;
        }

        private void Review_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectBooks(); //display book name but take ISBN as selected value from combobox
            ISBNcombo.DisplayMember = "BKTitle";
            ISBNcombo.ValueMember = "ISBN";
            ISBNcombo.DataSource = dt;
        }

        private void submitreviewbtn_Click(object sender, EventArgs e)
        {
            int r = controllerObj.Addreview(ID, ISBNcombo.SelectedValue.ToString(), Commenttxt.Text, int.Parse((Ratingcombo.Text)));
            MessageBox.Show("Review added Successfully");
        }
    }
}
