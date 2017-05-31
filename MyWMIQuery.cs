// Decompiled with JetBrains decompiler
// Type: OneStop.MyWMIQuery
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using System;
using System.Management;
using System.Windows.Forms;

namespace Hypo
{
  public class MyWMIQuery
  {
    public static void WMIQuery()
    {
      try
      {
        foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem").Get())
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("System Information");
          Console.WriteLine("-----------------------------------");
          //Console.WriteLine("ComputerName: {0}", managementObject["Name"]);
        }
      }
      catch (ManagementException ex)
      {
        int num = (int) MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
      }
      try
      {
        foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get())
        {
          Console.WriteLine("OS: {0}", managementObject["Caption"]);
          Console.WriteLine("OSArchitecture: {0}", managementObject["OSArchitecture"]);
          Console.WriteLine("RAM: {0}MB", (object) (Convert.ToInt32(managementObject["TotalVisibleMemorySize"].ToString()) / 1024));
        }
      }
      catch (ManagementException ex)
      {
        int num = (int) MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
      }
      try
      {
        foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get())
        {
          Console.WriteLine("CPU: {0}", managementBaseObject["Name"]);
          Console.WriteLine("-----------------------------------");
        }
      }
      catch (ManagementException ex)
      {
        int num = (int) MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
      }
    }
  }
}
