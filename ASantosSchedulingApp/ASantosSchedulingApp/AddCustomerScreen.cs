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
    public partial class AddCustomerScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public AddCustomerScreen()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
            this.Hide();
        }        

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Validation: Checks all fields for appropriate info and
            //saves any issues to a stringbuilder for a MessageBox to user

            int errorCount = 0;
            StringBuilder errorMessage = new StringBuilder();            

            if (addCustomerCountryComboBox.SelectedIndex >= 0)
            {
            }
            else
            {
                errorCount++;
                errorMessage.AppendLine("Please select a Country from the Drop Down Menu.");
            }

            if (addCustomerCityComboBox.SelectedIndex >= 0)
            { 
            }
            else
            {
                errorCount++;
                errorMessage.AppendLine("Please select a City from the Drop Down Menu.");
            }

            if (string.IsNullOrWhiteSpace(addCustomerNameTextBox.Text))
            {
                errorCount++;
                errorMessage.AppendLine("Customer Name is Null or only White Space.");
            }

            if (string.IsNullOrWhiteSpace(addCustomerAddressTextBox.Text))
            {
                errorCount++;
                errorMessage.AppendLine("Customer Address is Null or only White Space.");
            }

            int postalCodeTest;
            if (!Int32.TryParse(addCustomerPostalCodeTextBox.Text, out postalCodeTest))
            {
                errorCount++;
                errorMessage.AppendLine("Postal Code is not a Numerical Value.");
            }
            else
            {
                string x = postalCodeTest.ToString();
                int count = x.Count();

                if (count < 5 || count > 5)
                {
                    errorCount++;
                    errorMessage.AppendLine("Postal Code needs to be 5 integers.");
                }
            }

            int phoneNumber1Test;
            if (!Int32.TryParse(addCustomerPhoneNumberPart1TextBox.Text, out phoneNumber1Test))
            {
                errorCount++;
                errorMessage.AppendLine("First part of Phone Number is not a Numerical Value.");
            }
            else
            {
                string x = phoneNumber1Test.ToString();
                int count = x.Count();

                if (count < 3 || count > 3)
                {
                    errorCount++;
                    errorMessage.AppendLine("First part of Phone Number needs to be 3 integers.");
                }
            }

            int phoneNumber2Test;
            if (!Int32.TryParse(addCustomerPhoneNumberPart2TextBox.Text, out phoneNumber2Test))
            {
                errorCount++;
                errorMessage.AppendLine("Second part of Phone Number is not a Numerical Value.");
            }
            else
            {
                string x = phoneNumber2Test.ToString();
                int count = x.Count();

                if (count < 4 || count > 4)
                {
                    errorCount++;
                    errorMessage.AppendLine("Second part of Phone Number needs to be 4 integers.");
                }
            }

            errorMessage.AppendLine($"{errorCount} errors in total.");

            if (errorCount > 0)
            {
                MessageBox.Show($"{errorMessage}");
            }
            else
            {
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();

                    //fetch city and save its table ID for address creation
                    int cityId = 0;
                    string city = addCustomerCityComboBox.Text.ToString();

                    if (city == "New York")
                    {
                        cityId = 1;
                    }
                    else if (city == "Los Angeles")
                    {
                        cityId = 2;
                    }
                    else if (city == "Houston")
                    {
                        cityId = 3;
                    }
                    else if (city == "Salt Lake City")
                    {
                        cityId = 4;
                    }
                    else if (city == "Lancaster")
                    {
                        cityId = 5;
                    }
                    else if (city == "London")
                    {
                        cityId = 6;
                    }
                    else if (city == "Glasgow")
                    {
                        cityId = 7;
                    }
                    else if (city == "Toronto")
                    {
                        cityId = 8;
                    }
                    else if (city == "Vancouver")
                    {
                        cityId = 9;
                    }
                    else if (city == "Ottawa")
                    {
                        cityId = 10;
                    }
                    else if (city == "Oslo")
                    {
                        cityId = 11;
                    }
                    else if (city == "Bergen")
                    {
                        cityId = 12;
                    }
                    else if (city == "Trondheim")
                    {
                        cityId = 13;
                    }

                    //inserts new address record and saves its addressId for next step or query
                    int addressId = 0;
                    string xPhone = (addCustomerPhoneNumberPart1TextBox.Text.ToString()) + (addCustomerPhoneNumberPart2TextBox.Text.ToString());


                    MySqlCommand createAddress = new MySqlCommand("INSERT INTO U04pXF.address" +
                        " (address, cityId, postalCode, phone, createDate, createdBy, lastUpdate," +
                        " lastUpdateBy) " +
                        $"VALUES('{addCustomerAddressTextBox.Text.ToString()}'," +
                        $" '{cityId.ToString()}'," +
                        $" '{addCustomerPostalCodeTextBox.Text.ToString()}'," +
                        $" '{xPhone}'," +
                        $" NOW()," +
                        $" '{LoginScreen.CurrentUser}'," +
                        $" NOW()," +
                        $" '{LoginScreen.CurrentUser}');", mySqlCon);
                    
                    createAddress.ExecuteNonQuery();

                    MySqlCommand fetchNewAddressId = new MySqlCommand("SELECT LAST_INSERT_ID();", mySqlCon);
                    MySqlDataAdapter fetchNewAddressIdDA = new MySqlDataAdapter();
                    DataTable fetchNewAddressIdDataTable = new DataTable();
                    fetchNewAddressIdDA.SelectCommand = fetchNewAddressId;
                    fetchNewAddressIdDA.Fill(fetchNewAddressIdDataTable);

                    foreach (DataRow dr in fetchNewAddressIdDataTable.Rows)
                    {
                        string addressPk = dr["LAST_INSERT_ID()"].ToString();
                        addressId = Int32.Parse(addressPk);
                    }

                    //inserts new customer now that we have an addressId to provide
                    MySqlCommand createCustomer = new MySqlCommand("INSERT INTO U04pXF.customer " +
                        "(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        "VALUES" +
                        $"('{addCustomerNameTextBox.Text.ToString()}', " +
                        $"'{addressId}', " +
                        "'1', " +
                        $"NOW(), " +
                        $"'{LoginScreen.CurrentUser}', " +
                        $"NOW(), " +
                        $"'{LoginScreen.CurrentUser}'); ", mySqlCon);
                    
                    createCustomer.ExecuteNonQuery();

                    mySqlCon.Close();

                    CustomerScreen cs = new CustomerScreen();
                    cs.Show();
                    this.Hide();
                }
            }

            
            
            
           
        }

        private void phoneDashLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
