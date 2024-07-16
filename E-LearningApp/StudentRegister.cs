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
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentServices.StudentServiceSoapClient studentService=new StudentServices.StudentServiceSoapClient();
            studentService.StudentRegister(NameTxt.Text,Address.Text,Area.Text,PhoneNumber.Text,UserName.Text,Pwd.Text,Mail.Text);
            MessageBox.Show("You are Now Registered,Welcome "+NameTxt.Text+" !" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StudentSignIn studentSignIn = new StudentSignIn();
            this.Hide();
            studentSignIn.Show();

        }
    }
}
