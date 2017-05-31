
using Microsoft.Win32;
using Hypo.Properties;
using STS_Solution;
using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using System.Text;
//using System.Management.Automation;
using System.Collections.ObjectModel;
//using InternetZoneManager;

namespace Hypo
{
  public class hypo : Form
  {
    //private static readonly ILog Logger = LogManager.GetLogger(typeof(ButtonLogger));
    //private static readonly ILog Logger = LogManager.GetLogger(typeof(ButtonLogger));
    private int num = 0;
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private FolderBrowserDialog folderBrowserDialog1;
    private ToolTip toolTip1;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem tronScriptToolStripMenuItem;
    private ToolStripMenuItem staticExtasyToolStripMenuItem;
    private ToolStripMenuItem quitToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem aboutToolStripMenuItem1;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private ToolStripMenuItem timerToolStripMenuItem;
    private ToolStripMenuItem progressCheckListToolStripMenuItem;
    private ToolStripMenuItem donateToolStripMenuItem;
    private ToolStripMenuItem bitcoinToolStripMenuItem;
    private ToolStripMenuItem paypalToolStripMenuItem;
    private FlowLayoutPanel flowLayourPanel4;
    private Button messageBox;
    private ToolStripMenuItem disclaimerToolStripMenuItem;
    //private Form m;
    //private static int lineCount = 0;
    private static StringBuilder output = new StringBuilder();
    //private var valueNames;
    private bool requestInput = false;
    private string LogFileName;
    private bool HostsFileLogged = false;
    private long BytesSent = 0;
    private long BytesReceived = 0;
    //private long BytesSentTotal = 0;
    private TabPage tabPage7;
    private Button button43;
    private Button button42;
    private ListView listView1;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private TabPage usefulToolsTab;
    private Button button45;
    private Button button41;
    private Button button40;
    private Button button39;
    private Button button38;
    private Button revoButton;
    private Button bluescreenButton;
    private TabPage tabPage4;
    private Button button53;
    private Button button36;
    private Button button37;
    private Label labelWarning;
    private Button buttonViewHosts;
    private Label labelNetworkStats;
    private Label label26;
    private Button buttonRunAll;
    private CheckBox cbServicesDefault;
    private Button buttonServicesDefault;
    private CheckBox cbResetInternetSecurity;
    private CheckBox cbEnableWireless;
    private CheckBox cbEnableLAN;
    private CheckBox cbClearSSL;
    private CheckBox cbReloadNETBIOS;
    private CheckBox cbClearARP;
    private CheckBox cbFlushDNS;
    private CheckBox cbGoogleDNS;
    private CheckBox cbSetDHCP;
    private CheckBox cbClearHosts;
    private CheckBox cbRenewDHCP;
    private Button buttonResetInternetSecurity;
    private Button buttonEnableWireless;
    private Button buttonEnableLAN;
    private Button buttonClearSSL;
    private Button buttonReloadNETBIOS;
    private Button buttonClearARP;
    private Button buttonFlushDNS;
    private Button buttonGoogleDNS;
    private Button buttonSetDHCP;
    private Button buttonClearHosts;
    private Button buttonRenewDHCP;
    private Button buttonPingDNS;
    private Button buttonPingIP;
    private TextBox textBoxDHCP;
    private TextBox textBoxSubnet;
    private TextBox textBoxDNS;
    private TextBox textBoxDefaultGW;
    private TextBox textBoxMac;
    private TextBox textBoxLocalIP;
    private TextBox textBoxHostname;
    private RichTextBox richTextBoxLogArea;
    private Label label10;
    private Label label13;
    private Button buttonRefresh;
    private Label label14;
    private ComboBox comboBoxAdapters;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label19;
    private Label label20;
    private MenuStrip menuStrip2;
    private ToolStripStatusLabel toolStripStatusLabel;
    private ToolStripProgressBar toolStripProgressBar;
    private TabPage tabPage2;
    private Button button21;
    private ListView lstDisplayHardware;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private FlowLayoutPanel flowLayoutPanel3;
    private Button button31;
    private Button button24;
    private TabPage tabPage3;
    private Button button44;
    private Panel panel3;
    private CheckBox checkBox15;
    private CheckBox checkBox9;
    private CheckBox checkBox14;
    private CheckBox checkBox16;
    private CheckBox checkBox18;
    private CheckBox checkBox11;
    private CheckBox checkBox21;
    private CheckBox checkBox8;
    private CheckBox checkBox7;
    private CheckBox checkBox17;
    private CheckBox checkBox23;
    private CheckBox checkBox5;
    private CheckBox checkBox4;
    private CheckBox checkBox3;
    private CheckBox checkBox20;
    private CheckBox checkBox10;
    private CheckBox checkBox2;
    private CheckBox checkBox12;
    private CheckBox checkBox19;
    private CheckBox checkBox6;
    private CheckBox checkBox13;
    private Button button20;
    private CheckBox checkBox1;
    private CheckBox checkBox22;
    private GroupBox mailGroupBox;
    private Label label21;
    private TextBox mailSubjectBox;
    private Button button19;
    private Label label2;
    private Button button18;
    private Label label1;
    private Button adwButton;
    private Button RogueKiller;
    private Button button26;
    private Button button27;
    private Button button29;
    private TabPage tabPage5;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private GroupBox groupBox2;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button button2;
    private Button button3;
    private Button button1;
    private Button button4;
    private Button button9;
    private Button button10;
    private Button button8;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button25;
    private Button button51;
    private Button button52;
    private TabControl tabControl1;
    private Button button11;
    private Button button33;
    private Button button32;
    private Button button13;
    private ToolStripMenuItem productSitesToolStripMenuItem;
    private ToolStripMenuItem lenovoToolStripMenuItem;
    private ToolStripMenuItem hPToolStripMenuItem;
    private ToolStripMenuItem dellToolStripMenuItem;
    private ToolStripMenuItem aSUSToolStripMenuItem;
    private ToolStripMenuItem mSIToolStripMenuItem;
    private ToolStripMenuItem microsoftToolStripMenuItem;
    private ToolStripMenuItem toshibaToolStripMenuItem;
    private ToolStripMenuItem samsungToolStripMenuItem;
    private ToolStripMenuItem sonyToolStripMenuItem;
    private Button button28;
    private Button button23;
    private Button button22;
    private Button button17;
    private Button button16;
    private Button button15;
    private Button button14;
    private Button button30;
    private FlowLayoutPanel flowLayoutPanel5;
    private Button button34;
    private FlowLayoutPanel flowLayoutPanel6;
    private Label label4;
    private Button button35;
    private Button button46;
    private Button button49;
    private Button button50;
    private Label label6;
    private Label label5;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private Label label8;
    private Label label7;
    private Button button47;
    private Button button48;
    private Label label3;
    private Button button54;
    private Button button12;
    private int tabPage4SelectedTimes = 0;
    private int tabPage7SelectedTimes = 0;
    private Button button55;
    private int tabPage2SelectedTimes = 0;
    //private long BytesReceivedTotal = 0;
    

