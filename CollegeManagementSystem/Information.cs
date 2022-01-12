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

        public static Register marksForm = new Register();


        private void btSearch_Click(object sender, EventArgs e)
        {
           /* try
            {
                using (SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30"));
                var cmd = new SqlCommand("select * from RegisterTbl where StdFN='" + stdFN.Text + "'", this.dbconnection);
                var dr = cmd.ExecuteReader();
                {
                    if (dbconnection.State == ConnectionState.Closed)
                        dbconnection.Open();
                    using(DataTable dt = new DataTable("Information"))
                    {
                        using (cmd = new SqlCommand("select * from RegisterTbl where StdId=@StdId", dbconnection)) ;
                        {
                            cmd.Parameters.AddWithValue("StdFN", stdFN.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            InformDGV.DataSource = dt;
                            stdFN.Text = $"Information about student: {InformDGV.RowCount}";
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           */
        }

        private void Information_Load(object sender, EventArgs e)
        {
           
        }

        private void InformDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
