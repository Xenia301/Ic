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
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorization
            // 
            this.authorization.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.authorization.Location = new System.Drawing.Point(225, 207);
            this.authorization.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(106, 19);
            this.authorization.TabIndex = 0;
            this.authorization.Text = "Авторизация";
            this.authorization.UseCompatibleTextRendering = true;
            this.authorization.UseVisualStyleBackColor = true;
            this.authorization.Click += new System.EventHandler(this.authorization_Click);
            // 
            // exit_program
            // 
            this.exit_program.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exit_program.Location = new System.Drawing.Point(225, 230);
            this.exit_program.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit_program.Name = "exit_program";
            this.exit_program.Size = new System.Drawing.Size(106, 19);
            this.exit_program.TabIndex = 1;
            this.exit_program.Text = "Выход";
            this.exit_program.UseVisualStyleBackColor = true;
            this.exit_program.Click += new System.EventHandler(this.exit_program_Click);
            // 
            // txt_Login
            // 
            this.txt_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Login.Location = new System.Drawing.Point(225, 137);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(106, 20);
            this.txt_Login.TabIndex = 2;
            this.txt_Login.Text = "Введите пароль";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Password.Location = new System.Drawing.Point(225, 182);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(106, 20);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.Text = "Введите пароль";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(225, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(228, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.exit_program);
            this.Controls.Add(this.authorization);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Авторизация в страховой системе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorization;
        private System.Windows.Forms.Button exit_program;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