    public hypo()
    {
        LogFileName = System.Environment.MachineName + "-netadapter-log-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        runningProdKey m = new runningProdKey();
        //m.Show();
        this.InitializeComponent();
       
        Console.SetOut((TextWriter) new ControlWriter((Control) this.textBox1));
        Console.WriteLine("Ver. {0}", (object) Application.ProductVersion);
        MyWMIQuery.WMIQuery();
        
        Console.WriteLine("");
        Console.WriteLine(String.Format("Last Reboot: {0}", GetLastSystemShutdown()));
        Console.WriteLine("");
        Console.WriteLine(String.Format("OS Installation Date: {0}", GetWindowsInstallationDateTime(Environment.MachineName.ToString())));

            //The lines below display the current Product Key. Made sloppy for proof of concept
            String x = RunCommand("wmic", " path softwarelicensingservice get OA3xOriginalProductKey");
            Console.WriteLine(x);
            //


            //this.tsFolderBox.Text = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            this.tabControl1.Selected += new TabControlEventHandler(this.tabControl1_Selected);
        //this.writeDriveInfo();
        //
        
        



        
    }
    public static DateTime GetLastSystemShutdown()
    {
        string sKey = @"System\CurrentControlSet\Control\Windows";
        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(sKey);

        string sValueName = "ShutdownTime";
        byte[] val = (byte[])key.GetValue(sValueName);
        long valueAsLong = BitConverter.ToInt64(val, 0);
        return DateTime.FromFileTime(valueAsLong);
    }
    private NetworkInterface GetNic(string strAdapterName)
    {
        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface nic in nics)
        {
            if (nic.Name.Equals(strAdapterName))
            {
                return nic;
            }
        }
        return null;
    }
    private void RefreshAdapterInfo(string strAdapterName)
    {
        if (strAdapterName.Equals("")) return;

        LogMessage("Getting information for '" + strAdapterName + "'");
        ChangeStatus("Getting information for '" + strAdapterName + "'", 50);

        NetworkInterface nic = GetNic(strAdapterName);
        if (nic != null)
        {
            IPInterfaceProperties ipProperties = nic.GetIPProperties();
            if (ipProperties != null)
            {
                try
                {
                    textBoxLocalIP.Text = string.Join(", ", ipProperties.UnicastAddresses.Select(x => x.Address.ToString()).Where(x => !x.Contains(':')).OrderBy(x => x.Length));
                }
                catch (NullReferenceException) { }
                try
                {
                    textBoxSubnet.Text = string.Join(", ", ipProperties.UnicastAddresses.Select(x => x.IPv4Mask.ToString()).Where(x => !x.Equals("0.0.0.0")));
                }
                catch (NullReferenceException) { }
                try
                {
                    textBoxDefaultGW.Text = string.Join(", ", ipProperties.GatewayAddresses.Select(x => x.Address.ToString()).Where(x => !x.Equals("0.0.0.0")));
                }
                catch (NullReferenceException) { }
                try
                {
                    textBoxDNS.Text = string.Join(", ", ipProperties.DnsAddresses.Select(x => x.ToString()).Where(x => !x.Equals("0.0.0.0")));
                }
                catch (NullReferenceException) { }
                try
                {
                    textBoxDHCP.Text = string.Join(", ", ipProperties.DhcpServerAddresses.Select(x => x.ToString()).Where(x => !x.Equals("0.0.0.0")));
                }
                catch (NullReferenceException) { }
            }
            textBoxMac.Text = string.Join(":", (from z in nic.GetPhysicalAddress().GetAddressBytes() select z.ToString("X2")).ToArray());
        }

        ChangeStatus("Ready", 0);
    }
    private void RefreshNetworkInfo(bool isPublicIP)
    {
        LogMessage("Getting network information");
        ChangeStatus("Getting network information", 50);

        NetworkInterface nicDefault = FindDefaultNic();

        if (isPublicIP)
        {
                #if !DEBUG
                textBoxPublicIP.Text = GetPublicIP();
                #endif
        }
        textBoxHostname.Text = System.Net.Dns.GetHostName();

        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        comboBoxAdapters.Items.Clear();
        foreach (NetworkInterface adapter in adapters)
        {
            comboBoxAdapters.Items.Add(adapter.Name);
            if (adapter.Name.Equals(nicDefault.Name))
            {
                comboBoxAdapters.SelectedIndex = comboBoxAdapters.Items.IndexOf(adapter.Name);
            }
        }

        LogMessage("Network information updated");
        ChangeStatus("Ready", 0);
    }
    private NetworkInterface GetNicForIP(string strTargetIP)
    {
        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface nic in nics)
        {
            IPInterfaceProperties ipProperties = nic.GetIPProperties();
            if (ipProperties != null)
            {
                foreach (UnicastIPAddressInformation ip in ipProperties.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        if (ip.Address.ToString().Equals(strTargetIP))
                        {
                            return nic;
                        }
                    }
                }
            }
        }
        return null;
    }
    private NetworkInterface FindDefaultNic()
    {
        IPAddress[] ipList = Array.FindAll(Dns.GetHostEntry(String.Empty).AddressList,
                                           a => a.AddressFamily == AddressFamily.InterNetwork);
        foreach (IPAddress ip in ipList)
        {
            textBoxLocalIP.Text = ip.ToString();
        }

        String strDefaultLocalIP = ipList[ipList.Length - 1].ToString();
        NetworkInterface nicDefault = GetNicForIP(strDefaultLocalIP);

        // If adapter looks like a virtual one, try finding a more suitable one
        string nicDesc = nicDefault.Description.ToLower();
        if (nicDesc.Contains("virtual") || nicDesc.Contains("vm") || nicDesc.Contains("tap"))
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            comboBoxAdapters.Items.Clear();
            foreach (NetworkInterface adapter in adapters)
            {
                string adapterName = adapter.Name;
                IPInterfaceProperties ipProperties = adapter.GetIPProperties();
                if (ipProperties != null)
                {
                    bool hasGateway = false;
                    try
                    {
                        string gw = string.Join(", ", ipProperties.GatewayAddresses.Select(x => x.Address.ToString()).Where(x => !x.Equals("0.0.0.0")));
                        hasGateway = (gw.Length > 3);
                    }
                    catch (NullReferenceException) { }
                    if (hasGateway)
                    {
                        string adapterDesc = adapter.Description.ToLower();
                        if (!adapterDesc.Contains("virtual") && !adapterDesc.Contains("vm") && !adapterDesc.Contains("tap"))
                        {
                            return adapter;
                        }
                    }
                }
            }
        }

        return nicDefault;
    }
    private string RunCommand(String cmd, String args)
    {
        Process p = new Process();
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
        p.StartInfo.FileName = cmd;
        p.StartInfo.Arguments = args;
        p.Start();
        string output = p.StandardOutput.ReadToEnd();
        p.WaitForExit();
        return output;
    }
    private void sfcRunCommand(String cmd, String args, bool value)
    {
        //var proc = new Process();
        //proc.StartInfo.FileName = cmd;
        //proc.StartInfo.Arguments = args;
        //proc.StartInfo.UseShellExecute = false;
        //// set up output redirection
        //proc.StartInfo.RedirectStandardOutput = true;
        //proc.StartInfo.RedirectStandardError = true;
        //proc.EnableRaisingEvents = true;
        //proc.StartInfo.CreateNoWindow = true;
        //// see below for output handler
        //proc.ErrorDataReceived += proc_DataReceived;
        //proc.OutputDataReceived += proc_DataReceived;

        //proc.Start();

        //proc.BeginErrorReadLine();
        //proc.BeginOutputReadLine();

        //proc.WaitForExit();
        Process myProcess = new Process();
        // Start a new instance of this program but specify the 'spawned' version.
        ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("sfc.exe", "spawn");
        myProcessStartInfo.UseShellExecute = false;
        myProcessStartInfo.RedirectStandardOutput = true;
        myProcess.StartInfo = myProcessStartInfo;
        myProcess.Start();
        StreamReader myStreamReader = myProcess.StandardOutput;
        // Read the standard output of the spawned process.
        string myString = myStreamReader.ReadLine();
        Console.WriteLine(myString);

        myProcess.WaitForExit();
        myProcess.Close();
        
    }
    void proc_DataReceived(object sender, DataReceivedEventArgs e)
    {
        // output will be in string e.Data
        Console.WriteLine(e.Data);
        //textBox11.Text += "\r\n";
    }
    private void DoClearHosts()
    {
        LogMessage("Clearing hosts file changing back to default settings");
        ChangeStatus("Clearing hosts file changing back to default settings", 50);

        string sHostsPath = Environment.GetEnvironmentVariable("windir") + "\\System32\\Drivers\\Etc\\hosts";

        // Log the existing hosts file first
        if (!HostsFileLogged)
        {
            string result = RunCommand("cmd.exe", "/C type \"" + sHostsPath + "\"");
            result = "EXISTING HOSTS FILE CONTENTS:\n" + result;
            LogMessageToFile(result);
        }


        // Remove read-only attribute, if set
        try
        {
            FileInfo fileInfo = new FileInfo(sHostsPath);
            fileInfo.IsReadOnly = false;
            fileInfo.Refresh();
        }
        catch (FileNotFoundException)
        {
            LogMessage("No hosts file found, creating one");
        }

        // Overwrite hosts file
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(sHostsPath))
        {
            file.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp.");
            file.WriteLine("#");
            file.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.");
            file.WriteLine("#");
            file.WriteLine("# This file contains the mappings of IP addresses to host names. Each");
            file.WriteLine("# entry should be kept on an individual line. The IP address should");
            file.WriteLine("# be placed in the first column followed by the corresponding host name.");
            file.WriteLine("# The IP address and the host name should be separated by at least one");
            file.WriteLine("# space.");
            file.WriteLine("#");
            file.WriteLine("# Additionally, comments (such as these) may be inserted on individual");
            file.WriteLine("# lines or following the machine name denoted by a '#' symbol.");
            file.WriteLine("#");
            file.WriteLine("# For example:");
            file.WriteLine("#");
            file.WriteLine("#      102.54.94.97     rhino.acme.com          # source server");
            file.WriteLine("#       38.25.63.10     x.acme.com              # x client host");
            file.WriteLine("#");
            file.WriteLine("127.0.0.1       localhost");
            if (Environment.OSVersion.Version.Major > 5)    // If newer than XP, add IPv6 localhost line
            {
                file.WriteLine("::1             localhost");
            }
        }

        LogMessage("Hosts file cleared and changed back to default settings");
        ChangeStatus("Ready", 0);
    }
    private void LogMessage(String msg)
    {
        richTextBoxLogArea.Text += DateTime.Now + ": " + msg + "\n";
        richTextBoxLogArea.SelectionStart = richTextBoxLogArea.Text.Length;
        richTextBoxLogArea.ScrollToCaret();

        LogMessageToFile(msg);

        this.Refresh();
    }


    // Logs the message to the log file ONLY
    private void LogMessageToFile(String msg)
    {
        string pathString = Path.GetDirectoryName(Application.ExecutablePath);
        if (!Directory.Exists(pathString+"\\LOG"))  // if it doesn't exist, create
            Directory.CreateDirectory(pathString + "\\LOG");
        using (System.IO.StreamWriter LogFile = File.AppendText(pathString+"\\LOG\\"+LogFileName))
        {
            LogFile.WriteLine(DateTime.Now + ": " + msg);
        }
    }

    private void LogMessageToFileForButtons(String msg)
    {
        string pathString = Path.GetDirectoryName(Application.ExecutablePath);
        if (!Directory.Exists(pathString + "\\LOG"))  // if it doesn't exist, create
            Directory.CreateDirectory(pathString + "\\LOG");
        using (System.IO.StreamWriter LogFile = File.AppendText(pathString + "\\LOG\\" + System.Environment.MachineName + " log "+ DateTime.Now.ToString("yyyy-MM-dd")+".txt"))
        {
            LogFile.WriteLine(DateTime.Now + ": " + msg);
        }
    }

    // Sets the status message and the progress bar at the bottom
    private void ChangeStatus(String msg, int progress)
    {
        toolStripStatusLabel.Text = msg;
        toolStripProgressBar.Value = progress;
        this.Refresh();
    }

      private String findFile(string str)
      {
          //-------------Searches for the executable in the execution directory. Should be Stimpak.
          String path = Path.GetDirectoryName(Application.ExecutablePath);
          String[] pathString = Directory.GetFiles(path, str, SearchOption.AllDirectories);
          //label24.Text = pathString[0];
          try
          {
              if (System.IO.File.Exists(string.Format("{0}", pathString[0])))
              {
                  return (pathString[0]);
              }
              else
              {
                  int num = (int)MessageBox.Show(string.Format("Failed to launch {0} failed to launch | Make sure you are running OneStop from the folder \"Stimpak\". Or that {0} exists.", str), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
          }
          //If the program doesn't exist there it will throw a IndexOutOfBounds error. This catch mitigates that error.
          catch (Exception ex)
          {
              //label24.Text = ex.ToString();
              if (ex.ToString().Contains("IndexOutOfRangeException"))
              {
                  MessageBox.Show(string.Format("Could not find {0}. Make sure it exists and Hypo is running inside Stimpak.", str), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
              else
              {
                  MessageBox.Show(string.Format("Failed to launch {0}. Please don't say no...", str), "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
          } 


          return "Could not find";
      }
    public static DateTime GetWindowsInstallationDateTime(string computerName)
    {
        Microsoft.Win32.RegistryKey key = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, computerName);
        key = key.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false);
        if (key != null)
        {
            DateTime startDate = new DateTime(1970, 1, 1, 0, 0, 0);
            Int64 regVal = Convert.ToInt64(key.GetValue("InstallDate").ToString());

            DateTime installDate = startDate.AddSeconds(regVal);

            return installDate;
        }

        return DateTime.MinValue;
    }
    private void bootSafeMode()
    {

        BootMode mode = SystemInformation.BootMode;

        if (mode == BootMode.Normal)
        {
            hypo.AddApplicationToStartup();
            DialogResult diagResult = MessageBox.Show("Adding safe boot. Restarting now. " + mode.ToString(), "Restarting", MessageBoxButtons.OKCancel);
            if (diagResult == DialogResult.OK)
            {
                String exeString = "safeboot.bat";

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
                //using (Process process = new Process())
                //{
                //    //process.StartInfo.WorkingDirectory = path;
                //    process.StartInfo.FileName = "cmd.exe";
                //    //process.StartInfo.Arguments = "bcdedit /set {current} safeboot network";
                //    //process.StartInfo.CreateNoWindow = true;
                //    process.StartInfo.UseShellExecute = false;
                //    //process.StartInfo.RedirectStandardOutput = true;
                //    process.StartInfo.RedirectStandardInput = true;
                //    //process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
                //    process.Start();
                //    process.StandardInput.WriteLine("bcdedit /set {current} safeboot network");
                //    //process.StandardInput.WriteLine("shutdown /r /f /t 0");
                //    //process.BeginOutputReadLine();
                //}
                ////Application.Exit();
            }
        }
        else
        {
            hypo.RemoveApplicationFromStartup();
            DialogResult diagResult = MessageBox.Show("Removing safe boot. Restarting. " + mode.ToString(), "Restarting", MessageBoxButtons.OKCancel);
            if (diagResult == DialogResult.OK)
            {
                String exeString = "removesafeboot.bat";

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

        }
    }
    private void runGrabStartupPrograms()
    {

        const string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
       
        using (RegistryKey startupKey = Registry.LocalMachine.OpenSubKey(runKey))
        {

            var valueNames = startupKey.GetValueNames();


            var appInfos = valueNames

                .Where(valueName => startupKey.GetValueKind(valueName) == RegistryValueKind.String)

                .ToDictionary(valueName => valueName, valueName => startupKey.GetValue(valueName).ToString())

                .Select(s => new StartUpProgram { Name = s.Key, Path = s.Value });
            ListViewGroup group;
            try
            {
                group = listView1.Groups.Add(String.Format("Global startup items"), String.Format("Global startup items"));
            }
            catch
            {
                group = listView1.Groups.Add("Error", "Error");
            }
            foreach (var item in appInfos)
            {

                

                
                for (int i = 0; i < 6; i++)
                {
                    ListViewItem driveItem = new ListViewItem(group);
                    if (listView1.Items.Count % 2 != 0)
                        driveItem.BackColor = Color.Silver;
                    else
                        driveItem.BackColor = Color.Silver;
                    if (i == 0)
                    {
                        driveItem.Text = item.ToString();
                        driveItem.SubItems.Add(item.Path.ToString());

                        listView1.Items.Add(driveItem);
                    }
                    
                }


            }

        }
        
    }
    private void runGrabStartupPrograms3()
    {

        const string runKey = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";
        if (Registry.LocalMachine.OpenSubKey(runKey) == null)
        {
            return;
        }
        using (RegistryKey startupKey = Registry.LocalMachine.OpenSubKey(runKey))
        {

            var valueNames = startupKey.GetValueNames();


            var appInfos = valueNames

                .Where(valueName => startupKey.GetValueKind(valueName) == RegistryValueKind.String)

                .ToDictionary(valueName => valueName, valueName => startupKey.GetValue(valueName).ToString())

                .Select(s => new StartUpProgram { Name = s.Key, Path = s.Value });
            ListViewGroup group;
            try
            {
                group = listView1.Groups.Add(String.Format("32 bit Global startup items"), String.Format("32 bit Global startup items"));
            }
            catch
            {
                group = listView1.Groups.Add("Error", "Error");
            }
            foreach (var item in appInfos)
            {




                for (int i = 0; i < 6; i++)
                {
                    ListViewItem driveItem = new ListViewItem(group);
                    if (listView1.Items.Count % 2 != 0)
                        driveItem.BackColor = Color.Silver;
                    else
                        driveItem.BackColor = Color.Silver;
                    if (i == 0)
                    {
                        driveItem.Text = item.ToString();
                        driveItem.SubItems.Add(item.Path.ToString());

                        listView1.Items.Add(driveItem);
                    }

                }


            }

        }

    }
    private void runGrabStartupPrograms2()
    {
        
        const string runKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

        using (RegistryKey startupKey = Registry.CurrentUser.OpenSubKey(runKey))
        {

            var valueNames = startupKey.GetValueNames();


            var appInfos = valueNames

                .Where(valueName => startupKey.GetValueKind(valueName) == RegistryValueKind.String)

                .ToDictionary(valueName => valueName, valueName => startupKey.GetValue(valueName).ToString())

                .Select(s => new StartUpProgram { Name = s.Key, Path = s.Value });
            ListViewGroup group;
            try
            {
                group = listView1.Groups.Add(String.Format("Current user startup items"), String.Format("Current user startup items"));
            }
            catch
            {
                group = listView1.Groups.Add("Error", "Error");
            }
            foreach (var item in appInfos)
            {

                


                for (int i = 0; i < 6; i++)
                {
                    ListViewItem driveItem = new ListViewItem(group);
                    if (listView1.Items.Count % 2 != 0)
                        driveItem.BackColor = Color.Silver;
                    else
                        driveItem.BackColor = Color.Silver;
                    if (i == 0)
                    {
                        driveItem.Text = item.ToString();
                        driveItem.SubItems.Add(item.Path.ToString());


                        listView1.Items.Add(driveItem);
                    }

                }


            }

        }

    }

//-------------Runs any given program by searching for the executable string.-------------------------
    private void runProgramButton(object sender, String exeString)
    {
        //-------------Logs indiviudal button clicks.---------------------
        if (sender != null)
        {
            Button button = sender as Button;
            LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
            
            
        }

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
  
        

    /// <summary>
    /// Converts a file size value to a size string
    /// </summary>
    /// <param name="sizeinBytes">Size in bytes</param>
    /// <returns></returns>
    public static string fileSizer(long sizeInBytes)
    {
        string[] _suffix = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        double _fileSizeDivisor = 1024.0;
        double size = (double)sizeInBytes;
        int suffix = 0;

        while (size >= _fileSizeDivisor)
        {
            suffix++;
            size /= _fileSizeDivisor;
        }
        //return String.Format("{0:#,##0.##} {1}", size, _suffix[suffix]);
        return String.Format("{0:0.#} {1}", size, _suffix[suffix]);
    }
    
    /// <summary>
    /// This method finds both Physical hardware and Virtual drives and puts them in a ListView.
    /// All the physical hardware should exist in Win32_DiskDrive. All virtual drives(C:\, D:\, ..) should be simply in DriveInfo.
    /// </summary>
    /// <param name="lst"> This should pass in the reference to the ListView attached to TabPage2. </param>
    /// <param name="DontInsertNull"> </param>
    private void InsertInfo(ref ListView lst, bool DontInsertNull)
    {
        lst.Items.Clear();
        DontInsertNull = true;
        int count = -1;
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_DiskDrive");

        try
        {
            foreach (DriveInfo d in allDrives)
            {
                ListViewGroup group;
                try
                {
                    group = lst.Groups.Add(String.Format("Disk {0}", d.Name.ToString()), String.Format("Disk {0}", d.Name.ToString()));
                }
                catch
                {
                    group = lst.Groups.Add("Error", "Error");
                }
                for (int i = 0; i < 6; i++ )
                {
                    ListViewItem driveItem = new ListViewItem(group);
                    if (lst.Items.Count % 2 != 0)
                        driveItem.BackColor = Color.Silver;
                    else
                        driveItem.BackColor = Color.Silver;
                    if (i == 0)
                    {
                        driveItem.Text = "Drive Type";
                        driveItem.SubItems.Add(d.DriveType.ToString());
                        

                        lst.Items.Add(driveItem);
                    }
                    else if (i == 1){
                        
                        if ((d.IsReady == true) && (d.VolumeLabel != ""))
                        {
                            driveItem.Text = "Volume Label";
                            driveItem.SubItems.Add(d.VolumeLabel.ToString());
                            lst.Items.Add(driveItem);
                        }
                        
                    }
                    else if (i == 2)
                    {
                        
                        if (d.IsReady == true)
                        {
                            driveItem.Text = "File System";
                            driveItem.SubItems.Add(d.DriveFormat.ToString());
                            lst.Items.Add(driveItem);
                        }
                        
                    }
                    else if (i == 3)
                    {
                        
                        if (d.IsReady == true)
                        {
                            driveItem.Text = "Available Free Space";
                            long availableFreeSpace = d.AvailableFreeSpace;
                            driveItem.SubItems.Add(fileSizer(availableFreeSpace));
                            lst.Items.Add(driveItem);
                        }
                        
                    }
                    else if (i == 4)
                    {
                        
                        if (d.IsReady == true)
                        {
                            driveItem.Text = "Total Free Space";
                            long totalFreeSpace = d.TotalFreeSpace;
                            driveItem.SubItems.Add(fileSizer(totalFreeSpace));
                            lst.Items.Add(driveItem);
                        }
                        
                    }
                    else
                    {
                        
                        if (d.IsReady == true)
                        {
                            driveItem.Text = "Total Size";
                            long totalSize = d.TotalSize;
                            driveItem.SubItems.Add(fileSizer(totalSize));
                            lst.Items.Add(driveItem);
                        }
                        
                    }
                }
            }
            foreach (ManagementObject share in searcher.Get())
            {
                count++;
                ListViewGroup grp;
                try
                {
                    grp = lst.Groups.Add(String.Format("Disk Drive {0}", count), String.Format("Disk Drive {0}", count));
                    //grp = lst.Groups.Add(share["Model"].ToString(), share["Model"].ToString());
                }
                catch
                {
                    grp = lst.Groups.Add(share.ToString(), share.ToString());
                }

                if (share.Properties.Count <= 0)
                {
                    MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (PropertyData PC in share.Properties)
                {

                    ListViewItem item = new ListViewItem(grp);
                    if (lst.Items.Count % 2 != 0)
                        item.BackColor = Color.Silver;
                    else
                        item.BackColor = Color.Silver;

                    item.Text = PC.Name;
                    if ((PC.Name == "Model") || (PC.Name == "SerialNumber") || (PC.Name == "Name"))
                    {
                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                item.SubItems.Add("No Information available");
                            else
                                continue;
                        }
                        lst.Items.Add(item);
                    }
                }
            }
        }


        catch (Exception exp)
        {
            MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
    /// <summary>
    /// Leftover from source code from the original drive info grabber.
    /// </summary>
    /// <param name="lst"> Reference to original list </param>
    private void RemoveNullValue(ref ListView lst)
    {
        foreach (ListViewItem item in lst.Items)
            if (item.SubItems[1].Text == "No Information available")
                item.Remove();
    }
    
      /// <summary>
      /// Writes to the log file. Used inside the runProgramButton method to log button clicks.
      /// </summary>
      /// <param name="logMessage"></param>
      /// <param name="w"></param>
    public static void Log(string logMessage, TextWriter w)
    {
        w.Write("\r\nLog Entry : ");
        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
        w.WriteLine("  :");
        w.WriteLine("  :{0}", logMessage);
        w.WriteLine("-------------------------------");
    }
    /// <summary>
    /// Dumps log to console
    /// </summary>
    /// <param name="r"></param>
    public static void DumpLog(StreamReader r)
    {
        string line;
        while ((line = r.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// In order to easily grab the product key and write to the textbox in the Utility tab,
    /// produkey.exe is run through command line and written to a text file. 
    /// This method reads the output file.
    /// </summary>
    /// <param name="path"></param>
    public void readProdKey(String path)
    {
        String[] pathString = Directory.GetFiles(path, "ProdKey.txt", SearchOption.AllDirectories);
        try
        {
            using (StreamReader sr = new StreamReader(pathString[0]))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ProduKey.exe is missing. The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
    public string dateTime()
    {
      return DateTime.Now.ToString() + " ";
    }


    private void button1_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("appwiz.cpl");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("wuapp");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("ncpa.cpl");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("inetcpl.cpl");
    }

    private void button5_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("compmgmt.msc");
    }

    private void button6_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("taskmgr");
    }

    private void button7_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("cleanmgr");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("control");
    }

    private void button9_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("hdwwiz.cpl");
    }

    private void button10_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      Process.Start("powercfg.cpl");
    }

    
    private void button18_Click(object sender, EventArgs e)
    {
            //if (this.requestInput == false)
            //{
            //    MessageBox.Show("You need to input CI number", "error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    return;

            //}
            Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        BootMode mode = SystemInformation.BootMode;
            //if (mode == BootMode.Normal)
            //{
            //    //MessageBox.Show("Tron need to be run in Safe Mode. Please use the reboot in Safe Mode button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    FormRestartConfirmation dlgRestart = new FormRestartConfirmation(60, "Tron need to be run in Safe Mode.\r\nWould you like reboot into safe mode?");
            //    dlgRestart.ShowDialog();
            //    if (dlgRestart.ButtonPressed == 1)
            //    {
            //        LogMessage("Restarting the computer");
            //        ChangeStatus("Restarting the computer...", 100);
            //        this.bootSafeMode();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Restart in Safe Mode with networking.");
            //        LogMessage("Restart canceled by user");
            //    }
            //    return;
            //}
            string str = " ";
      string text = this.findFile("Tron.bat");
      //text = text.Replace("\\Tron.bat", "");
      
      //this.tsFolderBox.Text = text;
      
      //string text = this.tsFolderBox.Text;
      foreach (Control control in (ArrangedElementCollection) this.panel3.Controls)
      {
        if (control is CheckBox && ((CheckBox) control).Checked)
          str = str + control.Tag.ToString() + " ";
      }
      //text = string.Format("/c \"{0}\"{1}", (object)text, (object)str);
      //      String testing = "";
      try
      {
        if (System.IO.File.Exists(string.Format("{0}", (object) text)))
        {
            Process.Start("cmd.exe", string.Format("/c \"{0}\"{1}", (object)text, (object)str));
        }
        else
        {
          Console.WriteLine("Failed To Launch.");
          this.textBox1.SelectionStart = this.textBox1.Text.Length;
          this.textBox1.ScrollToCaret();
          int num = (int) MessageBox.Show("Failed to launch TronScript | Check that tron.bat has been found.", "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
          if (ex == null)
          {

          }
        Console.WriteLine("Failed To Launch.");
        this.textBox1.SelectionStart = this.textBox1.Text.Length;
        this.textBox1.ScrollToCaret();
        int num = (int) MessageBox.Show("Failed to launch TronScript", "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      Console.WriteLine(text + "\\" + str);
      Console.WriteLine("-----------------------------------");
      this.textBox1.SelectionStart = this.textBox1.Text.Length;
      this.textBox1.ScrollToCaret();
    }

    private void button20_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      //foreach (Control control in (ArrangedElementCollection) this.panel3.Controls)
      //{
      //  if (control is CheckBox)
      //    ((CheckBox) control).Checked = true;
      //}
        foreach( Control control in (ArrangedElementCollection)this.panel3.Controls){
            if (control is CheckBox)
            {
                if ((control == this.checkBox1)||(control == this.checkBox8)||(control == this.checkBox11)||(control == this.checkBox4)||(control == this.checkBox5))
                {
                    ((CheckBox)control).Checked = true;
                }
                else
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

      //if (button.Text == "Check All")
      //{
      //    foreach (Control control in (ArrangedElementCollection)this.panel3.Controls)
      //    {
      //        if (control is CheckBox)
      //            ((CheckBox)control).Checked = true;
      //    }
      //    button.Text = "UnCheck All";
      //}
      //else{
      //    foreach (Control control in (ArrangedElementCollection)this.panel3.Controls)
      //    {
      //        if (control is CheckBox && ((CheckBox)control).Checked)
      //            ((CheckBox)control).Checked = false;
      //    }
      //    button.Text = "Check All";
      //}
    }

    private void button21_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      foreach (Control control in (ArrangedElementCollection) this.panel3.Controls)
      {
        if (control is CheckBox && ((CheckBox) control).Checked)
          ((CheckBox) control).Checked = false;
      }
    }

    private void staticExtasyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start("http://www.reddit.com/u/staticextasy");
    }

    private void tronScriptToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start("http://www.reddit.com/r/tronscript");
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void button19_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        string text = this.findFile("Tron.bat");
            if (text.Contains("Tron.bat"))
            {
                text = text.Replace("\\Tron.bat", "");
            }
            else
            {
                text = text.Replace("\\tron.bat", "");
            }
      
      string filename = text + "\\resources\\stage_7_wrap-up\\email_report\\SwithMailSettings.xml";
        
      if (this.mailSubjectBox.Text == null || !this.mailSubjectBox.Text.Contains("CI")){
          MessageBox.Show("Please enter in a CI number with CI in caps.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return;
      }
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(filename);
        xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//FromName").InnerText = "HYPO";
        xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//FromAddress").InnerText = "ststronresults@gmail.com";
        xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//Password").InnerText = "1h4t3c0mps";
        xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//MailServer").InnerText = "smtp.gmail.com";
        xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//MailServerPort").InnerText = "587";
        
        xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//SSL").InnerText = "True";
        
        xmlDocument.SelectSingleNode("//SwithMailSettings//EmailAddresses//To").InnerText = "ststronresults@gmail.com";
        xmlDocument.SelectSingleNode("//SwithMailSettings//EmailContent//Subject").InnerText = this.mailSubjectBox.Text + " TRON: Run complete on %COMPUTERNAME%";
        xmlDocument.Save(filename);
        Console.WriteLine(string.Format("Saved Mail settings to {0}", (object) filename));
        this.textBox1.SelectionStart = this.textBox1.Text.Length;
        this.textBox1.ScrollToCaret();
        MessageBox.Show("Applied the email Subject", "Subject applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch
      {
        Console.WriteLine("Failed Save email settings.");
        this.textBox1.SelectionStart = this.textBox1.Text.Length;
        this.textBox1.ScrollToCaret();
        int num = (int) MessageBox.Show("Failed to save email settings | Have you located tron.bat already?", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.requestInput = true;
    }

    private void button22_Click(object sender, EventArgs e)
    {
        
      //  Button button = sender as Button;
      //  using (StreamWriter w = File.AppendText(System.Environment.MachineName + " log.txt"))
      //  {
      //      Log(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text), w);
      //  }
      //  string text = this.findFile("Tron.bat");
      //  text = text.Replace("\\Tron.bat", "");
      //string filename = text + "\\resources\\stage_7_wrap-up\\email_report\\SwithMailSettings.xml";
      //try
      //{
      //  XmlDocument xmlDocument = new XmlDocument();
      //  xmlDocument.Load(filename);
      //  this.fromMailBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//FromName").InnerText;
      //  this.fromAddrBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//FromAddress").InnerText;
      //  this.mailPassBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//Password").InnerText;
      //  this.mailSMTPBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//MailServer").InnerText;
      //  this.mailPortBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//MailServerPort").InnerText;
      //  if (xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//SSL").InnerText == "True")
      //    this.mailSSLCheck.Checked = true;
      //  if (xmlDocument.SelectSingleNode("//SwithMailSettings//ServerSettings//RequestReceipt").InnerText == "True")
      //    this.mailReqRecBox.Checked = true;
      //  this.mailToBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//EmailAddresses//To").InnerText;
      //  this.mailSubjectBox.Text = xmlDocument.SelectSingleNode("//SwithMailSettings//EmailContent//Subject").InnerText;
      //  Console.WriteLine(string.Format("Loaded mail settings from {0}", (object) filename));
      //  this.textBox1.SelectionStart = this.textBox1.Text.Length;
      //  this.textBox1.ScrollToCaret();
      //}
      //catch
      //{
      //  Console.WriteLine("Failed to load mail settings.");
      //  this.textBox1.SelectionStart = this.textBox1.Text.Length;
      //  this.textBox1.ScrollToCaret();
      //  int num = (int) MessageBox.Show("Failed to load mail settings | Have you located tron.bat already?", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      //}
    }

    private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      new AboutBox().Show();
    }

    private void timerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new timer().Show();
    }

    private void button23_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        RefreshNetworkInfo(true);
    }

    

    public static void AddApplicationToStartup()
    {
      using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
      {
        if (registryKey.GetValue("OneStopStart") != null)
          return;
        registryKey.SetValue("OneStopStart", (object) ("\"" + Application.ExecutablePath + "\""));
      }
    }

    public static void RemoveApplicationFromStartup()
    {
      using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
        registryKey.DeleteValue("OneStopStart", false);
    }


    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab == tabControl1.TabPages[this.tabPage5.Name])
        {
            
        }
        
        if (tabControl1.SelectedTab == tabControl1.TabPages[this.tabPage4.Name] && (tabPage4SelectedTimes == 0))
        {
            ++tabPage4SelectedTimes;
            string result = RunCommand("ipconfig.exe", "/all");
            LogMessageToFile(result);
            labelWarning.Text = "";
            RefreshNetworkInfo(true);
        }
        if (tabControl1.SelectedTab == tabControl1.TabPages[this.tabPage2.Name] && tabPage2SelectedTimes==0)
        {
            ++tabPage2SelectedTimes;
            this.InsertInfo(ref lstDisplayHardware, true);
        }
        
        if (tabControl1.SelectedTab == tabControl1.TabPages[this.tabPage7.Name] && tabPage7SelectedTimes==0)
        {
            ++tabPage7SelectedTimes;
            listView1.Items.Clear();
            this.runGrabStartupPrograms();
            this.runGrabStartupPrograms2();
            this.runGrabStartupPrograms3();
        }
    }
    private void tabControl1_Selected(object sender, TabControlEventArgs e)
    {
      if (!(e.TabPage.Name == this.tabPage4.Name))
        return;
      if (tabControl1.SelectedTab == tabControl1.TabPages[this.tabPage5.Text])
      {
          listView1.Items.Clear();
          this.runGrabStartupPrograms();
          this.runGrabStartupPrograms2();
          this.runGrabStartupPrograms3();
      }
      if (this.num == 0)
      {
        //this.getNetAdapter();
        //this.textBox2.Text = Environment.MachineName;
        ++this.num;
      }
      //this.comboBox1.SelectedIndex = 0;
      //this.comboBoxAdapters.SelectedIndex = 0;
    }

    private void getNetAdapter()
    {
      DateTime now = DateTime.Now;
      try
      {
        foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
        {
          if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
          {
            //this.comboBox1.Items.Add((object) networkInterface.Name);
            //this.textBox10.AppendText(now.ToString() + " Interface Found: " + networkInterface.Name + Environment.NewLine);
          }
        }
      }
      catch
      {
        //this.textBox10.AppendText(now.ToString() + " Error Finding Adapters " + Environment.NewLine);
      }
    }

    public static string GetPublicIP()
    {
      try
      {
        return new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(':')[1].Substring(1).Split('<')[0];
      }
      catch
      {
        return "Error Checking for IP. Try Again.";
      }
    }

    

    private void progressCheckListToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new progressWin().Show();
    }

    

    private void button14_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
      using (Process process = new Process())
      {
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = "/K ipconfig /flushdns";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
        process.Start();
        process.BeginOutputReadLine();
        process.WaitForExit(120);
      }
    }

    private void SortOutputHandler(object sender, DataReceivedEventArgs e)
    {
        if (e.Data != null)
        {
            if (e.Data.Contains("Emory") || e.Data.Contains("eduroam") || e.Data.Contains("Dooley") || e.Data.Contains("STS"))
            {
                if (!e.Data.Contains("netsh"))
                {
                    MessageBox.Show(e.Data, "Done", MessageBoxButtons.OK);
                }
            }
        }
        
    }

    

    private void button11_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        LogMessage("Releasing IP addresses");
        ChangeStatus("Releasing IP addresses", 50);
        String result;

        result = RunCommand("ipconfig.exe", " /release");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred releasing IP addresses");
            LogMessage(result);
        };

        LogMessage("Renewing IP addresses");
        ChangeStatus("Renewing IP addresses", 90);
        result = RunCommand("ipconfig.exe", " /renew");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred renewing IP addresses");
            LogMessage(result);
        };

        LogMessage("Released and renewed all adapters");
        ChangeStatus("Ready", 0);
    }
    private void messageBox_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "AdwCleaner.exe");
    }
    private void revoButton_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        warningMessage m = new warningMessage();
        m.Show();
    }
    private void bluescreenButton_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "BlueScreenView.exe");
    }
    private void adwButton_Click(object sender, EventArgs e)
    {

        this.runProgramButton(sender, "AdwCleaner.exe");
    }
    private void RogueKiller_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "RogueKiller.exe");
    }
    private void button24_Click(object sender, EventArgs e)
    {
        //Process process = new Process();
        //process.StartInfo.UseShellExecute = false;
        //process.StartInfo.RedirectStandardInput = true;
        //process.StartInfo.FileName = "cmd.exe";
        //process.StartInfo.Arguments = "/c sfc /scannow";
        //process.Start();
        //process.StandardInput.WriteLine("/c sfc.exe /scannow");
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        if (Environment.Is64BitOperatingSystem && !Environment.Is64BitProcess)
        {
            IntPtr ptr = new IntPtr();
            NativeMethods.Wow64DisableWow64FsRedirection(ref ptr);
            new Process()
            {
                StartInfo = new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = true,
                    CreateNoWindow = false,
                    WorkingDirectory = "C:\\",
                    Arguments = "/k sfc /scannow"
                }
            }.Start();
            NativeMethods.Wow64RevertWow64FsRedirection(ref ptr);
        }
        else
            new Process()
            {
                StartInfo = new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = true,
                    CreateNoWindow = false,
                    WorkingDirectory = "C:\\",
                    Arguments = "/k sfc /scannow"
                }
            }.Start();
        //sfcRunCommand("sfc.exe", "/scannow", true);
        //textBox11.Text += "Scanning now please wait for results \r\n";

        //Process p = new Process();
        //String s;
        //p.StartInfo.UseShellExecute = false;
        ////p.StartInfo.CreateNoWindow = true;
        ////p.StartInfo.RedirectStandardInput = true;
        //p.StartInfo.RedirectStandardOutput = true;
        //p.StartInfo.FileName = "sfc.exe";
        //p.StartInfo.Arguments = "/scannow";
        //p.Start();
        //Console.SetOut((TextWriter)new ControlWriter((Control)this.textBox11));
        //using (StreamReader reader = p.StandardOutput)
        //{
        //    while (!reader.EndOfStream)
        //    {
        //        string result = reader.ReadLine();
        //        Console.Out.WriteLine(result);
        //    }
        //}
        //p.WaitForExit();
       
        
        //Console.WriteLine(s);

        
        //Console.ReadLine();
        //textBox11.Text += result;
        //Console.WriteLine(result);
        //using (Process process = new Process())
        //{
            
        //    // process.StartInfo.WorkingDirectory = path;
        //    process.StartInfo.FileName = "sfc.exe";
        //    process.StartInfo.Arguments = "/scannow";
        //    process.StartInfo.CreateNoWindow = true;
        //    process.StartInfo.UseShellExecute = false;
        //    process.StartInfo.RedirectStandardOutput = true;
        //    //process.StartInfo.RedirectStandardInput = true;
        //    process.OutputDataReceived += new DataReceivedEventHandler((this.consoleOutputHandler)); 
        //    process.Start();

        //    process.BeginOutputReadLine();
        //    //process.WaitForExit();
        //    //String output = process.StandardOutput.ReadToEnd();

        //    Console.SetOut((TextWriter)new ControlWriter((Control)this.textBox11));
        //    Console.WriteLine("Scanning now please wait.");
        //    Console.WriteLine(output);

        //    //process.WaitForExit();
        //    process.Close();
            
        //    //Console.SetOut((TextWriter)new ControlWriter((Control)this.textBox1));


        //    //process.WaitForExit();
        //    //process.StandardInput.WriteLine("/scannow");
        //    //process.BeginOutputReadLine();
        //}
        //ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/C sfc /scannow");
        //startInfo.UseShellExecute = true;
        //startInfo.Verb = "runas";
        //Process process = Process(startInfo);

        //Process process = System.Diagnostics.Process.Start("sfc.exe", "/scannow");
        //process.WaitForExit(500000);

        
    }

    private void button25_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new settings().Show();
    }

    private void disclaimerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new disclaimer().Show();
    }

    private void ninitecomToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
    {
      Process.Start("http://ninite.com");
    }

    

   

   
    


    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressCheckListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toshibaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samsungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disclaimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tronScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticExtasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitcoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paypalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFlushDNS = new System.Windows.Forms.Button();
            this.buttonGoogleDNS = new System.Windows.Forms.Button();
            this.buttonSetDHCP = new System.Windows.Forms.Button();
            this.buttonRenewDHCP = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.buttonServicesDefault = new System.Windows.Forms.Button();
            this.buttonResetInternetSecurity = new System.Windows.Forms.Button();
            this.buttonClearSSL = new System.Windows.Forms.Button();
            this.buttonReloadNETBIOS = new System.Windows.Forms.Button();
            this.buttonClearARP = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.Button();
            this.flowLayourPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button43 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usefulToolsTab = new System.Windows.Forms.TabPage();
            this.button55 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button54 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button40 = new System.Windows.Forms.Button();
            this.bluescreenButton = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.revoButton = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button47 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.buttonViewHosts = new System.Windows.Forms.Button();
            this.labelNetworkStats = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.buttonRunAll = new System.Windows.Forms.Button();
            this.cbServicesDefault = new System.Windows.Forms.CheckBox();
            this.cbResetInternetSecurity = new System.Windows.Forms.CheckBox();
            this.cbEnableWireless = new System.Windows.Forms.CheckBox();
            this.cbEnableLAN = new System.Windows.Forms.CheckBox();
            this.cbClearSSL = new System.Windows.Forms.CheckBox();
            this.cbReloadNETBIOS = new System.Windows.Forms.CheckBox();
            this.cbClearARP = new System.Windows.Forms.CheckBox();
            this.cbFlushDNS = new System.Windows.Forms.CheckBox();
            this.cbGoogleDNS = new System.Windows.Forms.CheckBox();
            this.cbSetDHCP = new System.Windows.Forms.CheckBox();
            this.cbClearHosts = new System.Windows.Forms.CheckBox();
            this.cbRenewDHCP = new System.Windows.Forms.CheckBox();
            this.buttonEnableWireless = new System.Windows.Forms.Button();
            this.buttonEnableLAN = new System.Windows.Forms.Button();
            this.buttonClearHosts = new System.Windows.Forms.Button();
            this.buttonPingDNS = new System.Windows.Forms.Button();
            this.buttonPingIP = new System.Windows.Forms.Button();
            this.textBoxDHCP = new System.Windows.Forms.TextBox();
            this.textBoxSubnet = new System.Windows.Forms.TextBox();
            this.textBoxDNS = new System.Windows.Forms.TextBox();
            this.textBoxDefaultGW = new System.Windows.Forms.TextBox();
            this.textBoxMac = new System.Windows.Forms.TextBox();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.richTextBoxLogArea = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxAdapters = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button21 = new System.Windows.Forms.Button();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mailGroupBox = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mailSubjectBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.button20 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button48 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.adwButton = new System.Windows.Forms.Button();
            this.RogueKiller = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.usefulToolsTab.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.mailGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.productSitesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerToolStripMenuItem,
            this.progressCheckListToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // progressCheckListToolStripMenuItem
            // 
            this.progressCheckListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressCheckListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.progressCheckListToolStripMenuItem.Name = "progressCheckListToolStripMenuItem";
            this.progressCheckListToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.progressCheckListToolStripMenuItem.Text = "Progress CheckList";
            this.progressCheckListToolStripMenuItem.Click += new System.EventHandler(this.progressCheckListToolStripMenuItem_Click);
            // 
            // productSitesToolStripMenuItem
            // 
            this.productSitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lenovoToolStripMenuItem,
            this.hPToolStripMenuItem,
            this.dellToolStripMenuItem,
            this.aSUSToolStripMenuItem,
            this.mSIToolStripMenuItem,
            this.microsoftToolStripMenuItem,
            this.toshibaToolStripMenuItem,
            this.samsungToolStripMenuItem,
            this.sonyToolStripMenuItem});
            this.productSitesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productSitesToolStripMenuItem.Name = "productSitesToolStripMenuItem";
            this.productSitesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.productSitesToolStripMenuItem.Text = "Product Sites";
            // 
            // lenovoToolStripMenuItem
            // 
            this.lenovoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lenovoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lenovoToolStripMenuItem.Name = "lenovoToolStripMenuItem";
            this.lenovoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lenovoToolStripMenuItem.Text = "Lenovo";
            this.lenovoToolStripMenuItem.Click += new System.EventHandler(this.lenovoToolStripMenuItem_Click);
            // 
            // hPToolStripMenuItem
            // 
            this.hPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hPToolStripMenuItem.Name = "hPToolStripMenuItem";
            this.hPToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hPToolStripMenuItem.Text = "HP";
            this.hPToolStripMenuItem.Click += new System.EventHandler(this.hPToolStripMenuItem_Click);
            // 
            // dellToolStripMenuItem
            // 
            this.dellToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dellToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dellToolStripMenuItem.Name = "dellToolStripMenuItem";
            this.dellToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.dellToolStripMenuItem.Text = "Dell";
            this.dellToolStripMenuItem.Click += new System.EventHandler(this.dellToolStripMenuItem_Click);
            // 
            // aSUSToolStripMenuItem
            // 
            this.aSUSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aSUSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aSUSToolStripMenuItem.Name = "aSUSToolStripMenuItem";
            this.aSUSToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aSUSToolStripMenuItem.Text = "ASUS";
            this.aSUSToolStripMenuItem.Click += new System.EventHandler(this.aSUSToolStripMenuItem_Click);
            // 
            // mSIToolStripMenuItem
            // 
            this.mSIToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mSIToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mSIToolStripMenuItem.Name = "mSIToolStripMenuItem";
            this.mSIToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mSIToolStripMenuItem.Text = "MSI";
            this.mSIToolStripMenuItem.Click += new System.EventHandler(this.mSIToolStripMenuItem_Click);
            // 
            // microsoftToolStripMenuItem
            // 
            this.microsoftToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.microsoftToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.microsoftToolStripMenuItem.Name = "microsoftToolStripMenuItem";
            this.microsoftToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.microsoftToolStripMenuItem.Text = "Microsoft";
            this.microsoftToolStripMenuItem.Click += new System.EventHandler(this.microsoftToolStripMenuItem_Click);
            // 
            // toshibaToolStripMenuItem
            // 
            this.toshibaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toshibaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toshibaToolStripMenuItem.Name = "toshibaToolStripMenuItem";
            this.toshibaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.toshibaToolStripMenuItem.Text = "Toshiba";
            this.toshibaToolStripMenuItem.Click += new System.EventHandler(this.toshibaToolStripMenuItem_Click);
            // 
            // samsungToolStripMenuItem
            // 
            this.samsungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.samsungToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.samsungToolStripMenuItem.Name = "samsungToolStripMenuItem";
            this.samsungToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.samsungToolStripMenuItem.Text = "Samsung";
            this.samsungToolStripMenuItem.Click += new System.EventHandler(this.samsungToolStripMenuItem_Click);
            // 
            // sonyToolStripMenuItem
            // 
            this.sonyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sonyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sonyToolStripMenuItem.Name = "sonyToolStripMenuItem";
            this.sonyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sonyToolStripMenuItem.Text = "Sony";
            this.sonyToolStripMenuItem.Click += new System.EventHandler(this.sonyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.disclaimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.tronScriptToolStripMenuItem,
            this.staticExtasyToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // disclaimerToolStripMenuItem
            // 
            this.disclaimerToolStripMenuItem.Name = "disclaimerToolStripMenuItem";
            this.disclaimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.disclaimerToolStripMenuItem.Text = "Disclaimer";
            this.disclaimerToolStripMenuItem.Click += new System.EventHandler(this.disclaimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // tronScriptToolStripMenuItem
            // 
            this.tronScriptToolStripMenuItem.Name = "tronScriptToolStripMenuItem";
            this.tronScriptToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tronScriptToolStripMenuItem.Text = "TronScript";
            this.tronScriptToolStripMenuItem.Click += new System.EventHandler(this.tronScriptToolStripMenuItem_Click);
            // 
            // staticExtasyToolStripMenuItem
            // 
            this.staticExtasyToolStripMenuItem.Name = "staticExtasyToolStripMenuItem";
            this.staticExtasyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            // 
            // bitcoinToolStripMenuItem
            // 
            this.bitcoinToolStripMenuItem.Name = "bitcoinToolStripMenuItem";
            this.bitcoinToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // paypalToolStripMenuItem
            // 
            this.paypalToolStripMenuItem.Name = "paypalToolStripMenuItem";
            this.paypalToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(559, 603);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(94, 27);
            this.button18.TabIndex = 2;
            this.button18.Text = "Start Tronscript";
            this.toolTip1.SetToolTip(this.button18, "Launch TronScript with/without CLI Switches.");
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(311, 49);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(91, 23);
            this.button19.TabIndex = 0;
            this.button19.Text = "Apply Settings";
            this.toolTip1.SetToolTip(this.button19, "Apply new mail settings to XML.");
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(141, 207);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Win Disk Cleanup";
            this.toolTip1.SetToolTip(this.button7, "Microsoft Disk Cleanup utility.");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(3, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Task Manager";
            this.toolTip1.SetToolTip(this.button6, "Display/Modify Active Processes and View System usage from Task Manager.");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(141, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Computer Mgmt.";
            this.toolTip1.SetToolTip(this.button5, "Open Microsoft Management Console window.");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(3, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Control Panel";
            this.toolTip1.SetToolTip(this.button8, "Control Panel");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(141, 105);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "Power Options";
            this.toolTip1.SetToolTip(this.button10, "Modify Power Options.");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(3, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "Device Manager";
            this.toolTip1.SetToolTip(this.button9, "Windows Device Manager.");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(141, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Internet Options";
            this.toolTip1.SetToolTip(this.button4, "Modify Internet Options.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add/Remove Programs";
            this.toolTip1.SetToolTip(this.button1, "Remove Windows Programs via Add/Remove Programs");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(141, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Net Connections";
            this.toolTip1.SetToolTip(this.button3, "Open the network connections panel.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Windows Updates";
            this.toolTip1.SetToolTip(this.button2, "Perform Windows Updates.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFlushDNS
            // 
            this.buttonFlushDNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlushDNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlushDNS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFlushDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFlushDNS.Location = new System.Drawing.Point(38, 290);
            this.buttonFlushDNS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlushDNS.Name = "buttonFlushDNS";
            this.buttonFlushDNS.Size = new System.Drawing.Size(315, 30);
            this.buttonFlushDNS.TabIndex = 99;
            this.buttonFlushDNS.Text = "Flush DNS Cache";
            this.toolTip1.SetToolTip(this.buttonFlushDNS, "Runs ipconfig /flushdns");
            this.buttonFlushDNS.UseVisualStyleBackColor = true;
            this.buttonFlushDNS.Click += new System.EventHandler(this.buttonFlushDNS_Click);
            // 
            // buttonGoogleDNS
            // 
            this.buttonGoogleDNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoogleDNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoogleDNS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoogleDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoogleDNS.Location = new System.Drawing.Point(38, 254);
            this.buttonGoogleDNS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoogleDNS.Name = "buttonGoogleDNS";
            this.buttonGoogleDNS.Size = new System.Drawing.Size(315, 30);
            this.buttonGoogleDNS.TabIndex = 98;
            this.buttonGoogleDNS.Text = "Change to Emory DNS";
            this.toolTip1.SetToolTip(this.buttonGoogleDNS, "Change DNS to 170.140.1.1 and 170.140.2.1");
            this.buttonGoogleDNS.UseVisualStyleBackColor = true;
            this.buttonGoogleDNS.Click += new System.EventHandler(this.buttonGoogleDNS_Click);
            // 
            // buttonSetDHCP
            // 
            this.buttonSetDHCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSetDHCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetDHCP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSetDHCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetDHCP.Location = new System.Drawing.Point(38, 218);
            this.buttonSetDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetDHCP.Name = "buttonSetDHCP";
            this.buttonSetDHCP.Size = new System.Drawing.Size(315, 30);
            this.buttonSetDHCP.TabIndex = 97;
            this.buttonSetDHCP.Text = "Clear Static IP Settings (enable DHCP)";
            this.toolTip1.SetToolTip(this.buttonSetDHCP, "Change IP and DNS to automatic and enable DHCP.");
            this.buttonSetDHCP.UseVisualStyleBackColor = true;
            this.buttonSetDHCP.Click += new System.EventHandler(this.buttonSetDHCP_Click);
            // 
            // buttonRenewDHCP
            // 
            this.buttonRenewDHCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRenewDHCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRenewDHCP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRenewDHCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRenewDHCP.Location = new System.Drawing.Point(38, 147);
            this.buttonRenewDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRenewDHCP.Name = "buttonRenewDHCP";
            this.buttonRenewDHCP.Size = new System.Drawing.Size(315, 30);
            this.buttonRenewDHCP.TabIndex = 95;
            this.buttonRenewDHCP.Text = "Release and Renew DHCP Address";
            this.toolTip1.SetToolTip(this.buttonRenewDHCP, "Runs ipconfig /release and /renew. Restart may be needed.");
            this.buttonRenewDHCP.UseVisualStyleBackColor = true;
            this.buttonRenewDHCP.Click += new System.EventHandler(this.buttonRenewDHCP_Click);
            // 
            // button25
            // 
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(3, 258);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(132, 45);
            this.button25.TabIndex = 10;
            this.button25.Text = "Restart";
            this.toolTip1.SetToolTip(this.button25, "Restarting computer in Safe Mode with Networking");
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click_1);
            // 
            // buttonServicesDefault
            // 
            this.buttonServicesDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonServicesDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonServicesDefault.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonServicesDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServicesDefault.Location = new System.Drawing.Point(38, 541);
            this.buttonServicesDefault.Margin = new System.Windows.Forms.Padding(4);
            this.buttonServicesDefault.Name = "buttonServicesDefault";
            this.buttonServicesDefault.Size = new System.Drawing.Size(315, 30);
            this.buttonServicesDefault.TabIndex = 117;
            this.buttonServicesDefault.Text = "Set Network Windows Services Default";
            this.toolTip1.SetToolTip(this.buttonServicesDefault, "Setting Services to default. Restart is needed.");
            this.buttonServicesDefault.UseVisualStyleBackColor = true;
            this.buttonServicesDefault.Click += new System.EventHandler(this.buttonServicesDefault_Click);
            // 
            // buttonResetInternetSecurity
            // 
            this.buttonResetInternetSecurity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetInternetSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetInternetSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResetInternetSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetInternetSecurity.Location = new System.Drawing.Point(38, 504);
            this.buttonResetInternetSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResetInternetSecurity.Name = "buttonResetInternetSecurity";
            this.buttonResetInternetSecurity.Size = new System.Drawing.Size(315, 30);
            this.buttonResetInternetSecurity.TabIndex = 105;
            this.buttonResetInternetSecurity.Text = "Reset Internet Options Security/Privacy";
            this.toolTip1.SetToolTip(this.buttonResetInternetSecurity, "Reset Internet Options settings");
            this.buttonResetInternetSecurity.UseVisualStyleBackColor = true;
            this.buttonResetInternetSecurity.Click += new System.EventHandler(this.buttonResetInternetSecurity_Click);
            // 
            // buttonClearSSL
            // 
            this.buttonClearSSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearSSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearSSL.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearSSL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearSSL.Location = new System.Drawing.Point(38, 397);
            this.buttonClearSSL.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearSSL.Name = "buttonClearSSL";
            this.buttonClearSSL.Size = new System.Drawing.Size(315, 30);
            this.buttonClearSSL.TabIndex = 102;
            this.buttonClearSSL.Text = "Internet Options - Clear SSL State";
            this.toolTip1.SetToolTip(this.buttonClearSSL, "Clears SSL State cache.");
            this.buttonClearSSL.UseVisualStyleBackColor = true;
            this.buttonClearSSL.Click += new System.EventHandler(this.buttonClearSSL_Click);
            // 
            // buttonReloadNETBIOS
            // 
            this.buttonReloadNETBIOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReloadNETBIOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReloadNETBIOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReloadNETBIOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReloadNETBIOS.Location = new System.Drawing.Point(38, 361);
            this.buttonReloadNETBIOS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReloadNETBIOS.Name = "buttonReloadNETBIOS";
            this.buttonReloadNETBIOS.Size = new System.Drawing.Size(315, 30);
            this.buttonReloadNETBIOS.TabIndex = 101;
            this.buttonReloadNETBIOS.Text = "NetBIOS Reload and Release";
            this.toolTip1.SetToolTip(this.buttonReloadNETBIOS, "Reloading and releasing netBIOS");
            this.buttonReloadNETBIOS.UseVisualStyleBackColor = true;
            this.buttonReloadNETBIOS.Click += new System.EventHandler(this.buttonReloadNETBIOS_Click);
            // 
            // buttonClearARP
            // 
            this.buttonClearARP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearARP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearARP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearARP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearARP.Location = new System.Drawing.Point(38, 325);
            this.buttonClearARP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearARP.Name = "buttonClearARP";
            this.buttonClearARP.Size = new System.Drawing.Size(315, 30);
            this.buttonClearARP.TabIndex = 100;
            this.buttonClearARP.Text = "Clear ARP/Route Table";
            this.toolTip1.SetToolTip(this.buttonClearARP, "Running netsh interface ip delete arpcache and netsh interface ipv4 delete destin" +
        "ationcache. Restart is needed.");
            this.buttonClearARP.UseVisualStyleBackColor = true;
            this.buttonClearARP.Click += new System.EventHandler(this.buttonClearARP_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(8, 64);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(112, 29);
            this.messageBox.TabIndex = 1;
            this.messageBox.Text = "messageBox";
            this.messageBox.UseVisualStyleBackColor = true;
            this.messageBox.Click += new System.EventHandler(this.messageBox_Click);
            // 
            // flowLayourPanel4
            // 
            this.flowLayourPanel4.Location = new System.Drawing.Point(7, 248);
            this.flowLayourPanel4.Name = "flowLayourPanel4";
            this.flowLayourPanel4.Size = new System.Drawing.Size(372, 74);
            this.flowLayourPanel4.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Silver;
            this.tabPage7.Controls.Add(this.button43);
            this.tabPage7.Controls.Add(this.button42);
            this.tabPage7.Controls.Add(this.listView1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1123, 658);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "Autorun Manager";
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(642, 0);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(75, 26);
            this.button43.TabIndex = 8;
            this.button43.Text = "Refresh";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(848, 593);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(269, 54);
            this.button42.TabIndex = 7;
            this.button42.Text = "Delete checked startup item(s)";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Silver;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(742, 650);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 503;
            // 
            // usefulToolsTab
            // 
            this.usefulToolsTab.BackColor = System.Drawing.Color.Silver;
            this.usefulToolsTab.Controls.Add(this.button55);
            this.usefulToolsTab.Controls.Add(this.label3);
            this.usefulToolsTab.Controls.Add(this.button54);
            this.usefulToolsTab.Controls.Add(this.label6);
            this.usefulToolsTab.Controls.Add(this.label5);
            this.usefulToolsTab.Controls.Add(this.flowLayoutPanel6);
            this.usefulToolsTab.Controls.Add(this.flowLayoutPanel5);
            this.usefulToolsTab.Location = new System.Drawing.Point(4, 22);
            this.usefulToolsTab.Name = "usefulToolsTab";
            this.usefulToolsTab.Size = new System.Drawing.Size(1123, 658);
            this.usefulToolsTab.TabIndex = 6;
            this.usefulToolsTab.Text = "Useful Tools";
            this.usefulToolsTab.Click += new System.EventHandler(this.usefulToolsTab_Click);
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(741, 493);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(125, 125);
            this.button55.TabIndex = 23;
            this.button55.Text = "EaglePrint Uninstaller";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Printing";
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(610, 493);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(125, 125);
            this.button54.TabIndex = 21;
            this.button54.Text = "EaglePrint";
            this.button54.UseVisualStyleBackColor = true;
            this.button54.Click += new System.EventHandler(this.button54_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Anti-Virus Removal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tools";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.button14);
            this.flowLayoutPanel6.Controls.Add(this.button16);
            this.flowLayoutPanel6.Controls.Add(this.button17);
            this.flowLayoutPanel6.Controls.Add(this.button15);
            this.flowLayoutPanel6.Controls.Add(this.button22);
            this.flowLayoutPanel6.Controls.Add(this.button23);
            this.flowLayoutPanel6.Controls.Add(this.button28);
            this.flowLayoutPanel6.Controls.Add(this.button49);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(597, 45);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(530, 272);
            this.flowLayoutPanel6.TabIndex = 18;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(3, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(125, 125);
            this.button14.TabIndex = 10;
            this.button14.Text = "AVG Removal";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(134, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(125, 125);
            this.button16.TabIndex = 12;
            this.button16.Text = "Kaspersky Removal";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(265, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(125, 125);
            this.button17.TabIndex = 13;
            this.button17.Text = "McAfee Removal";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(396, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(125, 125);
            this.button15.TabIndex = 11;
            this.button15.Text = "NOD32";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(3, 134);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(125, 125);
            this.button22.TabIndex = 14;
            this.button22.Text = "Norton Removal";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click_2);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(134, 134);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(125, 125);
            this.button23.TabIndex = 15;
            this.button23.Text = "SEP Removal";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(265, 134);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(125, 125);
            this.button28.TabIndex = 16;
            this.button28.Text = "TrendMicro Removal";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(396, 134);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(125, 125);
            this.button49.TabIndex = 17;
            this.button49.Text = "Webroot Removal";
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button49_Click_1);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button40);
            this.flowLayoutPanel5.Controls.Add(this.bluescreenButton);
            this.flowLayoutPanel5.Controls.Add(this.button39);
            this.flowLayoutPanel5.Controls.Add(this.button35);
            this.flowLayoutPanel5.Controls.Add(this.button46);
            this.flowLayoutPanel5.Controls.Add(this.button38);
            this.flowLayoutPanel5.Controls.Add(this.button12);
            this.flowLayoutPanel5.Controls.Add(this.button11);
            this.flowLayoutPanel5.Controls.Add(this.button41);
            this.flowLayoutPanel5.Controls.Add(this.button45);
            this.flowLayoutPanel5.Controls.Add(this.revoButton);
            this.flowLayoutPanel5.Controls.Add(this.button34);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 45);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(538, 402);
            this.flowLayoutPanel5.TabIndex = 17;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(3, 3);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(125, 125);
            this.button40.TabIndex = 5;
            this.button40.Text = "7-zip x86";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // bluescreenButton
            // 
            this.bluescreenButton.Location = new System.Drawing.Point(134, 3);
            this.bluescreenButton.Name = "bluescreenButton";
            this.bluescreenButton.Size = new System.Drawing.Size(125, 125);
            this.bluescreenButton.TabIndex = 1;
            this.bluescreenButton.Text = "Blue Screen View";
            this.bluescreenButton.UseVisualStyleBackColor = true;
            this.bluescreenButton.Click += new System.EventHandler(this.bluescreenButton_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(265, 3);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(125, 125);
            this.button39.TabIndex = 3;
            this.button39.Text = "Chrome - Portable";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(396, 3);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(125, 125);
            this.button35.TabIndex = 11;
            this.button35.Text = "CPorts";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click_1);
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(3, 134);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(125, 125);
            this.button46.TabIndex = 12;
            this.button46.Text = "CPU-z";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click_1);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(134, 134);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(125, 125);
            this.button38.TabIndex = 2;
            this.button38.Text = "Firefox - Portable";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(265, 134);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(125, 125);
            this.button12.TabIndex = 9;
            this.button12.Text = "USB to Gigabit Ethernet Driver";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(396, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 125);
            this.button11.TabIndex = 8;
            this.button11.Text = "PID Checker";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(3, 265);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(125, 125);
            this.button41.TabIndex = 6;
            this.button41.Text = "ProduKey";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click_1);
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(134, 265);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(125, 125);
            this.button45.TabIndex = 7;
            this.button45.Text = "ReadWrite\r\nEverything";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // revoButton
            // 
            this.revoButton.Location = new System.Drawing.Point(265, 265);
            this.revoButton.Name = "revoButton";
            this.revoButton.Size = new System.Drawing.Size(125, 125);
            this.revoButton.TabIndex = 1;
            this.revoButton.Text = "Revo Uninstaller";
            this.revoButton.UseVisualStyleBackColor = true;
            this.revoButton.Click += new System.EventHandler(this.revoButton_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(396, 265);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(125, 125);
            this.button34.TabIndex = 10;
            this.button34.Text = "WinDirStat";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.button47);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.button33);
            this.tabPage4.Controls.Add(this.button32);
            this.tabPage4.Controls.Add(this.button53);
            this.tabPage4.Controls.Add(this.button36);
            this.tabPage4.Controls.Add(this.button37);
            this.tabPage4.Controls.Add(this.labelWarning);
            this.tabPage4.Controls.Add(this.buttonViewHosts);
            this.tabPage4.Controls.Add(this.labelNetworkStats);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.buttonRunAll);
            this.tabPage4.Controls.Add(this.cbServicesDefault);
            this.tabPage4.Controls.Add(this.buttonServicesDefault);
            this.tabPage4.Controls.Add(this.cbResetInternetSecurity);
            this.tabPage4.Controls.Add(this.cbEnableWireless);
            this.tabPage4.Controls.Add(this.cbEnableLAN);
            this.tabPage4.Controls.Add(this.cbClearSSL);
            this.tabPage4.Controls.Add(this.cbReloadNETBIOS);
            this.tabPage4.Controls.Add(this.cbClearARP);
            this.tabPage4.Controls.Add(this.cbFlushDNS);
            this.tabPage4.Controls.Add(this.cbGoogleDNS);
            this.tabPage4.Controls.Add(this.cbSetDHCP);
            this.tabPage4.Controls.Add(this.cbClearHosts);
            this.tabPage4.Controls.Add(this.cbRenewDHCP);
            this.tabPage4.Controls.Add(this.buttonResetInternetSecurity);
            this.tabPage4.Controls.Add(this.buttonEnableWireless);
            this.tabPage4.Controls.Add(this.buttonEnableLAN);
            this.tabPage4.Controls.Add(this.buttonClearSSL);
            this.tabPage4.Controls.Add(this.buttonReloadNETBIOS);
            this.tabPage4.Controls.Add(this.buttonClearARP);
            this.tabPage4.Controls.Add(this.buttonFlushDNS);
            this.tabPage4.Controls.Add(this.buttonGoogleDNS);
            this.tabPage4.Controls.Add(this.buttonSetDHCP);
            this.tabPage4.Controls.Add(this.buttonClearHosts);
            this.tabPage4.Controls.Add(this.buttonRenewDHCP);
            this.tabPage4.Controls.Add(this.buttonPingDNS);
            this.tabPage4.Controls.Add(this.buttonPingIP);
            this.tabPage4.Controls.Add(this.textBoxDHCP);
            this.tabPage4.Controls.Add(this.textBoxSubnet);
            this.tabPage4.Controls.Add(this.textBoxDNS);
            this.tabPage4.Controls.Add(this.textBoxDefaultGW);
            this.tabPage4.Controls.Add(this.textBoxMac);
            this.tabPage4.Controls.Add(this.textBoxLocalIP);
            this.tabPage4.Controls.Add(this.textBoxHostname);
            this.tabPage4.Controls.Add(this.richTextBoxLogArea);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.buttonRefresh);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.comboBoxAdapters);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.menuStrip2);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1123, 658);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Network Utility";
            // 
            // button47
            // 
            this.button47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button47.AutoSize = true;
            this.button47.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button47.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button47.Location = new System.Drawing.Point(524, 55);
            this.button47.Margin = new System.Windows.Forms.Padding(4);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(101, 35);
            this.button47.TabIndex = 130;
            this.button47.Text = "Net Conct.";
            this.button47.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click_2);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(938, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 129;
            this.label4.Text = "EmoryUnplugged";
            // 
            // button33
            // 
            this.button33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button33.Location = new System.Drawing.Point(943, 130);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(157, 28);
            this.button33.TabIndex = 128;
            this.button33.Text = "Bradford";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click_1);
            // 
            // button32
            // 
            this.button32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button32.Location = new System.Drawing.Point(943, 164);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(157, 28);
            this.button32.TabIndex = 127;
            this.button32.Text = "McAfee";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click_1);
            // 
            // button53
            // 
            this.button53.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button53.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button53.Location = new System.Drawing.Point(15, 43);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(338, 70);
            this.button53.TabIndex = 125;
            this.button53.Text = "Quick Fix";
            this.button53.UseVisualStyleBackColor = true;
            this.button53.Click += new System.EventHandler(this.button53_Click);
            // 
            // button36
            // 
            this.button36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button36.Location = new System.Drawing.Point(943, 197);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(157, 28);
            this.button36.TabIndex = 8;
            this.button36.Text = "Delete Profiles";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button37.Location = new System.Drawing.Point(943, 231);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(157, 28);
            this.button37.TabIndex = 9;
            this.button37.Text = "Import Profile";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(229, 7);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(680, 23);
            this.labelWarning.TabIndex = 124;
            this.labelWarning.Text = "Warning Line";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonViewHosts
            // 
            this.buttonViewHosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonViewHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewHosts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewHosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewHosts.Location = new System.Drawing.Point(246, 183);
            this.buttonViewHosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewHosts.Name = "buttonViewHosts";
            this.buttonViewHosts.Size = new System.Drawing.Size(107, 30);
            this.buttonViewHosts.TabIndex = 123;
            this.buttonViewHosts.Text = "View";
            this.buttonViewHosts.UseVisualStyleBackColor = true;
            this.buttonViewHosts.Click += new System.EventHandler(this.buttonViewHosts_Click);
            // 
            // labelNetworkStats
            // 
            this.labelNetworkStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNetworkStats.Location = new System.Drawing.Point(360, 583);
            this.labelNetworkStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetworkStats.Name = "labelNetworkStats";
            this.labelNetworkStats.Size = new System.Drawing.Size(471, 25);
            this.labelNetworkStats.TabIndex = 121;
            this.labelNetworkStats.Text = "Sent: 0KB / 0MB | Received: 0KB / 0MB";
            this.labelNetworkStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(15, 127);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 13);
            this.label26.TabIndex = 120;
            this.label26.Text = "Additional Tools";
            // 
            // buttonRunAll
            // 
            this.buttonRunAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRunAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRunAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRunAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRunAll.Location = new System.Drawing.Point(38, 578);
            this.buttonRunAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRunAll.Name = "buttonRunAll";
            this.buttonRunAll.Size = new System.Drawing.Size(315, 30);
            this.buttonRunAll.TabIndex = 119;
            this.buttonRunAll.Text = "Run All Selected";
            this.buttonRunAll.UseVisualStyleBackColor = true;
            this.buttonRunAll.Click += new System.EventHandler(this.buttonRunAll_Click);
            // 
            // cbServicesDefault
            // 
            this.cbServicesDefault.AutoSize = true;
            this.cbServicesDefault.Location = new System.Drawing.Point(15, 546);
            this.cbServicesDefault.Margin = new System.Windows.Forms.Padding(4);
            this.cbServicesDefault.Name = "cbServicesDefault";
            this.cbServicesDefault.Size = new System.Drawing.Size(15, 14);
            this.cbServicesDefault.TabIndex = 118;
            this.cbServicesDefault.UseVisualStyleBackColor = true;
            // 
            // cbResetInternetSecurity
            // 
            this.cbResetInternetSecurity.AutoSize = true;
            this.cbResetInternetSecurity.Location = new System.Drawing.Point(15, 509);
            this.cbResetInternetSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.cbResetInternetSecurity.Name = "cbResetInternetSecurity";
            this.cbResetInternetSecurity.Size = new System.Drawing.Size(15, 14);
            this.cbResetInternetSecurity.TabIndex = 116;
            this.cbResetInternetSecurity.UseVisualStyleBackColor = true;
            // 
            // cbEnableWireless
            // 
            this.cbEnableWireless.AutoSize = true;
            this.cbEnableWireless.Location = new System.Drawing.Point(15, 473);
            this.cbEnableWireless.Margin = new System.Windows.Forms.Padding(4);
            this.cbEnableWireless.Name = "cbEnableWireless";
            this.cbEnableWireless.Size = new System.Drawing.Size(15, 14);
            this.cbEnableWireless.TabIndex = 115;
            this.cbEnableWireless.UseVisualStyleBackColor = true;
            // 
            // cbEnableLAN
            // 
            this.cbEnableLAN.AutoSize = true;
            this.cbEnableLAN.Location = new System.Drawing.Point(15, 438);
            this.cbEnableLAN.Margin = new System.Windows.Forms.Padding(4);
            this.cbEnableLAN.Name = "cbEnableLAN";
            this.cbEnableLAN.Size = new System.Drawing.Size(15, 14);
            this.cbEnableLAN.TabIndex = 114;
            this.cbEnableLAN.UseVisualStyleBackColor = true;
            // 
            // cbClearSSL
            // 
            this.cbClearSSL.AutoSize = true;
            this.cbClearSSL.Location = new System.Drawing.Point(15, 402);
            this.cbClearSSL.Margin = new System.Windows.Forms.Padding(4);
            this.cbClearSSL.Name = "cbClearSSL";
            this.cbClearSSL.Size = new System.Drawing.Size(15, 14);
            this.cbClearSSL.TabIndex = 113;
            this.cbClearSSL.UseVisualStyleBackColor = true;
            // 
            // cbReloadNETBIOS
            // 
            this.cbReloadNETBIOS.AutoSize = true;
            this.cbReloadNETBIOS.Location = new System.Drawing.Point(15, 366);
            this.cbReloadNETBIOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbReloadNETBIOS.Name = "cbReloadNETBIOS";
            this.cbReloadNETBIOS.Size = new System.Drawing.Size(15, 14);
            this.cbReloadNETBIOS.TabIndex = 112;
            this.cbReloadNETBIOS.UseVisualStyleBackColor = true;
            // 
            // cbClearARP
            // 
            this.cbClearARP.AutoSize = true;
            this.cbClearARP.Location = new System.Drawing.Point(15, 331);
            this.cbClearARP.Margin = new System.Windows.Forms.Padding(4);
            this.cbClearARP.Name = "cbClearARP";
            this.cbClearARP.Size = new System.Drawing.Size(15, 14);
            this.cbClearARP.TabIndex = 111;
            this.cbClearARP.UseVisualStyleBackColor = true;
            // 
            // cbFlushDNS
            // 
            this.cbFlushDNS.AutoSize = true;
            this.cbFlushDNS.Location = new System.Drawing.Point(15, 295);
            this.cbFlushDNS.Margin = new System.Windows.Forms.Padding(4);
            this.cbFlushDNS.Name = "cbFlushDNS";
            this.cbFlushDNS.Size = new System.Drawing.Size(15, 14);
            this.cbFlushDNS.TabIndex = 110;
            this.cbFlushDNS.UseVisualStyleBackColor = true;
            // 
            // cbGoogleDNS
            // 
            this.cbGoogleDNS.AutoSize = true;
            this.cbGoogleDNS.Location = new System.Drawing.Point(15, 259);
            this.cbGoogleDNS.Margin = new System.Windows.Forms.Padding(4);
            this.cbGoogleDNS.Name = "cbGoogleDNS";
            this.cbGoogleDNS.Size = new System.Drawing.Size(15, 14);
            this.cbGoogleDNS.TabIndex = 109;
            this.cbGoogleDNS.UseVisualStyleBackColor = true;
            // 
            // cbSetDHCP
            // 
            this.cbSetDHCP.AutoSize = true;
            this.cbSetDHCP.Location = new System.Drawing.Point(15, 224);
            this.cbSetDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.cbSetDHCP.Name = "cbSetDHCP";
            this.cbSetDHCP.Size = new System.Drawing.Size(15, 14);
            this.cbSetDHCP.TabIndex = 108;
            this.cbSetDHCP.UseVisualStyleBackColor = true;
            // 
            // cbClearHosts
            // 
            this.cbClearHosts.AutoSize = true;
            this.cbClearHosts.Location = new System.Drawing.Point(15, 188);
            this.cbClearHosts.Margin = new System.Windows.Forms.Padding(4);
            this.cbClearHosts.Name = "cbClearHosts";
            this.cbClearHosts.Size = new System.Drawing.Size(15, 14);
            this.cbClearHosts.TabIndex = 107;
            this.cbClearHosts.UseVisualStyleBackColor = true;
            // 
            // cbRenewDHCP
            // 
            this.cbRenewDHCP.AutoSize = true;
            this.cbRenewDHCP.Location = new System.Drawing.Point(15, 151);
            this.cbRenewDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.cbRenewDHCP.Name = "cbRenewDHCP";
            this.cbRenewDHCP.Size = new System.Drawing.Size(15, 14);
            this.cbRenewDHCP.TabIndex = 106;
            this.cbRenewDHCP.UseVisualStyleBackColor = true;
            // 
            // buttonEnableWireless
            // 
            this.buttonEnableWireless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnableWireless.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnableWireless.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEnableWireless.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnableWireless.Location = new System.Drawing.Point(38, 468);
            this.buttonEnableWireless.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnableWireless.Name = "buttonEnableWireless";
            this.buttonEnableWireless.Size = new System.Drawing.Size(315, 30);
            this.buttonEnableWireless.TabIndex = 104;
            this.buttonEnableWireless.Text = "Enable Wireless Adapters";
            this.buttonEnableWireless.UseVisualStyleBackColor = true;
            this.buttonEnableWireless.Click += new System.EventHandler(this.buttonEnableWireless_Click);
            // 
            // buttonEnableLAN
            // 
            this.buttonEnableLAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnableLAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnableLAN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEnableLAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnableLAN.Location = new System.Drawing.Point(38, 432);
            this.buttonEnableLAN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnableLAN.Name = "buttonEnableLAN";
            this.buttonEnableLAN.Size = new System.Drawing.Size(315, 30);
            this.buttonEnableLAN.TabIndex = 103;
            this.buttonEnableLAN.Text = "Enable LAN Adapters";
            this.buttonEnableLAN.UseVisualStyleBackColor = true;
            this.buttonEnableLAN.Click += new System.EventHandler(this.buttonEnableLAN_Click);
            // 
            // buttonClearHosts
            // 
            this.buttonClearHosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearHosts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearHosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearHosts.Location = new System.Drawing.Point(38, 183);
            this.buttonClearHosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearHosts.Name = "buttonClearHosts";
            this.buttonClearHosts.Size = new System.Drawing.Size(200, 30);
            this.buttonClearHosts.TabIndex = 96;
            this.buttonClearHosts.Text = "Clear Hosts File";
            this.buttonClearHosts.UseVisualStyleBackColor = true;
            this.buttonClearHosts.Click += new System.EventHandler(this.buttonClearHosts_Click);
            // 
            // buttonPingDNS
            // 
            this.buttonPingDNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPingDNS.AutoSize = true;
            this.buttonPingDNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPingDNS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPingDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPingDNS.Location = new System.Drawing.Point(742, 55);
            this.buttonPingDNS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPingDNS.Name = "buttonPingDNS";
            this.buttonPingDNS.Size = new System.Drawing.Size(101, 35);
            this.buttonPingDNS.TabIndex = 92;
            this.buttonPingDNS.Text = "Ping DNS";
            this.buttonPingDNS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPingDNS.UseVisualStyleBackColor = true;
            this.buttonPingDNS.Click += new System.EventHandler(this.buttonPingDNS_Click);
            // 
            // buttonPingIP
            // 
            this.buttonPingIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPingIP.AutoSize = true;
            this.buttonPingIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPingIP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPingIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPingIP.Location = new System.Drawing.Point(633, 55);
            this.buttonPingIP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPingIP.Name = "buttonPingIP";
            this.buttonPingIP.Size = new System.Drawing.Size(101, 35);
            this.buttonPingIP.TabIndex = 91;
            this.buttonPingIP.Text = "Ping IP";
            this.buttonPingIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPingIP.UseVisualStyleBackColor = true;
            this.buttonPingIP.Click += new System.EventHandler(this.buttonPingIP_Click);
            // 
            // textBoxDHCP
            // 
            this.textBoxDHCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDHCP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDHCP.Location = new System.Drawing.Point(524, 292);
            this.textBoxDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDHCP.Name = "textBoxDHCP";
            this.textBoxDHCP.ReadOnly = true;
            this.textBoxDHCP.Size = new System.Drawing.Size(374, 19);
            this.textBoxDHCP.TabIndex = 90;
            // 
            // textBoxSubnet
            // 
            this.textBoxSubnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSubnet.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSubnet.Location = new System.Drawing.Point(524, 324);
            this.textBoxSubnet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubnet.Name = "textBoxSubnet";
            this.textBoxSubnet.ReadOnly = true;
            this.textBoxSubnet.Size = new System.Drawing.Size(374, 19);
            this.textBoxSubnet.TabIndex = 85;
            // 
            // textBoxDNS
            // 
            this.textBoxDNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDNS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDNS.Location = new System.Drawing.Point(524, 260);
            this.textBoxDNS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDNS.Name = "textBoxDNS";
            this.textBoxDNS.ReadOnly = true;
            this.textBoxDNS.Size = new System.Drawing.Size(374, 19);
            this.textBoxDNS.TabIndex = 84;
            // 
            // textBoxDefaultGW
            // 
            this.textBoxDefaultGW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDefaultGW.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDefaultGW.Location = new System.Drawing.Point(524, 228);
            this.textBoxDefaultGW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDefaultGW.Name = "textBoxDefaultGW";
            this.textBoxDefaultGW.ReadOnly = true;
            this.textBoxDefaultGW.Size = new System.Drawing.Size(374, 19);
            this.textBoxDefaultGW.TabIndex = 83;
            // 
            // textBoxMac
            // 
            this.textBoxMac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMac.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMac.Location = new System.Drawing.Point(524, 196);
            this.textBoxMac.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.ReadOnly = true;
            this.textBoxMac.Size = new System.Drawing.Size(374, 19);
            this.textBoxMac.TabIndex = 82;
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLocalIP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLocalIP.Location = new System.Drawing.Point(524, 164);
            this.textBoxLocalIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.ReadOnly = true;
            this.textBoxLocalIP.Size = new System.Drawing.Size(374, 19);
            this.textBoxLocalIP.TabIndex = 81;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHostname.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxHostname.Location = new System.Drawing.Point(524, 98);
            this.textBoxHostname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.ReadOnly = true;
            this.textBoxHostname.Size = new System.Drawing.Size(374, 19);
            this.textBoxHostname.TabIndex = 80;
            // 
            // richTextBoxLogArea
            // 
            this.richTextBoxLogArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxLogArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxLogArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLogArea.ForeColor = System.Drawing.Color.White;
            this.richTextBoxLogArea.Location = new System.Drawing.Point(379, 371);
            this.richTextBoxLogArea.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxLogArea.Name = "richTextBoxLogArea";
            this.richTextBoxLogArea.ReadOnly = true;
            this.richTextBoxLogArea.Size = new System.Drawing.Size(519, 203);
            this.richTextBoxLogArea.TabIndex = 13;
            this.richTextBoxLogArea.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(372, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "DHCP Server";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(371, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Current Network Settings";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(851, 55);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(47, 35);
            this.buttonRefresh.TabIndex = 71;
            this.buttonRefresh.Text = "↻";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.UseCompatibleTextRendering = true;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(372, 134);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 88;
            this.label14.Text = "Network Adapter";
            // 
            // comboBoxAdapters
            // 
            this.comboBoxAdapters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAdapters.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdapters.FormattingEnabled = true;
            this.comboBoxAdapters.Location = new System.Drawing.Point(524, 130);
            this.comboBoxAdapters.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAdapters.Name = "comboBoxAdapters";
            this.comboBoxAdapters.Size = new System.Drawing.Size(374, 21);
            this.comboBoxAdapters.TabIndex = 87;
            this.comboBoxAdapters.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdapters_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(374, 324);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 86;
            this.label15.Text = "Subnet Mask";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(372, 263);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 78;
            this.label16.Text = "DNS Servers";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(372, 231);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 77;
            this.label17.Text = "Default Gateway";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(372, 199);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "MAC Address";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(372, 167);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 75;
            this.label19.Text = "Local IP Address";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(372, 102);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 74;
            this.label20.Text = "Computer Host Name";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1123, 41);
            this.menuStrip2.TabIndex = 126;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(159, 32);
            this.toolStripStatusLabel.Text = "NetAdapter Repair All in One";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(133, 34);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.button21);
            this.tabPage2.Controls.Add(this.lstDisplayHardware);
            this.tabPage2.Controls.Add(this.flowLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1123, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drive Tools";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(1019, 6);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 24);
            this.button21.TabIndex = 6;
            this.button21.Text = "Refresh";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click_1);
            // 
            // lstDisplayHardware
            // 
            this.lstDisplayHardware.BackColor = System.Drawing.Color.Silver;
            this.lstDisplayHardware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDisplayHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDisplayHardware.Location = new System.Drawing.Point(197, 6);
            this.lstDisplayHardware.Margin = new System.Windows.Forms.Padding(4);
            this.lstDisplayHardware.Name = "lstDisplayHardware";
            this.lstDisplayHardware.Size = new System.Drawing.Size(917, 642);
            this.lstDisplayHardware.TabIndex = 5;
            this.lstDisplayHardware.UseCompatibleStateImageBehavior = false;
            this.lstDisplayHardware.View = System.Windows.Forms.View.Details;
            this.lstDisplayHardware.SelectedIndexChanged += new System.EventHandler(this.lstDisplayHardware_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 503;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button31);
            this.flowLayoutPanel3.Controls.Add(this.button30);
            this.flowLayoutPanel3.Controls.Add(this.button24);
            this.flowLayoutPanel3.Controls.Add(this.button13);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(183, 137);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(3, 3);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(156, 29);
            this.button31.TabIndex = 2;
            this.button31.Text = "Defraggler";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(3, 38);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(156, 29);
            this.button30.TabIndex = 4;
            this.button30.Text = "CHKDSK /f";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(3, 73);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(156, 29);
            this.button24.TabIndex = 1;
            this.button24.Text = "SFC /SCANNOW";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 108);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(156, 29);
            this.button13.TabIndex = 3;
            this.button13.Text = "CrystalDiskInfo";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1123, 658);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Virus Removal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mailGroupBox);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 636);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TRON";
            // 
            // mailGroupBox
            // 
            this.mailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mailGroupBox.Controls.Add(this.label21);
            this.mailGroupBox.Controls.Add(this.mailSubjectBox);
            this.mailGroupBox.Controls.Add(this.button19);
            this.mailGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailGroupBox.Location = new System.Drawing.Point(6, 469);
            this.mailGroupBox.Name = "mailGroupBox";
            this.mailGroupBox.Size = new System.Drawing.Size(409, 75);
            this.mailGroupBox.TabIndex = 3;
            this.mailGroupBox.TabStop = false;
            this.mailGroupBox.Text = "Mail Settings";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Subject:";
            // 
            // mailSubjectBox
            // 
            this.mailSubjectBox.Location = new System.Drawing.Point(100, 21);
            this.mailSubjectBox.Name = "mailSubjectBox";
            this.mailSubjectBox.Size = new System.Drawing.Size(244, 19);
            this.mailSubjectBox.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.checkBox15);
            this.panel3.Controls.Add(this.checkBox9);
            this.panel3.Controls.Add(this.checkBox14);
            this.panel3.Controls.Add(this.checkBox16);
            this.panel3.Controls.Add(this.checkBox18);
            this.panel3.Controls.Add(this.checkBox11);
            this.panel3.Controls.Add(this.checkBox21);
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox17);
            this.panel3.Controls.Add(this.checkBox23);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox20);
            this.panel3.Controls.Add(this.checkBox10);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox12);
            this.panel3.Controls.Add(this.checkBox19);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox13);
            this.panel3.Controls.Add(this.button20);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.checkBox22);
            this.panel3.Location = new System.Drawing.Point(6, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 400);
            this.panel3.TabIndex = 27;

        // CHECK BOXES
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Tag = "-a";
            this.checkBox1.Text = "-a Automatic Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(306, 202);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Tag = "-c";
            this.checkBox2.Text = "-c Config Dump";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(306, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Tag = "-d";
            this.checkBox3.Text = "-d Dry Run";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(15, 283);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(103, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Tag = "-e";
            this.checkBox4.Text = "-e Accept EULA";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(306, 256);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(110, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Tag = "-er";
            this.checkBox5.Text = "-er Email a Report";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(306, 67);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(155, 17);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Tag = "-dev";
            this.checkBox6.Text = "-dev Override OS detection";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(306, 13);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(216, 17);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Tag = "-h";
            this.checkBox7.Text = "-h Display help text (must be used alone)";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(15, 148);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(186, 17);
            this.checkBox8.TabIndex = 11;
            this.checkBox8.Tag = "-m";
            this.checkBox8.Text = "-m Preserve default METRO Apps";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(306, 276);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(104, 24);
            this.checkBox9.TabIndex = 19;
            this.checkBox9.Tag = "-ss";
            this.checkBox9.Text = "-ss Skip Sophos";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(15, 40);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(158, 17);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Tag = "-str";
            this.checkBox10.Text = "-str Skip Telemetry Removal";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(15, 175);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(215, 17);
            this.checkBox11.TabIndex = 14;
            this.checkBox11.Tag = "-p";
            this.checkBox11.Text = "-p Preserve power settings ( don\'t reset )";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(306, 94);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(134, 17);
            this.checkBox12.TabIndex = 27;
            this.checkBox12.Tag = "-sm";
            this.checkBox12.Text = "-sm Skip Malwarebytes";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(306, 148);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(111, 17);
            this.checkBox13.TabIndex = 16;
            this.checkBox13.Tag = "-sa";
            this.checkBox13.Text = "-sa Skip Anti-Virus";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(15, 67);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(114, 17);
            this.checkBox14.TabIndex = 17;
            this.checkBox14.Tag = "-sdb";
            this.checkBox14.Text = "-sdb Skip De-Bloat";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(15, 229);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(111, 17);
            this.checkBox15.TabIndex = 18;
            this.checkBox15.Tag = "-sd";
            this.checkBox15.Text = "-sd Skip DEFRAG";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16.Location = new System.Drawing.Point(15, 121);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(143, 17);
            this.checkBox16.TabIndex = 19;
            this.checkBox16.Tag = "-se";
            this.checkBox16.Text = "-se Skip Event Log Clear";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Location = new System.Drawing.Point(306, 121);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(160, 17);
            this.checkBox17.TabIndex = 20;
            this.checkBox17.Tag = "-sp";
            this.checkBox17.Text = "-sp Skip Patch Management";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Location = new System.Drawing.Point(15, 94);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(159, 17);
            this.checkBox18.TabIndex = 21;
            this.checkBox18.Tag = "-sfr";
            this.checkBox18.Text = "-sfr Skip FS Permission reset";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Location = new System.Drawing.Point(15, 310);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(140, 17);
            this.checkBox19.TabIndex = 22;
            this.checkBox19.Tag = "-spr";
            this.checkBox19.Text = "-spr Skip Page File reset";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Location = new System.Drawing.Point(306, 175);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(184, 17);
            this.checkBox20.TabIndex = 23;
            this.checkBox20.Tag = "-srr";
            this.checkBox20.Text = "-srr Skip Registry Permission reset";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.Location = new System.Drawing.Point(15, 202);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(131, 17);
            this.checkBox21.TabIndex = 24;
            this.checkBox21.Tag = "-sw";
            this.checkBox21.Text = "-sw Skip Win Updates";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.Location = new System.Drawing.Point(15, 256);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(112, 17);
            this.checkBox22.TabIndex = 25;
            this.checkBox22.Tag = "-v";
            this.checkBox22.Text = "-v Verbose Output (significantly slower)";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox23.Location = new System.Drawing.Point(306, 229);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(156, 17);
            this.checkBox23.TabIndex = 26;
            this.checkBox23.Tag = "-sdc";
            this.checkBox23.Text = "-sdc Skip DISM component";
            this.checkBox23.UseVisualStyleBackColor = true;
            
            
           
            
            
           
            
            
           
            
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(529, 348);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(126, 37);
            this.button20.TabIndex = 27;
            this.button20.Text = "STS Settings";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button48);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button27);
            this.groupBox3.Controls.Add(this.button29);
            this.groupBox3.Controls.Add(this.adwButton);
            this.groupBox3.Controls.Add(this.RogueKiller);
            this.groupBox3.Controls.Add(this.button44);
            this.groupBox3.Controls.Add(this.button26);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(698, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 636);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quick Virus Removal";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button48
            // 
            this.button48.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button48.Location = new System.Drawing.Point(21, 298);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(112, 28);
            this.button48.TabIndex = 35;
            this.button48.Text = "Junkware Removal";
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Step 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Step 1:";
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(221, 194);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(112, 28);
            this.button27.TabIndex = 3;
            this.button27.Text = "Malwarebytes";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(221, 228);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(112, 28);
            this.button29.TabIndex = 5;
            this.button29.Text = "McAfee Enterprise";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // adwButton
            // 
            this.adwButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adwButton.Location = new System.Drawing.Point(21, 194);
            this.adwButton.Name = "adwButton";
            this.adwButton.Size = new System.Drawing.Size(112, 29);
            this.adwButton.TabIndex = 1;
            this.adwButton.Text = "AdwCleaner";
            this.adwButton.UseVisualStyleBackColor = true;
            this.adwButton.Click += new System.EventHandler(this.adwButton_Click);
            // 
            // RogueKiller
            // 
            this.RogueKiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RogueKiller.Location = new System.Drawing.Point(21, 229);
            this.RogueKiller.Name = "RogueKiller";
            this.RogueKiller.Size = new System.Drawing.Size(112, 29);
            this.RogueKiller.TabIndex = 1;
            this.RogueKiller.Text = "RogueKiller";
            this.RogueKiller.UseVisualStyleBackColor = true;
            this.RogueKiller.Click += new System.EventHandler(this.RogueKiller_Click);
            // 
            // button44
            // 
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.Location = new System.Drawing.Point(21, 79);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(112, 28);
            this.button44.TabIndex = 32;
            this.button44.Text = "Rkill";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click_1);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(21, 264);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(112, 28);
            this.button26.TabIndex = 2;
            this.button26.Text = "HitmanPro";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Installer";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Portable";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1123, 658);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Summary";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 626);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Information";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(705, 607);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Hypo - ToolBox\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(803, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 392);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Utilities";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button25);
            this.flowLayoutPanel1.Controls.Add(this.button51);
            this.flowLayoutPanel1.Controls.Add(this.button52);
            this.flowLayoutPanel1.Controls.Add(this.button50);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 373);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button51
            // 
            this.button51.ForeColor = System.Drawing.Color.Black;
            this.button51.Location = new System.Drawing.Point(141, 258);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(132, 45);
            this.button51.TabIndex = 11;
            this.button51.Text = "Command Prompt";
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.button51_Click);
            // 
            // button52
            // 
            this.button52.ForeColor = System.Drawing.Color.Black;
            this.button52.Location = new System.Drawing.Point(3, 309);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(132, 45);
            this.button52.TabIndex = 12;
            this.button52.Text = "Copy ProduKey to clipboard";
            this.button52.UseVisualStyleBackColor = true;
            this.button52.Click += new System.EventHandler(this.button52_Click);
            // 
            // button50
            // 
            this.button50.ForeColor = System.Drawing.Color.Black;
            this.button50.Location = new System.Drawing.Point(141, 309);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(132, 45);
            this.button50.TabIndex = 13;
            this.button50.Text = "msconfig";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.usefulToolsTab);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 684);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // hypo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1131, 708);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(854, 530);
            this.Name = "hypo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hypo";
            this.Load += new System.EventHandler(this.hypo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.usefulToolsTab.ResumeLayout(false);
            this.usefulToolsTab.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.mailGroupBox.ResumeLayout(false);
            this.mailGroupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void lstDisplayHardware_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button21_Click_1(object sender, EventArgs e)
    {
        this.InsertInfo(ref lstDisplayHardware, true);
    }

    private void button31_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Defraggler.exe");
    }

    private void testLabel_Click(object sender, EventArgs e)
    {
      
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button27_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "MWB Setup.exe");
    }

    private void button29_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "McAfeeENS10_Tech_9-15-2016.exe");
    }

    private void button32_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "McAfeeENS10_Tech_9-15-2016.exe");
    }

    private void button33_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Bradford_Windows.exe");
    }

    private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button34_Click(object sender, EventArgs e)
    {
        String path = Path.GetDirectoryName(Application.ExecutablePath);
        using (Process process = new Process())
        {
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
            process.Start();
            process.StandardInput.WriteLine("netsh wlan add profile filename=Wi-Fi-EmoryUnplugged.xml user=all");
            process.BeginOutputReadLine();
        }
    }

    private void label23_Click(object sender, EventArgs e)
    {

    }

    private void button35_Click(object sender, EventArgs e)
    {
        String path = Path.GetDirectoryName(Application.ExecutablePath);
        using (Process process = new Process())
        {
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
            process.Start();
            process.StandardInput.WriteLine("netsh wlan delete profile name=EmoryUnplugged");
            process.StandardInput.WriteLine("netsh wlan delete profile name=EmoryGuest");
            process.StandardInput.WriteLine("netsh wlan delete profile name=eduroam");
            process.StandardInput.WriteLine("netsh wlan delete profile name=DooleyNet");
            process.BeginOutputReadLine();
        }
    }

    private void button36_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        String path = Path.GetDirectoryName(Application.ExecutablePath);
        
        using (Process process = new Process())
        {
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
            process.Start();
            process.StandardInput.WriteLine("netsh wlan delete profile name=Emory*");
            process.StandardInput.WriteLine("netsh wlan delete profile name=STS*");
            process.StandardInput.WriteLine("netsh wlan delete profile name=eduroam");
            process.StandardInput.WriteLine("netsh wlan delete profile name=DooleyNet");
            process.BeginOutputReadLine();
            //output = process.StandardOutput.ReadToEnd();
        }

        //MessageBox.Show(output, "Done", MessageBoxButtons.OK);
    }

    private void button37_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        String path = Path.GetDirectoryName(Application.ExecutablePath);
        string xmlPath = this.findFile("Wi-Fi-EmoryUnplugged.xml");
        //xmlPath = "Wi-Fi-EmoryUnplugged.xml";
        using (Process process = new Process())
        {
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
            process.Start();
            process.StandardInput.WriteLine(String.Format("netsh wlan add profile filename={0} user=all", xmlPath));
            process.BeginOutputReadLine();
        }
        //MessageBox.Show("Imported EmoryUnplugged", "Done", MessageBoxButtons.OK);
    }

    private void button38_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "FirefoxPortable.exe");
    }

    private void button39_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "GoogleChromePortable.exe");
    }

    private void button40_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "7zFM.exe");
    }

    private void button41_Click_1(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "ProduKey.exe");
    }

    private void textBox11_TextChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Close();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button25_Click_1(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        this.bootSafeMode();
    }

    
    private void button42_Click(object sender, EventArgs e)
    {
        ListView.CheckedListViewItemCollection checkedItems = 
			listView1.CheckedItems;
        
        foreach (ListViewItem item in checkedItems)
        {
            if (item.Group.ToString() == "Global startup items")
            {
                const string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey(runKey,true);

                startupKey.DeleteValue(item.Text, false);

                startupKey.Close();
            }
            else if (item.Group.ToString() == "32 bit Global startup items" )
            {
                const string runKey = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";

                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey(runKey, true);

                startupKey.DeleteValue(item.Text, false);

                startupKey.Close();
            }
            else
            {
                const string runKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

                RegistryKey startupKey = Registry.CurrentUser.OpenSubKey(runKey, true);

                startupKey.DeleteValue(item.Text, false);

                startupKey.Close();
            }
            
            
        }
        listView1.Items.Clear();
        this.runGrabStartupPrograms();
        this.runGrabStartupPrograms2();
        this.runGrabStartupPrograms3();
    }

    private void button43_Click(object sender, EventArgs e)
    {

        listView1.Items.Clear();
        this.runGrabStartupPrograms();
        this.runGrabStartupPrograms2();
        this.runGrabStartupPrograms3();
    }

    private void button16_Click(object sender, EventArgs e)
    {

    }

    private void button26_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        if (System.Environment.Is64BitOperatingSystem)
        {
            this.runProgramButton(sender, "HitmanPro_x64.exe");
        }
        else
        {
            this.runProgramButton(sender, "HitmanPro.exe");
        }
    }

    private void button44_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "rkill.com");
    }

    private void button45_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Rw.exe");
    }

    private void button46_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "AVG Removal Tool.exe");
    }

    private void button49_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "SEP Cleanwipe.exe");
    }

    private void button47_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "McAfee Removal Tool.exe");
    }

    private void button48_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Norton Removal Tool.exe");
    }

    private void button50_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "TrendMicro Removal Tool.exe");
    }

    private void button51_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        Process.Start("cmd.exe");
    }

    private void button52_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        string groups = "";
        foreach (var line in File.ReadAllLines(this.findFile("ProdKey.txt")))

        {
            if (line.Contains("Product Key")) 
            {
                groups = line.Replace("Product Key       : ", "");
            }
        }

        Console.WriteLine(String.Format("Copied \"{0}\" to clipboard.",groups));
        Clipboard.SetText(groups);
    }

    private void pIDCheckerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "pidgen.exe");
    }

    private void button22_Click_1(object sender, EventArgs e)
    {
        DoClearHosts();
    }

    private void comboBoxAdapters_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        NetworkInterface nic = GetNic((string)comboBoxAdapters.SelectedItem);
        if (nic != null)
        {
            IPv4InterfaceStatistics ipStats = nic.GetIPv4Statistics();
            if (ipStats != null)
            {
                BytesSent = ipStats.BytesSent;
                BytesReceived = ipStats.BytesReceived;
            }
        }
        RefreshAdapterInfo((string)comboBoxAdapters.SelectedItem);
    
    }

    private void buttonRenewDHCP_Click(object sender, EventArgs e)
    {
        DoRenewDHCP();
    }
    private void DoRenewDHCP()
    {
        LogMessage("Releasing IP addresses");
        ChangeStatus("Releasing IP addresses", 50);
        String result;

        result = RunCommand("ipconfig.exe", " /release");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred releasing IP addresses");
            LogMessage(result);
        };

        LogMessage("Renewing IP addresses");
        ChangeStatus("Renewing IP addresses", 90);
        result = RunCommand("ipconfig.exe", " /renew");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred renewing IP addresses");
            LogMessage(result);
        };

        LogMessage("Released and renewed all adapters");
        ChangeStatus("Ready", 0);
    }
    private string[] GetRasNames()
    {
        string sPBKPath = Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Roaming\\Microsoft\\Network\\Connections\\Pbk\\rasphone.pbk";
        List<string> list = new List<string>();
        if (File.Exists(sPBKPath))
        {
            using (StreamReader sr = File.OpenText(sPBKPath))
            {
                String input;
                while ((input = sr.ReadLine()) != null)
                {
                    if (input.StartsWith("[") && input.EndsWith("]"))
                    {
                        list.Add(input.Substring(1, input.Length - 2));
                    }
                }
            }
        }
        return list.ToArray();
    }
    private void buttonRepair_Click(object sender, EventArgs e)
    {
        DialogResult dlg;
        dlg = MessageBox.Show("You are about to run the following:\n"
                            + "\n"
                            + "1. WinSock/TCP IP Repair\n"
                            + "2. Clear all Proxy/VPN Settings\n"
                            + "3. Windows Firewall Repair\n"
                            + "\n"
                            + "Note: Restart required to complete repair\n"
                            + "\n"
                            + "Do you want to continue?",
                              "Information",
                              MessageBoxButtons.OKCancel,
                              MessageBoxIcon.Question);

        // Quit if the user clicks Cancel
        if (dlg == DialogResult.Cancel) return;

        String result;

        // STEP 1: Reset TCP/IP and WinSock using NETSH commands
        LogMessage("Resetting TCP/IP");
        ChangeStatus("Resetting TCP/IP", 25);

        result = RunCommand("ipconfig", "/flushdns");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred flushing DNS cache");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ipv4 reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ipv6 reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ip reset c:\\resetlog.txt");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ip reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int 6to4 reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP (6to4)");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int httpstunnel reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting HTTPSTunnel");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int isatap reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting ISATAP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int tcp reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int teredo reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting Teredo");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int portproxy reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting PortProxy");
            LogMessage(result);
        };

        result = RunCommand("netsh", "branchcache reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting BranchCache");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winhttp reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinHTTP");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset c:\\winsock.log");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset catalog");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };

        LogMessage("Reset TCP/IP");


        // STEP 2: Clear all Internet Explorer proxy settings by modifying registry
        // See support.microsoft.com/kb/2289942 for details
        LogMessage("Clearing Internet Explorer proxy/VPN settings");
        ChangeStatus("Clearing Internet Explorer proxy/VPN settings", 50);

        // Uncheck "Use a proxy server for LAN" setting
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v ProxyEnable /t REG_DWORD /d 0 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred disabling proxy settings.");
            LogMessage(result);
        };
        LogMessage("Disabled proxy settings.");

        // Delete any proxy servers
        result = RunCommand("reg", "delete \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v ProxyServer /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting proxy server");
            LogMessage(result);
        };
        LogMessage("Deleted proxy servers");

        // Uncheck "always dial my default connection" and set to "never dial a connection"
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v EnableAutodial /t REG_DWORD /d 0 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred disabling automatic dialing.");
            LogMessage(result);
        };
        LogMessage("Disabled automatic dialing.");

        // Delete all RAS connections
        string[] sRasList = GetRasNames();
        foreach (var ras in sRasList)
        {
            result = RunCommand("rasphone.exe", "-r \"" + ras + "\"");
            if (result.ToLower().Contains("error "))
            {
                LogMessage("An error occurred deleting RAS connection \"" + ras + "\"");
                LogMessage(result);
            };
        }
        LogMessage("Deleted all RAS connections");

        // Uncheck "Use automatic configuration script"
        result = RunCommand("reg", "delete \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v AutoConfigURL /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting automatic configuration settings");
            LogMessage(result);
        };
        LogMessage("Deleted automatic configuration settings");


        // STEP 3: Repair Windows Firewall service
        LogMessage("Repairing Windows Firewall service");
        ChangeStatus("Repairing Windows Firewall service", 75);
        string sINFPath = Environment.GetEnvironmentVariable("windir") + "\\inf\\netrass.inf";
        result = RunCommand("Rundll32.exe", "setupapi,InstallHinfSection Ndi-Steelhead 132 " + sINFPath);
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred registering Windows Firewall. Check log for details");
            LogMessage(result);
        };


        LogMessage("Resetting Windows Firewall service");
        ChangeStatus("Resetting Windows Firewall service", 80);
        result = RunCommand("netsh.exe", "firewall reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting Windows Firewall settings");
            LogMessage(result);
        };

        ChangeStatus("Resetting Windows Firewall service", 90);
        result = RunCommand("netsh.exe", "advfirewall reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting Windows Firewall settings");
            LogMessage(result);
        };

        LogMessage("Repaired Windows Firewall service");

        // Ask for restart confirmation
        FormRestartConfirmation dlgRestart = new FormRestartConfirmation(60);
        dlgRestart.ShowDialog();
        if (dlgRestart.ButtonPressed == 1)
        {
            LogMessage("Restarting the computer");
            ChangeStatus("Restarting the computer...", 100);
            RunCommand("cmd.exe", "/C shutdown /r /t 5");
        }
        else
        {
            MessageBox.Show("You should restart your computer manually.");
            LogMessage("Restart canceled by user");
        }

    }

    private void buttonReloadNETBIOS_Click(object sender, EventArgs e)
    {
        DoReloadNETBIOS();
    }

    private void DoReloadNETBIOS()
    {
        LogMessage("Reloading NetBIOS");
        ChangeStatus("Reloading NetBIOS", 50);
        String result;

        result = RunCommand("nbtstat.exe", "-R");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred reloading NetBIOS");
            LogMessage(result);
        };

        LogMessage("Releasing NetBIOS");
        ChangeStatus("Releasing NetBIOS", 90);
        result = RunCommand("nbtstat.exe", "-RR");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred releasing NetBIOS");
            LogMessage(result);
        };

        LogMessage("Reloaded and released NetBIOS");
        ChangeStatus("Ready", 0);
    }

    private void buttonClearHosts_Click(object sender, EventArgs e)
    {
        DoClearHosts();
    }

    


    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        RefreshNetworkInfo(true);
    }

    private void buttonViewHosts_Click(object sender, EventArgs e)
    {
        DoViewHosts();
    }

    private void DoViewHosts()
    {
        string sHostsPath = Environment.GetEnvironmentVariable("windir") + "\\System32\\Drivers\\Etc\\hosts";
        RunCommand("notepad.exe", sHostsPath);
    }

    private void buttonSetDHCP_Click(object sender, EventArgs e)
    {
        DoSetDHCP();
    }

    // Clears static IP settings and enable DHCP
    private void DoSetDHCP()
    {
        string nicName = (string)comboBoxAdapters.SelectedItem;
        NetworkInterface nicSelected;

        FormMessagebox dlg = new FormMessagebox("Clear Static IP Settings (enable DHCP)",
                                                "Do you want to clear static IP settings for all network "
                                              + "adapters or only the selected one?",
                                                "Only the Selected (" + nicName + ")",
                                                "All Network Adapters",
                                                "Cancel");
        dlg.ShowDialog();

        if (dlg.ButtonPressed == 0 || dlg.ButtonPressed == 3)
        {
            return;
        }

        LogMessage("Clearing static IP settings and set back to DHCP");
        ChangeStatus("Clearing static IP settings and set back to DHCP", 25);

        if (dlg.ButtonPressed == 1)
        {
            nicSelected = GetNic(nicName);
            EnableDHCP(nicSelected);
            LogMessage("Cleared static IP/DNS settings and set back to DHCP (" + nicName + ")");
        }
        else if (dlg.ButtonPressed == 2)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                EnableDHCP(nic);
            }
            LogMessage("Cleared static IP/DNS settings and set back to DHCP (All Adapters)");
            ChangeStatus("Ready", 0);
        }

        ChangeStatus("Ready", 0);
    }

    private void EnableDHCP(NetworkInterface nic)
    {
        IPInterfaceProperties ipProperties = nic.GetIPProperties();
        if (ipProperties != null)
        {
            try
            {
                //String dhcp = string.Join(", ", ipProperties.DhcpServerAddresses.Select(x => x.ToString()).OrderBy(x => x.Length));
                String ipAddress = string.Join(", ", ipProperties.UnicastAddresses.Select(x => x.Address.ToString()).OrderBy(x => x.Length));
                String dnsAddress = string.Join(", ", ipProperties.DnsAddresses.Select(x => x.ToString()).OrderBy(x => x.Length));
                String subnetMask = string.Join(", ", ipProperties.UnicastAddresses.Select(x => x.IPv4Mask.ToString()).Where(x => !x.Equals("0.0.0.0")));

                if (!ipAddress.Equals("") && !dnsAddress.Equals(""))
                {
                    LogMessage("Clearing static IP/DNS settings for '" + nic.Name + "'");
                    ChangeStatus("Clearing static IP/DNS settings for '" + nic.Name + "'", 50);
                    LogMessage("Existing settings for '" + nic.Name + "':");
                    if (!ipAddress.Equals(""))
                    {
                        LogMessage("IP Address: " + ipAddress);
                    }
                    if (!dnsAddress.Equals(""))
                    {
                        LogMessage("DNS Addresses: " + dnsAddress);
                    }
                    LogMessage("Subnet Mask: " + subnetMask);
                }

                RunCommand("netsh.exe", "interface ip set address \"" + nic.Name + "\" source=dhcp");

                if (!dnsAddress.Equals(""))
                {
                    LogMessage("Clearing DNS settings for '" + nic.Name + "'");
                    ChangeStatus("Clearing DNS settings for '" + nic.Name + "'", 50);
                }

                RunCommand("netsh.exe", "interface ip set dns \"" + nic.Name + "\" source=dhcp");
            }
            catch (Exception e)
            {
                LogMessage("There is an error getting IP/DNS settings. ");
                Console.WriteLine(e);
            }
        }
    }

    private void buttonGoogleDNS_Click(object sender, EventArgs e)
    {
        DoGoogleDNS();
    }
    private string[] GetAllAdapterNames()
    {
        string[] results = RunCommand("netsh.exe", "interface show interface").Split('\n');

        string[] names = new string[results.Count() - 5];
        for (int i = 3; i < results.Count() - 2; i++)
        {
            names[i - 3] = results[i].Substring(47, results[i].Length - 48);
        }

        return names;
    }
    private void DoGoogleDNS()
    {
        string nicName = (string)comboBoxAdapters.SelectedItem;

        FormMessagebox dlg = new FormMessagebox("Change to Emory DNS",
                                                "Do you want to set Emory DNS for all network "
                                              + "adapters or only the selected one?",
                                                "Only the Selected (" + nicName + ")",
                                                "All Network Adapters",
                                                "Cancel");
        dlg.ShowDialog();

        if (dlg.ButtonPressed == 0 || dlg.ButtonPressed == 3)
        {
            return;
        }

        LogMessage("Setting all DNS servers to Emory DNS");
        ChangeStatus("Setting all DNS servers to Emory DNS", 25);

        if (dlg.ButtonPressed == 1)
        {
            RunCommand("netsh.exe", "interface ip set dns \"" + nicName + "\" static 170.140.2.1 primary");
            RunCommand("netsh.exe", "interface ip add dns \"" + nicName + "\" 170.140.1.1 index=1");
            LogMessage("Set DNS servers to Emory DNS (" + nicName + ")");
        }
        else if (dlg.ButtonPressed == 2)
        {
            foreach (string adapter in GetAllAdapterNames())
            {
                LogMessage("Setting DNS server for '" + adapter + "'");
                ChangeStatus("Setting DNS server for '" + adapter + "'", 50);
                RunCommand("netsh.exe", "interface ip set dns \"" + adapter + "\" static 170.140.2.1 primary");
                RunCommand("netsh.exe", "interface ip add dns \"" + adapter + "\" 170.140.1.1 index=1");
            }

            LogMessage("Set DNS servers to Emory DNS (All Adapters)");
        }

        ChangeStatus("Ready", 0);
        RefreshNetworkInfo(true);
    }

    private void buttonFlushDNS_Click(object sender, EventArgs e)
    {
        DoFlushDNS();
    }

    private void DoFlushDNS()
    {
        LogMessage("Flushing DNS cache");
        ChangeStatus("Flushing DNS cache", 50);
        String result;

        result = RunCommand("ipconfig.exe", " /flushdns");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred flushing DNS cache");
            LogMessage(result);
        };

        LogMessage("Re-registering DNS names");
        ChangeStatus("Re-registering DNS names", 90);
        result = RunCommand("ipconfig.exe", " /registerdns");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred registering DNS names");
            LogMessage(result);
        };

        LogMessage("Flushed DNS cache and re-registered DNS names");
        ChangeStatus("Ready", 0);
    }

    private void buttonClearARP_Click(object sender, EventArgs e)
    {
        DoClearARP();
    }

    private void DoClearARP()
    {
        LogMessage("Clearing ARP cache");
        ChangeStatus("Clearing ARP cache", 50);
        String result;

        // Step 1
        result = RunCommand("netsh", "interface ip delete arpcache");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting ARP cache");
            LogMessage(result);
        };

        LogMessage("Cleared ARP Table cache");
        ChangeStatus("Cleared ARP Table cache", 70);

        // Step 2
        result = RunCommand("netsh", "interface ipv4 delete destinationcache");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting IPv4 DestinationCache");
            LogMessage(result);
        };

        result = RunCommand("netsh", "interface ipv6 delete destinationcache");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting IPv6 DestinationCache");
            LogMessage(result);
        };

        result = RunCommand("netsh", "interface ipv4 delete neighbors");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting IPv4 neighbors");
            LogMessage(result);
        };

        result = RunCommand("netsh", "interface ipv6 delete neighbors");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting IPv6 neighbors");
            LogMessage(result);
        };

        LogMessage("Route tables cleared");
        ChangeStatus("Route tables cleared", 90);

        LogMessage("Clearing the routing tables of all gateway entries");
        result = RunCommand("route.exe", " -f");
        if (result.ToLower().Contains("failed"))
        {
            LogMessage("An error occurred clearing routing tables");
            LogMessage(result);
        };

        LogMessage("Cleared ARP cache, routing tables and IP configuration");

        // Ask for restart confirmation
        FormRestartConfirmation dlgRestart = new FormRestartConfirmation(60);
        dlgRestart.ShowDialog();
        if (dlgRestart.ButtonPressed == 1)
        {
            LogMessage("Restarting the computer");
            ChangeStatus("Restarting the computer...", 100);
            RunCommand("cmd.exe", "/C shutdown /r /t 5");
        }
        else
        {
            MessageBox.Show("You should restart your computer manually.");
            LogMessage("Restart canceled by user");
        }

        ChangeStatus("Ready", 0);
    }


    // This procedure is removed per CB's request
    private void DoClearARP_OLD()
    {
        LogMessage("Clearing ARP cache");
        ChangeStatus("Clearing ARP cache", 50);
        String result;

        result = RunCommand("arp.exe", " -d *");
        if (result.ToLower().Contains("could not finish repairing "))
        {
            LogMessage("An error occurred clearing ARP cache");
            LogMessage(result);
        };

        LogMessage("Clearing the routing tables of all gateway entries");
        result = RunCommand("route.exe", " -f");
        if (result.ToLower().Contains("failed"))
        {
            LogMessage("An error occurred clearing routing tables");
            LogMessage(result);
        };

        LogMessage("Releasing and renewing the IP configuration");
        result = RunCommand("ipconfig.exe", " /release");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred releasing IP addresses");
            LogMessage(result);
        };

        result = RunCommand("ipconfig.exe", " /renew");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred renewing IP addresses");
            LogMessage(result);
        };

        LogMessage("Cleared ARP cache, routing tables and IP configuration");
        ChangeStatus("Ready", 0);
    }

    private void buttonClearSSL_Click(object sender, EventArgs e)
    {
        DoClearSSL();
    }

    private void DoClearSSL()
    {
        LogMessage("Clearing SSL state cache");
        ChangeStatus("Clearing SSL state cache", 50);

        string sDllPath = Environment.GetEnvironmentVariable("windir") + "\\system32\\wininet.dll";
        String result = RunCommand("Rundll32.exe", "\"" + sDllPath + "\",DispatchAPICall 3");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred clearing SSL state cache");
            LogMessage(result);
        };

        LogMessage("Cleared SSL state cache");
        ChangeStatus("Ready", 0);
    }

    private void buttonEnableLAN_Click(object sender, EventArgs e)
    {
        DoEnableLAN();
    }

    private void DoEnableLAN()
    {
        LogMessage("Enabling LAN adapters");
        ChangeStatus("Enabling LAN adapters", 25);

        string[] adapters = GetAllAdapterNames();

        foreach (string adapter in adapters)
        {
            if (!adapter.ToLower().Contains("wireless"))
            {
                LogMessage("Enabling '" + adapter + "'.");
                ChangeStatus("Enabling '" + adapter + "'.", 50);
                if (!SetNicStatus(adapter, true))
                {
                    LogMessage("Error enabling " + adapter);
                }
                string result = RunCommand("netsh.exe", "interface set interface \"" + adapter + "\" ENABLED");
            }
        }

        RefreshNetworkInfo(true);
        LogMessage("Enabled LAN adapters");
        ChangeStatus("Ready", 0);
    }
    private Shell32.Folder GetShell32NameSpaceFolder(Object folder)
    {
        Type shellAppType = Type.GetTypeFromProgID("Shell.Application");

        Object shell = Activator.CreateInstance(shellAppType);
        return (Shell32.Folder)shellAppType.InvokeMember("NameSpace",
        System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
    } 
    private bool SetNicStatus(string nicName, bool status)
    {
        const string verbDisable = "Disa&ble";
        const string verbEnable = "En&able";

        string sVerb = null;

        if (status)
        {
            sVerb = verbEnable;
        }
        else
        {
            sVerb = verbDisable;
        }

        Type ShellAppType = Type.GetTypeFromProgID("Shell.Application");
        Object sh = Activator.CreateInstance(ShellAppType);
        Shell32.Folder folder = GetShell32NameSpaceFolder(Shell32.ShellSpecialFolderConstants.ssfCONTROLS);

        try
        {
            foreach (Shell32.FolderItem myItem in folder.Items())
            {
                if (myItem.Name == "Network Connections")
                {
                    Shell32.Folder fd = (Shell32.Folder)myItem.GetFolder;
                    foreach (Shell32.FolderItem fi in fd.Items())
                    {
                        if ((fi.Name == nicName))
                        {
                            foreach (Shell32.FolderItemVerb Fib in fi.Verbs())
                            {
                                if (Fib.Name == sVerb)
                                {
                                    Fib.DoIt();
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        return true;
    }   
    private void buttonEnableWireless_Click(object sender, EventArgs e)
    {
        DoEnableWireless();
    }

    private void DoEnableWireless()
    {
        LogMessage("Enabling wireless adapters");
        ChangeStatus("Enabling wireless adapters", 25);

        string[] adapters = GetAllAdapterNames();

        foreach (string adapter in adapters)
        {
            if (adapter.ToLower().Contains("wireless"))
            {
                LogMessage("Enabling '" + adapter + "'.");
                ChangeStatus("Enabling '" + adapter + "'.", 50);
                if (!SetNicStatus(adapter, true))
                {
                    LogMessage("Error enabling " + adapter);
                }
                string result = RunCommand("netsh.exe", "interface set interface \"" + adapter + "\" ENABLED");
            }
        }

        RefreshNetworkInfo(true);
        LogMessage("Enabled wireless adapters");
        ChangeStatus("Ready", 0);
    }

    private void buttonResetInternetSecurity_Click(object sender, EventArgs e)
    {
        DoResetInternetSecurity();
    }
    private void RunIEPrivacyDefaultRegFile()
    {
        string sFileName = "ie_privacy_default.reg";
        string sRegPath = Environment.GetEnvironmentVariable("temp") + "\\" + sFileName;

        // Remove read-only attribute, if set
        try
        {
            FileInfo fileInfo = new FileInfo(sRegPath);
            fileInfo.IsReadOnly = false;
            fileInfo.Refresh();
        }
        catch (FileNotFoundException)
        {
        }

        // Create or overwrite .reg file (we could also use a resource file, but this feels safer)
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(sRegPath))
        {
            file.WriteLine("Windows Registry Editor Version 5.00");
            file.WriteLine("");
            file.WriteLine("[HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Zones\\3]");
            file.WriteLine("\"1A10\"=dword:00000001");
            file.WriteLine("\"{AEBA21FA-782A-4A90-978D-B72164C80120}\"=hex:1a,37,61,59,23,52,35,0c,7a,5f,20,\\");
            file.WriteLine("  17,2f,1e,1a,19,0e,2b,01,73,1e,28,1a,04,1b,0c,3b,c2,21,27,53,0d,36,05,2c,05,\\");
            file.WriteLine("  04,3d,4f,3a,4a,44,33,3a,0a,06,12,68,53,7c,20,13,35,5d,4c,10,27,01,56,7a,2d,\\");
            file.WriteLine("  3f,38,4f,79,0f,16,26,75,53,1c,31,00,56,7a,3e,32,24,4f,79,1b,00,33,71,4d,23,\\");
            file.WriteLine("  32,29,7c,6a,35,31,34,40,72,3b,01,2e,5d,4c,2a,07,15,48,72,38,12,00,56,7a,3e,\\");
            file.WriteLine("  16,3c,71,4d,24,33,35,7c,72,35,0e,3c,1a,41,44,19,0f,31,3a,56,7a,2e,3e,31,0c,\\");
            file.WriteLine("  7c,6a,10,27,0c,05,5d,4c,39,19,12,15,61,54,2e,00,33,32,40,52,03,25,1f,05,5d,\\");
            file.WriteLine("  4c,2c,0c,0a,15,61,54,1a,26,1f,05,5d,4c,10,21,1d,1b,71,4d,3b,24,3a,21,6d,72,\\");
            file.WriteLine("  24,16,3c,32,40,72,21,0f,3a,1a,41,44,1b,1e,01,01,71,4d,32,23,30,27,6d,4d,1f,\\");
            file.WriteLine("  28,10,3c,56,7a,2f,2e,32,16,7c,6a,3a,12,3b,28,75,53,0b,3f,12,01,71,4d,23,32,\\");
            file.WriteLine("  29,27,75,53,12,30,32,1e,4f,79,12,38,17,01,71,4d,30,3e,37,27,6d,72,38,12,3f,\\");
            file.WriteLine("  04,41,44,0a,0e,32,28,49,5f,1c,24,0b,1b,36,21,41,7b,5b,24,39,31,7c,6a,2b,0e,\\");
            file.WriteLine("  25,75,53,1a,2e,26,41,72,34,16,26,71,4d,30,30,3a,7c,6a,07,33,1a,56,7a,3a,00,\\");
            file.WriteLine("  33,71,4d,23,32,29,7c,6a,1a,26,1a,40,52,24,3f,1a,6d,4d,1c,22,28,75,53,13,25,\\");
            file.WriteLine("  20,41,44,0a,0e,32,75,53,08,07,20,71,4d,10,27,0d,05,5d,4c,24,1a,1e,1b,71,4d,\\");
            file.WriteLine("  3f,20,3f,21,6d,4d,10,27,0c,05,5d,4c,39,19,12,3a,56,7a,3a,20,2c,0c,7c,6a,3e,\\");
            file.WriteLine("  0c,37,07,75,53,12,30,32,3a,56,7a,25,2d,23,0c,7c,6a,2b,08,21,3a,56,7a,22,3a,\\");
            file.WriteLine("  32,3a,56,72,24,1e,26,1a,41,44,07,1f,03,1b,75,53,1c,31,01,01,71,4d,32,23,30,\\");
            file.WriteLine("  27,6d,72,34,1e,30,04,41,44,1b,1e,3b,28,49,5f,07,33,12,1b,5d,4c,35,0b,0a,1f,\\");
            file.WriteLine("  75,53,0b,00,34,28,40,72,3b,01,2d,04,41,44,01,05,34,28,40,52,22,36,04,34,48,\\");
            file.WriteLine("  72,38,12,3f,04,41,44,0a,0e,1f,01,71,4d,24,33,35,27,06,1c,68,53,49,14,21,01,\\");
            file.WriteLine("  40,52,10,27,0d,40,52,2c,29,05,6d,4d,1f,28,05,56,7a,2f,2e,32,75,53,07,33,12,\\");
            file.WriteLine("  40,52,3f,3a,19,6d,72,20,00,34,71,4d,1a,26,1a,40,52,24,3f,1a,6d,72,35,08,38,\\");
            file.WriteLine("  5d,4c,2d,01,18,48,7a,27,23,1f,56,7a,3b,2f,3f,4f,79,08,39,01,1b,71,72,33,1f,\\");
            file.WriteLine("  39,3a,56,7a,2e,3e,31,0c,7c,72,35,0e,3f,1a,41,44,0a,0a,35,3a,56,7a,3a,20,2c,\\");
            file.WriteLine("  0c,7c,6a,03,25,1f,05,5d,4c,2c,0c,0a,15,61,54,27,05,34,32,40,52,10,21,09,05,\\");
            file.WriteLine("  5d,4c,2d,01,18,15,61,54,07,37,17,05,5d,4c,1c,24,03,1b,71,4d,30,30,3b,27,6d,\\");
            file.WriteLine("  72,33,17,3f,28,40,72,34,1e,30,04,41,44,1b,1e,00,01,71,4d,2f,2c,2c,27,6d,4d,\\");
            file.WriteLine("  0b,26,3f,3c,56,7a,3a,20,23,16,7c,6a,35,05,33,28,75,53,12,30,17,01,71,4d,30,\\");
            file.WriteLine("  3e,37,27,75,53,13,25,20,1e,4f,79,1f,29,1f,01,71,4d,24,33,35,27,06,21,41,7b,\\");
            file.WriteLine("  5b,3d,24,37,7c,6a,2b,0e,25,40,72,33,1f,39,5d,72,34,1e,30,5d,4c,2a,0d,18,48,\\");
            file.WriteLine("  7a,27,12,3b,71,4d,23,32,12,56,72,20,0c,2e,5d,4c,2c,0c,0a,75,53,1a,26,1f,40,\\");
            file.WriteLine("  72,35,08,38,5d,4c,2d,01,18,75,53,0f,21,27,41,44,07,1f,3e,61,54,3d,06,22,32,\\");
            file.WriteLine("  40,52,2c,29,05,32,48,72,34,1e,05,1b,71,4d,10,27,0c,05,5d,4c,39,19,1a,1b,71,\\");
            file.WriteLine("  4d,23,32,24,21,6d,4d,03,25,1f,05,5d,4c,2c,0c,0a,3a,56,7a,25,2d,23,0c,7c,6a,\\");
            file.WriteLine("  2b,08,21,07,75,53,13,25,20,3a,56,7a,3e,3e,3b,0c,7c,6a,3f,0f,23,3a,56,7a,2f,\\");
            file.WriteLine("  2e,3d,3c,56,72,33,1f,39,04,41,44,1a,0e,05,01,75,53,1c,31,00,01,71,4d,2f,2c,\\");
            file.WriteLine("  2c,27,6d,72,20,0c,2d,04,41,44,06,18,2a,28,49,5f,1a,26,1a,1b,5d,4c,2c,0c,0f,\\");
            file.WriteLine("  1f,75,53,1c,1c,3e,28,40,72,38,12,3f,04,41,44,0a,16,3c,28,40,52,3e,39,06,34,\\");
            file.WriteLine("  21,21,41,7b,5b,23,27,3c,7c,6a,17,37,17,40,52,32,24,05,6d,4d,0e,21,2c,75,53,\\");
            file.WriteLine("  0b,31,31,75,53,08,3e,21,41,44,07,1e,3c,61,54,17,37,17,05,5d,4c,00,33,1e,1b,\\");
            file.WriteLine("  71,4d,2e,39,3b,21,6d,72,20,06,32,32,40,72,21,0f,3c,1a,41,44,1a,0e,1f,01,71,\\");
            file.WriteLine("  4d,20,2c,30,27,6d,4d,0e,21,2c,3c,56,7a,3a,2e,2d,16,7c,6a,3f,07,22,28,6e,02,\\");
            file.WriteLine("  68,4a,7c,21,09,26,5d,4c,29,1d,1f,56,7a,3f,32,38,4f,79,1e,30,01,56,7a,3a,2e,\\");
            file.WriteLine("  2d,4f,79,14,07,22,71,4d,24,30,3b,7c,6a,2a,1e,2f,07,75,53,0c,2d,26,3a,56,7a,\\");
            file.WriteLine("  31,25,3d,0c,7c,6a,3e,0e,35,3a,56,7a,3b,2f,3d,3a,56,72,34,1e,26,04,41,44,0b,\\");
            file.WriteLine("  0a,1e,01,75,53,0e,38,01,01,71,4d,23,30,2b,27,6d,72,21,0f,3c,04,28,1b,67,6b,\\");
            file.WriteLine("  5f,00,22,10,75,53,1f,21,27,41,44,0b,0a,31,75,53,0e,1d,22,71,4d,03,27,1d,40,\\");
            file.WriteLine("  52,3e,39,08,75,53,08,31,21,41,44,1a,0e,32,3a,56,7a,3f,32,38,0c,7c,6a,06,3e,\\");
            file.WriteLine("  0d,05,5d,4c,35,0d,09,15,61,54,29,07,22,32,40,52,17,37,17,1b,5d,4c,3a,19,16,\\");
            file.WriteLine("  1f,61,54,06,3e,0d,1b,5d,4c,03,27,11,01,71,4d,24,33,3b,27,06,21,41,73,41,11,\\");
            file.WriteLine("  25,1d,56,7a,2e,3e,3b,4f,79,18,12,3f,71,4d,2e,39,3b,7c,6a,3e,0e,35,40,72,21,\\");
            file.WriteLine("  0f,3c,5d,4c,36,0d,19,48,72,34,1e,1f,1b,71,4d,00,33,16,05,5d,4c,38,04,01,1b,\\");
            file.WriteLine("  71,4d,23,30,2b,21,6d,4d,1c,24,0d,05,5d,4c,29,1d,17,3c,56,7a,3f,32,38,16,7c,\\");
            file.WriteLine("  6a,39,09,25,09,75,53,0b,31,31,3c,56,7a,3b,2f,3d,16,15,39,5f,7b,42,03,38,02,\\");
            file.WriteLine("  40,20,2c,1e,4f,37,41,7b,5b,23,27,3c,7c,14,07,22,6e,14,68,4a,7c,20,13,35,5d,\\");
            file.WriteLine("  30,37,08,06,37,41,7b,5b,23,27,3c,7c,1b,39,1d,30,02,7c,50,68,3a,3b,34,4f,1b,\\");
            file.WriteLine("  1e,3b,6e,14,68,73,41,0b,22,0a,56,12,30,32,28,09,67,73,41,0b,22,2a,41,2c,0c,\\");
            file.WriteLine("  0f,21,37,41,7b,5b,23,27,3c,7c,08,1c,3e,66,0e,44,4f,56,06,13,05,61,27,23,1f,\\");
            file.WriteLine("  4f,3f,5b,53,7c,20,13,35,5d,3e,39,06,06,0a,68,53,7c,21,09,26,5d,32,12,3f,6e,\\");
            file.WriteLine("  14,68,4a,44,3e,37,02,6d,1c,24,01,4f,3f,5b,73,41,08,38,27,41,38,04,19,6e,14,\\");
            file.WriteLine("  68,4a,44,3e,37,02,6d,3e,0e,35,3b,37,41,7b,5b,24,39,31,7c,08,39,00,4f,3f,7c,\\");
            file.WriteLine("  50,68,3b,1d,3c,71,25,2d,2c,20,3a,7c,50,68,3b,25,3b,4f,01,1d,2a,6e,14,68,4a,\\");
            file.WriteLine("  44,3e,37,02,6d,10,21,09,29,1f,5e,45,67,14,30,07,49,12,16,3c,66,0e,44,73,41,\\");
            file.WriteLine("  08,38,27,41,36,0a,1b,21,3f,42,73,41,10,3b,2d,41,00,33,1e,4f,3f,5b,53,5e,2e,\\");
            file.WriteLine("  07,1d,75,21,07,22,66,0e,7c,50,68,23,24,31,4f,0d,15,01,4f,3f,5b,53,5e,2e,07,\\");
            file.WriteLine("  1d,48,0b,18,3c,6e,14,68,4a,44,26,36,0c,6d,2b,06,25,66,37,41,7b,5b,14,21,01,\\");
            file.WriteLine("  40,3a,31,24,15,37,41,7b,5b,3c,3e,3f,7c,12,38,17,4f,3f,5b,53,5e,2e,07,1d,75,\\");
            file.WriteLine("  35,08,38,36,03,56,76,74,37,08,19,40,07,37,17,29,1f,7c,50,68,23,24,31,4f,07,\\");
            file.WriteLine("  1f,3e,16,17,7c,50,68,20,3a,39,75,25,12,3f,66,0e,44,4f,56,1c,12,1d,56,1c,24,\\");
            file.WriteLine("  0d,29,37,41,7b,5b,3d,24,37,7c,1e,1d,22,66,0e,44,4f,56,1c,12,30,61,23,13,11,\\");
            file.WriteLine("  4f,3f,5b,53,5e,2f,01,15,48,10,27,0c,6e,14,68,4a,7c,36,12,38,5d,24,3f,19,6e,\\");
            file.WriteLine("  14,68,4a,44,21,2c,04,6d,35,05,34,66,0e,44,4f,56,1c,12,1d,56,1c,3b,25,28,09,\\");
            file.WriteLine("  67,6b,5f,01,2c,28,75,24,1e,26,36,37,41,7b,5b,3d,24,37,7c,14,3a,0b,30,37,41,\\");
            file.WriteLine("  7b,5b,36,0c,7c");
            file.WriteLine("\"{A8A88C49-5EB2-4990-A1A2-0876022C854F}\"=hex:1a,37,61,59,23,52,35,0c,7a,5f,20,\\");
            file.WriteLine("  17,2f,1e,1a,19,0e,2b,01,73,1e,28,1a,04,1b,0c,3b,c2,21,2d,53,49,07,25,0f,29,\\");
            file.WriteLine("  01,7c,50,68,3a,3b,34,4f,79,08,39,0d,49,72,33,1f,39,5d,4c,17,37,05,56,7a,2f,\\");
            file.WriteLine("  2e,32,4f,79,1f,12,3b,75,53,0b,3f,12,56,7a,3a,20,23,4f,79,12,05,33,71,4d,3a,\\");
            file.WriteLine("  31,29,7c,6a,2b,08,21,40,72,38,12,3f,5d,4c,39,1d,17,48,72,21,0f,03,56,7a,2f,\\");
            file.WriteLine("  06,22,32,40,52,2c,29,05,3a,56,7a,2e,3e,31,0c,7c,6a,2b,06,25,32,40,52,33,24,\\");
            file.WriteLine("  01,32,75,53,0b,3f,32,04,4f,79,1b,3b,1f,0c,40,72,3b,01,2d,1a,75,53,12,30,3f,\\");
            file.WriteLine("  04,4f,79,08,3f,09,0c,75,53,13,25,20,04,75,53,07,37,17,05,5d,4c,36,0a,1b,3a,\\");
            file.WriteLine("  56,72,35,0e,3c,3c,56,7a,2d,3f,38,16,7c,6a,17,37,01,1b,5d,4c,2a,0d,18,1f,61,\\");
            file.WriteLine("  54,12,12,3b,28,40,52,3f,3a,19,34,48,72,20,0c,17,01,71,4d,1a,26,1a,1b,5d,4c,\\");
            file.WriteLine("  2c,0c,17,01,71,4d,30,3e,37,27,6d,4d,1b,3b,0c,1b,5d,4c,39,1d,17,3c,56,7a,3b,\\");
            file.WriteLine("  2f,3f,16,15,39,5f,7b,42,29,1d,3c,71,4d,30,06,22,71,4d,32,23,30,7c,6a,2a,1e,\\");
            file.WriteLine("  19,75,53,1c,31,20,41,72,24,12,3b,71,4d,23,32,24,7c,6a,03,25,17,56,7a,25,05,\\");
            file.WriteLine("  33,71,4d,3a,31,29,7c,6a,10,21,09,40,52,27,2c,0b,6d,4d,0f,28,2a,75,53,08,3e,\\");
            file.WriteLine("  23,41,44,1b,1e,3c,3a,56,7a,12,34,16,05,75,53,1f,21,2d,04,4f,79,10,27,0c,05,\\");
            file.WriteLine("  5d,4c,39,19,12,15,75,53,0b,3f,32,04,4f,79,1b,00,34,32,40,52,24,3f,19,32,48,\\");
            file.WriteLine("  7a,2c,10,17,1b,71,4d,30,1c,3e,32,40,52,27,2c,0b,32,48,7a,27,16,3c,32,40,52,\\");
            file.WriteLine("  3e,07,20,3a,56,7a,2f,2e,3d,16,7c,6a,12,34,1e,01,71,4d,17,37,01,1b,5d,4c,2a,\\");
            file.WriteLine("  0d,18,3c,56,7a,3e,32,24,16,7c,6a,3e,0c,34,09,75,53,0b,3f,3f,1e,4f,79,12,38,\\");
            file.WriteLine("  12,01,71,72,3b,01,2e,3c,56,7a,2f,24,39,16,7c,72,38,12,3f,04,41,44,0a,0e,32,\\");
            file.WriteLine("  3c,56,7a,3b,2f,3f,16,15,39,7c,50,68,23,24,31,4f,79,08,39,0d,49,5f,12,34,16,\\");
            file.WriteLine("  40,52,17,37,01,40,52,22,38,0b,6d,4d,0f,34,1a,56,7a,3a,20,2c,75,53,03,25,1f,\\");
            file.WriteLine("  40,52,24,3f,19,6d,72,3b,05,34,71,4d,10,21,09,40,52,27,2c,0b,6d,72,24,1e,26,\\");
            file.WriteLine("  5d,4c,36,0a,1b,48,7a,36,13,01,1b,71,4d,32,23,30,21,6d,4d,17,37,01,3a,56,7a,\\");
            file.WriteLine("  2f,06,25,32,40,52,33,24,01,3a,56,7a,3a,20,2c,0c,7c,6a,3e,00,34,32,40,52,24,\\");
            file.WriteLine("  3f,19,32,75,53,12,30,3f,04,4f,79,08,3f,09,0c,40,72,38,12,3f,1a,75,53,0f,21,\\");
            file.WriteLine("  27,04,4f,79,14,3a,0b,0c,75,53,1c,31,21,1e,75,53,12,34,16,1b,5d,4c,29,1d,1d,\\");
            file.WriteLine("  3c,56,72,35,0e,3f,3c,56,7a,3e,32,24,16,7c,6a,03,25,1a,1b,5d,4c,35,0b,0f,1f,\\");
            file.WriteLine("  61,54,27,05,33,28,40,52,24,3f,1a,34,48,72,35,08,1d,01,71,4d,1b,3b,0c,1b,5d,\\");
            file.WriteLine("  4c,39,1d,1f,01,71,4d,24,33,35,27,06,1c,7c,50,68,20,3a,39,4f,79,08,06,22,71,\\");
            file.WriteLine("  4d,32,23,30,7c,6a,2a,1e,19,40,72,35,0e,3f,5d,72,24,1a,25,5d,4c,35,0b,0a,48,\\");
            file.WriteLine("  7a,23,00,34,71,4d,3a,31,12,56,72,3b,01,2e,5d,4c,2a,07,15,75,53,1b,3b,0c,40,\\");
            file.WriteLine("  72,24,1e,26,5d,4c,36,0a,1b,75,53,1c,31,21,04,4f,79,0a,2a,06,0c,40,72,34,1e,\\");
            file.WriteLine("  30,1a,41,44,1b,1e,3b,3a,56,7a,07,33,12,05,75,53,0b,3f,32,04,4f,79,03,25,1f,\\");
            file.WriteLine("  05,5d,4c,2c,0c,0a,15,75,53,12,30,3f,04,4f,79,08,1c,3e,32,40,52,27,2c,0b,32,\\");
            file.WriteLine("  48,7a,27,23,1f,1b,71,4d,24,07,20,32,40,52,22,38,08,34,48,7a,34,17,3f,28,40,\\");
            file.WriteLine("  52,23,16,26,3c,56,7a,2f,2e,32,16,7c,6a,07,33,1a,01,71,4d,03,25,1a,1b,5d,4c,\\");
            file.WriteLine("  35,0b,0f,3c,56,7a,25,2d,2c,16,7c,6a,35,31,37,09,75,53,1c,3b,25,1e,4f,79,13,\\");
            file.WriteLine("  35,00,01,71,72,24,1e,26,3c,56,7a,3b,2f,3f,16,15,21,41,7b,5b,23,27,3c,7c,6a,\\");
            file.WriteLine("  2a,16,3c,71,4d,20,2c,30,7c,6a,06,3e,0d,40,52,3f,38,18,6d,4d,08,27,2c,75,53,\\");
            file.WriteLine("  08,31,21,75,53,1f,21,27,04,4f,79,18,2d,06,0c,75,53,0e,38,21,04,75,53,03,27,\\");
            file.WriteLine("  1d,05,5d,4c,36,0a,19,3a,56,72,34,1e,26,3c,56,7a,3f,32,38,16,7c,6a,06,3e,0d,\\");
            file.WriteLine("  1b,5d,4c,35,0d,09,1f,61,54,29,07,22,28,29,01,5e,45,67,14,30,1f,56,7a,17,37,\\");
            file.WriteLine("  17,40,72,25,1a,39,5d,4c,38,04,01,56,7a,3a,2e,2d,4f,79,14,3a,01,56,7a,3b,2e,\\");
            file.WriteLine("  3d,4f,79,0f,16,3c,32,40,52,32,24,05,32,48,7a,18,28,01,1b,71,4d,23,06,32,32,\\");
            file.WriteLine("  40,52,3e,39,08,32,48,7a,37,16,3c,28,40,52,32,12,3f,3c,56,7a,31,25,3d,16,7c,\\");
            file.WriteLine("  6a,03,27,11,01,71,4d,1c,24,0d,1b,36,1d,56,76,74,14,21,01,40,52,23,28,02,6d,\\");
            file.WriteLine("  4d,0c,34,2b,75,53,0e,38,21,41,44,06,1e,2c,75,53,08,07,22,71,4d,1c,27,0d,40,\\");
            file.WriteLine("  52,23,28,02,3a,56,7a,3f,32,38,0c,7c,6a,39,1d,22,32,40,52,3f,38,18,32,75,53,\\");
            file.WriteLine("  08,3e,21,04,4f,79,0f,29,07,02,40,72,25,1a,39,04,75,53,0e,38,21,1e,4f,79,1b,\\");
            file.WriteLine("  39,1d,02,75,53,08,3e,21,1e,6e,02,7c,50,68,20,3a,39,4f,79,0f,16,3c,75,53,0c,\\");
            file.WriteLine("  2d,1e,56,7a,31,25,3d,4f,79,1b,06,32,71,4d,24,33,3b,7c,6a,3f,0e,25,40,72,34,\\");
            file.WriteLine("  1e,26,1a,41,44,0b,0a,31,3a,56,7a,06,3e,0d,05,75,53,0b,31,31,04,4f,79,1c,24,\\");
            file.WriteLine("  0d,05,5d,4c,29,1d,17,1f,75,53,0c,2d,26,1e,4f,79,1e,1d,22,28,40,52,3f,38,18,\\");
            file.WriteLine("  34,48,7a,22,12,01,01,66,1c,44,73,41,0b,22,2a,41,3a,19,16,21,2d,42,73,41,0b,\\");
            file.WriteLine("  22,2a,41,1c,24,01,4f,2d,5b,53,5e,35,1e,22,75,27,1d,22,66,1c,7c,50,68,3a,3b,\\");
            file.WriteLine("  34,4f,06,1e,11,4f,2d,5b,53,5e,35,1e,22,48,1c,18,2d,6e,02,68,4a,44,3f,2d,31,\\");
            file.WriteLine("  6d,35,05,33,66,21,41,7b,5b,03,38,02,40,3a,31,29,15,21,41,7b,5b,23,27,3c,7c,\\");
            file.WriteLine("  08,3f,1d,4f,2d,5b,53,5e,35,1e,22,75,24,1e,26,36,1d,56,76,74,3e,03,1c,40,1c,\\");
            file.WriteLine("  24,0b,29,01,7c,50,68,3b,25,3b,4f,0b,0a,31,16,05,7c,50,68,3b,25,3b,75,21,07,\\");
            file.WriteLine("  22,66,1c,44,4f,56,07,15,1f,56,06,3e,0d,29,21,41,7b,5b,24,39,31,7c,1b,06,32,\\");
            file.WriteLine("  66,1c,44,4f,56,07,15,32,61,36,13,00,4f,2d,5b,53,5e,36,04,17,48,1a,26,1a,6e,\\");
            file.WriteLine("  02,68,4a,7c,21,09,26,5d,24,3f,1a,6e,02,68,4a,44,3e,37,02,6d,2b,1c,3e,66,1c,\\");
            file.WriteLine("  44,4f,56,07,15,1f,56,0f,21,27,28,1b,67,6b,5f,08,21,2a,75,21,0f,3a,36,21,41,\\");
            file.WriteLine("  7b,5b,3c,3e,3f,7c,18,2d,06,30,21,41,7b,5b,3c,3e,05,56,1c,24,0d,29,01,5e,45,\\");
            file.WriteLine("  67,0c,1c,26,75,27,09,3c,6e,02,68,4a,44,26,36,0c,6d,03,27,1d,29,01,5e,45,67,\\");
            file.WriteLine("  0c,3f,31,49,3d,06,25,66,1c,44,4f,56,1f,14,38,75,3b,01,12,4f,2d,5b,73,41,10,\\");
            file.WriteLine("  3b,2d,41,2c,0c,17,4f,2d,5b,53,5e,2e,07,1d,48,10,21,09,29,01,5e,45,67,0c,1c,\\");
            file.WriteLine("  26,71,3e,3e,3b,20,28,74,4e,68,2a,29,05,56,08,3e,23,6e,02,68,4a,44,21,2c,04,\\");
            file.WriteLine("  6d,3b,1a,20,6e,02,68,4a,44,21,1a,3e,75,21,0f,3c,36,1d,56,76,74,15,3b,1d,56,\\");
            file.WriteLine("  0e,38,01,4f,2d,5b,53,5e,2f,01,15,75,20,0e,2c,36,1d,56,76,74,28,02,21,40,10,\\");
            file.WriteLine("  27,0c,29,01,5e,45,67,0d,35,1d,56,12,05,33,66,1c,7c,50,68,20,3a,39,4f,01,05,\\");
            file.WriteLine("  34,66,1c,44,4f,56,1c,12,30,75,35,08,38,36,1d,56,76,74,15,3b,09,40,2f,20,31,\\");
            file.WriteLine("  15,39,5f,7b,42,20,1a,3e,71,3b,2f,03,4f,2d,5b,53,5e,20,39,74");
        }

        String result = RunCommand("regedit.exe", "/s " + sRegPath);
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred importing .reg file:");
            LogMessage(result);
        };

    }
    private void DoResetInternetSecurity()
    {
        LogMessage("Resetting Internet Options Security/Privacy to default");
        ChangeStatus("Resetting Internet Options Security/Privacy to default", 50);
        String result;

        InternetZoneManager izm = new InternetZoneManager();
        izm.CopyTemplatePoliciesToZone(URLTEMPLATE.URLTEMPLATE_MEDHIGH, UrlZone.Internet);
        izm.CopyTemplatePoliciesToZone(URLTEMPLATE.URLTEMPLATE_MEDLOW, UrlZone.Intranet);
        izm.CopyTemplatePoliciesToZone(URLTEMPLATE.URLTEMPLATE_MEDIUM, UrlZone.Trusted);
        izm.CopyTemplatePoliciesToZone(URLTEMPLATE.URLTEMPLATE_HIGH, UrlZone.Untrusted);

        LogMessage("Resetting privacy level to default");
        ChangeStatus("Resetting privacy level to default", 60);
        RunIEPrivacyDefaultRegFile();

        LogMessage("Turning on popup blocker");
        ChangeStatus("Turning on popup blocker", 70);
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Internet Explorer\\New Windows\" /v PopupMgr /t REG_DWORD /d 1 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred turning on popup blocker");
            LogMessage(result);
        };

        LogMessage("Setting physical location requests to default");
        ChangeStatus("Setting physical location requests to default", 80);
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Internet Explorer\\Geolocation\" /v BlockAllWebsites /t REG_DWORD /d 0 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred setting physical location requests to default");
            LogMessage(result);
        };

        LogMessage("Disabling toolbars and extensions for InPrivate Browsing");
        ChangeStatus("Disabling toolbars and extensions for InPrivate Browsing", 90);
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Internet Explorer\\Safety\\PrivacIE\" /v DisableToolbars /t REG_DWORD /d 1 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred disabling toolbars and extensions for InPrivate Browsing");
            LogMessage(result);
        };

        LogMessage("Reset Internet Options Security/Privacy to default");
        ChangeStatus("Ready", 0);
    }

    // Event handler for combobox. Called when the user selects a different network adapter
    // Using the adapter combo box
    private void comboBoxAdapters_SelectedValueChanged(object sender, EventArgs e)
    {
        NetworkInterface nic = GetNic((string)comboBoxAdapters.SelectedItem);
        if (nic != null)
        {
            IPv4InterfaceStatistics ipStats = nic.GetIPv4Statistics();
            if (ipStats != null)
            {
                BytesSent = ipStats.BytesSent;
                BytesReceived = ipStats.BytesReceived;
            }
        }
        RefreshAdapterInfo((string)comboBoxAdapters.SelectedItem);
    }

    private void buttonServicesDefault_Click(object sender, EventArgs e)
    {
        DoServicesDefault();
    }

    // StartMode can be "Boot", "System", "Auto", "Manual" or "Disabled"
    public bool SetServiceMode(string ServiceName, string StartMode)
    {
        bool isChanged = false;
        ManagementPath p = new ManagementPath("Win32_Service.Name='" + ServiceName + "'");
        using (ManagementObject service = new ManagementObject(p))
        {
            try
            {
                string DisplayName = (string)service["DisplayName"];
                string ExistingMode = (string)service["StartMode"];
                if (ExistingMode.Equals("Auto"))     // WMI inconsistency
                {
                    ExistingMode = "Automatic";
                }
                if (!ExistingMode.Equals(StartMode))
                {
                    LogMessage("Setting service '" + DisplayName + "' to '" + StartMode + "' (was: '" + ExistingMode + "')");
                    ManagementBaseObject inputArgs = service.GetMethodParameters("ChangeStartMode");
                    inputArgs["StartMode"] = StartMode;
                    service.InvokeMethod("ChangeStartMode", inputArgs, null);
                    isChanged = true;
                }
            }
            catch (System.Management.ManagementException e)
            {
                LogMessage(e.StackTrace);
            }
        }
        return isChanged;
    }

    // Process a list of services and set their StartMode
    private bool ProcessServiceList(string[] ServiceNames, string ServiceMode)
    {
        bool isChanged = false;
        foreach (string ServiceName in ServiceNames)
        {
            isChanged = SetServiceMode(ServiceName, ServiceMode) || isChanged;
        }
        return isChanged;
    }

    private void DoServicesDefault()
    {
        bool isChanged = false;
        string[] XP_Auto = {"Browser", "Dhcp", "Dnscache", "LanmanServer", "LanmanWorkstation", 
                                "LmHosts", "PlugPlay", "SharedAccess", "W32Time", "wscsvc", "WZCSVC"};
        string[] XP_Manual = { "dot3svc", "EapHost", "Nla", "WinHttpAutoProxySvc" };
        string[] Vista_Auto = {"BFE", "Browser", "Dhcp", "Dnscache", "LanmanServer", "LanmanWorkstation", 
                                   "lmhosts", "MpsSvc", "netprofm", "NlaSvc", "nsi", "PlugPlay", "W32Time", 
                                   "wscsvc"};
        string[] Vista_Manual = { "dot3svc", "EapHost", "WinHttpAutoProxySvc", "Wlansvc", "WMPNetworkSvc" };
        string[] W7_Auto = {"BFE", "Dhcp", "Dnscache", "LanmanServer", "LanmanWorkstation", "lmhosts", 
                                "MpsSvc", "NlaSvc", "nsi", "PlugPlay", "wscsvc"};
        string[] W7_Manual = {"Browser", "dot3svc", "EapHost", "HomeGroupProvider", "netprofm", "W32Time", 
                                  "WinHttpAutoProxySvc", "Wlansvc", "WMPNetworkSvc", "WwanSvc"};
        string[] W8_Auto = {"BFE", "Dhcp", "Dnscache", "LanmanServer", "LanmanWorkstation", "lmhosts", 
                                "MpsSvc", "NlaSvc", "nsi", "Wcmsvc", "wscsvc"};
        string[] W8_Manual = {"Browser", "dot3svc", "EapHost", "HomeGroupProvider", "NcaSvc", "NcdAutoSetup", 
                                  "netprofm", "PlugPlay", "W32Time", "WinHttpAutoProxySvc", "Wlansvc", 
                                  "WMPNetworkSvc", "WwanSvc"};

        int VMajor = Environment.OSVersion.Version.Major;
        int VMinor = Environment.OSVersion.Version.Minor;

        LogMessage("Setting Network Windows Services to Default");
        ChangeStatus("Setting Network Windows Services to Default", 50);
        if ((VMajor == 5) && ((VMinor == 1) || (VMinor == 2)))  // Windows XP or XP 64-Bit
        {
            isChanged = isChanged || ProcessServiceList(XP_Auto, "Automatic");
            isChanged = isChanged || ProcessServiceList(XP_Manual, "Manual");

        }
        else if ((VMajor == 6) && (VMinor == 0))
        {            // Windows Vista
            isChanged = isChanged || ProcessServiceList(Vista_Auto, "Automatic");
            isChanged = isChanged || ProcessServiceList(Vista_Manual, "Manual");

        }
        else if ((VMajor == 6) && (VMinor == 1))
        {            // Windows 7
            isChanged = isChanged || ProcessServiceList(W7_Auto, "Automatic");
            isChanged = isChanged || ProcessServiceList(W7_Manual, "Manual");

        }
        else if ((VMajor == 6) && ((VMinor == 2) || (VMinor == 3)))
        {  // Windows 8/8.1
            isChanged = isChanged || ProcessServiceList(W8_Auto, "Automatic");
            isChanged = isChanged || ProcessServiceList(W8_Manual, "Manual");
        }
        else
        {
            LogMessage("Unsupported Windows version; default service settings cannot be determined");
        }
        if (!isChanged)
        {
            LogMessage("All services was already in their default states; no changes were made");
        }
        else
        {
            FormRestartConfirmation dlgRestart = new FormRestartConfirmation(60);
            dlgRestart.ShowDialog();
            if (dlgRestart.ButtonPressed == 1)
            {
                LogMessage("Restarting the computer");
                ChangeStatus("Restarting the computer...", 100);
                RunCommand("cmd.exe", "/C shutdown /r /t 5");
            }
            else
            {
                MessageBox.Show("You should restart your computer manually.");
                LogMessage("Restart canceled by user");
            }
        }
        ChangeStatus("Ready", 0);
    }

    private void buttonRunAll_Click(object sender, EventArgs e)
    {
        if (cbRenewDHCP.Checked)
        {
            DoRenewDHCP();
        }

        if (cbClearHosts.Checked)
        {
            DoClearHosts();
        }

        if (cbSetDHCP.Checked)
        {
            DoSetDHCP();
        }

        if (cbGoogleDNS.Checked)
        {
            DoGoogleDNS();
        }

        if (cbFlushDNS.Checked)
        {
            DoFlushDNS();
        }

        if (cbClearARP.Checked)
        {
            DoClearARP();
        }

        if (cbReloadNETBIOS.Checked)
        {
            DoReloadNETBIOS();
        }

        if (cbClearSSL.Checked)
        {
            DoClearSSL();
        }

        if (cbEnableLAN.Checked)
        {
            DoEnableLAN();
        }

        if (cbEnableWireless.Checked)
        {
            DoEnableWireless();
        }

        if (cbResetInternetSecurity.Checked)
        {
            DoResetInternetSecurity();
        }

        if (cbServicesDefault.Checked)
        {
            DoServicesDefault();
        }

        setCheckboxStates(false);
    }
    private void setCheckboxStates(bool state)
    {
        cbRenewDHCP.Checked = state;
        cbClearHosts.Checked = state;
        cbSetDHCP.Checked = state;
        cbGoogleDNS.Checked = state;
        cbFlushDNS.Checked = state;
        cbClearARP.Checked = state;
        cbReloadNETBIOS.Checked = state;
        cbClearSSL.Checked = state;
        cbEnableLAN.Checked = state;
        cbEnableWireless.Checked = state;
        cbResetInternetSecurity.Checked = state;
        cbServicesDefault.Checked = state;
        //cbAdditionalAll.Checked = state;
    }

    private void buttonPingIP_Click(object sender, EventArgs e)
    {
        DoPing("Google", "74.125.239.128");
        DoPing("Cloudflare", "198.41.213.157");
    }

    private void buttonPingDNS_Click(object sender, EventArgs e)
    {
        DoPing("Google", "google.com");
        DoPing("Cloudflare", "cloudflare.com");
    }
    private void DoPing(string Name, string Address)
    {
        LogMessage("Pinging '" + Name + "' (" + Address + ")");
        ChangeStatus("Pinging '" + Name + "' (" + Address + ")", 30);

        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        options.DontFragment = true;
        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        int timeout = 1000;     // 1 seconds
        try
        {
            PingReply reply = pingSender.Send(Address, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                LogMessage("Pinged '" + Name + "' (" + Address + ") successfully (" + reply.RoundtripTime + " ms)");
                return;
            }
            else
            {
                LogMessage("Ping unsuccessful for '" + Name + "' (" + Address + ")");
            }
        }
        catch (Exception e)
        {
            LogMessage("Ping unsuccessful for '" + Name + "' (" + Address + ")");
            Console.WriteLine(e);
        }
        finally
        {
            ChangeStatus("Ready", 0);
        }
    }

    private void button53_Click(object sender, EventArgs e)
    {
        DialogResult dlg;
        dlg = MessageBox.Show("You are about to run the following:\n"
                            + "\n"
                            + "1. WinSock/TCP IP Repair\n"
                            + "2. Clear all Proxy/VPN Settings\n"
                            + "3. Windows Firewall Repair\n"
                            + "\n"
                            + "Note: Restart required to complete repair\n"
                            + "\n"
                            + "Do you want to continue?",
                              "Information",
                              MessageBoxButtons.OKCancel,
                              MessageBoxIcon.Question);

        // Quit if the user clicks Cancel
        if (dlg == DialogResult.Cancel) return;

        String result;

        // STEP 1: Reset TCP/IP and WinSock using NETSH commands
        LogMessage("Resetting TCP/IP");
        ChangeStatus("Resetting TCP/IP", 25);

        result = RunCommand("ipconfig", "/flushdns");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred flushing DNS cache");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ipv4 reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ipv6 reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ip reset c:\\resetlog.txt");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int ip reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int 6to4 reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP (6to4)");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int httpstunnel reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting HTTPSTunnel");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int isatap reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting ISATAP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int tcp reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting TCP/IP");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int teredo reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting Teredo");
            LogMessage(result);
        };

        result = RunCommand("netsh", "int portproxy reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting PortProxy");
            LogMessage(result);
        };

        result = RunCommand("netsh", "branchcache reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting BranchCache");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winhttp reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinHTTP");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset c:\\winsock.log");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset all");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };


        result = RunCommand("netsh", "winsock reset catalog");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting WinSock");
            LogMessage(result);
        };

        LogMessage("Reset TCP/IP");


        // STEP 2: Clear all Internet Explorer proxy settings by modifying registry
        // See support.microsoft.com/kb/2289942 for details
        LogMessage("Clearing Internet Explorer proxy/VPN settings");
        ChangeStatus("Clearing Internet Explorer proxy/VPN settings", 50);

        // Uncheck "Use a proxy server for LAN" setting
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v ProxyEnable /t REG_DWORD /d 0 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred disabling proxy settings.");
            LogMessage(result);
        };
        LogMessage("Disabled proxy settings.");

        // Delete any proxy servers
        result = RunCommand("reg", "delete \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v ProxyServer /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting proxy server");
            LogMessage(result);
        };
        LogMessage("Deleted proxy servers");

        // Uncheck "always dial my default connection" and set to "never dial a connection"
        result = RunCommand("reg", "add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v EnableAutodial /t REG_DWORD /d 0 /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred disabling automatic dialing.");
            LogMessage(result);
        };
        LogMessage("Disabled automatic dialing.");

        // Delete all RAS connections
        string[] sRasList = GetRasNames();
        foreach (var ras in sRasList)
        {
            result = RunCommand("rasphone.exe", "-r \"" + ras + "\"");
            if (result.ToLower().Contains("error "))
            {
                LogMessage("An error occurred deleting RAS connection \"" + ras + "\"");
                LogMessage(result);
            };
        }
        LogMessage("Deleted all RAS connections");

        // Uncheck "Use automatic configuration script"
        result = RunCommand("reg", "delete \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v AutoConfigURL /f");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred deleting automatic configuration settings");
            LogMessage(result);
        };
        LogMessage("Deleted automatic configuration settings");


        // STEP 3: Repair Windows Firewall service
        LogMessage("Repairing Windows Firewall service");
        ChangeStatus("Repairing Windows Firewall service", 75);
        string sINFPath = Environment.GetEnvironmentVariable("windir") + "\\inf\\netrass.inf";
        result = RunCommand("Rundll32.exe", "setupapi,InstallHinfSection Ndi-Steelhead 132 " + sINFPath);
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred registering Windows Firewall. Check log for details");
            LogMessage(result);
        };


        LogMessage("Resetting Windows Firewall service");
        ChangeStatus("Resetting Windows Firewall service", 80);
        result = RunCommand("netsh.exe", "firewall reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting Windows Firewall settings");
            LogMessage(result);
        };

        ChangeStatus("Resetting Windows Firewall service", 90);
        result = RunCommand("netsh.exe", "advfirewall reset");
        if (result.ToLower().Contains("error "))
        {
            LogMessage("An error occurred resetting Windows Firewall settings");
            LogMessage(result);
        };

        LogMessage("Repaired Windows Firewall service");

        // Ask for restart confirmation
        FormRestartConfirmation dlgRestart = new FormRestartConfirmation(60);
        dlgRestart.ShowDialog();
        if (dlgRestart.ButtonPressed == 1)
        {
            LogMessage("Restarting the computer");
            ChangeStatus("Restarting the computer...", 100);
            RunCommand("cmd.exe", "/C shutdown /r /t 5");
        }
        else
        {
            MessageBox.Show("You should restart your computer manually.");
            LogMessage("Restart canceled by user");
        }
    }

    

    private void lenovoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://support.lenovo.com/us/en/products");
    }

    private void hPToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://www8.hp.com/us/en/drivers.html");
    }

    private void dellToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://www.dell.com/support/home/us/en/04");
    }

    private void aSUSToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://www.asus.com/us/support/");
    }

    private void mSIToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://us.msi.com/support");
    }

    private void microsoftToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("https://support.microsoft.com/en-us");
    }

    private void toshibaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://support.toshiba.com/");
    }

    private void samsungToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("http://www.samsung.com/us/support/");
    }

    private void sonyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("https://esupport.sony.com/");
    }

    private void aVGRemovalToolToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "AVG Removal Tool.exe");
    }

    private void nOD32ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "clear NOD32.bat");
    }

    private void kasperskyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "kaspersky_security_uninstaller.zip");
    }

    private void mcAfeeRemovalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Mcafee Removal Tool.exe");

    }

    private void nortonToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Norton Removal Tool.exe");
    }

    private void sEPCleanwipeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "SEP Cleanwipe.exe");
    }

    private void trendMicroRemovalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "TrendMicro Removal Tool.exe");
    }

    
    private void button44_Click_1(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "rkill.com");
    }

   

    private void button11_Click_1(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "pidgen.exe");
    }

    private void button12_Click(object sender, EventArgs e)
    {
        String path = Path.GetDirectoryName(Application.ExecutablePath);
        String[] pathString = Directory.GetDirectories(path, "AX88179", SearchOption.AllDirectories);

        try
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\Windows", pathString[0]));
        }
        catch(Exception error)
        {
            MessageBox.Show(String.Format("Could not find folder. Error: {0}", error),"No Folder Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            
        }
    }

   
    private void button13_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "DiskInfo.exe");
    }

    private void button14_Click_1(object sender, EventArgs e)
    {
        if (Environment.Is64BitOperatingSystem)
        {
            this.runProgramButton(sender, "avg_remover_stf_x64_2015_5501.exe");
        }
        else
        {
            this.runProgramButton(sender, "avg_remover_stf_x86_2015_5501.exe");
        }
        
    }

    private void button15_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "clear NOD32.bat");
    }

    private void button16_Click_1(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "kavremover.exe");
    }

    private void button17_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "McAfee Removal Tool.exe");
    }

    private void button22_Click_2(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "Norton Removal Tool.exe");
    }

    private void button23_Click_1(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "SEP Cleanwipe.exe");
    }

    private void button28_Click(object sender, EventArgs e)
    {
        this.runProgramButton(sender, "TrendMicro Removal Tool.exe");
    }

    private void button30_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        if (Environment.Is64BitOperatingSystem && !Environment.Is64BitProcess)
        {
            IntPtr ptr = new IntPtr();
            NativeMethods.Wow64DisableWow64FsRedirection(ref ptr);
            Process.Start(new ProcessStartInfo("cmd.exe")
            {
                WorkingDirectory = "C:\\",
                UseShellExecute = true,
                CreateNoWindow = false,
                Arguments = "/K chkdsk /f"
            });
            NativeMethods.Wow64RevertWow64FsRedirection(ref ptr);
        }
        else
            Process.Start(new ProcessStartInfo("cmd.exe")
            {
                WorkingDirectory = "C:\\",
                UseShellExecute = true,
                CreateNoWindow = false,
                Arguments = "/K chkdsk /f"
            });
       
    }

    private void button34_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "WinDirStatPortable.exe");
    }

    private void button50_Click_1(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        Process.Start("msconfig.exe");
    }

    private void button35_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "cports.exe");
    }

    private void button46_Click_1(object sender, EventArgs e)
    {
        if (Environment.Is64BitOperatingSystem)
        {
            runProgramButton(sender, "cpuz_x64.exe");
        }
        else
        {
            runProgramButton(sender, "cpuz_x32.exe");
        }
    }

    private void button47_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "gpu-z.exe");
    }

    private void button49_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "WRUpgradeTool.exe");
    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }

    private void label2_Click_1(object sender, EventArgs e)
    {

    }

    private void button48_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "JRT.exe");
    }

    private void button47_Click_2(object sender, EventArgs e)
    {
        Button button = sender as Button;
        LogMessageToFileForButtons(String.Format("Button clicked: {0} ({1})", button.Text, button.Parent.Text));
        Process.Start("ncpa.cpl");
    }

    private void button33_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "Bradford_Windows.exe");
    }

    private void button32_Click_1(object sender, EventArgs e)
    {
        runProgramButton(sender, "McAfeeENS10_Tech_9-15-2016.exe");
    }

    private void button54_Click(object sender, EventArgs e)
    {
        runProgramButton(sender, "EaglePrint.exe");
    }

    private void hypo_Load(object sender, EventArgs e)
    {
        String entrypath = Path.GetDirectoryName(Application.ExecutablePath);
        this.readProdKey(entrypath);
        //this.bootSafeMode();
        BootMode mode = SystemInformation.BootMode;
        if (mode == BootMode.Normal)
        {
            this.button25.Text = "Restart in safe mode";
        }
        else
        {
            this.button25.Text = "Restart in normal mode";
        }
        this.textBox1.SelectionStart = this.textBox1.Text.Length;
        this.textBox1.ScrollToCaret();
        
        

    }

    private void usefulToolsTab_Click(object sender, EventArgs e)
    {

    }

    private void button55_Click(object sender, EventArgs e)
    {
        runProgramButton(sender, "remove-popups.bat");
    }


    

    

  }
}
