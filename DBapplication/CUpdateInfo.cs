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
    public partial class CUpdateInfo : Form
    {
        Controller controllerObj;
        string ID;
        public CUpdateInfo(string s)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ID = s;
        }

        private void CUpdateInfo_Load(object sender, EventArgs e)
        {
            Genderbox.Text = controllerObj.SelectGender(ID);
            Agebox.Text = controllerObj.SelectAge(ID).ToString();
            Phonetxt.Text ="0"+ controllerObj.CustomerPhone(ID).ToString();
        }

        private void Updateinfobtn_Click(object sender, EventArgs e)
        {
            string r = controllerObj.SetGender(ID, Genderbox.Text);
            string s = controllerObj.SetAge(ID, Agebox.Text);
            string t = controllerObj.SetPhone(ID, Convert.ToInt32(Phonetxt.Text));
            MessageBox.Show("Changes Saved Succesfully");
        }
    }
}
