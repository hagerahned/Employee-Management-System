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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //button login
        private void button1_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text ==""||PasswordTb.Text=="")
            {
                MessageBox.Show("Missing Data");
            }
            else if(UNameTb.Text=="Admin" && PasswordTb.Text=="Password")
            {
                DeleteBtn obj = new DeleteBtn();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
                PasswordTb.Text = "";
                UNameTb.Text = "";
                
            }
        }
        //button reset
        private void label4_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = "";
            UNameTb.Text = "";
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
