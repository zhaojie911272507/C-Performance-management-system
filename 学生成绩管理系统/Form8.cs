using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生成绩管理系统
{
    public partial class Form8 : Form
    {
        Form0 f0;
        Form1 f1;
        Form2 f2;
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        Form7 f7;
        Form9 f9;
        //数据库地址
        private static string serverIP = "localhost\\sqlexpress";
        //连接本地数据库的字符串
        private static string connString = "server=" + serverIP + ";database=RFIDLab;integrated security=SSPI";
        SqlConnection conn = new SqlConnection();

        public Form8()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f0 = new Form0();
            string username = f0.userName;
            try
            {
                //获取所有用户信息
                //string sql = "select cjb.课程号,课程名,成绩 from cjb,kcb where cjb.课程号=kcb.课程号 and 学号=(select CardID from StdInfo where UserName=N'" + username + "')";
                string sql = "select cjb.课程号,课程名,成绩 from cjb,kcb where cjb.课程号=kcb.课程号 and 学号=(select CardID from StdInfo where UserName=N'zhaojie')";
                DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //先清空列表
                    this.listView1.Items.Clear();

                    //有用户存在
                    //循环数据库中每一个用户信息，将每个姓名和班级当作一行存到列表变量中
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        //获取用户姓名信息
                        string cj = ds.Tables[0].Rows[i]["成绩"].ToString();

                        string kcm = ds.Tables[0].Rows[i]["课程名"].ToString();

                        string kch = ds.Tables[0].Rows[i]["课程号"].ToString();
                        //在列表第一列显示班级信息
                        ListViewItem lvi = new ListViewItem(kch);
                       
                        //在列表第二列显示姓名信息
                        lvi.SubItems.Add(kcm);
                    
                        lvi.SubItems.Add(cj);


                        this.listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    //没有数据，将现有数据清空
                    this.listView1.Items.Clear();
                }
            }
            catch
            {

            }
        }

        private void shuaxin_Click(object sender, EventArgs e)
        {

            f0 = new Form0();
            string username = f0.userName;
            try
            {
                //获取所有用户信息
                //string sql = "select cjb.课程号,课程名,成绩 from cjb,kcb where cjb.课程号=kcb.课程号 and 学号=(select CardID from StdInfo where UserName=N'" + username + "')";
                string sql = "select cjb.课程号,课程名,成绩 from cjb,kcb where cjb.课程号=kcb.课程号 and 学号=(select CardID from StdInfo where UserName=N'zhaojie')";
                DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //先清空列表
                    this.listView1.Items.Clear();

                    //有用户存在
                    //循环数据库中每一个用户信息，将每个姓名和班级当作一行存到列表变量中
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        //获取用户姓名信息
                        string cj = ds.Tables[0].Rows[i]["成绩"].ToString();

                        string kcm = ds.Tables[0].Rows[i]["课程名"].ToString();

                        string kch = ds.Tables[0].Rows[i]["课程号"].ToString();
                        //在列表第一列显示班级信息
                        ListViewItem lvi = new ListViewItem(kch);

                        //在列表第二列显示姓名信息
                        lvi.SubItems.Add(kcm);
                    
                        lvi.SubItems.Add(cj);


                        this.listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    //没有数据，将现有数据清空
                    this.listView1.Items.Clear();
                }
            }
            catch
            {

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            f0 = new Form0();
            f0.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
