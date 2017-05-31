// Decompiled with JetBrains decompiler
// Type: OneStop.progressWin
// Assembly: OneStop, Version=0.38.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 48A1B5F1-121D-4610-ADF6-E570367C4DBE
// Assembly location: C:\Users\airyimbin\Desktop\OneStop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hypo
{
  public class progressWin : Form
  {
    private IContainer components = (IContainer) null;
    private CheckedListBox checkedListBox1;
    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private Label label1;
    private Label label2;

    public progressWin()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.checkedListBox1.Items.Add((object) this.textBox1.Text);
      this.textBox1.Text = "Enter Step Name...";
    }

    private void button2_Click(object sender, EventArgs e)
    {
    }

    private void textBox1_MouseDown(object sender, MouseEventArgs e)
    {
      this.textBox1.Clear();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.checkedListBox1 = new CheckedListBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.SuspendLayout();
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new Point(12, 12);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new Size(214, 364);
      this.checkedListBox1.TabIndex = 0;
      this.button1.Location = new Point(230, 86);
      this.button1.Name = "button1";
      this.button1.Size = new Size(140, 44);
      this.button1.TabIndex = 1;
      this.button1.Text = "Add Step";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(230, 197);
      this.button2.Name = "button2";
      this.button2.Size = new Size(140, 44);
      this.button2.TabIndex = 2;
      this.button2.Text = "Remove Step";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.textBox1.AllowDrop = true;
      this.textBox1.Location = new Point(230, 60);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(140, 20);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "Enter Step Name...";
      this.textBox1.WordWrap = false;
      this.textBox1.MouseDown += new MouseEventHandler(this.textBox1_MouseDown);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(232, 168);
      this.label1.Name = "label1";
      this.label1.Size = new Size(132, 26);
      this.label1.TabIndex = 4;
      this.label1.Text = "To remove a step, select it\r\nand press the button";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(232, 18);
      this.label2.Name = "label2";
      this.label2.Size = new Size(123, 39);
      this.label2.TabIndex = 5;
      this.label2.Text = "To add a step, \r\nEnter name in box below\r\nand press the button.\r\n";
      this.AutoScaleDimensions = new SizeF(96f, 96f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.ClientSize = new Size(382, 389);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.checkedListBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "progressWin";
      this.Text = "Progress List";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
