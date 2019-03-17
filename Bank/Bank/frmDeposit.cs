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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string AccNum = txtAccNum.Text;
              
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
                if(lblState.Text=="正常")
                {
                    btnSave.Enabled = true;
                }
                else 
                {
                    btnSave.Enabled = false;
                }

            }

        }
        //数据合理性
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

         private void txtMoney_TextChanged(object sender, EventArgs e)
         {
             //int num;
             IsValid_();
             //{
                // num = int.Parse(txtMoney.Text);
                 //if(num<0)
                 //{
                   //  MessageBox.Show("存款金额必须大于0");
               //  }
                 
             //}
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
                         MessageBox.Show("输入的存款金额必须是数字并且大于0");
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

         private void btnSave_Click(object sender, EventArgs e)
         {
             float balance = float.Parse(txtMoney.Text);
             float money = float.Parse(lblMoney.Text);
             float sum = balance + money;
             string Balance = sum.ToString();
             lblMoney.Text = Balance+".00";

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
                     MessageBox.Show("存款成功！\n" + "账号为：" + txtAccNum.Text+"  当前余额为："+lblMoney.Text);
                     //this.DialogResult == DialogResult.OK;
                 }
                 else
                 {
                     MessageBox.Show("添加失败");
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

         private void btnClose_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }
    }
}





            
           
           
           
 