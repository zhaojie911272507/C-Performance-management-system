namespace 学生成绩管理系统
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exit = new System.Windows.Forms.Button();
            this.shuaxin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.query = new System.Windows.Forms.Button();
            this.queryxuehao = new System.Windows.Forms.TextBox();
            this.queryxingming = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 482);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "班级";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "课程名";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "成绩";
            this.columnHeader5.Width = 64;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(391, 429);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 45);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "返回";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // shuaxin
            // 
            this.shuaxin.Location = new System.Drawing.Point(391, 26);
            this.shuaxin.Name = "shuaxin";
            this.shuaxin.Size = new System.Drawing.Size(120, 45);
            this.shuaxin.TabIndex = 2;
            this.shuaxin.Text = "刷新";
            this.shuaxin.UseVisualStyleBackColor = true;
            this.shuaxin.Click += new System.EventHandler(this.shuaxin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "成绩从高到低显示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(391, 322);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(120, 45);
            this.query.TabIndex = 4;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // queryxuehao
            // 
            this.queryxuehao.Location = new System.Drawing.Point(436, 225);
            this.queryxuehao.Name = "queryxuehao";
            this.queryxuehao.Size = new System.Drawing.Size(137, 21);
            this.queryxuehao.TabIndex = 5;
            // 
            // queryxingming
            // 
            this.queryxingming.Location = new System.Drawing.Point(436, 283);
            this.queryxingming.Name = "queryxingming";
            this.queryxingming.Size = new System.Drawing.Size(137, 21);
            this.queryxingming.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "姓名：";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.queryxingming);
            this.Controls.Add(this.queryxuehao);
            this.Controls.Add(this.query);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shuaxin);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.listView1);
            this.Name = "Form5";
            this.Text = "学生成绩";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button shuaxin;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.TextBox queryxuehao;
        private System.Windows.Forms.TextBox queryxingming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}