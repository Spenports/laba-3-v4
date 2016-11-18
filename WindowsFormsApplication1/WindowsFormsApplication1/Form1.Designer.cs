namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.T2_textBox2 = new System.Windows.Forms.TextBox();
            this.T2_textBox1 = new System.Windows.Forms.TextBox();
            this.T2_textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // T2_textBox2
            // 
            this.T2_textBox2.Location = new System.Drawing.Point(236, 65);
            this.T2_textBox2.Name = "T2_textBox2";
            this.T2_textBox2.Size = new System.Drawing.Size(139, 20);
            this.T2_textBox2.TabIndex = 11;
            // 
            // T2_textBox1
            // 
            this.T2_textBox1.Location = new System.Drawing.Point(23, 65);
            this.T2_textBox1.Name = "T2_textBox1";
            this.T2_textBox1.Size = new System.Drawing.Size(141, 20);
            this.T2_textBox1.TabIndex = 10;
            // 
            // T2_textBox3
            // 
            this.T2_textBox3.Location = new System.Drawing.Point(70, 361);
            this.T2_textBox3.Name = "T2_textBox3";
            this.T2_textBox3.Size = new System.Drawing.Size(262, 20);
            this.T2_textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 421);
            this.Controls.Add(this.T2_textBox3);
            this.Controls.Add(this.T2_textBox2);
            this.Controls.Add(this.T2_textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T2_textBox2;
        private System.Windows.Forms.TextBox T2_textBox1;
        private System.Windows.Forms.TextBox T2_textBox3;
    }
}

