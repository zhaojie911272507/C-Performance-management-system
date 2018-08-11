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
using System.Data.Odbc;

namespace 学生成绩管理系统
{
    public partial class Form0 : Form
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
        public Form0()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }


       
        private void Login_Click(object sender, EventArgs e)
        {
            string userName = LoginUserName.Text;
            string password = LoginPassword.Text;
           
  
            try
            {
                if(Type.Text==""||Type.Text==null)
                {
                     MessageBox.Show("请选择用户身份");
                    
                }
                else if(LoginUserName.Text==""|| LoginUserName.Text == null||LoginPassword.Text==""|| LoginPassword.Text == "")
                {
                    MessageBox.Show("请输入正确的用户名和密码");
                }
                else if (Type.Text == "管理员")
                {
                    string SelectSQL = "select * from admin where UserName=N'" + userName + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //该用户名存在，从数据中获取保存的加盐哈希值，赋值给变量goodhash
                        string goodhash = ds.Tables[0].Rows[0]["Password"].ToString();

                        //判断用户输入的密码是否匹配
                        if (PasswordSecurity.PasswordStorage.VerifyPassword(password, goodhash))
                        {
                            f9 = new Form9();
                            f9.Show();
                            this.Hide();
                        }
                        else
                        {
                            LoginUserName.Clear();
                            LoginPassword.Clear();
                            MessageBox.Show("如果不是管理员，请离开");
                        }
                    }
                    else
                    {
                        LoginUserName.Clear();
                        LoginPassword.Clear();
                        MessageBox.Show("如果不是管理员，请离开");
                    }
                }
                else if(Type.Text == "教师")
                {
                    string SelectSQL = "select * from teacher where UserName=N'" + userName + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //该用户名存在，从数据中获取保存的加盐哈希值，赋值给变量goodhash
                        string goodhash = ds.Tables[0].Rows[0]["Password"].ToString();
                        //判断用户输入的密码是否匹配
                        if (PasswordSecurity.PasswordStorage.VerifyPassword(password, goodhash))
                        {
                            f3 = new Form3();
                            f3.Show();
                            this.Hide();
                        }
                        else
                        {
                            LoginUserName.Clear();
                            LoginPassword.Clear();
                            MessageBox.Show("如果不是老师，请选择正确的身份登录");
                        }
                    }
                    else
                    {
                        LoginUserName.Clear();
                        LoginPassword.Clear();
                        MessageBox.Show("如果不是老师，请选择正确的身份登录");
                    }
                }
                else if (Type.Text == "学生")
                {
                    string SelectSQL = "select * from StdInfo where UserName=N'" + userName + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string goodhash = ds.Tables[0].Rows[0]["Password"].ToString();
                        if (PasswordSecurity.PasswordStorage.VerifyPassword(password, goodhash))
                        {
                            f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            LoginUserName.Clear();
                            LoginPassword.Clear();
                            MessageBox.Show("用户名或密码错误");
                        }
                    }
                    else
                    {
                        LoginUserName.Clear();
                        LoginPassword.Clear();
                        MessageBox.Show("用户名或密码错误");
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误或身份不匹配");
                }

            }
            catch
            {
                MessageBox.Show("用户名或密码输入错误");
            }

        }

        public string userName
        {
            get { return LoginUserName.Text; }
        }
        //对于get方式，服务器端用Request.QueryString获取变量的值
        public string password
        {
            get { return LoginUserName.Text; }
        }
        public string type
        {
            get { return Type.Text; }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch
            {

            }
        }

        
        private void register_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系老师或管理员");
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // button1.Text = "成功";
            }
            catch
            {
                //  button1.Text = "失败";
                conn.Close();
                MessageBox.Show("数据库连接失败,重新登录");
            }
        }
    }
}
