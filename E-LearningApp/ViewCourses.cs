using E_LearningApp.AdminServices;
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
    public partial class ViewCourses : Form
    {
        public ViewCourses()
        {
            InitializeComponent();
            LoadCourses();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void ViewCourses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_learningDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this._E_learningDataSet.Courses);
            // TODO: This line of code loads data into the '_E_learningDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this._E_learningDataSet.Courses);

        }
        private void LoadCourses()
        {
            try
            {
                
                AdminService1Client adminService = new AdminService1Client();

                
                Course[] courses = adminService.ViewCourses();

                
                foreach (Course course in courses)
                {
                    dataGridView1.Rows.Add(course.CourseID, course.CourseName, course.CourseDescription, course.CoursePrice, course.CourseCategory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                
                CourseNameTxt.Text = selectedRow.Cells["CourseName"].Value.ToString();
                CourseDescTxt.Text = selectedRow.Cells["CourseDescription"].Value.ToString();
                CoursePriceTxt.Text = selectedRow.Cells["CoursePrice"].Value.ToString();
                CourseCategoryTxt.Text = selectedRow.Cells["CourseCategory"].Value.ToString();
            }
        }



        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);

                string courseName = CourseNameTxt.Text;
                string courseDescription = CourseDescTxt.Text;
                int coursePrice = Convert.ToInt32(CoursePriceTxt.Text);
                string courseCategory = CourseCategoryTxt.Text;

                AdminService1Client adminService = new AdminService1Client();

                adminService.EditCourse(courseId, courseName, courseDescription, coursePrice, courseCategory);

                dataGridView1.SelectedRows[0].Cells["CourseName"].Value = courseName;
                dataGridView1.SelectedRows[0].Cells["CourseDescription"].Value = courseDescription;
                dataGridView1.SelectedRows[0].Cells["CoursePrice"].Value = coursePrice;
                dataGridView1.SelectedRows[0].Cells["CourseCategory"].Value = courseCategory;

                MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {             
                int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);
                AdminService1Client adminService = new AdminService1Client();
                adminService.DeleteCourse(courseId);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

