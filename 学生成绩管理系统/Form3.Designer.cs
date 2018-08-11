namespace 学生成绩管理系统
{
    partial class Form3
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
            this.Project = new System.Windows.Forms.Button();
            this.StdInfo = new System.Windows.Forms.Button();
            this.alertPassword = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Project
            // 
            this.Project.Location = new System.Drawing.Point(12, 45);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(162, 52);
            this.Project.TabIndex = 0;
            this.Project.Text = "学生成绩情况";
            this.Project.UseVisualStyleBackColor = true;
            this.Project.Click += new System.EventHandler(this.Project_Click);
            // 
            // StdInfo
            // 
            this.StdInfo.Location = new System.Drawing.Point(203, 45);
            this.StdInfo.Name = "StdInfo";
            this.StdInfo.Size = new System.Drawing.Size(162, 52);
            this.StdInfo.TabIndex = 1;
            this.StdInfo.Text = "成绩管理";
            this.StdInfo.UseVisualStyleBackColor = true;
            this.StdInfo.Click += new System.EventHandler(this.StdInfo_Click);
            // 
            // alertPassword
            // 
            this.alertPassword.Location = new System.Drawing.Point(405, 45);
            this.alertPassword.Name = "alertPassword";
            this.alertPassword.Size = new System.Drawing.Size(162, 52);
            this.alertPassword.TabIndex = 3;
            this.alertPassword.Text = "修改密码";
            this.alertPassword.UseVisualStyleBackColor = true;
            this.alertPassword.Click += new System.EventHandler(this.alertPassword_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(291, 208);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(244, 52);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "退出系统";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(25, 208);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(244, 52);
            this.back.TabIndex = 5;
            this.back.Text = "返回登陆界面";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 289);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.alertPassword);
            this.Controls.Add(this.StdInfo);
            this.Controls.Add(this.Project);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "老师管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Project;
        private System.Windows.Forms.Button StdInfo;
        private System.Windows.Forms.Button alertPassword;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button back;
    }
}