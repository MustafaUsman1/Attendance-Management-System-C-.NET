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
    public partial class LoginForm : Form
    {

        // TODO: Specify the connection string for connecting the front end to the backend.
        const string constr = @"Data Source=DESKTOP-DNME7HG\SPARTA;Initial Catalog=AttendanceDB; Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        public bool flag { get; set; }
        public int id { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            flag = false;
        }

        private void metroButton1login_Click(object sender, EventArgs e)
        {
            String username, user_pass;

            username = metroTextBoxuser.Text;
            user_pass = metroTextBoxpass.Text;

            try
            {
                String query = "SELECT * FROM USERS where username = '"+metroTextBoxuser.Text+"' AND password = '"+metroTextBoxpass.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dataTable= new DataTable();
                sda.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    username = metroTextBoxuser.Text;
                    user_pass= metroTextBoxpass.Text;
                    flag = true;
                    
                    //page
                    MessageBox.Show("Succesful attempt");
                    
                    attendance att = new attendance();
                    att.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid attempt","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    metroTextBoxpass.Clear();
                    metroTextBoxuser.Clear();       
                }
                
            }
            catch { MessageBox.Show("Invalid attempt"); }
            finally { 
                con.Close();
            }
            Close();

        }

        //get values from database


    }
}

