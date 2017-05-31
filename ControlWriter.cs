// Decompiled with JetBrains decompiler
// Type: OneStop.ControlWriter
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hypo
{
  public class ControlWriter : TextWriter
  {
    private Control textbox;

    public override Encoding Encoding
    {
      get
      {
        return Encoding.ASCII;
      }
    }

    public ControlWriter(Control textbox)
    {
      this.textbox = textbox;
    }

    public override void Write(char value)
    {
      this.textbox.Text += value.ToString();
    }

    public override void Write(string value)
    {
      this.textbox.Text += value;
    }
  }
}
