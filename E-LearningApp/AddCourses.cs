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
    public partial class AddCourses : Form
    {
        public AddCourses()
        {
            InitializeComponent();
        }

        private void ViewAllCourses_Load(object sender, EventArgs e)
        {

        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            AdminServices.AdminService1Client adminService = new AdminServices.AdminService1Client();
            int Price =int.Parse(PriceTxt.Text);
            string selectedCategory = comboBox1.SelectedItem.ToString();
            adminService.AddCourse(Nametxt.Text,DescriptionTxt.Text,Price,selectedCategory);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Close();
        }
    }
}
