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
    public partial class DeleteBtn : Form
    {
        Functions Con;
        public DeleteBtn()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            try
            {
                string Query = "Select * from EmployeeTbl";
                EmployeeList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void GetDepartment()
        {
            string Query = "select * from DepartmentTbl";

           

            DepCb.DataSource = Con.GetData(Query);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void Employee_Load(object sender, EventArgs e)
        {

        }



        private void EmpLbl_Click(object sender, EventArgs e)
        {
            DeleteBtn obj = new DeleteBtn();
            obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "insert into EmployeeTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {

                    string Query = "delete from EmployeeTbl where Empid={0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.Date.ToString();
                    string JDate = JDateTb.Value.Date.ToString();
                    int salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "Update EmployeeTbl set EmpName='{0}',EmpGen='{1}',EmpDep='{2}',EmpDOB='{3}',EmpJDate='{4}',EmpSal='{5}'where Empid={6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, salary, key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.CurrentRow.Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.CurrentRow.Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.CurrentRow.Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.CurrentRow.Cells[4].Value.ToString();
            DailySalTb.Text = EmployeeList.CurrentRow.Cells[6].Value.ToString();
            JDateTb.Text = EmployeeList.CurrentRow.Cells[5].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.CurrentRow.Cells[0].Value.ToString());
            }
        }


        
        private void DepLbl_Click(object sender, EventArgs e)
        {
            departments obj = new departments();
            obj.Show();
            obj.Hide();
        }
        private void SalLbl_Click(object sender, EventArgs e)
        {
            salaryf obj = new salaryf();
            obj.Show();
            obj.Hide();

        }

        
        private void label12_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            obj.Hide();
        }
        private void DailySalTb_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
