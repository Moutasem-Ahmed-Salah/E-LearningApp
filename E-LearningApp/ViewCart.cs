using E_LearningApp.StudentServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace E_LearningApp
{
    public partial class ViewCart : Form
    {
        int studentID;
        int selectedShoppingCartID;
        

        public ViewCart(int StudentID)
        {
            studentID = StudentID;
            InitializeComponent();
            loadCart();
        }

        private void loadCart()
        {
            StudentServiceSoapClient studentService = new StudentServiceSoapClient();

            try
            {

                DataTable cartData = studentService.ViewCart(studentID);

                dataGridView1.DataSource = cartData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int quantity = (int)Quantity.Value;

           
            if (selectedShoppingCartID > 0)
            {
                StudentServiceSoapClient studentService = new StudentServiceSoapClient();
                MessageBox.Show("Cart Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentService.UpdateCart(selectedShoppingCartID, quantity);

                loadCart();
            }
            else
            {
                MessageBox.Show("Please select a row from the cart.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedShoppingCartID = (int)dataGridView1.SelectedRows[0].Cells["ShoppingCartID"].Value;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedShoppingCartID > 0)
            {
                StudentServiceSoapClient studentService = new StudentServiceSoapClient();
                studentService.DeleteCart(selectedShoppingCartID);
                MessageBox.Show("Item Deleted Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCart();       
            }
            else
            {
                MessageBox.Show("Please select an item from the cart.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
        }

        private void CodBtn_Click(object sender, EventArgs e)
        {
            CODform cod = new CODform(studentID);
            cod.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}

    

