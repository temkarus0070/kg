﻿namespace kgFirst.Forms
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.functionInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // functionInputTextBox
            // 
            this.functionInputTextBox.Location = new System.Drawing.Point(22, 31);
            this.functionInputTextBox.Name = "functionInputTextBox";
            this.functionInputTextBox.Size = new System.Drawing.Size(691, 20);
            this.functionInputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ф-цию";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(25, 58);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(244, 23);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Построить график";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Значение ф-ции";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 633);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.functionInputTextBox);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox functionInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}