
namespace Employee_Management_System
{
    partial class departments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepList = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DepNameTb = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Label();
            this.Salbtn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmbLbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 128);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(533, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(632, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DepList
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DepList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Constantia", 13.12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DepList.ColumnHeadersHeight = 29;
            this.DepList.GridColor = System.Drawing.Color.Teal;
            this.DepList.Location = new System.Drawing.Point(556, 261);
            this.DepList.Name = "DepList";
            this.DepList.RowHeadersWidth = 100;
            this.DepList.RowTemplate.Height = 24;
            this.DepList.Size = new System.Drawing.Size(888, 885);
            this.DepList.TabIndex = 23;
            this.DepList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepList_CellContentClick);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Teal;
            this.EditBtn.Location = new System.Drawing.Point(187, 309);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(151, 54);
            this.EditBtn.TabIndex = 38;
            this.EditBtn.Text = "Update";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Teal;
            this.AddBtn.Location = new System.Drawing.Point(13, 309);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(151, 54);
            this.AddBtn.TabIndex = 37;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(931, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Department list";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(7, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Department name";
            // 
            // DepNameTb
            // 
            this.DepNameTb.Location = new System.Drawing.Point(12, 226);
            this.DepNameTb.Multiline = true;
            this.DepNameTb.Name = "DepNameTb";
            this.DepNameTb.Size = new System.Drawing.Size(316, 47);
            this.DepNameTb.TabIndex = 25;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Teal;
            this.logout.Location = new System.Drawing.Point(1017, 143);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(102, 32);
            this.logout.TabIndex = 57;
            this.logout.Text = "Log out ";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Salbtn
            // 
            this.Salbtn.AutoSize = true;
            this.Salbtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salbtn.ForeColor = System.Drawing.Color.Teal;
            this.Salbtn.Location = new System.Drawing.Point(854, 143);
            this.Salbtn.Name = "Salbtn";
            this.Salbtn.Size = new System.Drawing.Size(85, 32);
            this.Salbtn.TabIndex = 56;
            this.Salbtn.Text = "Salary ";
            this.Salbtn.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(631, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 32);
            this.label10.TabIndex = 55;
            this.label10.Text = "Departments ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // EmbLbl
            // 
            this.EmbLbl.AutoSize = true;
            this.EmbLbl.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbLbl.ForeColor = System.Drawing.Color.Teal;
            this.EmbLbl.Location = new System.Drawing.Point(441, 143);
            this.EmbLbl.Name = "EmbLbl";
            this.EmbLbl.Size = new System.Drawing.Size(125, 32);
            this.EmbLbl.TabIndex = 54;
            this.EmbLbl.Text = "Employee ";
            this.EmbLbl.Click += new System.EventHandler(this.EmbLbl_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Teal;
            this.DeleteBtn.Location = new System.Drawing.Point(101, 382);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(151, 54);
            this.DeleteBtn.TabIndex = 62;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1627, 898);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Salbtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmbLbl);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepNameTb);
            this.Controls.Add(this.DepList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Constantia", 13.12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "departments";
            this.Load += new System.EventHandler(this.departments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DepList;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepNameTb;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label Salbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EmbLbl;
        private System.Windows.Forms.Button DeleteBtn;
    }
}