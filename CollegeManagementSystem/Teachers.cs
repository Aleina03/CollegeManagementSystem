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
        SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || cbGender.Text == "" || tbPhone.Text == "" || cbSpeciality.Text== "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                dbconnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT TeacherTbl (TeacherName,TeacherGender,TeacherPhone,TeacherSpeciality) VALUES(@TeacherName,@TeacherGender,@TeacherPhone,@TeacherSpeciality)", dbconnection);

                cmd.Parameters.AddWithValue("@TeacherName", tbName.Text);
                cmd.Parameters.AddWithValue("@TeacherGender", cbGender.Text);
                cmd.Parameters.AddWithValue("@TeacherPhone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@TeacherSpeciality", cbSpeciality.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Successfully Added");
                dbconnection.Close();


                loadTeacherTableData();
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            fillTheTeacherTable();
        }

        private void loadTeacherTableData()
        {
            dbconnection.Open();
            string querry = "SELECT * FROM TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querry, dbconnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            dbconnection.Close();

            var ds = new DataSet("Teachers");
            sda.Fill(ds);

            TeacherDGV.DataSource = ds.Tables[0];

            TeacherDGV.Columns["TeacherName"].HeaderText = "Teacher Name";
        }

        private void fillTheTeacherTable()
        {

            loadTeacherTableData();

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Action";
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            TeacherDGV.Columns.Add(deleteButton);

        }

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TeacherDGV.Columns[e.ColumnIndex].Name == "Delete")

            {
                try
                {
                    int deleteTeacherId = Convert.ToInt32(TeacherDGV.Rows[e.RowIndex].Cells[0].Value);

                    dbconnection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TeacherTbl WHERE TeacherId=@TeacherId", dbconnection);
                    cmd.Parameters.AddWithValue("@TeacherId", deleteTeacherId);
                    cmd.ExecuteNonQuery();
                    dbconnection.Close();

                    MessageBox.Show("Deleted.");

                    fillTheTeacherTable();

                    this.Hide();
                    Teachers teachertForm = new Teachers();
                    teachertForm.Show();
                }
                catch { }
            }
            // This will show you the button name when you click
            // MessageBox.Show(StdDGV.Columns[e.ColumnIndex].Name); 
        }
    }
}
