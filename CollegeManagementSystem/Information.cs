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

        private void btDelete_Click(object sender, EventArgs e)
        {
            dbconnection.Open();
            SqlCommand cmd = new SqlCommand("delete from InformTbl where StdId ='" + tbId.Text + "'", dbconnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Mark Deleted Successfully.");
            dbconnection.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            /*
             da tursi po tbId, tbName i tbFN ot StudentTbl, RegisterTbl i sa pokaje v Inf About list-a
             */
        }

        private void Information_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {

            dbconnection.Open();
            string querry = "select * from InformaTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querry, dbconnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds); //dava error
            InformDGV.DataSource = ds.Tables[0];
            dbconnection.Close();

        }
    }
}
