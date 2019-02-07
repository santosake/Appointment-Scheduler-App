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
using System.Globalization;
using System.IO;
using System.Threading;

namespace ASantosSchedulingApp
{
    public partial class LoginScreen : Form
    {
        //Connection String to Database
        string connectionString = @"server=52.206.157.109;password=53688311316;user id=U04pXF;database=U04pXF;persistsecurityinfo=True;allowuservariables=True;Convert Zero Datetime = True;";

        public static string CurrentUser { get; set; }

        public static string LoginTime { get; set; }

        public LoginScreen()
        {
            InitializeComponent();
            Localize();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();

            int successSwitch = 0;

            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT U04pXF.user.userName," +
                    " U04pXF.user.password FROM U04pXF.user", mySqlCon);
                MySqlDataAdapter mySqlDA = new MySqlDataAdapter(cmd);

                DataTable dtbl = new DataTable();
                mySqlDA.Fill(dtbl);

                foreach (DataRow dr in dtbl.Rows)
                {
                    string userFetched = dr["userName"].ToString();
                    string passwordFetched = dr["password"].ToString();

                    if (userName == userFetched && password == passwordFetched)
                    {
                        successSwitch = 1;
                        CurrentUser = userFetched;
                        DateTime x = new DateTime();
                        x = DateTime.Now;
                        LoginTime = x.ToString();
                        LogEntry();
                    }
                }
            }

            if (successSwitch == 1)
            {
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Visible = true;
            }

        }

        private void Localize()
        {
            //CultureInfo currentCulture = new CultureInfo("es");
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            //Thread.CurrentThread.CurrentUICulture = currentCulture;
            int cultureLCID = currentCulture.LCID;

            if (cultureLCID == 11274 || cultureLCID == 16394 || cultureLCID == 13322
                || cultureLCID == 9226 || cultureLCID == 5130 || cultureLCID == 7178
                || cultureLCID == 12298 || cultureLCID == 17418 || cultureLCID == 4106
                || cultureLCID == 18442 || cultureLCID == 2058 || cultureLCID == 19466
                || cultureLCID == 6154 || cultureLCID == 15370 || cultureLCID == 10250
                || cultureLCID == 20490 || cultureLCID == 1034 || cultureLCID == 14346
                || cultureLCID == 8202)
            {
                formTitleLabel.Text = "Horario de Inicio de Sesion";
                usernameLabel.Text = "Nombre de Usuario :";
                passwordLabel.Text = "Contrasena :";
                loginButton.Text = "Iniciar";
                exitButton.Text = "Salir"; 
                errorLabel.Text = "Nombre de usuario y/o contrasena no valida.";
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void LogEntry()
        {
            string path = @"UserActivityRecords.txt";

            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{CurrentUser} has logged in at {LoginTime}");
            }

        }
    }
}
