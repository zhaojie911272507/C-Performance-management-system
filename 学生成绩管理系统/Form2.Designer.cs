namespace 学生成绩管理系统
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.stdgrade = new System.Windows.Forms.Button();
            this.alertstdpassword = new System.Windows.Forms.Button();
            this.stdexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stdgrade
            // 
            this.stdgrade.BackColor = System.Drawing.SystemColors.Control;
            this.stdgrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stdgrade.BackgroundImage")));
            this.stdgrade.Image = global::学生成绩管理系统.Properties.Resources.picture17;
            this.stdgrade.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.stdgrade.Location = new System.Drawing.Point(0, 0);
            this.stdgrade.Name = "stdgrade";
            this.stdgrade.Size = new System.Drawing.Size(193, 45);
            this.stdgrade.TabIndex = 0;
            this.stdgrade.Text = "本学期成绩查询";
            this.stdgrade.UseVisualStyleBackColor = false;
            this.stdgrade.Click += new System.EventHandler(this.stdgrade_Click);
            // 
            // alertstdpassword
            // 
            this.alertstdpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alertstdpassword.BackgroundImage")));
            this.alertstdpassword.Image = global::学生成绩管理系统.Properties.Resources.picture17;
            this.alertstdpassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.alertstdpassword.Location = new System.Drawing.Point(187, 0);
            this.alertstdpassword.Name = "alertstdpassword";
            this.alertstdpassword.Size = new System.Drawing.Size(195, 45);
            this.alertstdpassword.TabIndex = 1;
            this.alertstdpassword.Text = "修改密码";
            this.alertstdpassword.UseVisualStyleBackColor = true;
            this.alertstdpassword.Click += new System.EventHandler(this.alertstdpassword_Click);
            // 
            // stdexit
            // 
            this.stdexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stdexit.BackgroundImage")));
            this.stdexit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdexit.Image = global::学生成绩管理系统.Properties.Resources.picture17;
            this.stdexit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stdexit.Location = new System.Drawing.Point(187, 209);
            this.stdexit.Name = "stdexit";
            this.stdexit.Size = new System.Drawing.Size(195, 44);
            this.stdexit.TabIndex = 2;
            this.stdexit.Text = "退出";
            this.stdexit.UseVisualStyleBackColor = true;
            this.stdexit.Click += new System.EventHandler(this.stdexit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::学生成绩管理系统.Properties.Resources.picture17;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.stdexit);
            this.Controls.Add(this.alertstdpassword);
            this.Controls.Add(this.stdgrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "学生";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stdgrade;
        private System.Windows.Forms.Button alertstdpassword;
        private System.Windows.Forms.Button stdexit;
    }
}