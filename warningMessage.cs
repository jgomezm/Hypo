using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Hypo.Properties;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms.Layout;
using System.Xml;

namespace Hypo
{
    public partial class warningMessage : Form
    {
        
        public void messageBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void runProgramButton(object sender, String exeString)
        {
           

            //-------------Searches for the executable in the execution directory. Should be Stimpak.
            String path = Path.GetDirectoryName(Application.ExecutablePath);
            String[] pathString = Directory.GetFiles(path, exeString, SearchOption.AllDirectories);
            //label24.Text = pathString[0];
            try
            {
                if (System.IO.File.Exists(string.Format("{0}", pathString[0])))
                {
                    Process.Start(pathString[0]);
                }
                else
                {
                    int num = (int)MessageBox.Show(string.Format("Failed to launch {0} failed to launch | Make sure you are running OneStop from the folder \"Stimpak\". Or that {0} exists.", exeString), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            //If the program doesn't exist there it will throw a IndexOutOfBounds error. This catch mitigates that error.
            catch (Exception ex)
            {
                //label24.Text = ex.ToString();
                if (ex.ToString().Contains("IndexOutOfRangeException"))
                {
                    MessageBox.Show(string.Format("Could not find {0}. Make sure it exists and Hypo is running inside Stimpak.", exeString), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to launch {0}. Please don't say no...", exeString), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        public warningMessage()
        {
            
            this.InitializeComponent();
            this.Text = "Warning!";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            //this.StartPosition = System.Windows.Forms.FormStartPosition.
            this.ResumeLayout(false);
            this.PerformLayout();
            this.label1.Text = "Revo uninstaller may have problems uninstalling \r\nprograms. Use with caution.";
        }

        private void warningMessage_Load(object sender, EventArgs e)
        {
            //this.initializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String exeString = "Revouninstaller.exe";
            this.runProgramButton(sender, exeString);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Why. \r\nWhy is clicking a label a thing?", "Wow", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        
    }
}
