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
    public partial class CUOwnedBooks : Form
    {
        Controller controllerObj;
        string s="";
        public CUOwnedBooks(string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            s=ID;
        }

        private void CUOwnedBooks_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectOwnedBooks(s);
            OwnedBooksgrid.DataSource = dt;
            OwnedBooksgrid.Refresh();

            DataTable ds = controllerObj.SelectBorrowedBooks(s);
            BorrowedBooksgrid.DataSource = ds;
            BorrowedBooksgrid.Refresh();
        }
    }
}
