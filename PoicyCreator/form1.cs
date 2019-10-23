/*
 * Admin Side
 * Admin selects the file types which are allowed per policy
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace policy_creator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            //checkedListBox1.Hide();
            string line;
            int x;
            
            string str="";
            using (StreamReader reader = new StreamReader("C:\\Watchware\\names.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {try
                    {
                        str = null;
                        x = line.IndexOf("$");
                        for (int i = 0; i < x; i++)
                        {
                            str += line[i];
                        }
                        listBox1.Items.Add(str);
                    }
                    catch(Exception e)
                    { }

                }
                reader.Close();
            }

        }

        private void pc_add_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();   
            frm2.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pc_edit_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void pc_del_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
