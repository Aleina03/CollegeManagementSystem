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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            string searchString = stdFN.Text;

            dbconnection.Open();
            string querry = "SELECT * FROM RegisterTbl WHERE StdFN=@StdFN";
            SqlDataAdapter sda = new SqlDataAdapter(querry, dbconnection);
            sda.SelectCommand.Parameters.AddWithValue("@StdFN", searchString);

            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            dbconnection.Close(); 

            var ds = new DataSet("Register");
            sda.Fill(ds);

            InformDGV.DataSource = ds.Tables[0];

            InformDGV.Columns["StdFN"].HeaderText = "Faculty №";
            InformDGV.Columns["StdName"].HeaderText = "Name Family";
            InformDGV.Columns["Period"].HeaderText = "Period";
            InformDGV.Columns["Mark"].HeaderText = "Mark";
            InformDGV.Columns["Subject"].HeaderText = "Sudject";

        }

        private void Information_Load(object sender, EventArgs e)
        {

        }
        private void InformDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stdFN_TextChanged(object sender, EventArgs e)
        {
        }

        private void stdFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                btSearch.PerformClick();
        }
    }
}
