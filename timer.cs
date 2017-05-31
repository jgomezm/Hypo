// Decompiled with JetBrains decompiler
// Type: OneStop.timer
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hypo
{
  public class timer : Form
  {
    private int sduration = 0;
    private int mduration = 0;
    private int hduration = 0;
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private Timer timer1;
    private Button button3;
    private Label label1;

    public timer()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.timer1.Enabled = true;
      this.timer1.Start();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.timer1.Stop();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this.sduration < 60)
        ++this.sduration;
      if (this.sduration >= 60)
      {
        ++this.mduration;
        this.sduration = 0;
      }
      if (this.mduration >= 60)
      {
        ++this.hduration;
        this.mduration = 0;
      }
      this.textBox1.Text = string.Format("{0} : {1} : {2}", (object) this.hduration, (object) this.mduration, (object) this.sduration).ToString();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.textBox1.Text = "0 : 0 : 0";
      this.sduration = 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.button1 = new Button();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.timer1 = new Timer(this.components);
      this.button3 = new Button();
      this.label1 = new Label();
      this.SuspendLayout();
      this.button1.Location = new Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Start";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(93, 12);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Stop";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.textBox1.Location = new Point(12, 42);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(76, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "0 : 0 : 0";
      this.textBox1.TextAlign = HorizontalAlignment.Right;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.button3.Location = new Point(174, 12);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 3;
      this.button3.Text = "Reset";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(106, 44);
      this.label1.Name = "label1";
      this.label1.Size = new Size(132, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Hours : Minutes : Seconds";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(256, 73);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "timer";
      this.ShowIcon = false;
      this.Text = "Timer";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
