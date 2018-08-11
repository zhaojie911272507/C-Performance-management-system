namespace 学生成绩管理系统
{
    partial class Form0
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.ForgetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            this.label3.Name = "label3";
            // 
            // LoginUserName
            // 
            resources.ApplyResources(this.LoginUserName, "LoginUserName");
            this.LoginUserName.Name = "LoginUserName";
            // 
            // LoginPassword
            // 
            resources.ApplyResources(this.LoginPassword, "LoginPassword");
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.Enter += new System.EventHandler(this.Login_Click);
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            this.label1.Name = "label1";
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            resources.GetString("Type.Items"),
            resources.GetString("Type.Items1"),
            resources.GetString("Type.Items2")});
            resources.ApplyResources(this.Type, "Type");
            this.Type.Name = "Type";
            // 
            // register
            // 
            this.register.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            resources.ApplyResources(this.register, "register");
            this.register.Name = "register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            this.label4.Name = "label4";
            // 
            // Exit
            // 
            this.Exit.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.Image = global::学生成绩管理系统.Properties.Resources.picture119;
            resources.ApplyResources(this.ForgetPassword, "ForgetPassword");
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.UseVisualStyleBackColor = true;
            this.ForgetPassword.Click += new System.EventHandler(this.ForgetPassword_Click);
            // 
            // Form0
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::学生成绩管理系统.Properties.Resources.picture119;
            this.Controls.Add(this.ForgetPassword);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "Form0";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginUserName;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ForgetPassword;
    }
}

