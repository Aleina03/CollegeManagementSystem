using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection;
        private void Register_Load(object sender, EventArgs e)
        {

            dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NELLY\DOCUMENTS\COLLEGEDB.MDF;Integrated Security=True");
            dbconnection.Open(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            inputUsername.Text = "";
            inputPassword.Text = "";
            inputConfirmPassword.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (inputUsername.Text != string.Empty || inputPassword.Text != string.Empty || inputConfirmPassword.Text != string.Empty)
            {
                if (inputPassword.Text == inputConfirmPassword.Text)
                {
                    var cmd = new SqlCommand("select * from UserTbl where UserName='" + inputUsername.Text + "'", this.dbconnection);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    else 
                    {
                        dr.Close();

                        cmd = new SqlCommand("INSERT INTO UserTbl (UserName, Password) Values('" + inputUsername.Text + "', '" + inputPassword.Text + "')", this.dbconnection);
                        cmd.ExecuteNonQuery();      

                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   


                    
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
