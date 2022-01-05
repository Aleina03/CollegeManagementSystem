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

namespace CollegeManagementSystem
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection myconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            myconn.Open();
            string querry = "select + fromUserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myconn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            myconn.Close();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show(); 
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            UIdTb.Text = "";
            UNameTb.Text = "";
            UPasswordTb.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (UIdTb.Text == "" || UNameTb.Text == "" || UPasswordTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into UserTbl values(" + UIdTb.Text + ",'" + UNameTb.Text + "','" + UPasswordTb.Text + "')", myconn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    myconn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
    }
}
