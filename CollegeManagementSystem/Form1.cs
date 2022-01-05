using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        int tickProgress = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tickProgress++;
            MyProgressBar.Value = tickProgress;

            if (MyProgressBar.Value == 100)
            {
                timer1.Stop();

                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void MyProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
