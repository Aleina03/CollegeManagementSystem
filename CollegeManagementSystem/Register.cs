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
    public partial class Register: Form 
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection;

        private void Register_Load_1(object sender, EventArgs e)
        {

            dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NELLY\DOCUMENTS\COLLEGEDB.MDF;Integrated Security=True");
            dbconnection.Open(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbFn.Text = "";
            tbName.Text = "";
            tbId.Text = "";
            cbMarks.SelectedItem = null;
            cbSub.SelectedItem = null;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFn.Text == "" || tbName.Text == "" || tbId.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    dbconnection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into RegistrerTbl values(" + tbId + ",'" + tbFn.Text + ",'" + tbName.Text + "','" + dateTimePicker1 + "','" + cbMarks.SelectedItem + "','" + cbSub.SelectedItem + "')", dbconnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mark Successfully Added");
                    dbconnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

    }
}
