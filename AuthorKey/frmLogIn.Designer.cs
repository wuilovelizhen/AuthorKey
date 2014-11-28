namespace AuthorKey
{
    partial class frmLogIn
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPsw = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPsw = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(26, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "帐号：";
            // 
            // lblUserPsw
            // 
            this.lblUserPsw.AutoSize = true;
            this.lblUserPsw.Location = new System.Drawing.Point(28, 61);
            this.lblUserPsw.Name = "lblUserPsw";
            this.lblUserPsw.Size = new System.Drawing.Size(41, 12);
            this.lblUserPsw.TabIndex = 1;
            this.lblUserPsw.Text = "密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(87, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(117, 21);
            this.txtUserName.TabIndex = 2;
            // 
            // txtUserPsw
            // 
            this.txtUserPsw.Location = new System.Drawing.Point(87, 58);
            this.txtUserPsw.Name = "txtUserPsw";
            this.txtUserPsw.Size = new System.Drawing.Size(117, 21);
            this.txtUserPsw.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(30, 99);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(171, 40);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "登录";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnRegedit
            // 
            this.btnRegedit.Location = new System.Drawing.Point(30, 145);
            this.btnRegedit.Name = "btnRegedit";
            this.btnRegedit.Size = new System.Drawing.Size(171, 41);
            this.btnRegedit.TabIndex = 4;
            this.btnRegedit.Text = "注册";
            this.btnRegedit.UseVisualStyleBackColor = true;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 213);
            this.Controls.Add(this.btnRegedit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtUserPsw);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserPsw);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmLogIn";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPsw;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPsw;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnRegedit;
    }
}

