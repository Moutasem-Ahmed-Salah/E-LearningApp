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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // or this.Close() if you want to close the current form

            // Create an instance of the second form (assuming the second form is named Form2)
            Form2 form2 = new Form2();

            // Show the second form
            form2.Show();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAuthentication studentAuthentication = new StudentAuthentication();
            studentAuthentication.Show();
        }
    }
}
