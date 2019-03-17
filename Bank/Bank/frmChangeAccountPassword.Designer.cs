namespace Bank
{
    partial class frmChangeAccountPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePwd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOldpwd = new System.Windows.Forms.TextBox();
            this.txtNewpwd = new System.Windows.Forms.TextBox();
            this.txtRepwd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "请输入账号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "账户状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "户主姓名：";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(168, 63);
            this.txtAccNum.MaxLength = 5;
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(118, 25);
            this.txtAccNum.TabIndex = 21;
            this.txtAccNum.TextChanged += new System.EventHandler(this.txtAccNum_TextChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(156, 88);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(55, 15);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "@@@@@@";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(156, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "@@@@@@";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(221, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(51, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 123);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账号信息";
            // 
            // btnUpdatePwd
            // 
            this.btnUpdatePwd.Location = new System.Drawing.Point(44, 410);
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.Size = new System.Drawing.Size(118, 39);
            this.btnUpdatePwd.TabIndex = 24;
            this.btnUpdatePwd.Text = "修改密码";
            this.btnUpdatePwd.UseVisualStyleBackColor = true;
            this.btnUpdatePwd.Click += new System.EventHandler(this.btnUpdatePwd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "新密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "旧密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "重复密码：";
            // 
            // txtOldpwd
            // 
            this.txtOldpwd.Location = new System.Drawing.Point(196, 274);
            this.txtOldpwd.Name = "txtOldpwd";
            this.txtOldpwd.PasswordChar = '*';
            this.txtOldpwd.Size = new System.Drawing.Size(143, 25);
            this.txtOldpwd.TabIndex = 29;
            this.txtOldpwd.TextChanged += new System.EventHandler(this.txtOldpwd_TextChanged);
            // 
            // txtNewpwd
            // 
            this.txtNewpwd.Location = new System.Drawing.Point(196, 314);
            this.txtNewpwd.Name = "txtNewpwd";
            this.txtNewpwd.PasswordChar = '*';
            this.txtNewpwd.Size = new System.Drawing.Size(143, 25);
            this.txtNewpwd.TabIndex = 30;
            this.txtNewpwd.TextChanged += new System.EventHandler(this.txtNewpwd_TextChanged);
            // 
            // txtRepwd
            // 
            this.txtRepwd.Location = new System.Drawing.Point(196, 362);
            this.txtRepwd.Name = "txtRepwd";
            this.txtRepwd.PasswordChar = '*';
            this.txtRepwd.Size = new System.Drawing.Size(143, 25);
            this.txtRepwd.TabIndex = 31;
            this.txtRepwd.TextChanged += new System.EventHandler(this.txtRepwd_TextChanged);
            // 
            // frmChangeAccountPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 494);
            this.Controls.Add(this.txtRepwd);
            this.Controls.Add(this.txtNewpwd);
            this.Controls.Add(this.txtOldpwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdatePwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChangeAccountPassword";
            this.Text = "frmChangeAccountPassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdatePwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOldpwd;
        private System.Windows.Forms.TextBox txtNewpwd;
        private System.Windows.Forms.TextBox txtRepwd;
    }
}