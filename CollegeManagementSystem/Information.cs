﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
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
            tbFN.Text = "";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            /*
             da tursi po tbId, tbName i tbFN ot StudentTbl, RegisterTbl i sa pokaje v Inf About list-a
             */
        }
    }
}
