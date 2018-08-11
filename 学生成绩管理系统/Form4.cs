using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 学生成绩管理系统
{
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }
        private void button5_Click(object sender, EventArgs e)
        {

            f5 = new Form5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            f5.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                string xuehao = xuehaoadd.Text;
                string kechenghao = kechenghaoadd.Text;
                string cj = cjadd.Text;
                if(xuehaoadd.Text=="" && kechenghaoadd.Text==""&&cjadd.Text==""|| xuehaoadd.Text == null && kechenghaoadd.Text == null && cjadd.Text == null)
                {
                    MessageBox.Show("请填写完整的添加信息");
                }
                else if(xuehaoadd.Text==""|| xuehaoadd.Text == null)
                {
                    MessageBox.Show("学号不能为空");
                }
                else if(kechenghaoadd.Text==""|| kechenghaoadd.Text == null)
                {
                    MessageBox.Show("课程号不能为空");
                }
                else if(cjadd.Text==""|| cjadd.Text == null)
                {
                    MessageBox.Show("成绩不能为空");
                }
                else
                {
                    xuehaoadd.Clear();
                    kechenghaoadd.Update();
                    cjadd.Clear();
                    //先判断学号和课程号是否重复
                    string selectSQL = "select * from cjb where 学号='" + xuehao + "' or 课程号='" + kechenghao + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, selectSQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //有重复的
                        MessageBox.Show("该学号的该课程成绩已存在");
                    }
                    else
                    {
                       
                        string insertSQL = "INSERT INTO cjb VALUES ('" + xuehao + "', '" + kechenghao + "', N'" + cj + "')";
                        int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, insertSQL);
                        if (result > 0)
                        {
                            MessageBox.Show("信息添加成功");
                        }
                        else
                        {
                            MessageBox.Show("信息添加失败");
                        }
                    }
                       
                }
             
            }
            catch
            {
                MessageBox.Show("添加失败,请重新添加");
            }

        }


        private void alert_Click(object sender, EventArgs e)
        {
            try
            {
                string xuehao = xuehaoalert.Text;
                string kechenghao = kechenghaoalert.Text;
                string cj = cjalert.Text;

                if (xuehaoalert.Text == "" && kechenghaoalert.Text == "" && cjalert.Text == ""|| xuehaoalert.Text == null && kechenghaoalert.Text == null && cjalert.Text == null)
                {
                    MessageBox.Show("请填写完整的添加信息");
                }
                else if (xuehaoalert.Text == ""|| xuehaoalert.Text == null)
                {
                    MessageBox.Show("学号不能为空");
                }
                else if (kechenghaoalert.Text == ""|| kechenghaoalert.Text == null)
                {
                    MessageBox.Show("课程号不能为空");
                }
                else if (cjalert.Text == ""|| cjalert.Text == null)
                {
                    MessageBox.Show("成绩不能为空");
                }
                else
                {
                    xuehaoalert.Clear();
                    kechenghaoalert.Update();
                    cjalert.Clear();
                    string selectSQL = "select * from cjb where 学号='" + xuehao + "' or 课程号='" + kechenghao + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, selectSQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                      
                        string alertSQL = "update cjb set 成绩='" + cj + "' where 学号='" + xuehao + "' and 课程号='" + kechenghao + "'";
                        int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, alertSQL);
                        if (result > 0)
                        {

                            MessageBox.Show("信息修改成功");

                        }
                        else
                        {

                            MessageBox.Show("信息修改失败");
                        }

                    }
                    else
                    {
                        MessageBox.Show("该学号的该课程成绩已存在");
                    }

                   
                }
                    
            }
            catch
            {
                MessageBox.Show("修改失败,请重新修改");
            }
            
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                string xuehao = xuehaodel.Text;
                string kechenghao = kechenghaodel.Text;
                if (xuehaodel.Text==""|| xuehaodel.Text == null)
                {
                    MessageBox.Show("请填写学号");
                }
                else if(kechenghaodel.Text==""|| kechenghaodel.Text == null)
                {
                    MessageBox.Show("请填写课程号");
                }
                else
                {
                    xuehaodel.Clear();
                    kechenghaodel.Update();
                    string selectSQL = "select * from cjb where 学号='" + xuehao + "' or 课程号='" + kechenghao + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, selectSQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string delSQL = "delete from cjb where 学号='" + xuehao + "' and 课程号='" + kechenghao + "'";
                        int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, delSQL);
                        if (result > 0)
                        {
                            MessageBox.Show("信息删除成功");
                        }
                        else
                        {
                            MessageBox.Show("信息删除失败，检查输入是否有误");
                        }
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("学号或课程号输入错误");
                    }

                    
                }
            }
            catch
            {
                MessageBox.Show("删除失败,检查输入是否有误");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            f5.Show();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            xuehaoadd.Clear();
            kechenghaoadd.Update();
            cjadd.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            xuehaoalert.Clear();
            kechenghaoalert.Update();
            cjalert.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xuehaodel.Clear();
            kechenghaodel.Update();
          
        }
    }
}
