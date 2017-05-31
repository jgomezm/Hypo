// Decompiled with JetBrains decompiler
// Type: OneStop.disclaimer
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using Hypo.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hypo
{
  public class disclaimer : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox discText;
    private Button button1;
    private Button button2;

    public disclaimer()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      File.WriteAllText(string.Format("{0}\\\\disclaimer.txt", (object) Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]).ToString()), this.discText.Text.ToString() + Environment.NewLine + "WAIVER ACCEPTED");
      Settings.Default.DISCACCEPT = "true";
      Settings.Default.Save();
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (disclaimer));
      this.discText = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.discText.BorderStyle = BorderStyle.FixedSingle;
      this.discText.CharacterCasing = CharacterCasing.Upper;
      this.discText.Location = new Point(13, 13);
      this.discText.Multiline = true;
      this.discText.Name = "discText";
      this.discText.ReadOnly = true;
      this.discText.ScrollBars = ScrollBars.Vertical;
      this.discText.Size = new Size(259, 198);
      this.discText.TabIndex = 0;
      this.discText.TabStop = false;
      //this.discText.Text = componentResourceManager.GetString("discText.Text");
      this.button1.Location = new Point(116, 217);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "I AGREE";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.Location = new Point(197, 217);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "DENY";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(96f, 96f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(284, 253);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.discText);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "disclaimer";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Disclaimer";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
