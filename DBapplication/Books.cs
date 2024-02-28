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
    public partial class Books : Form
    {
        Controller controllerObj;
        string ISBN; // variables
        string ID;
        public Books(string ID1)//CustomerID sent as a parameter  
        {
            InitializeComponent();
            controllerObj = new Controller();
            ID = ID1; //to use it in the whole form (ID1 scope ends)
        }
        private void Books_Load(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectBooks(); //put books in booksgridview
            Booksgrid.DataSource = dt;
            Booksgrid.Refresh();

        }
        private void Booksgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = Booksgrid.Rows[e.RowIndex].Cells[0].Value; // selected row cell 0 in booksgridview
            ISBN = item.ToString(); //ISBN =cell[0] (ISBN of selected book)
            Priceboxtxt.Text = controllerObj.SelectBookPrice(item.ToString());

        }
        private void PurchaseBookbtn_Click(object sender, EventArgs e)
        {

            int r = controllerObj.PurcahseBook(ID, ISBN); //put book in Purchased book Table
            MessageBox.Show("Book Purchased Successfully");
            
        }

        private void borrowBooksbtn_Click(object sender, EventArgs e)
        {
            int r = controllerObj.BorrowBook(ID, ISBN); //put book in Borrowed book Table
            MessageBox.Show("Book Borrowed Successfully");
        }

        private void button1_Click(object sender, EventArgs e) //voucher btn
        {
            int r=controllerObj.Vouchercodepercentage(Voucherbox.Text);
            if (r != 0) //if r=0 there is no voucher code with this vouchercodeID
                DiscountedPricetxt.Text = (Convert.ToInt32(Priceboxtxt.Text) * r / 100).ToString();
            else
                MessageBox.Show("Invalid Voucher Code");
            
        }
    }
}
