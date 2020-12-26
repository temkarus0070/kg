namespace FinalTask
{
    partial class FinalTaskForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.runBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.animationSpeedTrackar = new System.Windows.Forms.TrackBar();
            this.arrayLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedTrackar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1618, 489);
            this.panel1.TabIndex = 0;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(258, 31);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(218, 23);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Запустить сортировку";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(4, 31);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(209, 23);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Сгенерировать массив";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // animationSpeedTrackar
            // 
            this.animationSpeedTrackar.Location = new System.Drawing.Point(258, 60);
            this.animationSpeedTrackar.Name = "animationSpeedTrackar";
            this.animationSpeedTrackar.Size = new System.Drawing.Size(104, 45);
            this.animationSpeedTrackar.TabIndex = 2;
            // 
            // arrayLengthTextBox
            // 
            this.arrayLengthTextBox.Location = new System.Drawing.Point(4, 84);
            this.arrayLengthTextBox.Name = "arrayLengthTextBox";
            this.arrayLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrayLengthTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Длина массива";
            // 
            // FinalTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayLengthTextBox);
            this.Controls.Add(this.animationSpeedTrackar);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.panel1);
            this.Name = "FinalTaskForm";
            this.Text = "Визуализация сортировки вставками";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedTrackar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TrackBar animationSpeedTrackar;
        private System.Windows.Forms.TextBox arrayLengthTextBox;
        private System.Windows.Forms.Label label1;
    }
}

