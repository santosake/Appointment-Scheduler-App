using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ASantosSchedulingApp
{
    public partial class CustomerScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public CustomerScreen()
        {
            InitializeComponent();
            ReloadCustomerDGV();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerScreen addCustomerScreen = new AddCustomerScreen();
            addCustomerScreen.Show();
            this.Hide();
        }

        //Populates the Customer DGV with the customer database table
        private void ReloadCustomerDGV()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand cmd = new MySqlCommand($"Select * FROM customer", mySqlCon);
                MySqlDataAdapter mySqlDA = new MySqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                mySqlDA.Fill(dtbl);

                customerDataGridView.DataSource = dtbl;
                mySqlCon.Close();
            }
        }
    }
}
