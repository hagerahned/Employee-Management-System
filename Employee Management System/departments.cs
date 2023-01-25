using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class departments : Form
    {
        Functions Con;
        public departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTbl";
            DepList.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text=="")
                {
                    MessageBox.Show("Missing Data!!!");
                }else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query,DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int n = e.RowIndex;
            DepNameTb.Text = DepList.CurrentRow.Cells[1].Value.ToString();
            if(DepNameTb.Text =="")
            {
                key = 0;
            }
            else
            {
               key = Convert.ToInt32(DepList.CurrentRow.Cells[0].Value.ToString());
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTbl where DepName='{0}'";
                    Query = string.Format(Query, Dep);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    int index = Convert.ToInt32(DepList.CurrentRow.Cells[0].Value.ToString());
                    string Query = "Update  DepartmentTbl set DepName='{0}' where Depid={1} ";
                    Query = string.Format(Query, Dep, index);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department updated!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void departments_Load(object sender, EventArgs e)
        {

        }

        private void EmbLbl_Click(object sender, EventArgs e)
        {
            DeleteBtn obj = new DeleteBtn();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            departments obj = new departments();
            obj.Show();
            obj.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            salaryf obj = new salaryf();
            obj.Show();
            obj.Hide();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            obj.Hide();
        }
    }
}
