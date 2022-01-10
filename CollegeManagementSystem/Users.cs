﻿using System;
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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelly\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {

            dbconnection.Open();
             string querry = "select * from UserTbl";
             SqlDataAdapter sda = new SqlDataAdapter(querry, dbconnection);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             UserDGV.DataSource = ds.Tables[0];
            dbconnection.Close(); 
             
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show(); 
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            UIdTb.Text = "";
            UNameTb.Text = "";
            UPasswordTb.Text = "";
            cbRole.SelectedItem = null;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (UIdTb.Text == "" || UNameTb.Text == "" || UPasswordTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    dbconnection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into UserTbl values(" + UIdTb.Text + ",'" + UNameTb.Text + "','" + UPasswordTb.Text + "','" + cbRole.SelectedItem + "' )", dbconnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    dbconnection.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
