using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Security.Cryptography;

namespace Attendance_System
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        // TODO: Specify the connection string for connecting the front end to the backend.
        const string constr = @"Data Source=DESKTOP-DNME7HG\SPARTA;Initial Catalog=AttendanceDB; Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        public int log { get; set; }
        public int id { get; set; }
        public MainForm()
        {
            InitializeComponent();
            log = 0;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (log == 0)
            {
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();
                newLogin.Close();
                log = 1;
            }
            

        }
        
    }
}
