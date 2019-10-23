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
using System.Diagnostics;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            l_password.Hide();
            l_passforget.Hide();
            tb_password.Hide();
            b_adduser.Hide();
            b_polcreate.Hide();
           
            b_enterpwd.Hide();
            b_changepwd.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_admin_Click(object sender, EventArgs e)
        {
            l_passforget.Show();
            l_password.Show();
            tb_password.Show();
            b_enterpwd.Show();
            b_changepwd.Show();
        }

        private void b_enterpwd_Click(object sender, EventArgs e)
        {
            string passwordEntered;
            passwordEntered = tb_password.Text;

            string originalPassword;
            int flag = 0;
            using (StreamReader sr = new StreamReader("C:\\Watchware\\password.txt"))
            {
                originalPassword = sr.ReadLine();
                if(originalPassword == passwordEntered)
                {
                    flag = 1;
                }
                sr.Close();
            }
            if(flag == 1)
            {
                b_adduser.Show();
                b_polcreate.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password! :(");
            }
        }

        private void b_polcreate_Click(object sender, EventArgs e)
        {
           // Process p = new Process();
          //  p.StartInfo.FileName = "C:\\Users\\hp\\Documents\\Visual Studio 2015\\Projects\\policy_creator1\\Debug\\policy_creator1.exe";
            Process.Start("C:\\Watchware\\policy_creator1.exe");
        }

        private void b_adduser_Click(object sender, EventArgs e)
        {
            //Process p = new Process();
          //  p.StartInfo.FileName = "C:\\Users\\hp\\Documents\\Visual Studio 2015\\Projects\\USBForm1\\Debug\\USBForm1.exe";
            Process.Start("C:\\Watchware\\admin_USB.exe");
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';

        }

        private void l_passforget_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_changepwd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Watchware\\Decryption.exe");
        }

        private void l_password_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Watchware\\ProcMon.exe");
        }
    }
}
