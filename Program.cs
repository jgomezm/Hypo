// Decompiled with JetBrains decompiler
// Type: OneStop.Program
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using System;
using Microsoft.Win32;
using Hypo.Properties;
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

namespace Hypo
{
  internal static class Program
  {
    [STAThread]
      //public static void runProdKey(String path)
      //{
      //    path += "\\Useful Tools for Windows\\produkey";
      //    using (Process process = new Process())
      //    {
      //        process.StartInfo.WorkingDirectory = path;
      //        process.StartInfo.FileName = "cmd.exe";
      //        //process.StartInfo.Arguments = "ProduKey.exe /stext ProdKey.txt";
      //        process.StartInfo.CreateNoWindow = true;
      //        process.StartInfo.UseShellExecute = false;
      //        process.StartInfo.RedirectStandardOutput = true;
      //        process.StartInfo.RedirectStandardInput = true;
      //        //process.OutputDataReceived += new DataReceivedEventHandler(this.SortOutputHandler);
      //        process.Start();
      //        process.StandardInput.WriteLine("ProduKey.exe /IEKeys 0 /stext ProdKey.txt");
      //        process.BeginOutputReadLine();
      //    }
      //}
    private static void Main()
    {
        //String entrypath = Path.GetDirectoryName(Application.ExecutablePath);
        //runProdKey(entrypath);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new hypo());
    }
  }
}
