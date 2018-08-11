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
    public partial class Form6 : Form
    {
        Form0 f0;
        Form1 f1;
        Form2 f2;
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        Form7 f7;
        Form10 f10;


        private static string serverIP = "localhost\\sqlexpress";

        //连接本地数据库的字符串
        private static string connString = "server=" + serverIP + ";database=RFIDLab;integrated security=SSPI";
        SqlConnection conn = new SqlConnection();
        public Form6()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            f10 = new Form10();
            f10.Show();

        }

        private void delStdInfo_Click(object sender, EventArgs e)
        {
            string xuehao = StdUserName.Text;
            string username = StdPassword.Text;
            try
            {
                if (StdUserName.Text == "" || StdUserName.Text == null)
                {
                    MessageBox.Show("请输入学号");
                }
                else if (StdPassword.Text == "" || StdPassword.Text == null)
                {
                    MessageBox.Show("请输入用户名");
                }
                else
                {
                    StdUserName.Clear();
                    StdPassword.Clear();
                    //从数据库选择用户输入的用户名的所有信息
                    string SelectSQL = "select * from UserInfo where CardID=N'" + xuehao + "' and UserName='" + username + "' ";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string delSQL = "delete from StdInfo where 学号='" + xuehao + "' and UserName='" + username + "'";
                        int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, delSQL);
                        if (result > 0)
                        {
                            MessageBox.Show("信息删除成功");
                        }
                        else
                        {
                            MessageBox.Show("信息删除失败，检查输入信息");
                        }
                    }
                    else
                    {
                        MessageBox.Show("信息输入有误，请重新输入");
                    }
                }
            }
            catch
            {

            }
        }
               
        

        private void delTeaInfo_Click(object sender, EventArgs e)
        {
            string username = teaUserName.Text;
            string password = teaPassword.Text;
            try
            {
                if (teaUserName.Text == "" || teaUserName.Text == null)
                {
                    MessageBox.Show("请输入用户名");
                }
                else if (teaPassword.Text == "" || teaPassword.Text == null)
                {
                    MessageBox.Show("请输入用户名");
                }
                else
                {
                    StdUserName.Clear();
                    StdPassword.Clear();
                    //从数据库选择用户输入的用户名的所有信息
                    string SelectSQL = "select * from teacher where  UserName='" + username + "' ";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string delSQL = "delete from teacher where  UserName='" + username + "'";
                        int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, delSQL);
                        if (result > 0)
                        {
                            MessageBox.Show("信息删除成功");
                        }
                        else
                        {
                            MessageBox.Show("信息删除失败，检查输入信息");
                        }
                    }
                    else
                    {
                        MessageBox.Show("信息输入有误，请重新输入");
                    }
                }
            }
            catch
            {

            }

        }



        private void sureTeaAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string username = teaUserName.Text;
                string password = teaPassword.Text;
                if (teaUserName.Text == "" || teaUserName.Text == null)
                {
                    MessageBox.Show("请输入用户名");
                }
                else if (teaPassword.Text == "" || teaPassword.Text == null)
                {
                    MessageBox.Show("请输入密码");
                }
                else
                {
                    if (Regex.IsMatch(password, @"^[a-zA-Z0-9]\w{5,17}$") == false)
                    {
                        MessageBox.Show("密码以字母开头，长度在6~18之间，只能包含字母、数字和下划线");
                    }
                    else
                    {
                        string SelectSQL = "select * from teacher where  UserName='" + username + "' ";

                        DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("改用户名已存在，请重新输入");
                        }
                        else
                        {
                            password = PasswordSecurity.PasswordStorage.CreateHash(teaPassword.Text);

                            //将数据存入数据库
                            string insertSQL = "INSERT INTO teacher VALUES ('" + username + "', '" + password + "')";

                            int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, insertSQL);

                            if (result > 0)
                            {
                                MessageBox.Show("老师信息添加成功");
                            }
                            else
                            {
                                MessageBox.Show("老师信息添加失败");
                            }

                        }
                    }
                }
            }
            catch
            {

            }
            
           
        }
    }
}

