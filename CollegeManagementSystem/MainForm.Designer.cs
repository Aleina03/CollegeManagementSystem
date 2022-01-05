
namespace CollegeManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btStudent = new System.Windows.Forms.Button();
            this.btTeacher = new System.Windows.Forms.Button();
            this.btDepartment = new System.Windows.Forms.Button();
            this.btFees = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(809, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "College Management System";
            // 
            // btStudent
            // 
            this.btStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.btStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStudent.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStudent.ForeColor = System.Drawing.Color.White;
            this.btStudent.Location = new System.Drawing.Point(316, 127);
            this.btStudent.Name = "btStudent";
            this.btStudent.Size = new System.Drawing.Size(196, 43);
            this.btStudent.TabIndex = 1;
            this.btStudent.Text = "Students";
            this.btStudent.UseVisualStyleBackColor = false;
            this.btStudent.Click += new System.EventHandler(this.btStudent_Click);
            // 
            // btTeacher
            // 
            this.btTeacher.BackColor = System.Drawing.Color.SteelBlue;
            this.btTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTeacher.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTeacher.ForeColor = System.Drawing.Color.White;
            this.btTeacher.Location = new System.Drawing.Point(316, 193);
            this.btTeacher.Name = "btTeacher";
            this.btTeacher.Size = new System.Drawing.Size(196, 43);
            this.btTeacher.TabIndex = 2;
            this.btTeacher.Text = "Teachers";
            this.btTeacher.UseVisualStyleBackColor = false;
            this.btTeacher.Click += new System.EventHandler(this.btTeacher_Click);
            // 
            // btDepartment
            // 
            this.btDepartment.BackColor = System.Drawing.Color.SteelBlue;
            this.btDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDepartment.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDepartment.ForeColor = System.Drawing.Color.White;
            this.btDepartment.Location = new System.Drawing.Point(316, 254);
            this.btDepartment.Name = "btDepartment";
            this.btDepartment.Size = new System.Drawing.Size(196, 43);
            this.btDepartment.TabIndex = 3;
            this.btDepartment.Text = "Departments";
            this.btDepartment.UseVisualStyleBackColor = false;
            this.btDepartment.Click += new System.EventHandler(this.btDepartment_Click);
            // 
            // btFees
            // 
            this.btFees.BackColor = System.Drawing.Color.SteelBlue;
            this.btFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFees.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btFees.ForeColor = System.Drawing.Color.White;
            this.btFees.Location = new System.Drawing.Point(316, 324);
            this.btFees.Name = "btFees";
            this.btFees.Size = new System.Drawing.Size(196, 43);
            this.btFees.TabIndex = 4;
            this.btFees.Text = "Fees";
            this.btFees.UseVisualStyleBackColor = false;
            this.btFees.Click += new System.EventHandler(this.btFees_Click);
            // 
            // btUsers
            // 
            this.btUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUsers.ForeColor = System.Drawing.Color.White;
            this.btUsers.Location = new System.Drawing.Point(316, 392);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(196, 43);
            this.btUsers.TabIndex = 5;
            this.btUsers.Text = "Users";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(357, 454);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(108, 29);
            this.btLogout.TabIndex = 6;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(847, 506);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btUsers);
            this.Controls.Add(this.btFees);
            this.Controls.Add(this.btDepartment);
            this.Controls.Add(this.btTeacher);
            this.Controls.Add(this.btStudent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStudent;
        private System.Windows.Forms.Button btTeacher;
        private System.Windows.Forms.Button btDepartment;
        private System.Windows.Forms.Button btFees;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label2;
    }
}