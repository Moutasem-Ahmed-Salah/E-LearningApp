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
    public partial class StudentAuthentication : Form
    {
        public StudentAuthentication()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
             StudentSignIn studentsign=new StudentSignIn();
            this.Close();
            studentsign.Show();


        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            StudentRegister studentReg=new StudentRegister();
            this.Close();
            studentReg.Show();
        }
    }
}
