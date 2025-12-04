namespace Ic
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
            this.authorization = new System.Windows.Forms.Button();
            this.exit_program = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorization
            // 
            this.authorization.Location = new System.Drawing.Point(300, 186);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(142, 23);
            this.authorization.TabIndex = 0;
            this.authorization.Text = "Авторизация";
            this.authorization.UseCompatibleTextRendering = true;
            this.authorization.UseVisualStyleBackColor = true;
            this.authorization.Click += new System.EventHandler(this.authorization_Click);
            // 
            // exit_program
            // 
            this.exit_program.Location = new System.Drawing.Point(300, 215);
            this.exit_program.Name = "exit_program";
            this.exit_program.Size = new System.Drawing.Size(142, 23);
            this.exit_program.TabIndex = 1;
            this.exit_program.Text = "Выход";
            this.exit_program.UseVisualStyleBackColor = true;
            this.exit_program.Click += new System.EventHandler(this.exit_program_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_program);
            this.Controls.Add(this.authorization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authorization;
        private System.Windows.Forms.Button exit_program;
    }
}

