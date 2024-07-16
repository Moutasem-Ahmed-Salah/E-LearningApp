namespace E_LearningApp
{
    partial class CourseDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.Label();
            this.CourseDescription = new System.Windows.Forms.Label();
            this.CourseCategory = new System.Windows.Forms.Label();
            this.CoursePrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 48);
            this.label2.TabIndex = 1;
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID.Location = new System.Drawing.Point(101, 135);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(81, 29);
            this.CourseID.TabIndex = 5;
            this.CourseID.Text = "label3";
            // 
            // CourseDescription
            // 
            this.CourseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDescription.Location = new System.Drawing.Point(182, 180);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(228, 43);
            this.CourseDescription.TabIndex = 2;
            this.CourseDescription.Text = "label3";
            // 
            // CourseCategory
            // 
            this.CourseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseCategory.Location = new System.Drawing.Point(101, 225);
            this.CourseCategory.Name = "CourseCategory";
            this.CourseCategory.Size = new System.Drawing.Size(434, 28);
            this.CourseCategory.TabIndex = 3;
            this.CourseCategory.Text = "label4";
            // 
            // CoursePrice
            // 
            this.CoursePrice.AutoSize = true;
            this.CoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursePrice.Location = new System.Drawing.Point(73, 285);
            this.CoursePrice.Name = "CoursePrice";
            this.CoursePrice.Size = new System.Drawing.Size(81, 29);
            this.CoursePrice.TabIndex = 4;
            this.CoursePrice.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price :";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(106, 358);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(120, 22);
            this.Quantity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantity :";
            // 
            // AddCart
            // 
            this.AddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCart.Image = ((System.Drawing.Image)(resources.GetObject("AddCart.Image")));
            this.AddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCart.Location = new System.Drawing.Point(602, 258);
            this.AddCart.Name = "AddCart";
            this.AddCart.Size = new System.Drawing.Size(307, 83);
            this.AddCart.TabIndex = 10;
            this.AddCart.Text = "Add To Cart";
            this.AddCart.UseVisualStyleBackColor = true;
            this.AddCart.Click += new System.EventHandler(this.AddCart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course ID :";
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 635);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.AddCart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoursePrice);
            this.Controls.Add(this.CourseCategory);
            this.Controls.Add(this.CourseDescription);
            this.Controls.Add(this.panel1);
            this.Name = "CourseDetails";
            this.Text = "CourseDetails";
            this.Load += new System.EventHandler(this.CourseDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CourseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CourseDescription;
        private System.Windows.Forms.Label CourseCategory;
        private System.Windows.Forms.Label CoursePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCart;
        private System.Windows.Forms.Label label7;
    }
}