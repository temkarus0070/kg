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
            this.SuspendLayout();
            // 
            // DdaBtn
            // 
            this.DdaBtn.Location = new System.Drawing.Point(13, 13);
            this.DdaBtn.Name = "DdaBtn";
            this.DdaBtn.Size = new System.Drawing.Size(75, 23);
            this.DdaBtn.TabIndex = 0;
            this.DdaBtn.Text = "DDA";
            this.DdaBtn.UseVisualStyleBackColor = true;
            this.DdaBtn.Click += new System.EventHandler(this.DdaBtn_Click);
            // 
            // brzBtn
            // 
            this.brzBtn.Location = new System.Drawing.Point(138, 12);
            this.brzBtn.Name = "brzBtn";
            this.brzBtn.Size = new System.Drawing.Size(75, 23);
            this.brzBtn.TabIndex = 1;
            this.brzBtn.Text = "Brezhenheim";
            this.brzBtn.UseVisualStyleBackColor = true;
            this.brzBtn.Click += new System.EventHandler(this.brzBtn_Click);
            // 
            // byBtn
            // 
            this.byBtn.Location = new System.Drawing.Point(262, 11);
            this.byBtn.Name = "byBtn";
            this.byBtn.Size = new System.Drawing.Size(75, 23);
            this.byBtn.TabIndex = 2;
            this.byBtn.Text = "ВУ";
            this.byBtn.UseVisualStyleBackColor = true;
            this.byBtn.Click += new System.EventHandler(this.byBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 551);
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
    }
}

