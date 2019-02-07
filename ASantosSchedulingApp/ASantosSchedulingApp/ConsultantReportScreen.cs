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
    public partial class ConsultantReportScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public ConsultantReportScreen()
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

        public void LoadReport()
        {
            //using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                //mySqlCon.Open();
                //MySqlCommand cmd = new MySqlCommand("SELECT U04pXF.appointment.title," +
                //    " U04pXF.appointment.type, U04pXF.appointment.start," +
                //    " U04pXF.appointment.end, U04pXF.user.userName, U04pXF.customer.customerName" +
                //    " FROM U04pXF.user INNER JOIN U04pXF.appointment ON user.userId" +
                //    " = appointment.userId INNER JOIN U04pXF.customer ON appointment.customerId" +
                //    " = customer.customerId ORDER BY U04pXF.appointment.start", mySqlCon);
                //MySqlDataAdapter mySqlDA = new MySqlDataAdapter(cmd);

                //DataTable dtbl = new DataTable();
                //mySqlDA.Fill(dtbl);

                //string user1;
                ////make new list here with user1 as the owner of the list
                ////loop through the dr's in dt, extract userName, loop through
                ////all user variables and if its not default (maybe 0)

                ////ALTERATIVE, going to have to make separate queries using DISTINCT and ORDER BY
                ////to get the different groups
                ////first query gets count of distinct users and then saves count and
                ////and different users somewhere which powers a 
                ////counted iteration loop to requery only that user
                ////following queries gets all appt data for only that user
                ////saves all info to some variable for stringbuilder
                ////string interpolation works for mysqlcommands

                //foreach (DataRow dr in dtbl.Rows)
                //{
                //    string x = dr["start"].ToString();
                //    DateTime date = Convert.ToDateTime(x);
                //    int caseSwitch = Int32.Parse(date.Month.ToString());
                //    string y = dr["type"].ToString();

                    
                //}

                ////StringBuilder sb = new StringBuilder();
                ////sb.AppendLine($"January has {january} appointments. {janNew} of type New Appt and {janFollow} of type Followup.");
                

                ////monthReportScreenTextBox.Clear();
                ////monthReportScreenTextBox.Text = sb.ToString();

                //mySqlCon.Close();
            }
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT U04pXF.user.userName" +
                    " FROM U04pXF.user",mySqlCon);
                MySqlDataAdapter mySqlDA = new MySqlDataAdapter();
                mySqlDA.SelectCommand = cmd;
                DataTable dtbl = new DataTable();
                mySqlDA.Fill(dtbl);

                StringBuilder sbFinal = new StringBuilder();

                foreach (DataRow drUser in dtbl.Rows)
                {
                    string user = drUser["userName"].ToString();

                    //retrieves only the user's appointment data with string interpolation
                    MySqlCommand cmdAppt = new MySqlCommand($"SELECT U04pXF.appointment.title," +
                        $" U04pXF.appointment.type, U04pXF.appointment.start," +
                        $" U04pXF.appointment.end, U04pXF.user.userName," +
                        $" U04pXF.customer.customerName FROM U04pXF.user" +
                        $" INNER JOIN U04pXF.appointment ON user.userId = appointment.userId" +
                        $" INNER JOIN U04pXF.customer ON appointment.customerId = customer.customerId " +
                        $"WHERE user.userName = '{user}' ORDER BY U04pXF.appointment.start", mySqlCon);
                    MySqlDataAdapter mySqlDAAppt = new MySqlDataAdapter();
                    DataTable dtblAppt = new DataTable();
                    mySqlDAAppt.SelectCommand = cmdAppt;
                    mySqlDAAppt.Fill(dtblAppt);

                    StringBuilder sbUser = new StringBuilder();
                    sbUser.AppendLine($"{user} has the following schedule:");

                    //extract all data to variables, build final string of details to append
                    //to stringbuilder
                    foreach (DataRow drAppt in dtblAppt.Rows)
                    {
                        string start = drAppt["start"].ToString();
                        string end = drAppt["end"].ToString();
                        string customerName = drAppt["customerName"].ToString();
                        string title = drAppt["title"].ToString();
                        string type = drAppt["type"].ToString();

                        sbUser.AppendLine($"Start:{start}, End:{end}, Customer:{customerName}, Type:{type}, Title:{title}");
                    }

                    sbFinal.AppendLine($"{sbUser}");

                    consultantReportScreenTextBox.Clear();
                    consultantReportScreenTextBox.Text = sbFinal.ToString();

                    mySqlCon.Close();
                }

            }
        }
    }
}
