using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            //1.验证数据有效性
            if (IsValid())
            {
                if(IsValid_())
                {
                //2.获得原始数据
            string AccNum =ID.Text;//int32.Parse(txtAccNum.Text);
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string repassword = txtRePassword.Text;
            string Balance = txtMoney.Text;            
                //3.数据库操作
                //3.1创建连接对象
                string connstr = "server=.;database=bank;uid=sa;pwd=123456";
                SqlConnection conn = new SqlConnection(connstr);
                //连接字符串一定要提供
                //conn.ConnectionString = connstr;
                try
                {
                    conn.Open();//打开连接
                    //sql语句
                    
                    string sql = "insert Account_information(AccNum,UserName,Password,Balance) values(@AccNum,@UserName,@Password,@Balance)";
                   
                    //命令对象（操作对象）:SqlCommand:负责执行sql语句
                    SqlCommand cmd = new SqlCommand(sql, conn);//第一个参数表示sql语句，第二个参数表示连接对象
                    SqlParameter p1 = new SqlParameter("@AccNum", AccNum);
                    SqlParameter p2 = new SqlParameter("@UserName", UserName);
                    SqlParameter p3 = new SqlParameter("@Password", Password);
                    SqlParameter p4 = new SqlParameter("@Balance", Balance);          
                   
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
        
                  
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("开户成功");
                       
                    }
                    else
                    {
                        MessageBox.Show("开户失败");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)//如果连接打开
                    {
                        conn.Close();
                    }
                }



            }

            }


        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
           
           
            string connstr = "server=.;database=bank;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            //int num ;
            string str=null;
            int INT;
     
            try 
            {
                conn.Open();//打开连接
                string sql = "select MAX(AccNum) from Account_information ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                str= cmd.ExecuteScalar().ToString();
               // num=int.Parse(this.ID.Text);
                if (string.IsNullOrEmpty(str))
                {
                    this.ID.Text = "10000";
                }
                else
                {
                    // MessageBox.Show("qaq");
                   
                    INT = int.Parse(str) + 1;
                    this.ID.Text = INT.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (conn.State == ConnectionState.Open)//如果连接打开
                {
                    conn.Close();
                }

            }
            
        }
        private bool IsValid()
        {
            if (!string.IsNullOrEmpty(txtMoney.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUserName.Text))
            {
                if(txtPassword.Text==txtRePassword.Text)
                {
                    int num;
                    while (true)
                    {
                        if (int.TryParse(txtMoney.Text, out num))
                        {

                            if(int.Parse(txtMoney.Text)>1)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("开户金额小于1");
                                return false;
                            }

                           
                        }
                        else
                        {
                            MessageBox.Show("开户金额不是数字");
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("密码和重复密码不一致");
                    return false;
                }
                
               
            }
            else
            {
                MessageBox.Show("户主姓名、金额和密码不能为空");
                return false;
            }
           
        }


        private bool IsValid_()
        {

                int num;
                while (true)
                {
                    if (int.TryParse(txtPassword.Text, out num))
                    {
                        if (txtPassword.Text.Length == 6)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("密码必须是六位数字");
                            return false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("密码必须是数字");
                        return false;
                    }
                }
   
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   


    }
}


