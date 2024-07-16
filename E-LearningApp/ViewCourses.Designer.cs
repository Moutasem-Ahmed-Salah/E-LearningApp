namespace E_LearningApp
{
    partial class ViewCourses
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elearningDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._E_learningDataSet = new E_LearningApp._E_learningDataSet();
            this.coursesTableAdapter = new E_LearningApp._E_learningDataSetTableAdapters.CoursesTableAdapter();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseNameTxt = new System.Windows.Forms.TextBox();
            this.CourseDescTxt = new System.Windows.Forms.TextBox();
            this.CoursePriceTxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CourseCategoryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elearningDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_learningDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.courseDescription,
            this.coursePrice,
            this.courseCategory});
            this.dataGridView1.DataSource = this.coursesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.MinimumWidth = 6;
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Width = 125;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 125;
            // 
            // courseDescription
            // 
            this.courseDescription.DataPropertyName = "CourseDescription";
            this.courseDescription.HeaderText = "CourseDescription";
            this.courseDescription.MinimumWidth = 6;
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.ReadOnly = true;
            this.courseDescription.Width = 125;
            // 
            // coursePrice
            // 
            this.coursePrice.DataPropertyName = "CoursePrice";
            this.coursePrice.HeaderText = "CoursePrice";
            this.coursePrice.MinimumWidth = 6;
            this.coursePrice.Name = "coursePrice";
            this.coursePrice.ReadOnly = true;
            this.coursePrice.Width = 125;
            // 
            // courseCategory
            // 
            this.courseCategory.DataPropertyName = "CourseCategory";
            this.courseCategory.HeaderText = "CourseCategory";
            this.courseCategory.MinimumWidth = 6;
            this.courseCategory.Name = "courseCategory";
            this.courseCategory.ReadOnly = true;
            this.courseCategory.Width = 125;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.elearningDataSetBindingSource;
            // 
            // elearningDataSetBindingSource
            // 
            this.elearningDataSetBindingSource.DataSource = this._E_learningDataSet;
            this.elearningDataSetBindingSource.Position = 0;
            // 
            // _E_learningDataSet
            // 
            this._E_learningDataSet.DataSetName = "_E_learningDataSet";
            this._E_learningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(736, 73);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(107, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course Price";
            // 
            // CourseNameTxt
            // 
            this.CourseNameTxt.Location = new System.Drawing.Point(108, 338);
            this.CourseNameTxt.Name = "CourseNameTxt";
            this.CourseNameTxt.Size = new System.Drawing.Size(100, 22);
            this.CourseNameTxt.TabIndex = 5;
            // 
            // CourseDescTxt
            // 
            this.CourseDescTxt.Location = new System.Drawing.Point(136, 383);
            this.CourseDescTxt.Multiline = true;
            this.CourseDescTxt.Name = "CourseDescTxt";
            this.CourseDescTxt.Size = new System.Drawing.Size(317, 22);
            this.CourseDescTxt.TabIndex = 6;
            // 
            // CoursePriceTxt
            // 
            this.CoursePriceTxt.Location = new System.Drawing.Point(108, 424);
            this.CoursePriceTxt.Name = "CoursePriceTxt";
            this.CoursePriceTxt.Size = new System.Drawing.Size(100, 22);
            this.CoursePriceTxt.TabIndex = 7;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(15, 505);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(97, 23);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CourseCategoryTxt
            // 
            this.CourseCategoryTxt.Location = new System.Drawing.Point(123, 467);
            this.CourseCategoryTxt.Name = "CourseCategoryTxt";
            this.CourseCategoryTxt.Size = new System.Drawing.Size(100, 22);
            this.CourseCategoryTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Category";
            // 
            // ViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 575);
            this.Controls.Add(this.CourseCategoryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CoursePriceTxt);
            this.Controls.Add(this.CourseDescTxt);
            this.Controls.Add(this.CourseNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewCourses";
            this.Text = "View Courses";
            this.Load += new System.EventHandler(this.ViewCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elearningDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_learningDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource elearningDataSetBindingSource;
        private _E_learningDataSet _E_learningDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private _E_learningDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseNameTxt;
        private System.Windows.Forms.TextBox CourseDescTxt;
        private System.Windows.Forms.TextBox CoursePriceTxt;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox CourseCategoryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCategory;
    }
}