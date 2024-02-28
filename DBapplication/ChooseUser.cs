namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
      
        private void Custbtn_Click_1(object sender, EventArgs e)
        {

            CustomerSignup cust = new CustomerSignup();

            cust.Show();
            
        }

    }
}