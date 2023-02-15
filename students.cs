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


namespace Attendance_System
{
    public partial class students :  MetroFramework.Forms.MetroForm 

    {
        const string constr = @"Data Source=DESKTOP-DNME7HG\SPARTA;Initial Catalog=AttendanceDB; Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public students()
        {
            InitializeComponent();
            // get student table
            cm.CommandText = "SELECT * FROM Students";
            cm.Connection = con;
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            // add students data to datagridview
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

            

        }

        private void students_Load(object sender, EventArgs e)
        {

        }
    }
}
