/*
 * Admin side 
 * Admin enters USB devices - device ID, policy and Username to users database
 * Device ID and Drive Letter are detected when the application is executed 
 * Policy and username have to be entered by the Admin
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace admin_USB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManagementObjectSearcher moSearch = new ManagementObjectSearcher("Select * from Win32_DiskDrive where InterfaceType='USB'");
            try
            {
                foreach (var mo in moSearch.Get())
                {
                 //   mo["GUID"]

                    //tb_devid.Text= mo["DriveLetter"].ToString();
                    tb_devid.Text = mo["PNPDeviceID"].ToString();
                    //Process.Start("C:\\Users\\hp\\Desktop\\watcher.exe");

                }
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        tb_driveletter.Text = drive.RootDirectory.FullName;
                    }
                }
            }
            catch (Exception)
            { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void driveletter_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string user, devid, policy, driveletter;
            user = tb_username.Text;
            devid = tb_devid.Text;
            
            policy = tb_policy.Text;
            driveletter = tb_driveletter.Text;
            string final;
            final = driveletter + "$$" + devid + "$$" + user + "$$" + policy + "$$";

            int flag = 0;
            using (StreamReader sr = new StreamReader("C:\\Watchware\\users.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line)) continue;
                    if (line.IndexOf(devid, StringComparison.CurrentCultureIgnoreCase) < 0)
                    {
                        //Console.WriteLine(line);
                        flag =flag + 1;

                    }
                    else
                    {
                        flag = 0;
                
                    }
                }
                sr.Close();
            }
            if (flag >= 1)
            {
                using (StreamWriter sw = new StreamWriter("C:\\Watchware\\users.txt", true))
                {

                    sw.WriteLine(final);
                    MessageBox.Show("Device Instance Id: " + tb_devid.Text + "is saved in the file.");
                }
            }
            else
            {
                MessageBox.Show("The Device ID is already added in the database");
            }
        }
    }
}
