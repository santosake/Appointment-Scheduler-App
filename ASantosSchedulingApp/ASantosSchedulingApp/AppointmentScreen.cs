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
    public partial class AppointmentScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public AppointmentScreen()
        {
            InitializeComponent();
            ReloadAppointmentDGV();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointmentScreen addAppointmentScreen = new AddAppointmentScreen();
            addAppointmentScreen.Show();
            this.Hide();
        }

        //Populates the Appointment DGV with the appointment database table
        private void ReloadAppointmentDGV()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("Select * FROM appointment", mySqlCon);
                MySqlDataAdapter mySqlDA = new MySqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                mySqlDA.Fill(dtbl);

                appointmentDataGridView.DataSource = dtbl;
                mySqlCon.Close();
            }
        }
    }
}
