namespace E_LearningApp
{
    partial class StudentSignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.usrTxt = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.pwdTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usrTxt
            // 
            this.usrTxt.Location = new System.Drawing.Point(331, 138);
            this.usrTxt.Name = "usrTxt";
            this.usrTxt.Size = new System.Drawing.Size(158, 22);
            this.usrTxt.TabIndex = 1;
            this.usrTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(317, 248);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign in";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // pwdTXT
            // 
            this.pwdTXT.Location = new System.Drawing.Point(331, 180);
            this.pwdTXT.Name = "pwdTXT";
            this.pwdTXT.PasswordChar = '*';
            this.pwdTXT.Size = new System.Drawing.Size(158, 22);
            this.pwdTXT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // StudentSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 463);
            this.Controls.Add(this.pwdTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.usrTxt);
            this.Controls.Add(this.label1);
            this.Name = "StudentSignIn";
            this.Text = "StudentSignIn";
            this.Load += new System.EventHandler(this.StudentSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrTxt;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.TextBox pwdTXT;
        private System.Windows.Forms.Label label2;
    }
}