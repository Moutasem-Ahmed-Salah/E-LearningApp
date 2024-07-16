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
    public partial class StudentSignIn : Form
    {
        public int studentID;
        public StudentSignIn()
        {
            InitializeComponent();
        }

        private void StudentSignIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            StudentServices.StudentServiceSoapClient StudentService = new StudentServices.StudentServiceSoapClient();
            String username=usrTxt.Text;
            String password=pwdTXT.Text;
            Boolean SignedIn = StudentService.StudentSign(username, password);
            if (SignedIn)
            {
                studentID = GetStudentID(username, password);
                MessageBox.Show("Signed In Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentHomePage studentHomePage = new StudentHomePage(studentID);
                studentHomePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetStudentID(string username, string password)
        {
            int studentID = 0;
            string connectionString = "Data Source=MO3TA-LAPTOP;Initial Catalog=E-learning;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a SqlCommand to retrieve the student ID based on the entered username and password
                string query = "SELECT ID FROM Students WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the command and retrieve the student ID
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        studentID = Convert.ToInt32(result);
                    }
                }
            }

            return studentID;
        }

    }
}
