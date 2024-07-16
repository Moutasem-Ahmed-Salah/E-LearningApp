using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminServices.AdminService1Client adminService=new AdminServices.AdminService1Client();
           Boolean SignedIn= adminService.AdminSignIn(Usertxt.Text,PWDtxt.Text);
            if (SignedIn)
            {
                MessageBox.Show("Credentials are correct.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminHome adminHome= new AdminHome();
                this.Hide();
                adminHome.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
