﻿namespace Задание_11
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Items.AddRange(new object[] {"Количество цифр: 1448", "2+2=5", "Крокодил", "S63", "Word Office Excel PowerPoint", ":-)", "+7(999)999-99-99"});
      this.listBox1.Location = new System.Drawing.Point(12, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(214, 134);
      this.listBox1.TabIndex = 12;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 150);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Результат";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 166);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 22);
      this.button1.TabIndex = 10;
      this.button1.Text = "Пуск";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 200);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Задание 11";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

