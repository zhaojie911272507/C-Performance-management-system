namespace 学生成绩管理系统
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.back = new System.Windows.Forms.Button();
            this.SurePassword = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SureAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(261, 295);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 42);
            this.back.TabIndex = 16;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            // 
            // SurePassword
            // 
            this.SurePassword.Location = new System.Drawing.Point(204, 231);
            this.SurePassword.Name = "SurePassword";
            this.SurePassword.PasswordChar = '*';
            this.SurePassword.Size = new System.Drawing.Size(132, 21);
            this.SurePassword.TabIndex = 15;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(204, 176);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(132, 21);
            this.NewPassword.TabIndex = 14;
            // 
            // OldPassword
            // 
            this.OldPassword.Location = new System.Drawing.Point(204, 114);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.PasswordChar = '*';
            this.OldPassword.Size = new System.Drawing.Size(132, 21);
            this.OldPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(86, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "确认输入密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(86, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "请输入新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(86, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "请输入旧密码：";
            // 
            // SureAlert
            // 
            this.SureAlert.Image = ((System.Drawing.Image)(resources.GetObject("SureAlert.Image")));
            this.SureAlert.Location = new System.Drawing.Point(152, 295);
            this.SureAlert.Name = "SureAlert";
            this.SureAlert.Size = new System.Drawing.Size(75, 42);
            this.SureAlert.TabIndex = 9;
            this.SureAlert.Text = "确定";
            this.SureAlert.UseVisualStyleBackColor = true;
            this.SureAlert.Click += new System.EventHandler(this.SureAlert_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::学生成绩管理系统.Properties.Resources.picture119;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.SurePassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SureAlert);
            this.Name = "Form11";
            this.Text = "老师修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox SurePassword;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox OldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SureAlert;
    }
}