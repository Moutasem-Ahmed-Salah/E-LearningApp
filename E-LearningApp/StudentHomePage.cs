using System;
using System.Data;
using System.Windows.Forms;
using E_LearningApp.StudentServices;

namespace E_LearningApp
{
    public partial class StudentHomePage : Form
    {
        int ID;
        public string selectedCourseName;
        public StudentHomePage(int studentID)
        {
            ID= studentID;
            InitializeComponent();

            // Call the ViewCourses web method when the form loads
            LoadCourses();
        }

        private void LoadCourses()
        {
           
            StudentServiceSoapClient studentService = new StudentServiceSoapClient();

            try
            {
                
                DataTable coursesData = studentService.ViewCourses();

                dataGridView1.DataSource = coursesData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                selectedCourseName = dataGridView1.SelectedRows[0].Cells["CourseName"].Value.ToString();

               
                CourseDetails courseDetailsForm = new CourseDetails(selectedCourseName, ID);
                courseDetailsForm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCart viewCart = new ViewCart(ID);
            viewCart.ShowDialog();
            
        }
    }

      
    }

