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
    public partial class frmFreezeAccount : Form
    {
        public frmFreezeAccount()
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
                        lblMoney.Text = reader["Balance"].ToString()+".00";
                        lblState.Text = reader["State"].ToString();
                    }
                    reader.Close();


                    string State = lblState.Text;
                    if (State == "正常")
                    {
                        btnFreeze.Enabled = true;
                        btnFreeze.Text="冻结账户";
                    }
                    if (State == "冻结")
                    {
                        btnFreeze.Enabled = true;
                        btnFreeze.Text = "解冻账户";
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

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            string State = lblState.Text;
            if(State=="正常")
            {
                Freeze();
            }
            else
            {
                UnFreeze();
            }
        }
        private void Freeze()
        {
            string AccNum = txtAccNum.Text;
            string State = "冻结";
            string connstr = "server=.;database=bank;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "update Account_information set State=@State where AccNum=@AccNum";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlParameter p1 = new SqlParameter("@State", State);
                SqlParameter p2 = new SqlParameter("@AccNum", AccNum);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblState.Text = "冻结";
                    MessageBox.Show("冻结账户成功");
                    btnFreeze.Text = "解冻账户";
                  
                }
                else
                {
                    MessageBox.Show("冻结账户失败");
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }





        }

        private void UnFreeze()
        {
            string AccNum = txtAccNum.Text;
            string State = "正常";
            string connstr = "server=.;database=bank;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "update Account_information set State=@State where AccNum=@AccNum";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlParameter p1 = new SqlParameter("@State", State);
                SqlParameter p2 = new SqlParameter("@AccNum", AccNum);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblState.Text = "正常";
                    MessageBox.Show("解冻账户成功");
                    btnFreeze.Text = "冻结账户";
                    
                }
                else
                {
                    MessageBox.Show("解冻账户失败");
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
