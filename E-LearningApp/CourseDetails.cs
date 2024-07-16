using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApp
{
    public partial class CourseDetails : Form
    {
        int ID;
        int CourseIDSelected;
        public CourseDetails(String CourseName,int StudentID)
        {
            InitializeComponent();
            ID = StudentID;
            label1.Text = CourseName;
           StudentServices.StudentServiceSoapClient studentService=new StudentServices.StudentServiceSoapClient();
            string[] CourseDetail=studentService.CourseDetail(CourseName);
            CourseID.Text=CourseDetail[0];
            CourseCategory.Text = CourseDetail[1];
            CourseDescription.Text = CourseDetail[2];
            CoursePrice.Text = CourseDetail[3];
            CourseIDSelected = int.Parse(CourseDetail[0]);
        }

        private void AddCart_Click(object sender, EventArgs e)
        {
            int quantity = (int)Quantity.Value;
            StudentServices.StudentServiceSoapClient studentServices= new StudentServices.StudentServiceSoapClient();
            studentServices.AddToCart(ID,CourseIDSelected,quantity);
            MessageBox.Show("Added to Cart Succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
