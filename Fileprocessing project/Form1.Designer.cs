namespace Fileprocessing_project
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.log_in = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sign_up = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.useroremail = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fileprocessing_project.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(144, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(125, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(80, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 4;
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.SystemColors.Highlight;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log_in.ForeColor = System.Drawing.Color.White;
            this.log_in.Location = new System.Drawing.Point(80, 386);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(236, 37);
            this.log_in.TabIndex = 6;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Don\'t have an account? ";
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.BackColor = System.Drawing.Color.White;
            this.sign_up.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sign_up.Location = new System.Drawing.Point(247, 437);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(59, 20);
            this.sign_up.TabIndex = 11;
            this.sign_up.Text = "Sign up";
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(354, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 20);
            this.exit.TabIndex = 12;
            this.exit.Text = "✖";
            this.exit.Click += new System.EventHandler(this.exit_Click_2);
            // 
            // useroremail
            // 
            this.useroremail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.useroremail.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.useroremail.ForeColor = System.Drawing.Color.LightGray;
            this.useroremail.Location = new System.Drawing.Point(113, 239);
            this.useroremail.Name = "useroremail";
            this.useroremail.Size = new System.Drawing.Size(220, 20);
            this.useroremail.TabIndex = 15;
            this.useroremail.Tag = "Enter your emai or user name";
            this.useroremail.Text = "Enter your emai or user name";
            this.useroremail.Enter += new System.EventHandler(this.useroremail_Enter);
            this.useroremail.Leave += new System.EventHandler(this.useroremail_Leave);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.LightGray;
            this.password.Location = new System.Drawing.Point(113, 322);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(214, 20);
            this.password.TabIndex = 16;
            this.password.Tag = "Password";
            this.password.Text = "password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(80, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(80, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fileprocessing_project.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(80, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Fileprocessing_project.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(80, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 493);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.useroremail);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button log_in;
        private Label label4;
        private Label sign_up;
        private Label exit;
        private TextBox useroremail;
        private TextBox password;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}