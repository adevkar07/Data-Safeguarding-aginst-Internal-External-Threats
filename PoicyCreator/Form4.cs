using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace policy_creator1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void b4_del_Click(object sender, EventArgs e)
        {
            string policy, line;
            policy = tb_del.Text;
            string line_to_delete = null;
            int flag = 0;
            using (StreamReader reader = new StreamReader("C:\\Watchware\\names.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(policy))
                    {
                        flag = 1;
                        line_to_delete = line;
                        break;

                    }
                    
                }
                if(flag!=1)
                {
                    MessageBox.Show(policy + " does not exist.");
                }
            }
            using (StreamReader reader = new StreamReader("C:\\Watchware\\names.txt"))
            {

                using (StreamWriter writer = new StreamWriter("C:\\Watchware\\output.txt"))
                {

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, line_to_delete) == 0)
                            continue;
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                reader.Close();

            }

            
            if (File.Exists(@"C:\\Watchware\\names.txt"))
            {
                File.Delete(@"C:\\Watchware\\names.txt");
                
            }
            System.IO.File.Move(@"C:\\Watchware\\output.txt", @"C:\\Watchware\\names.txt");
            
            this.Hide();
            Form f1 = new Form1();
            f1.Show();

        }

        private void tb_del_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
    

