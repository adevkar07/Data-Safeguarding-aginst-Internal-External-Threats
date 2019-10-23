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
using System.Management;

namespace policy_creator1
{

    public partial class Form2 : Form
    {
        string s1 = null;
        string s2 = null;
        string s3 = null;
        int i;
        public Form2()
        {
            InitializeComponent();
            cl_av.Hide();
            cl_images.Hide();
            cl_office.Hide();
        }

        

        private void rb_image_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_image.Checked == true)
            {
                cl_images.Show();
            }
        }

        private void rb_office_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_office.Checked == true)
            {
                cl_office.Show();
            }
        }

        private void rb_av_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_av.Checked == true)
            {
                cl_av.Show();
            }

        }

        private void cl_images_SelectedIndexChanged(object sender, EventArgs e)
        {

            
         
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cl_office_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < cl_images.Items.Count; i++)
            {
                if (cl_images.GetItemChecked(i))
                {

                    s1 = s1 + "*" + (i + 1).ToString();
                }
            }
            for (i = 0; i < cl_office.Items.Count; i++)
            {
                if (cl_office.GetItemChecked(i))
                {

                    s2 = s2 + "*" + (i + 4).ToString();
                }
            }
            for (i = 0; i < cl_av.Items.Count; i++)
            {
                if (cl_av.GetItemChecked(i))
                {

                    s3 = s3 + "*" + (i + 8).ToString();
                }
            }

            string pname, pdesc, final;
            pname = tb_namepol.Text;
            pdesc = tb_desc_pol.Text;
            final = pname + "$$" + pdesc + "$$"  + s1 + s2 + s3;
            using (StreamWriter sw = new StreamWriter("C:\\Watchware\\names.txt", true))
            {
                sw.WriteLine(final);
            }
            MessageBox.Show("Name:" + pname + Environment.NewLine + "Description:" + pdesc  + Environment.NewLine + "Is Saved");
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
             
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cl_av_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}