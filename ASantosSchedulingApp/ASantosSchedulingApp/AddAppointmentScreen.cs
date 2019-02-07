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
    public partial class AddAppointmentScreen : Form
    {
        public AddAppointmentScreen()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AppointmentScreen appointmentScreen = new AppointmentScreen();
            appointmentScreen.Show();
            this.Hide();
        }
    }
}
