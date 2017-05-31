// Decompiled with JetBrains decompiler
// Type: OneStop.settings
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using Hypo.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hypo
{
  public class settings : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label3;
    private ColorDialog colorDialog1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
    private Button button3;
    private GroupBox groupBox1;

    public settings()
    {
      this.InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox1.ForeColor = this.colorDialog1.Color;
      this.textBox2.ForeColor = this.colorDialog1.Color;
      Settings.Default.consoleFore = this.colorDialog1.Color;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox1.BackColor = this.colorDialog1.Color;
      this.textBox2.BackColor = this.colorDialog1.Color;
      Settings.Default.consoleBack = this.colorDialog1.Color;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Settings.Default.Save();
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label2 = new Label();
      this.label3 = new Label();
      this.colorDialog1 = new ColorDialog();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.groupBox1 = new GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Location = new Point(6, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(91, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Foreground Color:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(6, 45);
      this.label3.Name = "label3";
      this.label3.Size = new Size(95, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Background Color:";
      this.colorDialog1.SolidColorOnly = true;
      this.textBox1.BackColor = Settings.Default.consoleBack;
      this.textBox1.DataBindings.Add(new Binding("BackColor", (object) Settings.Default, "consoleBack", true, DataSourceUpdateMode.OnPropertyChanged));
      this.textBox1.DataBindings.Add(new Binding("ForeColor", (object) Settings.Default, "consoleFore", true, DataSourceUpdateMode.OnPropertyChanged));
      this.textBox1.ForeColor = Settings.Default.consoleFore;
      this.textBox1.Location = new Point(117, 16);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 3;
      this.textBox1.TabStop = false;
      this.textBox1.Text = "Some Text...";
      this.textBox2.BackColor = Settings.Default.consoleBack;
      this.textBox2.DataBindings.Add(new Binding("ForeColor", (object) Settings.Default, "consoleFore", true, DataSourceUpdateMode.OnPropertyChanged));
      this.textBox2.DataBindings.Add(new Binding("BackColor", (object) Settings.Default, "consoleBack", true, DataSourceUpdateMode.OnPropertyChanged));
      this.textBox2.ForeColor = Settings.Default.consoleFore;
      this.textBox2.Location = new Point(117, 42);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 4;
      this.textBox2.TabStop = false;
      this.textBox2.Text = "Some Text...";
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.Location = new Point(192, 95);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(223, 16);
      this.button2.Name = "button2";
      this.button2.Size = new Size(20, 20);
      this.button2.TabIndex = 6;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(223, 42);
      this.button3.Name = "button3";
      this.button3.Size = new Size(20, 20);
      this.button3.TabIndex = 7;
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.button3);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.button2);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(252, 72);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Console Settings";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(279, 130);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "settings";
      this.ShowIcon = false;
      this.Text = "OneStop - Settings";
      this.TopMost = true;
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
