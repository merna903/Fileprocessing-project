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
    public partial class Ipn_con : Form
    {
        FileStream myfile;
        StreamWriter sw;
        StreamReader sr;
        public Ipn_con()
        {
            InitializeComponent();
           
        }
      


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            {
                var search = File.ReadAllLines("file_user.txt").ToList();
                var lines = File.ReadAllLines("log_c.txt").ToList();
                string ipn = Ipn.Text;

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] line = lines[i].Split(',');


                    if (line.Length > 6 && search.Count > 0 && line[2] == search[0])
                    {
                        int count = lines.Count;
                        line[0]= count.ToString();
                        line[6] = ipn;
                        lines[i] = String.Join(',', line);
                        File.WriteAllLines("log_c.txt", lines);
                       
                        Console.WriteLine("Content added successfully.");
                        break;
                    }
                }
                MessageBox.Show("done");
            }
        }

            private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
