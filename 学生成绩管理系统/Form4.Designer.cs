namespace 学生成绩管理系统
{
    partial class Form4
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
            this.add = new System.Windows.Forms.Button();
            this.alert = new System.Windows.Forms.Button();
            this.addbox = new System.Windows.Forms.GroupBox();
            this.kechenghaoadd = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.cjadd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuehaoadd = new System.Windows.Forms.TextBox();
            this.xuehaoalert = new System.Windows.Forms.TextBox();
            this.cjalert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.kechenghaoalert = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.kechenghaodel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xuehaodel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(267, 20);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 34);
            this.add.TabIndex = 0;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // alert
            // 
            this.alert.Location = new System.Drawing.Point(268, 22);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(75, 35);
            this.alert.TabIndex = 3;
            this.alert.Text = "修改";
            this.alert.UseVisualStyleBackColor = true;
            this.alert.Click += new System.EventHandler(this.alert_Click);
            // 
            // addbox
            // 
            this.addbox.Controls.Add(this.kechenghaoadd);
            this.addbox.Controls.Add(this.button7);
            this.addbox.Controls.Add(this.cjadd);
            this.addbox.Controls.Add(this.label5);
            this.addbox.Controls.Add(this.button5);
            this.addbox.Controls.Add(this.label2);
            this.addbox.Controls.Add(this.label1);
            this.addbox.Controls.Add(this.xuehaoadd);
            this.addbox.Controls.Add(this.add);
            this.addbox.Location = new System.Drawing.Point(12, 12);
            this.addbox.Name = "addbox";
            this.addbox.Size = new System.Drawing.Size(408, 169);
            this.addbox.TabIndex = 4;
            this.addbox.TabStop = false;
            this.addbox.Text = "添加";
            // 
            // kechenghaoadd
            // 
            this.kechenghaoadd.FormattingEnabled = true;
            this.kechenghaoadd.Items.AddRange(new object[] {
            "101",
            "102",
            "206"});
            this.kechenghaoadd.Location = new System.Drawing.Point(99, 74);
            this.kechenghaoadd.Name = "kechenghaoadd";
            this.kechenghaoadd.Size = new System.Drawing.Size(129, 20);
            this.kechenghaoadd.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(267, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 34);
            this.button7.TabIndex = 9;
            this.button7.Text = "取消";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cjadd
            // 
            this.cjadd.Location = new System.Drawing.Point(99, 111);
            this.cjadd.Name = "cjadd";
            this.cjadd.Size = new System.Drawing.Size(129, 21);
            this.cjadd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "课程号：";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "查看";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "成绩：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "学号：";
            // 
            // xuehaoadd
            // 
            this.xuehaoadd.Location = new System.Drawing.Point(99, 35);
            this.xuehaoadd.Name = "xuehaoadd";
            this.xuehaoadd.Size = new System.Drawing.Size(129, 21);
            this.xuehaoadd.TabIndex = 0;
            // 
            // xuehaoalert
            // 
            this.xuehaoalert.Location = new System.Drawing.Point(100, 36);
            this.xuehaoalert.Name = "xuehaoalert";
            this.xuehaoalert.Size = new System.Drawing.Size(129, 21);
            this.xuehaoalert.TabIndex = 2;
            // 
            // cjalert
            // 
            this.cjalert.Location = new System.Drawing.Point(100, 119);
            this.cjalert.Name = "cjalert";
            this.cjalert.Size = new System.Drawing.Size(129, 21);
            this.cjalert.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "学号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "成绩：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.kechenghaoalert);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.xuehaoalert);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.alert);
            this.groupBox2.Controls.Add(this.cjalert);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(11, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 169);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kechenghaoalert
            // 
            this.kechenghaoalert.FormattingEnabled = true;
            this.kechenghaoalert.Items.AddRange(new object[] {
            "101",
            "102",
            "206"});
            this.kechenghaoalert.Location = new System.Drawing.Point(100, 78);
            this.kechenghaoalert.Name = "kechenghaoalert";
            this.kechenghaoalert.Size = new System.Drawing.Size(129, 20);
            this.kechenghaoalert.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "课程号：";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(268, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "查看";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.del);
            this.groupBox3.Controls.Add(this.kechenghaodel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.xuehaodel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(11, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 147);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 18;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "查看";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(266, 18);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 34);
            this.del.TabIndex = 16;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // kechenghaodel
            // 
            this.kechenghaodel.FormattingEnabled = true;
            this.kechenghaodel.Items.AddRange(new object[] {
            "101",
            "102",
            "206"});
            this.kechenghaodel.Location = new System.Drawing.Point(100, 84);
            this.kechenghaodel.Name = "kechenghaodel";
            this.kechenghaodel.Size = new System.Drawing.Size(129, 20);
            this.kechenghaodel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "课程号：";
            // 
            // xuehaodel
            // 
            this.xuehaodel.Location = new System.Drawing.Point(100, 42);
            this.xuehaodel.Name = "xuehaodel";
            this.xuehaodel.Size = new System.Drawing.Size(129, 21);
            this.xuehaodel.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "学号：";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addbox);
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "Form4";
            this.Text = "成绩管理";
            this.TopMost = true;
            this.addbox.ResumeLayout(false);
            this.addbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button alert;
        private System.Windows.Forms.GroupBox addbox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuehaoadd;
        private System.Windows.Forms.TextBox xuehaoalert;
        private System.Windows.Forms.TextBox cjalert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox cjadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox kechenghaoadd;
        private System.Windows.Forms.ComboBox kechenghaoalert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox kechenghaodel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xuehaodel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}