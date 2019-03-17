namespace Bank
{
    partial class frmQueryAllAccount
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开户销户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存取款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.冻结解冻ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改储户密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询账户余额ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看全部账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.账号,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_info.Location = new System.Drawing.Point(0, 31);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowTemplate.Height = 27;
            this.dgv_info.Size = new System.Drawing.Size(809, 470);
            this.dgv_info.TabIndex = 2;
            this.dgv_info.Visible = false;
            // 
            // 账号
            // 
            this.账号.DataPropertyName = "AccNum";
            this.账号.HeaderText = "账号";
            this.账号.Name = "账号";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "账户姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Balance";
            this.Column3.HeaderText = "账户余额";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "State";
            this.Column4.HeaderText = "账户状态";
            this.Column4.Name = "Column4";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 开户销户ToolStripMenuItem
            // 
            this.开户销户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开户ToolStripMenuItem,
            this.销户ToolStripMenuItem});
            this.开户销户ToolStripMenuItem.Name = "开户销户ToolStripMenuItem";
            this.开户销户ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.开户销户ToolStripMenuItem.Text = "开户销户";
            // 
            // 开户ToolStripMenuItem
            // 
            this.开户ToolStripMenuItem.Name = "开户ToolStripMenuItem";
            this.开户ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.开户ToolStripMenuItem.Text = "开户";
            this.开户ToolStripMenuItem.Click += new System.EventHandler(this.开户ToolStripMenuItem_Click);
            // 
            // 销户ToolStripMenuItem
            // 
            this.销户ToolStripMenuItem.Name = "销户ToolStripMenuItem";
            this.销户ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.销户ToolStripMenuItem.Text = "销户";
            this.销户ToolStripMenuItem.Click += new System.EventHandler(this.销户ToolStripMenuItem_Click);
            // 
            // 存取款ToolStripMenuItem
            // 
            this.存取款ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.存款ToolStripMenuItem,
            this.取款ToolStripMenuItem});
            this.存取款ToolStripMenuItem.Name = "存取款ToolStripMenuItem";
            this.存取款ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.存取款ToolStripMenuItem.Text = "存取款";
            // 
            // 存款ToolStripMenuItem
            // 
            this.存款ToolStripMenuItem.Name = "存款ToolStripMenuItem";
            this.存款ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.存款ToolStripMenuItem.Text = "存款";
            this.存款ToolStripMenuItem.Click += new System.EventHandler(this.存款ToolStripMenuItem_Click);
            // 
            // 取款ToolStripMenuItem
            // 
            this.取款ToolStripMenuItem.Name = "取款ToolStripMenuItem";
            this.取款ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.取款ToolStripMenuItem.Text = "取款";
            this.取款ToolStripMenuItem.Click += new System.EventHandler(this.取款ToolStripMenuItem_Click);
            // 
            // 冻结解冻ToolStripMenuItem
            // 
            this.冻结解冻ToolStripMenuItem.Name = "冻结解冻ToolStripMenuItem";
            this.冻结解冻ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.冻结解冻ToolStripMenuItem.Text = "冻结解冻";
            this.冻结解冻ToolStripMenuItem.Click += new System.EventHandler(this.冻结解冻ToolStripMenuItem_Click);
            // 
            // 修改储户密码ToolStripMenuItem
            // 
            this.修改储户密码ToolStripMenuItem.Name = "修改储户密码ToolStripMenuItem";
            this.修改储户密码ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.修改储户密码ToolStripMenuItem.Text = "修改储户密码";
            this.修改储户密码ToolStripMenuItem.Click += new System.EventHandler(this.修改储户密码ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询账户余额ToolStripMenuItem,
            this.查看全部账户ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 查询账户余额ToolStripMenuItem
            // 
            this.查询账户余额ToolStripMenuItem.Name = "查询账户余额ToolStripMenuItem";
            this.查询账户余额ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.查询账户余额ToolStripMenuItem.Text = "查询账户余额";
            this.查询账户余额ToolStripMenuItem.Click += new System.EventHandler(this.查询账户余额ToolStripMenuItem_Click);
            // 
            // 查看全部账户ToolStripMenuItem
            // 
            this.查看全部账户ToolStripMenuItem.Name = "查看全部账户ToolStripMenuItem";
            this.查看全部账户ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.查看全部账户ToolStripMenuItem.Text = "查看所有账户";
            this.查看全部账户ToolStripMenuItem.Click += new System.EventHandler(this.查看全部账户ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.开户销户ToolStripMenuItem,
            this.存取款ToolStripMenuItem,
            this.冻结解冻ToolStripMenuItem,
            this.修改储户密码ToolStripMenuItem,
            this.查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmQueryAllAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 502);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQueryAllAccount";
            this.Text = "储蓄综合业务平台";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开户销户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存取款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 冻结解冻ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改储户密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询账户余额ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看全部账户ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

