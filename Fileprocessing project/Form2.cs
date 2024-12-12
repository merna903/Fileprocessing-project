using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fileprocessing_project
{
    public partial class Sign_up : Form
    {
        FileStream myfile;
        StreamReader sr;
        StreamWriter sw;
        string Filename = "log_c.txt";
        public Sign_up()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); // Manually attach the Load event
            this.Load += new EventHandler(Form2_Load); // Manually attach the Load event

            password.PasswordChar = '*';
            con_password.PasswordChar = '*';
            myfile = new FileStream(Filename, FileMode.Open, FileAccess.ReadWrite);
            sr = new StreamReader(myfile);
            sw = new StreamWriter(myfile);

        }
        

        
        private void email_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code goes here
            // For example, setting hint text and properties for the Email TextBox
            email.Tag = "Enter your email";
            email.Text = email.Tag.ToString();
            email.ForeColor = Color.LightGray;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialization code goes here
            // For example, setting hint text and properties for the Email TextBox
            Username.Tag = "Enter your username";
            Username.Text = Username.Tag.ToString();
            Username.ForeColor = Color.LightGray;
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            bool testnull = false;
            
            if (email.Text.TrimStart() == string.Empty)
                    MessageBox.Show("Plesea Enter your email", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Username.Text.TrimStart() == string.Empty)
                    MessageBox.Show("Plesea Enter your username", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (phonenum.Text.TrimStart() == string.Empty)
                    MessageBox.Show("Plesea Enter your phone number", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (password.Text.TrimStart() == string.Empty && con_password.Text.TrimStart() == String.Empty)
                    MessageBox.Show("Plesea Enter your password", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if ((radioButton1.Checked) == false)
                    MessageBox.Show("you must accept for terms and conitions", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           else
                testnull = true;
            bool testuser = true;
            bool testconpass = false;
            bool passwordvaild = false;
            
            if (testnull == true)
            {
                string line;
                string[] field;
                string user = Username.Text;
                
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine("writtttttttttteeeeeeeeee");
                    field = line.Split(',');
                    if (field.Length > 2 && user == field[2])
                    {
                        MessageBox.Show("A user with that username already exists", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        testuser = false;
                        Username.Text = null;
                        break;

                    }
                }
                
                string pass = password.Text;

                if (pass.Length < 8)
                    passwordvaild = false;

                bool hasUppercase = false;
                bool hasLowercase = false;
                bool hasNumber = false;
                bool hasSpecialChar = false;

                for (int i = 0; i < pass.Length; i++)
                {
                    char c = pass[i];

                    if (char.IsUpper(c))
                        hasUppercase = true;
                    else if (char.IsLower(c))
                        hasLowercase = true;
                    else if (char.IsDigit(c))
                        hasNumber = true;
                    else if (!char.IsLetterOrDigit(c))
                        hasSpecialChar = true;
                }
                if (hasUppercase && hasLowercase && hasNumber && hasSpecialChar)
                    passwordvaild = true;
                else
                    passwordvaild = false;

                if (!passwordvaild)
                    MessageBox.Show("password is not vaild", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                

                if (password.Text != con_password.Text)
                    MessageBox.Show("not correct password", "Invaild input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    testconpass = true;
            }

            if (passwordvaild && testuser && testconpass)
            {
                int balance =0 ;
                int IPN = 0;
                int count = 0;

                    string record = $"{count},{email.Text},{Username.Text},{phonenum.Text},{password.Text},{balance},{IPN}";
                    sw.WriteLine(record); 
                    sw.Flush();
                FileStream file_user = new FileStream ("file_user.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(file_user);
                string search = Username.Text;
                streamWriter.WriteLine(search);
                streamWriter.Flush();
                streamWriter.Close();
                sr.Close();
                myfile.Close();
                new Ipn_con().Show();
                this.Hide();
            }


        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            sr.Close();
            myfile.Close();
            Application.Exit();
        }

        private void log_back_Click_1(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            bool passwordvaild = false;
            string pass = password.Text;

            if (pass.Length < 8)
                passwordvaild = false;

            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasNumber = false;
            bool hasSpecialChar = false;

            for (int i = 0; i < pass.Length; i++)
            {
                char c = pass[i];

                if (char.IsUpper(c))
                    hasUppercase = true;
                else if (char.IsLower(c))
                    hasLowercase = true;
                else if (char.IsDigit(c))
                    hasNumber = true;
                else if (!char.IsLetterOrDigit(c))
                    hasSpecialChar = true;
            }
            if (hasUppercase && hasLowercase && hasNumber && hasSpecialChar)
                passwordvaild = true;
            else
                passwordvaild = false;

            if (passwordvaild == true)
                label7.ForeColor = Color.Green;
            else
                label7.ForeColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_Enter(object sender, EventArgs e)
        {
            TextBox email = sender as TextBox; // Get the TextBox that triggered the event
            if (email.Text == email.Tag.ToString()) // Check if the text matches the hint
            {
                email.Text = ""; // Clear the hint text
                email.ForeColor = Color.Black; // Change the text color to black for user input
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            TextBox email = sender as TextBox; // Get the TextBox that triggered the event
            if (string.IsNullOrWhiteSpace(email.Text)) // Check if the TextBox is empty
            {
                email.Text = email.Tag.ToString(); // Restore the hint text
                email.ForeColor = Color.LightGray; // Set the text color back to gray
            }
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            TextBox username = sender as TextBox; // Get the TextBox that triggered the event
            if (username.Text == username.Tag.ToString()) // Check if the text matches the hint
            {
                username.Text = ""; // Clear the hint text
                username.ForeColor = Color.Black; // Change the text color to black for user input
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            TextBox email = sender as TextBox; // Get the TextBox that triggered the event
            if (string.IsNullOrWhiteSpace(email.Text)) // Check if the TextBox is empty
            {
                email.Text = email.Tag.ToString(); // Restore the hint text
                email.ForeColor = Color.LightGray; // Set the text color back to gray
            }

        }

        private void phonenum_Enter(object sender, EventArgs e)
        {

        }
    }
}
