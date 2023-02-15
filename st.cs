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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_System
{
    public partial class st : MetroFramework.Forms.MetroForm
    {
        const string constr = @"Data Source=DESKTOP-DNME7HG\SPARTA;Initial Catalog=AttendanceDB; Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public st()
        {
            InitializeComponent();
            cm.CommandText = "SELECT * FROM Classes";
            cm.Connection = con;
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            // add students data to datagridview
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //get data from name id and user id
            
            //insert data to student table
            string sql = "INSERT INTO Student (name, id, userid) VALUES (@name, @id, @userid)";
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@name", metroTextBox1.Text);
            cm.Parameters.AddWithValue("@id", Convert.ToInt32(metroTextBox2.Text));
            cm.Parameters.AddWithValue("@userid", Convert.ToInt32(metroTextBox3.Text));
            cm.ExecuteNonQuery();
            con.Close();


            //open student window form



        }

        private void st_Load(object sender, EventArgs e)
        {

        }
    }
}
