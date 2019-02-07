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
    public partial class MonthReportScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public MonthReportScreen()
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

        //est connection to db. fills data table with query command. loops through data table extracting month
        //and adding counts to respective month. populates textbox with results.
        private void LoadReport()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT appointment.start, appointment.type FROM U04pXF.appointment", mySqlCon);
                MySqlDataAdapter mySqlDA = new MySqlDataAdapter(cmd);

                DataTable dtbl = new DataTable();
                mySqlDA.Fill(dtbl);

                int january = 0;
                int february = 0;
                int march = 0;
                int april = 0;
                int may = 0;
                int june = 0;
                int july = 0;
                int august = 0;
                int september = 0;
                int october = 0;
                int november = 0;
                int december = 0;

                int janNew = 0;
                int janFollow = 0;
                int febNew = 0;
                int febFollow = 0;
                int marNew = 0;
                int marFollow = 0;
                int aprNew = 0;
                int aprFollow = 0;
                int mayNew = 0;
                int mayFollow = 0;
                int junNew = 0;
                int junFollow = 0;
                int julNew = 0;
                int julFollow = 0;
                int augNew = 0;
                int augFollow = 0;
                int sepNew = 0;
                int sepFollow = 0;
                int octNew = 0;
                int octFollow = 0;
                int novNew = 0;
                int novFollow = 0;
                int decNew = 0;
                int decFollow = 0;

                foreach (DataRow dr in dtbl.Rows)
                {
                    string x = dr["start"].ToString();
                    DateTime date = Convert.ToDateTime(x);
                    int caseSwitch = Int32.Parse(date.Month.ToString());
                    string y = dr["type"].ToString();

                    switch (caseSwitch)
                    {
                        case 1:
                            january++;
                            if (y == "New Appt")
                            {
                                janNew++;
                            }
                            else if (y == "Followup")
                            {
                                janFollow++;
                            }
                            break;
                        case 2:
                            february++;
                            if (y == "New Appt")
                            {
                                febNew++;
                            }
                            else if (y == "Followup")
                            {
                                febFollow++;
                            }
                            break;
                        case 3:
                            march++;
                            if (y == "New Appt")
                            {
                                marNew++;
                            }
                            else if (y == "Followup")
                            {
                                marFollow++;
                            }
                            break;
                        case 4:
                            april++;
                            if (y == "New Appt")
                            {
                                aprNew++;
                            }
                            else if (y == "Followup")
                            {
                                aprFollow++;
                            }
                            break;
                        case 5:
                            may++;
                            if (y == "New Appt")
                            {
                                mayNew++;
                            }
                            else if (y == "Followup")
                            {
                                mayFollow++;
                            }
                            break;
                        case 6:
                            june++;
                            if (y == "New Appt")
                            {
                                junNew++;
                            }
                            else if (y == "Followup")
                            {
                                junFollow++;
                            }
                            break;
                        case 7:
                            july++;
                            if (y == "New Appt")
                            {
                                julNew++;
                            }
                            else if (y == "Followup")
                            {
                                julFollow++;
                            }
                            break;
                        case 8:
                            august++;
                            if (y == "New Appt")
                            {
                                augNew++;
                            }
                            else if (y == "Followup")
                            {
                                augFollow++;
                            }
                            break;
                        case 9:
                            september++;
                            if (y == "New Appt")
                            {
                                sepNew++;
                            }
                            else if (y == "Followup")
                            {
                                sepFollow++;
                            }
                            break;
                        case 10:
                            october++;
                            if (y == "New Appt")
                            {
                                octNew++;
                            }
                            else if (y == "Followup")
                            {
                                octFollow++;
                            }
                            break;
                        case 11:
                            november++;
                            if (y == "New Appt")
                            {
                                novNew++;
                            }
                            else if (y == "Followup")
                            {
                                novFollow++;
                            }
                            break;
                        case 12:
                            december++;
                            if (y == "New Appt")
                            {
                                decNew++;
                            }
                            else if (y == "Followup")
                            {
                                decFollow++;
                            }
                            break;
                    }


                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"January has {january} appointments. {janNew} of type New Appt and {janFollow} of type Followup.");
                sb.AppendLine($"February has {february} appointments. {febNew} of type New Appt and {febFollow} of type Followup.");
                sb.AppendLine($"March has {march} appointments. {marNew} of type New Appt and {marFollow} of type Followup.");
                sb.AppendLine($"April has {april} appointments. {aprNew} of type New Appt and {aprFollow} of type Followup.");
                sb.AppendLine($"May has {may} appointments. {mayNew} of type New Appt and {mayFollow} of type Followup.");
                sb.AppendLine($"June has {june} appointments. {junNew} of type New Appt and {junFollow} of type Followup.");
                sb.AppendLine($"July has {july} appointments. {julNew} of type New Appt and {julFollow} of type Followup.");
                sb.AppendLine($"August has {august} appointments. {augNew} of type New Appt and {augFollow} of type Followup.");
                sb.AppendLine($"September has {september} appointments. {sepNew} of type New Appt and {sepFollow} of type Followup.");
                sb.AppendLine($"October has {october} appointments. {octNew} of type New Appt and {octFollow} of type Followup.");
                sb.AppendLine($"November has {november} appointments. {novNew} of type New Appt and {novFollow} of type Followup.");
                sb.AppendLine($"December has {december} appointments. {decNew} of type New Appt and {decFollow} of type Followup.");

                monthReportScreenTextBox.Clear();
                monthReportScreenTextBox.Text = sb.ToString();

                mySqlCon.Close();
            }
        }
    }
}
