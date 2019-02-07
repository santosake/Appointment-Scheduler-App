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
    public partial class CityReportScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public CityReportScreen()
        {
            InitializeComponent();
            LoadReport();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }

        private void LoadReport()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT U04pXF.appointment.appointmentId," +
                    " U04pXF.customer.customerName, U04pXF.address.addressId, U04pXF.city.city" +
                    " FROM U04pXF.appointment INNER JOIN U04pXF.customer ON appointment.customerId" +
                    " = customer.customerId INNER JOIN U04pXF.address ON customer.addressId" +
                    " = address.addressId INNER JOIN U04pXF.city ON address.cityId =" +
                    " city.cityId", mySqlCon);
                MySqlDataAdapter mySqlDA = new MySqlDataAdapter(cmd);

                DataTable dtbl = new DataTable();
                mySqlDA.Fill(dtbl);

                int newYork = 0;
                int losAngeles = 0;
                int houston = 0;
                int saltLakeCity = 0;
                int lancaster = 0;
                int london = 0;
                int glasgow = 0;
                int toronto = 0;
                int vancouver = 0;
                int ottawa = 0;
                int oslo = 0;
                int bergen = 0;
                int trondheim = 0;
                int other = 0;

                foreach (DataRow dr in dtbl.Rows)
                {
                    string x = dr["city"].ToString();

                    if (x == "New York")
                    {
                        newYork++;
                    }
                    else if (x == "Los Angeles")
                    {
                        losAngeles++;
                    }
                    else if (x == "Houston")
                    {
                        houston++;
                    }
                    else if (x == "Salt Lake City")
                    {
                        saltLakeCity++;
                    }
                    else if (x == "Lancaster")
                    {
                        lancaster++;
                    }
                    else if (x == "London")
                    {
                        london++;
                    }
                    else if (x == "Glasgow")
                    {
                        glasgow++;
                    }
                    else if (x == "Toronto")
                    {
                        toronto++;
                    }
                    else if (x == "Vancouver")
                    {
                        vancouver++;
                    }
                    else if (x == "Ottawa")
                    {
                        ottawa++;
                    }
                    else if (x == "Oslo")
                    {
                        oslo++;
                    }
                    else if (x == "Bergen")
                    {
                        bergen++;
                    }
                    else if (x == "Trondheim")
                    {
                        trondheim++;
                    }
                    else
                    {
                        other++;
                    }
                }

                StringBuilder sb = new StringBuilder();
                
                sb.AppendLine($"New York has {newYork} appointments.");
                sb.AppendLine($"Los Angeles has {losAngeles} appointments.");
                sb.AppendLine($"Houston has {houston} appointments.");
                sb.AppendLine($"Salt Lake City has {saltLakeCity} appointments.");
                sb.AppendLine($"Lancaster has {lancaster} appointments.");
                sb.AppendLine($"London has {london} appointments.");
                sb.AppendLine($"Glasgow has {glasgow} appointments.");
                sb.AppendLine($"Toronto has {toronto} appointments.");
                sb.AppendLine($"Vancouver has {vancouver} appointments.");
                sb.AppendLine($"Ottawa has {ottawa} appointments.");
                sb.AppendLine($"Oslo has {oslo} appointments.");
                sb.AppendLine($"Bergen has {bergen} appointments.");
                sb.AppendLine($"Trondheim has {trondheim} appointments.");
                sb.AppendLine($"There are {other} appointments in other cities not listed.");

                cityReportScreenTextBox.Clear();
                cityReportScreenTextBox.Text = sb.ToString();

                mySqlCon.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
