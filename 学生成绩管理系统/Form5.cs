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
using System.Text.RegularExpressions;

namespace 学生成绩管理系统
{
    public partial class Form5 : Form
    {
        Form0 f0;
        Form1 f1;
        Form2 f2;
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        Form7 f7;

        private static string serverIP = "localhost\\sqlexpress";

        //连接本地数据库的字符串
        private static string connString = "server=" + serverIP + ";database=RFIDLab;integrated security=SSPI";
        SqlConnection conn = new SqlConnection();
        public Form5()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //获取所有用户信息
                string sql = "select 学号,UserName,Class,课程名,成绩 from StdInfo,cjb,kcb  where  cjb.课程号=kcb.课程号 and cjb.学号=StdInfo.CardID order by 学号";

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
                        string CardID = ds.Tables[0].Rows[i]["学号"].ToString();
                        string Name = ds.Tables[0].Rows[i]["UserName"].ToString();
                        string Class = ds.Tables[0].Rows[i]["Class"].ToString();
                        string kcm = ds.Tables[0].Rows[i]["课程名"].ToString();
                        string cj = ds.Tables[0].Rows[i]["成绩"].ToString();

                        //在列表第一列显示班级信息
                        ListViewItem lvi = new ListViewItem(CardID);

                        //在列表第二列显示姓名信息
                        lvi.SubItems.Add(Name);
                        lvi.SubItems.Add(Class);
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

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timer1.Stop();
                conn.Close();
            }
            catch
            {
            }
        }


        private void shuaxin_Click(object sender, EventArgs e)
        {
            try
            {
                //获取所有用户信息
                string sql = "select 学号,UserName,Class,课程名,成绩 from StdInfo,cjb,kcb  where  cjb.课程号=kcb.课程号 and cjb.学号=StdInfo.CardID order by 学号";

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
                        string CardID = ds.Tables[0].Rows[i]["学号"].ToString();
                        string Name = ds.Tables[0].Rows[i]["UserName"].ToString();
                        string Class = ds.Tables[0].Rows[i]["Class"].ToString();
                        string kcm = ds.Tables[0].Rows[i]["课程名"].ToString();
                        string cj = ds.Tables[0].Rows[i]["成绩"].ToString();

                        //在列表第一列显示班级信息
                        ListViewItem lvi = new ListViewItem(CardID);

                        //在列表第二列显示姓名信息
                        lvi.SubItems.Add(Name);
                        lvi.SubItems.Add(Class);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //获取所有用户信息
                string sql = "select 学号,UserName,Class,课程名,成绩 from StdInfo,cjb,kcb  where  cjb.课程号=kcb.课程号 and cjb.学号=StdInfo.CardID order by 成绩 desc";

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
                        string CardID = ds.Tables[0].Rows[i]["学号"].ToString();
                        string Name = ds.Tables[0].Rows[i]["UserName"].ToString();
                        string Class = ds.Tables[0].Rows[i]["Class"].ToString();
                        string kcm = ds.Tables[0].Rows[i]["课程名"].ToString();
                        string cj = ds.Tables[0].Rows[i]["成绩"].ToString();

                        //在列表第一列显示班级信息
                        ListViewItem lvi = new ListViewItem(CardID);

                        //在列表第二列显示姓名信息
                        lvi.SubItems.Add(Name);
                        lvi.SubItems.Add(Class);
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

        private void query_Click(object sender, EventArgs e)
        {

            try
            {
                string xuehao = queryxuehao.Text;
                string xingming = queryxingming.Text;

                //获取所有用户信息
                if (queryxuehao.Text == "" || queryxuehao.Text == null)
                {
                    MessageBox.Show("请输入您所要查询的学号");
                }
                else if (queryxingming.Text==""|| queryxingming.Text==null)
                {
                    MessageBox.Show("请输入你所要查询的姓名");
                }
                else
                {
                    queryxuehao.Clear();
                    queryxingming.Clear();
                    string sql = "select 学号,UserName,Class,课程名,成绩 from StdInfo,cjb,kcb  where  cjb.课程号=kcb.课程号 and cjb.学号=StdInfo.CardID and StdInfo.Name=N'" + xingming + "' and cjb.学号='" + xuehao + "'order by 成绩 desc";
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
                            string CardID = ds.Tables[0].Rows[i]["学号"].ToString();
                            string Name = ds.Tables[0].Rows[i]["UserName"].ToString();
                            string Class = ds.Tables[0].Rows[i]["Class"].ToString();
                            string kcm = ds.Tables[0].Rows[i]["课程名"].ToString();
                            string cj = ds.Tables[0].Rows[i]["成绩"].ToString();

                            //在列表第一列显示班级信息
                            ListViewItem lvi = new ListViewItem(CardID);

                            //在列表第二列显示姓名信息
                            lvi.SubItems.Add(Name);
                            lvi.SubItems.Add(Class);
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
                

            }
            catch
            {

            }
        }
    }
}
