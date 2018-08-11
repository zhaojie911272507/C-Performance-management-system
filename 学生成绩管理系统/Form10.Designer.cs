namespace 学生成绩管理系统
{
    partial class Form10
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
            this.backandlogin = new System.Windows.Forms.Button();
            this.RegClass = new System.Windows.Forms.TextBox();
            this.班级 = new System.Windows.Forms.Label();
            this.RegCardID = new System.Windows.Forms.TextBox();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.RegUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StdReg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backandlogin
            // 
            this.backandlogin.Location = new System.Drawing.Point(210, 347);
            this.backandlogin.Name = "backandlogin";
            this.backandlogin.Size = new System.Drawing.Size(91, 36);
            this.backandlogin.TabIndex = 25;
            this.backandlogin.Text = "返回";
            this.backandlogin.UseVisualStyleBackColor = true;
            this.backandlogin.Click += new System.EventHandler(this.backandlogin_Click);
            // 
            // RegClass
            // 
            this.RegClass.Location = new System.Drawing.Point(128, 233);
            this.RegClass.Name = "RegClass";
            this.RegClass.Size = new System.Drawing.Size(164, 21);
            this.RegClass.TabIndex = 24;
            // 
            // 班级
            // 
            this.班级.AutoSize = true;
            this.班级.Location = new System.Drawing.Point(69, 236);
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(41, 12);
            this.班级.TabIndex = 23;
            this.班级.Text = "班级：";
            // 
            // RegCardID
            // 
            this.RegCardID.Location = new System.Drawing.Point(128, 289);
            this.RegCardID.Name = "RegCardID";
            this.RegCardID.Size = new System.Drawing.Size(164, 21);
            this.RegCardID.TabIndex = 22;
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(128, 174);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(164, 21);
            this.RegName.TabIndex = 21;
            // 
            // RegPassword
            // 
            this.RegPassword.Location = new System.Drawing.Point(128, 121);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(164, 21);
            this.RegPassword.TabIndex = 20;
            this.RegPassword.UseSystemPasswordChar = true;
            // 
            // RegUserName
            // 
            this.RegUserName.Location = new System.Drawing.Point(128, 68);
            this.RegUserName.Name = "RegUserName";
            this.RegUserName.Size = new System.Drawing.Size(164, 21);
            this.RegUserName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "姓名：";
            // 
            // StdReg
            // 
            this.StdReg.Location = new System.Drawing.Point(71, 347);
            this.StdReg.Name = "StdReg";
            this.StdReg.Size = new System.Drawing.Size(91, 36);
            this.StdReg.TabIndex = 14;
            this.StdReg.Text = "添加";
            this.StdReg.UseVisualStyleBackColor = true;
            this.StdReg.Click += new System.EventHandler(this.StdReg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "密码：";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.backandlogin);
            this.Controls.Add(this.RegClass);
            this.Controls.Add(this.班级);
            this.Controls.Add(this.RegCardID);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StdReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form10";
            this.Text = "添加学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backandlogin;
        private System.Windows.Forms.TextBox RegClass;
        private System.Windows.Forms.Label 班级;
        private System.Windows.Forms.TextBox RegCardID;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.TextBox RegUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StdReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}