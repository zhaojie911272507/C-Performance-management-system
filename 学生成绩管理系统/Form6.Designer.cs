namespace 学生成绩管理系统
{
    partial class Form6
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
            this.status = new System.Windows.Forms.Label();
            this.StdUserName = new System.Windows.Forms.TextBox();
            this.sureStdInfoAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StdPassword = new System.Windows.Forms.TextBox();
            this.delStdInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sureTeaAdd = new System.Windows.Forms.Button();
            this.delTeaInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teaUserName = new System.Windows.Forms.TextBox();
            this.teaPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(218, 183);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 12);
            this.status.TabIndex = 20;
            // 
            // StdUserName
            // 
            this.StdUserName.Location = new System.Drawing.Point(121, 36);
            this.StdUserName.Name = "StdUserName";
            this.StdUserName.Size = new System.Drawing.Size(134, 21);
            this.StdUserName.TabIndex = 16;
            // 
            // sureStdInfoAdd
            // 
            this.sureStdInfoAdd.Location = new System.Drawing.Point(17, 111);
            this.sureStdInfoAdd.Name = "sureStdInfoAdd";
            this.sureStdInfoAdd.Size = new System.Drawing.Size(136, 36);
            this.sureStdInfoAdd.TabIndex = 18;
            this.sureStdInfoAdd.Text = "点击添加学生信息";
            this.sureStdInfoAdd.UseVisualStyleBackColor = true;
            this.sureStdInfoAdd.Click += new System.EventHandler(this.Register_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StdPassword);
            this.groupBox1.Controls.Add(this.delStdInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StdUserName);
            this.groupBox1.Controls.Add(this.sureStdInfoAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 153);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "用户名：";
            // 
            // StdPassword
            // 
            this.StdPassword.Location = new System.Drawing.Point(121, 74);
            this.StdPassword.Name = "StdPassword";
            this.StdPassword.Size = new System.Drawing.Size(134, 21);
            this.StdPassword.TabIndex = 21;
            // 
            // delStdInfo
            // 
            this.delStdInfo.Location = new System.Drawing.Point(284, 57);
            this.delStdInfo.Name = "delStdInfo";
            this.delStdInfo.Size = new System.Drawing.Size(75, 23);
            this.delStdInfo.TabIndex = 20;
            this.delStdInfo.Text = "删除";
            this.delStdInfo.UseVisualStyleBackColor = true;
            this.delStdInfo.Click += new System.EventHandler(this.delStdInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "学生学号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sureTeaAdd);
            this.groupBox2.Controls.Add(this.delTeaInfo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.teaUserName);
            this.groupBox2.Controls.Add(this.teaPassword);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 167);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "老师信息管理";
            // 
            // sureTeaAdd
            // 
            this.sureTeaAdd.Location = new System.Drawing.Point(17, 125);
            this.sureTeaAdd.Name = "sureTeaAdd";
            this.sureTeaAdd.Size = new System.Drawing.Size(109, 36);
            this.sureTeaAdd.TabIndex = 25;
            this.sureTeaAdd.Text = "确定添加";
            this.sureTeaAdd.UseVisualStyleBackColor = true;
            this.sureTeaAdd.Click += new System.EventHandler(this.sureTeaAdd_Click);
            // 
            // delTeaInfo
            // 
            this.delTeaInfo.Location = new System.Drawing.Point(278, 64);
            this.delTeaInfo.Name = "delTeaInfo";
            this.delTeaInfo.Size = new System.Drawing.Size(75, 23);
            this.delTeaInfo.TabIndex = 24;
            this.delTeaInfo.Text = "删除";
            this.delTeaInfo.UseVisualStyleBackColor = true;
            this.delTeaInfo.Click += new System.EventHandler(this.delTeaInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "用户名：";
            // 
            // teaUserName
            // 
            this.teaUserName.Location = new System.Drawing.Point(135, 41);
            this.teaUserName.Name = "teaUserName";
            this.teaUserName.Size = new System.Drawing.Size(134, 21);
            this.teaUserName.TabIndex = 20;
            // 
            // teaPassword
            // 
            this.teaPassword.Location = new System.Drawing.Point(135, 90);
            this.teaPassword.Name = "teaPassword";
            this.teaPassword.PasswordChar = '*';
            this.teaPassword.Size = new System.Drawing.Size(134, 21);
            this.teaPassword.TabIndex = 21;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Name = "Form6";
            this.Text = "系统成员管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button sureStdInfoAdd;
        private System.Windows.Forms.TextBox StdUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StdPassword;
        private System.Windows.Forms.Button delStdInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teaUserName;
        private System.Windows.Forms.TextBox teaPassword;
        private System.Windows.Forms.Button sureTeaAdd;
        private System.Windows.Forms.Button delTeaInfo;
    }
}