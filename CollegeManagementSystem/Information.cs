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
            /*
            DataView DV = new DataView(dbdataset);
            Dv.RowFilter = string.Format("Faculty Nomer LIKE '%{0}%'", btSearch);
            InformDGV.DataSource = DV;
             */
        }

        private void Information_Load(object sender, EventArgs e)
        {
           
        }

    }
}
