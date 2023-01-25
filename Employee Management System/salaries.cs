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
    public partial class salaryf : Form
    {
        Functions Con;
        public salaryf()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";

            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["Empid"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }
        int DSal = 0;
        string period = "";
        private void GetSalary()
        {
            string Query = "select * from EmployeeTbl where Empid ={0} ";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach(DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
           
            //MessageBox.Show("" + DSal);
           // EmpCb.DataSource = Con.GetData(Query);
           if(DaysTb.Text == "")
            {
                AmountTb.Text = "Rs" + (d * DSal);
            }else if(Convert.ToInt32( DaysTb.Text) >31)
            {
                MessageBox.Show("days can not be greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "Rs" + (d * DSal);
            }
        }
        private void ShowSalries()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void salaries_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            salaryf obj = new salaryf();
            obj.Show();
            this.Hide();
        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("missing data!!!!!");
                }
                else
                {
                    period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = DSal * Convert.ToInt32(DaysTb.Text);
                    
                    string Query = "insert SalaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, period, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalries();
                    MessageBox.Show("salaries paid!!!");
                    DaysTb.Text = "";
                    

                    
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            departments obj = new departments();
            obj.Show();
            obj.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            DeleteBtn obj = new DeleteBtn();
            obj.Show();
            obj.Hide();
        }

        private void AmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            obj.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
