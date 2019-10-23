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

namespace Decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Decrypt_Click(object sender, EventArgs e)
        {
            string filename = " ";
            filename = tb_filename.Text;
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Watchware\\decry.exe";
            p.StartInfo.Arguments = filename;
            p.Start();
        }
    }
}
