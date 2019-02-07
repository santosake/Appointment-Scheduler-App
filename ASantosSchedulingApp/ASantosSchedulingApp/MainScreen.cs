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
    public partial class MainScreen : Form
    {
        //Saves user selection of Report Radio Button
        int reportSelection = 0;

        //Saves user selection of Calendar Radio Button
        int calendarSelection = 0;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
            this.Hide();
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentScreen appointmentScreen = new AppointmentScreen();
            appointmentScreen.Show();
            this.Hide();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            if (reportSelection > 2)
            {
                //placeholder for third option
                CityReportScreen cityReportScreen = new CityReportScreen();
                cityReportScreen.Show();
                this.Hide();
            }
            else if (reportSelection > 1 && reportSelection < 3)
            {
                //placeholder for second option
                ConsultantReportScreen consultantReportScreen = new ConsultantReportScreen();
                consultantReportScreen.Show();
                this.Hide();
            }
            else if (reportSelection > 0 && reportSelection < 2)
            {
                //placeholder for first option
                MonthReportScreen monthReportScreen = new MonthReportScreen();
                monthReportScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a Report option.");
            }
        }

        private void appointmentsByMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            reportSelection = 1;
        }

        private void scheduleForEachConsultantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            reportSelection = 2;
        }

        private void appointmentsByRegionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            reportSelection = 3;
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {           
            if (calendarSelection > 1 && calendarSelection < 3)
            {
                //placeholder for second option
                MonthlyCalendarScreen monthlyCalendarScreen = new MonthlyCalendarScreen();
                monthlyCalendarScreen.Show();
                this.Hide();
                
            }
            else if (calendarSelection > 0 && calendarSelection < 2)
            {
                //placeholder for first option
                WeeklyCalendarScreen weeklyCalendarScreen = new WeeklyCalendarScreen();
                weeklyCalendarScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a Calendar option.");
            }
        }

        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calendarSelection = 1;
        }

        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calendarSelection = 2;
        }
    }
}
