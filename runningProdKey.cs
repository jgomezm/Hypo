using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS_Solution
{
    public partial class runningProdKey : Form
    {
        public void runProdKey(String path)
        {
            //path += "\\Useful Tools for Windows\\produkey";
            //using (Process process = new Process())
            //{
            //    process.StartInfo.WorkingDirectory = path;
            //    process.StartInfo.FileName = "cmd.exe";
            //    //process.StartInfo.Arguments = "ProduKey.exe /stext ProdKey.txt";
            //    process.StartInfo.CreateNoWindow = true;
            //    process.StartInfo.UseShellExecute = false;
            //    process.StartInfo.RedirectStandardOutput = true;
            //    process.StartInfo.RedirectStandardInput = true;
            //    //process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
            //    process.Start();
            //    process.StandardInput.WriteLine("ProduKey.exe /IEKeys 0 /stext ProdKey.txt");
            //    process.BeginOutputReadLine();
            //}
            //String path = Path.GetDirectoryName(Application.ExecutablePath);
            String exeString = "ProduKey.exe";
            String[] pathString = Directory.GetFiles(path, exeString, SearchOption.AllDirectories);
            //int index = pathString[0].IndexOf(exeString);String sourceString
            String sourceString = "";
            try
            {
                sourceString = pathString[0];
            }
            catch(Exception ex)
            {
                this.Close();
            }
            
            int index = sourceString.IndexOf(exeString);
            sourceString = sourceString.Replace("ProduKey.exe", "");
            try
            {
                if (pathString != null)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo.WorkingDirectory = sourceString;
                        process.StartInfo.FileName = "cmd.exe";
                        //process.StartInfo.Arguments = "ProduKey.exe /stext ProdKey.txt";
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardInput = true;
                        //process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
                        process.Start();
                        process.StandardInput.WriteLine("ProduKey.exe /OfficeKeys 0 /SQLKeys 0 /ExchangeKeys 0 /IEKeys 0 /stext ProdKey.txt");
                        process.BeginOutputReadLine();
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show(string.Format("Failed to launch {0} failed to launch | Make sure you are running OneStop from the folder \"Stimpak\". Or that {0} exists.\r\n{1}", exeString, sourceString), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                    MessageBox.Show(string.Format("Failed to launch {0}. Please don't say no...\r\n{1}.", exeString, sourceString), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            } 
        }
        public runningProdKey()
        {
            InitializeComponent();
            String entrypath = Path.GetDirectoryName(Application.ExecutablePath);
            runProdKey(entrypath);
            this.Close();
        }
    }
}
