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
    public partial class Form2 : Form
    {

        Form0 f0;
        Form1 f1;
        Form2 f2;
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        Form7 f7;
        Form8 f8;
        public Form2()
        {
            InitializeComponent();
        }

        private void stdgrade_Click(object sender, EventArgs e)
        {
            f8 = new Form8();
            f8.Show();
        }

        private void stdexit_Click(object sender, EventArgs e)
        {
            f0 = new Form0();
            f0.Show();
            this.Close();
            f0.Show();
        }

        private void alertstdpassword_Click(object sender, EventArgs e)
        {
            f7 = new Form7();
            f7.Show();
        }
    }
}
