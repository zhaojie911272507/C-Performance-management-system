using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生成绩管理系统
{
    public partial class Form3 : Form
    {
        Form0 f1;
        Form4 f4;
        Form5 f5;
        Form11 f11;
        public Form3()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void StdInfo_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Show();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            f5.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            f1 = new Form0();
            f1.Show();
            this.Close();
        }

        private void alertPassword_Click(object sender, EventArgs e)
        {
            f11 = new Form11();
            f11.Show();
        }
    }
}
