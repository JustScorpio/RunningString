
namespace RunningString
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
            this.components = new System.ComponentModel.Container();
            this.textBoxRunningString = new System.Windows.Forms.TextBox();
            this.textBoxStaticString = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxRunningString
            // 
            this.textBoxRunningString.Enabled = false;
            this.textBoxRunningString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRunningString.Location = new System.Drawing.Point(12, 12);
            this.textBoxRunningString.Name = "textBoxRunningString";
            this.textBoxRunningString.Size = new System.Drawing.Size(246, 26);
            this.textBoxRunningString.TabIndex = 0;
            // 
            // textBoxStaticString
            // 
            this.textBoxStaticString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxStaticString.Location = new System.Drawing.Point(12, 60);
            this.textBoxStaticString.Multiline = true;
            this.textBoxStaticString.Name = "textBoxStaticString";
            this.textBoxStaticString.Size = new System.Drawing.Size(246, 167);
            this.textBoxStaticString.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(95, 246);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "RUN!";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 285);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxStaticString);
            this.Controls.Add(this.textBoxRunningString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRunningString;
        private System.Windows.Forms.TextBox textBoxStaticString;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Timer timer1;
    }
}

