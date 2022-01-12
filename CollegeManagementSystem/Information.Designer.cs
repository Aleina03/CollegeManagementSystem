
namespace CollegeManagementSystem
{
    partial class Information
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InformDGV = new System.Windows.Forms.DataGridView();
            this.btHome = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.stdFN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.averageMarkLabelText = new System.Windows.Forms.Label();
            this.averageMarkLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 100);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Information ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(979, 9);
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
            this.label1.Location = new System.Drawing.Point(308, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "College Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 18);
            this.panel2.TabIndex = 4;
            // 
            // InformDGV
            // 
            this.InformDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.InformDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InformDGV.Location = new System.Drawing.Point(319, 162);
            this.InformDGV.Name = "InformDGV";
            this.InformDGV.RowTemplate.Height = 25;
            this.InformDGV.Size = new System.Drawing.Size(661, 344);
            this.InformDGV.TabIndex = 39;
            this.InformDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InformDGV_CellContentClick);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Location = new System.Drawing.Point(178, 477);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(108, 29);
            this.btHome.TabIndex = 90;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(178, 199);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(108, 29);
            this.btSearch.TabIndex = 88;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // stdFN
            // 
            this.stdFN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdFN.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdFN.ForeColor = System.Drawing.Color.SteelBlue;
            this.stdFN.Location = new System.Drawing.Point(115, 162);
            this.stdFN.Name = "stdFN";
            this.stdFN.Size = new System.Drawing.Size(171, 19);
            this.stdFN.TabIndex = 100;
            this.stdFN.TextChanged += new System.EventHandler(this.stdFN_TextChanged);
            this.stdFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stdFN_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(13, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 99;
            this.label8.Text = "Faculty №";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(319, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 101;
            this.label11.Text = "Information About";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // averageMarkLabelText
            // 
            this.averageMarkLabelText.AutoSize = true;
            this.averageMarkLabelText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageMarkLabelText.Location = new System.Drawing.Point(178, 280);
            this.averageMarkLabelText.Name = "averageMarkLabelText";
            this.averageMarkLabelText.Size = new System.Drawing.Size(128, 25);
            this.averageMarkLabelText.TabIndex = 102;
            this.averageMarkLabelText.Text = "Average mark";
            this.averageMarkLabelText.Visible = false;
            this.averageMarkLabelText.Click += new System.EventHandler(this.label4_Click);
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.AutoSize = true;
            this.averageMarkLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageMarkLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.averageMarkLabel.Location = new System.Drawing.Point(215, 316);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(49, 28);
            this.averageMarkLabel.TabIndex = 103;
            this.averageMarkLabel.Text = "0.00";
            this.averageMarkLabel.Visible = false;
            this.averageMarkLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 572);
            this.Controls.Add(this.averageMarkLabel);
            this.Controls.Add(this.averageMarkLabelText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.stdFN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.InformDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView InformDGV;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox stdFN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label averageMarkLabelText;
        private System.Windows.Forms.Label averageMarkLabel;
    }
}