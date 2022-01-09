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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }
        SqlConnection myconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

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
            tbId.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            //tbAddress.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.Text == "" || tbName.Text == "" || tbPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TeacherTbl values(" + tbId.Text + ",'" + tbName.Text + "','" + tbPhone.Text + "')", myconn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Successfully Added");
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
