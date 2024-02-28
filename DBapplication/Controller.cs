using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using DatabaseProject;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.DirectoryServices.ActiveDirectory;

namespace DatabaseProject
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectBooks()
        {
            string query = "SELECT * FROM Book;";
            return dbMan.ExecuteReader(query);
        }
        public string CustomerFname(string ID)
        {
            string query = "Select CUfname from Customer where CustomerID='" + ID + "';";

            return dbMan.ExecuteScalar(query).ToString();
        }
        public string CustomerLname(string ID)
        {
            string query = "Select CUlname from Customer where CustomerID='" + ID + "';";

            return dbMan.ExecuteScalar(query).ToString();
        }
        public string CustomerPhone(string ID)
        {
            string query = "Select CUPhone from Customer where CustomerID='" + ID + "';";

            return dbMan.ExecuteScalar(query).ToString();
        }
        public string password(string ID)
        {
            string query = "Select Passcode from CUsignin where CCustomerID='" + ID + "';";

            return dbMan.ExecuteScalar(query).ToString();
        }
        public DataTable SelectOwnedBooks(string ID)
        {
            string query = "SELECT ISBN FROM Customer_Book where CustomerID='" + ID + "'AND Borrowed=0;";
            return dbMan.ExecuteReader(query);
        }
        public string SelectBookPrice(string ISBN)
        {
            string query = "Select BKPrice from Book where ISBN='" + ISBN + "';";

            return dbMan.ExecuteScalar(query).ToString();
        }
        public DataTable SelectBorrowedBooks(string ID)
        {
            string query = "SELECT ISBN FROM Customer_Book where CustomerID='" + ID + "'AND Borrowed=1;";
            return dbMan.ExecuteReader(query);
        }

        public int PurcahseBook(string ID, string ISBN)
        {
            string query = "INSERT INTO Customer_Book (CustomerID,ISBN,Borrowed) " +
            "Values ('" + ID + "','" + ISBN + "',0);";
            return dbMan.ExecuteNonQuery(query);
        }
        public int BorrowBook(string ID, string ISBN)
        {
            string query = "INSERT INTO Customer_Book (CustomerID,ISBN,Borrowed) " +
            "Values ('" + ID + "','" + ISBN + "',1);";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Addreview(string ID, string ISBN, string comment, int rating)
        {
            string query = "INSERT INTO Review (RCustomerID,BookISBN,Comment,ReviewRating) " +
            "Values ('" + ID + "','" + ISBN + "','" + comment + "'," + rating + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertCustomer(int id, string fname, string lname, int phone)
        {
            string query = "INSERT INTO Customer (CustomerID,CUFname,CULname,CUPhone) " +
            "Values (" + id + ",'" + fname + "','" + lname + "'," + phone + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int CheckuniqueID(string ID)
        {
            string query = "IF EXISTS (SELECT CUFNAME FROM Customer WHERE CustomerID ='" + ID + "') PRINT('1') else PRINT('2')";

            return Convert.ToInt32(dbMan.ExecuteScalar(query).ToString());
        }
        public int InsertCustomerSigninInfo(int id, string Password)
        {
            string query = "INSERT INTO CUsignin (CCustomerID,Passcode) " +
            "Values (" + id + ",'" + Password + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public string SelectGender(string ID)
        {
            string query = "Select Gender from information where CCustomerID='" + ID + "';";

            return dbMan.ExecuteScalar(query).ToString();
        }
        public int SelectAge(string ID)
        {
            string query = "Select Age from information where CCustomerID='" + ID + "';";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int Vouchercodepercentage(string ID)
        {
            string query = "Select VoucherDiscountPercentage from Voucher where VoucherID='" + ID + "';";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public string SetGender(string ID, string gender)
        {
            string query = "Update information set Gender='" + gender + "' where CCustomerID='" + ID + "';";

            return dbMan.ExecuteNonQuery(query).ToString();
        }

        public string SetAge(string ID, string Age)
        {
            string query = "Update information set Age='" + Age + "' where CCustomerID='" + ID + "';";

            return dbMan.ExecuteNonQuery(query).ToString();
        }
        public string SetPhone(string ID, int phone)
        {
            string query = "Update Customer set CUPhone='" + phone + "' where CustomerID='" + ID + "';";

            return dbMan.ExecuteNonQuery(query).ToString();
        }
    }





    //-----------------------------------------------------------------------------//

}



