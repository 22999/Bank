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
    public partial class frmTakeOutMoney : Form
    {
        public frmTakeOutMoney()
        {
            InitializeComponent();
        }


        private void txtMoney_TextChanged(object sender, EventArgs e)
         {
            
             IsValid_();
           
         }

        private bool IsValid_()
        {
            if (!string.IsNullOrEmpty(txtMoney.Text))
            {
                int num;
                while (true)
                {
                    if (int.TryParse(txtMoney.Text, out num))
                    {
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("输入的取款金额必须是数字并且大于0");
                        return false;
                    }
                }
            }
            else
            {
                //MessageBox.Show("取款金额不为空");
                return false;
            }

        }

       

        private void btnTake_Click(object sender, EventArgs e)
        {
            string s = txtAccNum.Text;//
            Login frm = new Login(s);//
            frm.chuan += frm_chuan;
            frm.Show();

            //if (Login.flag == "True")
            //{

            //    MessageBox.Show("Test");
            //    print();
            //   
            //    Login.flag = "False";
            //}
            //else
            //{
            //    MessageBox.Show("Test");
            //}
            
        }

        void frm_chuan()//回调函数，tab两下生成
        {
            if(State_())
            {
                Print_Talk();
            }
            else
            {
                MessageBox.Show("您账户状态是 “销户”或“冻结”");
            }
           
        }

        private bool State_()
        {  
                string AccNum = txtAccNum.Text;
                string str = null;
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
                        str = reader["State"].ToString();
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
               if(str=="正常")
               {
                   btnTake.Enabled = true;
                   return true;
               }
               else
               {
                   btnTake.Enabled = false;
                   return false;
               }
                     
        }


        private void Print_Talk()
        {

            string AccNum = txtAccNum.Text;
            float Float;
            float Float_;
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
                    lblMoney.Text = reader["Balance"].ToString() + ".00";
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
            Float = float.Parse(lblMoney.Text);
            Float_ = float.Parse(txtMoney.Text);
            if (Float >= Float_)
            {
                Take();
            }
            else
            {
                MessageBox.Show("取款金额必须小于账户余额");
            }


        }
        private void  Take()
        {
            
            float money = float.Parse(txtMoney.Text);
            float balance = float.Parse(lblMoney.Text);
            float sub = balance - money;
            string Balance = sub.ToString();
            lblMoney.Text = Balance + ".00";//标记--------------------------------------

            string AccNum = txtAccNum.Text;
            //string str = null;
            string connstr = "server=.;database=bank;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "update Account_information set Balance=@Balance where AccNum=@AccNum";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlParameter p1 = new SqlParameter("@Balance", Balance);
                SqlParameter p2 = new SqlParameter("@AccNum", AccNum);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("取款成功！\n" + "账号为：" + txtAccNum.Text + "  当前余额为：" + lblMoney.Text);
                    
                }
                else
                {
                    MessageBox.Show("取款失败");
                }

                //str = cmd.ExecuteScalar().ToString();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {
            IsValid();
        }
    }
}
