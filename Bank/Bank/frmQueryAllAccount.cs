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
    public partial class frmQueryAllAccount : Form
    {
        SqlDataAdapter adapter = null;
        DataSet set = null;
        public frmQueryAllAccount()
        {
            InitializeComponent();
        }
        string str;
        public frmQueryAllAccount(string s)
        {
            InitializeComponent();
            this.str = s;//
        }

        private void 开户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void 存款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposit frm = new frmDeposit();
            frm.Show();
        }

        private void 取款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeOutMoney frm = new frmTakeOutMoney();
            frm.Show();

        }

        private void 查询账户余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueryAccount frm = new frmQueryAccount();
            frm.Show();
        }

        private void 查看全部账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "True";//重载---
            frmQueryAllAccount_Load(s);
            
        }

        private DataSet GetInfo()
        {
            DataSet set = new DataSet();
            string sql = "select AccNum,UserName,Balance,State from Account_information";
            string connstr = "server=.;database=bank;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connstr);
            adapter = new SqlDataAdapter(sql, conn);
            try
            {
                adapter.Fill(set, "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return set;
        }

        private void frmQueryAllAccount_Load(string s)
        {
            set = GetInfo();
            
            dgv_info.Visible = true;
            dgv_info.DataSource = set.Tables["Info"];
        }

        private void 冻结解冻ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFreezeAccount frm = new frmFreezeAccount();
            frm.Show();
        }

        private void 修改储户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeAccountPassword frm = new frmChangeAccountPassword();
            frm.Show();
        }

        private void 销户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCloseAccount frm = new frmCloseAccount();
            frm.Show();
        }




    }
}
