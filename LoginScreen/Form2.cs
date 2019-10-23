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

namespace LoginScreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpass = null;
            string newpass = null;
            string connewpass = null;
            oldpass=tb_oldpass.Text;
            string originalPassword = null;
            int flag=0;
            using (StreamReader sr = new StreamReader("C:\\Watchware\\password.txt"))
            {
                originalPassword = sr.ReadLine();
                if (originalPassword == oldpass)
                {
                    flag = 1;
                }
                sr.Close();
            }
            if(flag==1)
            {
                newpass = tb_newpass.Text;
                connewpass = tb_connewpass.Text;
                if(newpass==connewpass)
                {
                    using (StreamWriter sw = new StreamWriter("C:\\Watchware\\password.txt"))
                    {
                        sw.WriteLine(newpass);
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password"+Environment.NewLine+"Try Again");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void tb_oldpass_TextChanged(object sender, EventArgs e)
        {
            tb_oldpass.PasswordChar = '*';
        }

        private void tb_newpass_TextChanged(object sender, EventArgs e)
        {
            tb_newpass.PasswordChar = '*';
        }

        private void tb_connewpass_TextChanged(object sender, EventArgs e)
        {
            tb_connewpass.PasswordChar = '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
