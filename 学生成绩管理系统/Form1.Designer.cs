namespace 学生成绩管理系统
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StdReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RegUserName = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegCardID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backandlogin = new System.Windows.Forms.Button();
            this.RegClass = new System.Windows.Forms.TextBox();
            this.班级 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "学号：";
            // 
            // StdReg
            // 
            this.StdReg.Location = new System.Drawing.Point(55, 321);
            this.StdReg.Name = "StdReg";
            this.StdReg.Size = new System.Drawing.Size(91, 36);
            this.StdReg.TabIndex = 0;
            this.StdReg.Text = "注册";
            this.StdReg.UseVisualStyleBackColor = true;
            this.StdReg.Click += new System.EventHandler(this.StdReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名：";
            // 
            // RegUserName
            // 
            this.RegUserName.Location = new System.Drawing.Point(112, 42);
            this.RegUserName.Name = "RegUserName";
            this.RegUserName.Size = new System.Drawing.Size(164, 21);
            this.RegUserName.TabIndex = 6;
            // 
            // RegPassword
            // 
            this.RegPassword.Location = new System.Drawing.Point(112, 95);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(164, 21);
            this.RegPassword.TabIndex = 7;
            this.RegPassword.UseSystemPasswordChar = true;
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(112, 148);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(164, 21);
            this.RegName.TabIndex = 8;
            // 
            // RegCardID
            // 
            this.RegCardID.Location = new System.Drawing.Point(112, 263);
            this.RegCardID.Name = "RegCardID";
            this.RegCardID.Size = new System.Drawing.Size(164, 21);
            this.RegCardID.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backandlogin);
            this.groupBox1.Controls.Add(this.RegClass);
            this.groupBox1.Controls.Add(this.班级);
            this.groupBox1.Controls.Add(this.RegCardID);
            this.groupBox1.Controls.Add(this.RegName);
            this.groupBox1.Controls.Add(this.RegPassword);
            this.groupBox1.Controls.Add(this.RegUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StdReg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生注册";
            // 
            // backandlogin
            // 
            this.backandlogin.Location = new System.Drawing.Point(194, 321);
            this.backandlogin.Name = "backandlogin";
            this.backandlogin.Size = new System.Drawing.Size(91, 36);
            this.backandlogin.TabIndex = 13;
            this.backandlogin.Text = "返回登录";
            this.backandlogin.UseVisualStyleBackColor = true;
            this.backandlogin.Click += new System.EventHandler(this.backandlogin_Click);
            // 
            // RegClass
            // 
            this.RegClass.Location = new System.Drawing.Point(112, 207);
            this.RegClass.Name = "RegClass";
            this.RegClass.Size = new System.Drawing.Size(164, 21);
            this.RegClass.TabIndex = 12;
            // 
            // 班级
            // 
            this.班级.AutoSize = true;
            this.班级.Location = new System.Drawing.Point(53, 210);
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(41, 12);
            this.班级.TabIndex = 11;
            this.班级.Text = "班级：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 435);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "学生注册与登陆";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StdReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegUserName;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegCardID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RegClass;
        private System.Windows.Forms.Label 班级;
        private System.Windows.Forms.Button backandlogin;
    }
}