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
    public partial class frmCloseAccount : Form
    {
        public frmCloseAccount()
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

        private void btnCloseAcc_Click(object sender, EventArgs e)
        {
            string s = txtAccNum.Text;//
            Login frm = new Login(s);//
            frm.chuan += frm_chuan;
            frm.Show();
        }

        void frm_chuan()
        {
            
            float balance=float.Parse(lblMoney.Text);

            if(balance==0)
            {
                CloseAcc();
            }
            else
            {
                MessageBox.Show("请将余额" + lblMoney.Text + "取出");
            }
           
            //throw new NotImplementedException();
        }


        private void CloseAcc()
        {
            string AccNum = txtAccNum.Text;
            string State = "销户";
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
                    MessageBox.Show("销户成功！" + "户主姓名为：" + lblName.Text + "的账号销户成功！");
                   
                }
                else
                {
                    MessageBox.Show("销户失败");
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


    }
}
