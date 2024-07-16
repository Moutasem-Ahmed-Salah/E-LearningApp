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
using System.Net;
using System.Diagnostics;

namespace E_LearningApp
{
    public partial class CODform : Form
    {
        int ID;
        int total = 0;
        public CODform(int StudentID)
        {
            ID = StudentID;
            InitializeComponent();
            DisplayStudentDetails(ID);
            LoadReceipt();
        }


        public void LoadReceipt()
        {
            StudentServices.StudentServiceSoapClient studentService = new StudentServices.StudentServiceSoapClient();
            try
            {
                DataTable ReceiptData = studentService.GetTotal(ID);

                
                if (ReceiptData.Rows.Count == 0)
                {
                    
                    dataGridView1.Visible = false;

                    
                    NoOrdersLabel.Visible = true;
                }
                else
                {
                   
                    dataGridView1.Visible = true;

                    
                    NoOrdersLabel.Visible = false;

                   
                    dataGridView1.DataSource = ReceiptData;

                   
                    
                    foreach (DataRow row in ReceiptData.Rows)
                    {
                        total += Convert.ToInt32(row["SubTotal"]);
                    }
                    Total.Text = total.ToString() + "$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayStudentDetails(int studentID)
        {
            string connectionString = "Data Source=MO3TA-LAPTOP;Initial Catalog=E-learning;Integrated Security=True";


            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Name, MobileNumber, Area ,Address FROM Students WHERE ID = @StudentID;
";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                StudentName.Text = reader["Name"].ToString();
                                PhoneNumber.Text = reader["MobileNumber"].ToString();
                                Address.Text = reader["Area"].ToString() +" "+ reader["Address"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred while fetching student details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentServices.StudentServiceSoapClient studentService = new StudentServices.StudentServiceSoapClient();
            studentService.ConfirmOrder(ID,total);
            MessageBox.Show("Order Is Complete! An email was sent to you confirming your order", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadReceipt();
        }

        private void CreditBtn_Click(object sender, EventArgs e)
        {
            string htmlPageUrl = @"C:\Users\mo3ta\OneDrive\Desktop\Reusable-Project\E-LearningApp\E-LearningApp\HTMLPage1.html";          
            Process.Start(htmlPageUrl);

        }
    }
}
