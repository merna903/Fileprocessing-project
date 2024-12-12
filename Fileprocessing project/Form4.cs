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
    public partial class emp_form : Form
    {
        FileStream myfile;
        StreamReader sr;
        public emp_form()
        {
            InitializeComponent();
            myfile = new FileStream("log_c.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(myfile);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            string record = sr.ReadLine();
            string[] field;
            
            if (record != null)
            {
                
                field = record.Split(',');
                Acc_id.Text = field[0];
                username.Text = field[2];
                phonenum.Text = field[3];
                balance.Text = field[5];
            }
            else
            {
                MessageBox.Show("No more record");
                Acc_id.Text = username.Text = phonenum.Text = balance.Text = null;

            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            int accnom = int.Parse(Acc_id.Text);
            string line;
            string[] field;
            myfile.Seek(0, SeekOrigin.Begin);
            while ((line = sr.ReadLine()) != null)
            {
                field = line.Split(',');
                if (int.Parse(field[0]) == accnom)
                {
                    username.Text = field[2];
                    phonenum.Text = field[3];
                    balance.Text = field[5];
                    MessageBox.Show("Found");
                    return;
                }
            }
            MessageBox.Show("Not found");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            sr.Close();
            myfile.Close();
            Application.Exit();
        }
    }
}
            