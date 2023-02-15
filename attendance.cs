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
    public partial class attendance : MetroFramework.Forms.MetroForm 
    {
        const string constr = @"Data Source=DESKTOP-DNME7HG\SPARTA;Initial Catalog=AttendanceDB; Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public attendance()
        {
            InitializeComponent();
            

            // get student table
            cm.CommandText = "SELECT * FROM Attendance";
            cm.Connection = con;
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            // add students data to datagridview
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

            

            


        }

        private void attendance_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void SS_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           //open student form
            st st1 = new st();
            st1.Show(); 
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // make data gridview editable
            

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            //get text from metrotextbox1




        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //take data from metrotextbox3 and metrotextbox4 and metrotextbox4 and add to database Students
            //insert into student table 
            string sql = "INSERT INTO Attendance (name, id, classid) VALUES (@name, @id, @classid )";
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@name", metroTextBox3.Text);
            cm.Parameters.AddWithValue("@id", Convert.ToInt32(metroTextBox4.Text));
            cm.Parameters.AddWithValue("@classid", Convert.ToInt32(metroTextBox5.Text));
            cm.ExecuteNonQuery();
            con.Close();
            //refresh datagridview
            cm.CommandText = "SELECT * FROM Attendance";
            cm.Connection = con;
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            // add students data to datagridview
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            

            
           

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //if radiobutton is checked 

            //update status viarable in attendance table
            string sql = "UPDATE Attendance SET status = @status WHERE id = @id";
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@status", '1');
            cm.Parameters.AddWithValue("@id", Convert.ToInt32(metroTextBox2.Text));
            cm.ExecuteNonQuery();
            con.Close();
            
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            //open student form
            students st1 = new students();
            st1.Show();
        }











        //read table students




    }
    }




