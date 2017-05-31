// Decompiled with JetBrains decompiler
// Type: OneStop.Properties.Settings
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Hypo.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings settings = Settings.defaultInstance;
        return settings;
      }
    }

    [DefaultSettingValue("false")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string DISCACCEPT
    {
      get
      {
        return (string) this["DISCACCEPT"];
      }
      set
      {
        this["DISCACCEPT"] = (object) value;
      }
    }

    [DefaultSettingValue("GreenYellow")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Color consoleFore
    {
      get
      {
        return (Color) this["consoleFore"];
      }
      set
      {
        this["consoleFore"] = (object) value;
      }
    }

    [DefaultSettingValue("Black")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Color consoleBack
    {
      get
      {
        return (Color) this["consoleBack"];
      }
      set
      {
        this["consoleBack"] = (object) value;
      }
    }
  }
}
