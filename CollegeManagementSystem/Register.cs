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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        public static object stdFN { get; internal set; }

        private void Register_Load_1(object sender, EventArgs e)
        {
            fillTheRegisterTable();
        }

        private void loadRegisterTableData()
        {
            dbconnection.Open();
            string querry = "SELECT * FROM RegisterTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querry, dbconnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            dbconnection.Close();

            var ds = new DataSet("Register");
            sda.Fill(ds);

            RegDGV.DataSource = ds.Tables[0];

            RegDGV.Columns["StdId"].Visible = false;
            RegDGV.Columns["StdFN"].HeaderText = "Faculty №";
            RegDGV.Columns["Period"].HeaderText = "Period";
            RegDGV.Columns["Mark"].HeaderText = "Mark";
            RegDGV.Columns["Subject"].HeaderText = "Sudject";
        }

        private void fillTheRegisterTable()
        {

            loadRegisterTableData();

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Action";
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            RegDGV.Columns.Add(deleteButton);

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



        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbFN.Text == "" || dtPeriod.Text == "" || cbMark.Text == "" || cbSub.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                dbconnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT RegisterTbl (StdFN,Period,Mark,Subject) VALUES(@StdFN,@Period,@Mark,@Subject)", dbconnection);

                cmd.Parameters.AddWithValue("@StdFN", tbFN.Text);
                cmd.Parameters.AddWithValue("@Period", dtPeriod.Text);
                cmd.Parameters.AddWithValue("@Mark", cbMark.Text);
                cmd.Parameters.AddWithValue("@Subject", cbSub.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mark Successfully Added");
                dbconnection.Close();


                loadRegisterTableData();
            }


        }

        private void RegDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RegDGV.Columns[e.ColumnIndex].Name == "Delete")

            {
                try
                {
                    int deleteStudentFN = Convert.ToInt32(RegDGV.Rows[e.RowIndex].Cells[0].Value);

                    dbconnection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM RegisterTbl WHERE StdFN=@StdFN", dbconnection);
                    cmd.Parameters.AddWithValue("@StdFN", deleteStudentFN);
                    cmd.ExecuteNonQuery();
                    dbconnection.Close();

                    MessageBox.Show("Deleted.");

                    fillTheRegisterTable();

                    this.Hide();
                    Register registerForm = new Register();
                    registerForm.Show();
                }
                catch { }
            }
            // This will show you the button name when you click
            // MessageBox.Show(StdDGV.Columns[e.ColumnIndex].Name); 
        }
    }
}
