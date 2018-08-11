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
using System.Text.RegularExpressions;

namespace 学生成绩管理系统
{
    public partial class Form7 : Form
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
        public Form7()
        {
            InitializeComponent();
            conn.ConnectionString = connString;
        }

        private void SureAlert_Click(object sender, EventArgs e)
        {
            f0 = new Form0();
            string newpassword = NewPassword.Text;
            string surepassword = SurePassword.Text;
            string username = f0.userName;
            string password = f0.password;
            string type = f0.type;
            try
            {
                if (OldPassword.Text == "" || OldPassword.Text == null)
                {
                    MessageBox.Show("请输入正确的旧密码");
                }
                else if (/*NewPassword.Text*/newpassword == "" || /*NewPassword.Text*/ newpassword == null || /*SurePassword.Text*/surepassword == "" || /*SurePassword.Text*/ surepassword == null)
                {
                    MessageBox.Show("请输入密码");
                }
                else if (Regex.IsMatch(newpassword, @"^[a-zA-Z0-9]\w{5,17}$") == false)
                {
                    MessageBox.Show("密码以字母开头，长度在6~18之间，只能包含字母、数字和下划线");
                }
                else
                {
                  //  if (type == "学生")
                  //  {
                        string SelectSQL = "select * from StdInfo where UserName=N'" + username + "'";

                        DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, SelectSQL);
                        string goodhash = ds.Tables[0].Rows[0]["Password"].ToString();

                        //判断用户输入的密码是否匹配
                        if (PasswordSecurity.PasswordStorage.VerifyPassword(password, goodhash))
                        {
                            if (newpassword != surepassword)
                            {
                                MessageBox.Show("两次输入的密码不一致");
                            }
                            else if (newpassword == surepassword)
                            {
                                try
                                {
                                    int result;
                                    password = PasswordSecurity.PasswordStorage.CreateHash(newpassword);
                                    string alertSQL = "update StdInfo set Password ='" + password + "' where UserName = '" + username + "'";
                                    result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, alertSQL);

                                    MessageBox.Show("密码修改成功，请重新登录");
                                    f0 = new Form0();
                                    f0.Show();
                                    this.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("密码修改失败");
                                }
                                
 
                            }
                     //   }
                      
                    }
               
                }
            }
            catch
            {
                MessageBox.Show("密码修改失败");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
