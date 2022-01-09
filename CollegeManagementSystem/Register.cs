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
    public partial class Register : Form
    {
        public Register()
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
            tbFn.Text = "";
            tbName.Text = "";
            tbMark.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFn.Text == "" || tbName.Text == "" || tbMark.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TeacherTbl values(" + tbFn.Text + ",'" + tbName.Text + "','" + tbMark.Text + "')", myconn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Successfully Added");
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
