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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Student_Load(object sender, EventArgs e)
        {
            fillTheStudentTable(); 
        }

        private void loadStudentTableData()
        {
            dbconnection.Open();
            string querry = "SELECT * FROM StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querry, dbconnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            dbconnection.Close();

            var ds = new DataSet("Students");
            sda.Fill(ds);

            StdDGV.DataSource = ds.Tables[0];

            StdDGV.Columns["StdFN"].HeaderText = "Fakultet nomer"; 
        }

        private void fillTheStudentTable()
        {

            loadStudentTableData();

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Action";
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
          
            StdDGV.Columns.Add(deleteButton);

        }

        private void StdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StdDGV.Columns[e.ColumnIndex].Name == "Delete")
               
            {
                try
                {
                    int deleteStudentID = Convert.ToInt32(StdDGV.Rows[e.RowIndex].Cells[0].Value);

                    dbconnection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM StudentTbl WHERE StdId=@StdId", dbconnection);
                    cmd.Parameters.AddWithValue("@StdId", deleteStudentID);
                    cmd.ExecuteNonQuery();
                    dbconnection.Close();

                    MessageBox.Show("Deleted.");

                    fillTheStudentTable();

                    this.Hide();
                    Student studentForm = new Student();
                    studentForm.Show();
                } catch { }
                }
            // This will show you the button name when you click
            // MessageBox.Show(StdDGV.Columns[e.ColumnIndex].Name); 
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
          /*  try
            {
                if (tbId.Text == "")
                {
                    MessageBox.Show("Enter The User Id");
                }
                else
                {
                    dbconnection.Open();
                    string query = "delete from UserTbl where UserId=" + tbId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, dbconnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    dbconnection.Close(); 
                    fillTheStudentTable();
                }
            }
            catch
            {
                MessageBox.Show("User Not Deleted");
            }*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (tbFN.Text == "" || tbName.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                dbconnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT StudentTbl (StdFN,StdName,StdGender,StdPhone) VALUES(@StdFN,@StdName,@StdGender,@StdPhone)", dbconnection);

                cmd.Parameters.AddWithValue("@StdFN", tbFN.Text);
                cmd.Parameters.AddWithValue("@StdName", tbName.Text);
                cmd.Parameters.AddWithValue("@StdGender", cbGender.Text); 
                cmd.Parameters.AddWithValue("@StdPhone", tbPhone.Text); 

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added");
                dbconnection.Close();


                loadStudentTableData();
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
      
    }
}
