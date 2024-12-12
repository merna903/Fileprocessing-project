namespace Fileprocessing_project
{
    partial class Sign_up
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.con_password = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.log_back = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 74);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(536, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 20);
            this.exit.TabIndex = 1;
            this.exit.Text = "✖";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(146, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(148, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(148, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(148, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.LightGray;
            this.email.Location = new System.Drawing.Point(146, 102);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(265, 30);
            this.email.TabIndex = 5;
            this.email.Tag = "enter your email ";
            this.email.Text = "enter your email ";
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.LightGray;
            this.Username.Location = new System.Drawing.Point(146, 177);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(265, 30);
            this.Username.TabIndex = 6;
            this.Username.Tag = "enter your username";
            this.Username.Text = "enter your username";
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.password.Location = new System.Drawing.Point(148, 322);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(265, 30);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // con_password
            // 
            this.con_password.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.con_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.con_password.Location = new System.Drawing.Point(148, 456);
            this.con_password.Name = "con_password";
            this.con_password.Size = new System.Drawing.Size(263, 30);
            this.con_password.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(156, 515);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(246, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "accept the Terms and Conditions";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(146, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // phonenum
            // 
            this.phonenum.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phonenum.ForeColor = System.Drawing.Color.LightGray;
            this.phonenum.Location = new System.Drawing.Point(146, 252);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(263, 30);
            this.phonenum.TabIndex = 11;
            this.phonenum.Tag = "enter your phone number";
            this.phonenum.Text = "enter your phone number";
            this.phonenum.Enter += new System.EventHandler(this.phonenum_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(148, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 57);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password must be at least 8 characters long and \r\ninclude an uppercase letter, a " +
    "lowercase letter,\r\n a number, and a special character.";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.register.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(148, 558);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(265, 43);
            this.register.TabIndex = 13;
            this.register.Text = "REGISTER";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 615);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Have an account?";
            // 
            // log_back
            // 
            this.log_back.AutoSize = true;
            this.log_back.ForeColor = System.Drawing.SystemColors.Highlight;
            this.log_back.Location = new System.Drawing.Point(311, 615);
            this.log_back.Name = "log_back";
            this.log_back.Size = new System.Drawing.Size(50, 20);
            this.log_back.TabIndex = 15;
            this.log_back.Text = "Log in";
            this.log_back.Click += new System.EventHandler(this.log_back_Click_1);
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 663);
            this.Controls.Add(this.log_back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.con_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 100);
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label exit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox email;
        private TextBox Username;
        private TextBox password;
        private TextBox con_password;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox phonenum;
        private Label label7;
        private Button register;
        private Label label8;
        private Label log_back;
    }
}