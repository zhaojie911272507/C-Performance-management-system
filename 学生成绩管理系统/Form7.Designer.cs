namespace 学生成绩管理系统
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.SureAlert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.SurePassword = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SureAlert
            // 
            this.SureAlert.Image = ((System.Drawing.Image)(resources.GetObject("SureAlert.Image")));
            this.SureAlert.Location = new System.Drawing.Point(143, 292);
            this.SureAlert.Name = "SureAlert";
            this.SureAlert.Size = new System.Drawing.Size(75, 42);
            this.SureAlert.TabIndex = 0;
            this.SureAlert.Text = "确定";
            this.SureAlert.UseVisualStyleBackColor = true;
            this.SureAlert.Click += new System.EventHandler(this.SureAlert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(77, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(77, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(77, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认输入密码：";
            // 
            // OldPassword
            // 
            this.OldPassword.Location = new System.Drawing.Point(195, 111);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.PasswordChar = '*';
            this.OldPassword.Size = new System.Drawing.Size(132, 21);
            this.OldPassword.TabIndex = 5;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(195, 173);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(132, 21);
            this.NewPassword.TabIndex = 6;
            // 
            // SurePassword
            // 
            this.SurePassword.Location = new System.Drawing.Point(195, 228);
            this.SurePassword.Name = "SurePassword";
            this.SurePassword.PasswordChar = '*';
            this.SurePassword.Size = new System.Drawing.Size(132, 21);
            this.SurePassword.TabIndex = 7;
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(252, 292);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 42);
            this.back.TabIndex = 8;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::学生成绩管理系统.Properties.Resources.picture119;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.SurePassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SureAlert);
            this.Name = "Form7";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SureAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPassword;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox SurePassword;
        private System.Windows.Forms.Button back;
    }
}