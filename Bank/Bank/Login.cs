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
   public delegate void boat();//声明委托
    public partial class Login : Form
    {
        public event boat chuan;//注册事件
        public Login()
        {
            InitializeComponent();
        }
       private string str;//
        public Login(string s)
        {
            InitializeComponent();
            this.str = s;//
        }
        //public static string flag = "False";
        private void btnSure_Click(object sender, EventArgs e)
        {


            string AccNum = str;//lblAccNum.Text;
            //MessageBox.Show(AccNum);
            string Password = pwd.Text;
          
       
            string connstr = "server=.;database=bank;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "select count(*) from Account_information where Password=@Password and AccNum=@AccNum";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter p1 = new SqlParameter("@Password", Password);
                SqlParameter p2 = new SqlParameter("@AccNum",AccNum);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                int keys = (int)cmd.ExecuteScalar();
                if (keys == 1)
                {
                    //flag = "True";
                    this.Close();
                    chuan();//调用委托
                 
                }
                else
                {
                    MessageBox.Show("账号或密码不正确");
                }
                conn.Close();




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
                    //flag = "False";
                }

            }
        



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
