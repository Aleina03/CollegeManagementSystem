using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student studentForm = new Student();
            studentForm.Show();
        }

        private void btTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers teachersForm = new Teachers();
            teachersForm.Show();
        }


        private void btFees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register marksForm = new Register();
            marksForm.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information informForm = new Information();
            informForm.Show();
        }
    }
}
