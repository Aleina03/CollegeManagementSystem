
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
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btInformation = new System.Windows.Forms.Button();
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
            this.btStudent.Location = new System.Drawing.Point(316, 133);
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
            this.btTeacher.Location = new System.Drawing.Point(316, 210);
            this.btTeacher.Name = "btTeacher";
            this.btTeacher.Size = new System.Drawing.Size(196, 43);
            this.btTeacher.TabIndex = 2;
            this.btTeacher.Text = "Teachers";
            this.btTeacher.UseVisualStyleBackColor = false;
            this.btTeacher.Click += new System.EventHandler(this.btTeacher_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(316, 283);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(196, 43);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btFees_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(360, 431);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(108, 29);
            this.btLogout.TabIndex = 6;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btInformation
            // 
            this.btInformation.BackColor = System.Drawing.Color.SteelBlue;
            this.btInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInformation.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInformation.ForeColor = System.Drawing.Color.White;
            this.btInformation.Location = new System.Drawing.Point(316, 357);
            this.btInformation.Name = "btInformation";
            this.btInformation.Size = new System.Drawing.Size(196, 43);
            this.btInformation.TabIndex = 7;
            this.btInformation.Text = "Information";
            this.btInformation.UseVisualStyleBackColor = false;
            this.btInformation.Click += new System.EventHandler(this.btInformation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(847, 506);
            this.Controls.Add(this.btInformation);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btRegister);
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
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInformation;
    }
}