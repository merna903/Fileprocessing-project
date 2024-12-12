namespace Fileprocessing_project
{
    public partial class login : Form
    {
        FileStream myfile;
        StreamReader myreader;
        public login()
        {
            InitializeComponent();
       //     password.PasswordChar = '*';
            this.Load += new EventHandler(Form1_Load);
        }
       
       

        private void sign_up_Click(object sender, EventArgs e)
        {
            new Sign_up().Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the Tag property for the Password TextBox to store the hint text
            password.Tag = "Password";

            // Set the initial hint text in the TextBox
            password.Text = password.Tag.ToString();

            // Set the color of the hint text to light gray
            password.ForeColor = Color.Gray;

            // Set password masking off so the hint text is visible initially
            password.PasswordChar = '\0'; // No password masking (hint visible)
        }


        private void exit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_in_Click_1(object sender, EventArgs e)
        {
            bool loginScussed = false;
            myfile = new FileStream("log_c.txt", FileMode.Open, FileAccess.Read);
            myreader = new StreamReader(myfile);
            string line;
            string[] field;
            string user = useroremail.Text;
            string pass = password.Text;
            while ((line = myreader.ReadLine()) != null)
            {
                field = line.Split(',');
                if ((user == field[1] || user == field[2]) && pass == field[4])
                {
                    myfile.Close();
                    myreader.Close();
                    new Form3().Show();
                    this.Hide();
                    loginScussed = true;
                    break;

                }
            }

            if (!loginScussed)
            {
                myfile = new FileStream("employee.txt", FileMode.Open, FileAccess.Read);
                myreader = new StreamReader(myfile);
                while ((line = myreader.ReadLine()) != null)
                {
                    field = line.Split(',');
                    if ((user == field[0] || user == field[1]) && pass == field[2])
                    {
                        myfile.Close();
                        myreader.Close();
                        new emp_form().Show();
                        loginScussed = true;
                        this.Hide();
                        break;
                    }

                }
            }

            if (!loginScussed)
            {
                MessageBox.Show("not login");
            }
        }

        private void useroremail_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Get the TextBox that triggered the event
            if (textBox.Text == textBox.Tag.ToString()) // Check if the text matches the hint
            {
                textBox.Text = ""; // Clear the hint text
                textBox.ForeColor = Color.Black; // Change the text color to black for user input
            }
        }

        private void useroremail_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Get the TextBox that triggered the event
            if (string.IsNullOrWhiteSpace(textBox.Text)) // Check if the TextBox is empty
            {
                textBox.Text = textBox.Tag.ToString(); // Restore the hint text
                textBox.ForeColor = Color.Gray; // Set the text color back to gray
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag.ToString()) // Check if the text matches the hint
            {
                textBox.Text = ""; // Clear the hint text
                textBox.ForeColor = Color.Black; // Change the text color to black for user input
                textBox.PasswordChar = '*'; // Ensure password is hidden
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag.ToString()) // Check if the text matches the hint
            {
                textBox.Text = ""; // Clear the hint text
                textBox.ForeColor = Color.Black; // Change the text color to black for user input
                textBox.PasswordChar = '*'; // Ensure password is hidden
            }
        }
    }
}