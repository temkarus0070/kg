namespace kgFirst
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DdaBtn = new System.Windows.Forms.Button();
            this.brzBtn = new System.Windows.Forms.Button();
            this.byBtn = new System.Windows.Forms.Button();
            this.chartBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DdaBtn
            // 
            this.DdaBtn.Location = new System.Drawing.Point(236, 12);
            this.DdaBtn.Name = "DdaBtn";
            this.DdaBtn.Size = new System.Drawing.Size(75, 23);
            this.DdaBtn.TabIndex = 0;
            this.DdaBtn.Text = "DDA";
            this.DdaBtn.UseVisualStyleBackColor = true;
            this.DdaBtn.Click += new System.EventHandler(this.DdaBtn_Click);
            // 
            // brzBtn
            // 
            this.brzBtn.Location = new System.Drawing.Point(326, 12);
            this.brzBtn.Name = "brzBtn";
            this.brzBtn.Size = new System.Drawing.Size(99, 23);
            this.brzBtn.TabIndex = 1;
            this.brzBtn.Text = "Brezhenheim";
            this.brzBtn.UseVisualStyleBackColor = true;
            this.brzBtn.Click += new System.EventHandler(this.brzBtn_Click);
            // 
            // byBtn
            // 
            this.byBtn.Location = new System.Drawing.Point(431, 10);
            this.byBtn.Name = "byBtn";
            this.byBtn.Size = new System.Drawing.Size(75, 23);
            this.byBtn.TabIndex = 2;
            this.byBtn.Text = "ВУ";
            this.byBtn.UseVisualStyleBackColor = true;
            this.byBtn.Click += new System.EventHandler(this.byBtn_Click);
            // 
            // chartBtn
            // 
            this.chartBtn.Location = new System.Drawing.Point(526, 11);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(177, 23);
            this.chartBtn.TabIndex = 3;
            this.chartBtn.Text = "Построение графиков";
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.ChartBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Визуализация сортировки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartBtn);
            this.Controls.Add(this.byBtn);
            this.Controls.Add(this.brzBtn);
            this.Controls.Add(this.DdaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DdaBtn;
        private System.Windows.Forms.Button brzBtn;
        private System.Windows.Forms.Button byBtn;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Button button1;
    }
}

