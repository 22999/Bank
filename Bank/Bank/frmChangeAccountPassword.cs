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
    public partial class frmChangeAccountPassword : Form
    {
        public frmChangeAccountPassword()
        {
            InitializeComponent();
        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string AccNum = txtAccNum.Text;
                //string str = null;
                string connstr = "server=.;database=bank;uid=sa;pwd=123456";
                SqlConnection conn = new SqlConnection(connstr);
                try
                {
                    conn.Open();
                    string sql = "select * from Account_information where AccNum=@AccNum";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlParameter p1 = new SqlParameter("@AccNum", AccNum);
                    cmd.Parameters.Add(p1);
                    //str = cmd.ExecuteScalar().ToString();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblName.Text = reader["UserName"].ToString();
                        //lblMoney.Text = reader["Balance"].ToString()+".00";
                        lblState.Text = reader["State"].ToString();
                    }
                    reader.Close();
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

        }


        private bool IsValid()
        {
            if (!string.IsNullOrEmpty(txtAccNum.Text))
            {
                int num;
                while (true)
                {
                    if (int.TryParse(txtAccNum.Text, out num))
                    {
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("输入的账号必须是数字");
                        return false;
                    }
                }
            }
            else
            {
                //MessageBox.Show("账户不存在");
                return false;
            }
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        { 
            if(IsValid_())
            {
                if (Select_pwd())
                {
                    string AccNum = txtAccNum.Text;
                    string Password = txtNewpwd.Text;

                    string connstr = "server=.;database=bank;uid=sa;pwd=123456";
                    SqlConnection conn = new SqlConnection(connstr);
                    try
                    {
                        conn.Open();
                        string sql = "update Account_information set Password=@Password where AccNum=@AccNum";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        SqlParameter p1 = new SqlParameter("@Password", Password);
                        SqlParameter p2 = new SqlParameter("@AccNum", AccNum);
                        cmd.Parameters.Add(p1);
                        cmd.Parameters.Add(p2);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("修改密码成功");

                        }
                        else
                        {
                            MessageBox.Show("修改密码失败");
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

            }
        }

        //检验旧密码和数据库里的密码一致不//
        private bool Select_pwd()
        {
           
          
                string AccNum = txtAccNum.Text;
                string pwd = null;
                string connstr = "server=.;database=bank;uid=sa;pwd=123456";
                SqlConnection conn = new SqlConnection(connstr);
                try
                {
                    conn.Open();
                    string sql = "select * from Account_information where AccNum=@AccNum";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlParameter p1 = new SqlParameter("@AccNum", AccNum);
                    cmd.Parameters.Add(p1);
                    //str = cmd.ExecuteScalar().ToString();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                       pwd = reader["Password"].ToString();                    
                    }
                    reader.Close();


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
                if (pwd == txtOldpwd.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("旧密码错误");
                    return false;
                }
                
        }

         private bool IsValid_()
        {
            if (!string.IsNullOrEmpty(txtOldpwd.Text) && !string.IsNullOrEmpty(txtNewpwd.Text) && !string.IsNullOrEmpty(txtRepwd.Text))
              {
                if(txtNewpwd.Text==txtRepwd.Text)
                {
                    int num;
                    while (true)
                    {
                        if (int.TryParse(txtNewpwd.Text, out num))
                        {
                          if(txtNewpwd.Text.Length==6)
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
                else
                {
                    MessageBox.Show("新密码和重复密码不一致");
                    return false;
                }

              }
            else
            {
                MessageBox.Show("旧密码、新密码、重复密码不能为空");
                return false;
            }

        }


         private bool IsValid(string s)
         {
             if (!string.IsNullOrEmpty(s))
             {
                 int num;
                 while (true)
                 {
                     if (int.TryParse(s, out num))
                     {
                         return true;

                     }
                     else
                     {
                         MessageBox.Show("输入的密码必须是数字");
                         return false;
                     }
                 }
             }
             else
             {
                 //MessageBox.Show("账户不存在");
                 return false;
             }
         }


        //###检验密码是否合理
         private void txtOldpwd_TextChanged(object sender, EventArgs e)
         {
             IsValid(txtOldpwd.Text);
         }
        
         private void txtNewpwd_TextChanged(object sender, EventArgs e)
         {
             IsValid(txtNewpwd.Text);
         }

         private void txtRepwd_TextChanged(object sender, EventArgs e)
         {
             IsValid(txtRepwd.Text);
         }
      //###检验完毕
    }
}
