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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }

        private void StdReg_Click(object sender, EventArgs e)
        {
            try
            {
                //从用户名文本框获取字符串给用户名变量赋值
                string userName = RegUserName.Text;

                //从密码文本框获取字符串给密码变量赋值
                string password = RegPassword.Text;

                //从姓名文本框获取字符串给姓名变量赋值
                string name = RegName.Text;

                //从班级文本框获取字符串给班级变量赋值
                string className = RegClass.Text;

                //从学号文本框获取字符串给学号变量赋值
                string cardID = RegCardID.Text;

                //利用正则表达式判断各文本框内的值是否符合要求
                if (Regex.IsMatch(userName, @"^[a-zA-Z][a-zA-Z0-9_]{4,15}$") == false)
                {
                    MessageBox.Show("用户名只能由英文和数字组成，长度为5-16个字节");
                }
                else if (Regex.IsMatch(password, @"^[a-zA-Z0-9]\w{5,17}$") == false)
                {
                    MessageBox.Show("密码以字母开头，长度在6~18之间，只能包含字母、数字和下划线");
                }
                else if (Regex.IsMatch(name, @"^[\u4e00-\u9fa5]+$") == false)
                {
                    MessageBox.Show("姓名只能为中文");
                }
                else if (Regex.IsMatch(className, @"^[0-9]+$") == false || Regex.IsMatch(cardID, @"^[0-9]+$") == false)
                {
                    MessageBox.Show("班级和卡号只能为数字");
                }
                else
                {
                    //用户输入的都符合要求

                    //先判断用户名和学号是否重复
                    string selectSQL = "select * from StdInfo where UserName='" + userName + "' or CardID='" + cardID + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, selectSQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //有重复的
                        MessageBox.Show("用户名或学号已被注册");
                    }
                    else
                    {

                        RegUserName.Clear();
                        RegPassword.Clear();
                        RegName.Clear();
                        RegClass.Clear();
                        RegCardID.Clear();
                        //没有重复的

                        //将用户输入的密码进行加盐哈希处理
                        password = PasswordSecurity.PasswordStorage.CreateHash(RegPassword.Text);

                        //将数据存入数据库
                        string insertSQL = "INSERT INTO StdInfo VALUES ('" + userName + "', '" + password + "', N'" + name + "', '" + className + "','" + cardID + "')";

                        int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, insertSQL);
                        if (result > 0)
                        {
                            MessageBox.Show("注册成功，请返回登录");

                        }
                        else
                        {

                            MessageBox.Show("注册失败，请重新注册");
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("注册失败");
            }

        }

        private void backandlogin_Click(object sender, EventArgs e)
        {
            this.Close();
            f0 = new Form0();
            f0.Show();
        }
    }

    }
