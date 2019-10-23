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
    public partial class Form3 : Form
    {
        System.IO.StreamReader file = new System.IO.StreamReader("C:\\Watchware\\names.txt");
        int x, len;
        string line;
        string[] arr1;
        string policy;
        public Form3()
        {
            InitializeComponent();
        }

        private void b_search_Click(object sender, EventArgs e)
        {

            tb_edit_desc.Show();
            l_edit_desc.Show();
            arr1 = new string[100];
            policy = tb_search.Text;
            //string line;
            //int flag = 0;
            char[] array = new char[5];


            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(policy))
                {
                    string str = null;
                    int i;
                    //int k = 0;
                    x = line.IndexOf("*");

                    len = line.Length;
                    int substrlen = len - x;
                    for (i = x; i < len; i++)
                    {
                        str += line[i];

                    }
                    //string karr = array.ToString();
                    arr1 = str.Split('*');
                    break;
                }
                
            }



            using (StreamWriter sw = new StreamWriter("C:\\Watchware\\compare.txt", true))
            {

                foreach (string q in arr1)
                {
                    sw.WriteLine(q);
                    if (q == "1")
                    {
                        cledit_images.SetItemChecked(0, true);
                    }
                    else if (q == "2")
                    {
                        cledit_images.SetItemChecked(1, true);
                    }
                    else if (q == "3")
                    {
                        cledit_images.SetItemChecked(2, true);
                    }
                    else if (q == "4")
                    {
                        cledit_images.SetItemChecked(3, true);
                    }
                    else if (q == "5")
                    {
                        cledit_office.SetItemChecked(0, true);
                    }
                    else if (q == "6")
                    {
                        cledit_office.SetItemChecked(1, true);
                    }
                    else if (q == "7")
                    {
                        cledit_office.SetItemChecked(2, true);
                    }
                    else if (q == "8")
                    {
                        cledit_av.SetItemChecked(0, true);
                    }
                    else if (q == "9")
                    {
                        cledit_av.SetItemChecked(1, true);
                    }
                    else if (q == "10")
                    {
                        cledit_av.SetItemChecked(2, true);
                    }
                }
            }

            file.Close();
         
        }

        private void png_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tb_edit_desc.Hide();
            l_edit_desc.Hide();
        }

        private void cledit_office_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string s1 = null;
            string s2 = null;
            string s3 = null;
            policy = tb_search.Text;
            string line_to_delete = null;
            int i;

            using (StreamReader reader = new StreamReader("C:\\Watchware\\names.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(policy))
                    {
                        line_to_delete = line;
                        break;

                    }
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
                
            //string dest = "C:\\Users\\hp\\Desktop\\names.txt";
            //string source = "C:\\Users\\hp\\Desktop\\output.txt";
            if (File.Exists(@"C:\\Watchware\\names.txt"))
            {
                File.Delete(@"C:\\Watchware\\names.txt");
            }
            
            System.IO.File.Move(@"C:\\Watchware\\output.txt", @"C:\\Watchware\\names.txt");

            

                for (i = 0; i < cledit_images.Items.Count; i++)
            {
                if (cledit_images.GetItemChecked(i))
                {

                    s1 = s1 + "*" + (i + 1).ToString();
                }
            }
            for (i = 0; i < cledit_office.Items.Count; i++)
            {
                if (cledit_office.GetItemChecked(i))
                {

                    s2 = s2 + "*" + (i + 5).ToString();
                }
            }
            for (i = 0; i < cledit_av.Items.Count; i++)
            {
                if (cledit_av.GetItemChecked(i))
                {

                    s3 = s3 + "*" + (i + 8).ToString();
                }
            }

            string pname, pdesc, final;
            pname = tb_search.Text;
            pdesc = tb_edit_desc.Text;
            final = pname + "$$" + pdesc + "$$" + s1 + s2 + s3;
            using (StreamWriter sw = new StreamWriter("C:\\Watchware\\names.txt", true))
            {
                sw.WriteLine(final);
            }
            MessageBox.Show("Name:" + pname + Environment.NewLine + "Description:" + pdesc + Environment.NewLine + "Is Saved");
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }     
        }
    }

  

