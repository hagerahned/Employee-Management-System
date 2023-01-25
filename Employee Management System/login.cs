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

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text ==""||PasswordTb.Text=="")
            {
                MessageBox.Show("missing data");
            }
            else if(UNameTb.Text=="Admin" && PasswordTb.Text=="Password")
            {
                DeleteBtn obj = new DeleteBtn();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
