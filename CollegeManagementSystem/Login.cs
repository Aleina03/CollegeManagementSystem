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
    public partial class Login : Form
    {
        public object MForm { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inputPassword.Text != string.Empty || inputUsername.Text != string.Empty)
            {

                var cmd = new SqlCommand("select * from UsersTbl where inputUsername='" + inputUsername.Text + "'", this.dbconnection);
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registerForm = new Registration();
            registerForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            inputUsername.Text = "";
            inputPassword.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection dbconnection;
        private void Login_Load(object sender, EventArgs e)
        {
            dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NELLY\DOCUMENTS\COLLEGEDB.MDF;Integrated Security=True");
            dbconnection.Open();
        }
    }
}
