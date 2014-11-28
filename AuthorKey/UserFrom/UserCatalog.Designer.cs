namespace AuthorKey.UserFrom
{
    partial class UserCatalog
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvCatalog = new System.Windows.Forms.TreeView();
            this.contextMenuCatalog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建章节ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建卷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看角色表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuCatalog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvCatalog
            // 
            this.tvCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCatalog.Location = new System.Drawing.Point(3, 17);
            this.tvCatalog.Name = "tvCatalog";
            this.tvCatalog.Size = new System.Drawing.Size(225, 248);
            this.tvCatalog.TabIndex = 0;
            this.tvCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCatalog_AfterSelect);
            // 
            // contextMenuCatalog
            // 
            this.contextMenuCatalog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建章节ToolStripMenuItem,
            this.新建卷ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.角色表ToolStripMenuItem,
            this.查看角色表ToolStripMenuItem});
            this.contextMenuCatalog.Name = "contextMenuCatalog";
            this.contextMenuCatalog.Size = new System.Drawing.Size(155, 136);
            // 
            // 新建章节ToolStripMenuItem
            // 
            this.新建章节ToolStripMenuItem.Name = "新建章节ToolStripMenuItem";
            this.新建章节ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.新建章节ToolStripMenuItem.Text = "新建>>章节";
            // 
            // 新建卷ToolStripMenuItem
            // 
            this.新建卷ToolStripMenuItem.Name = "新建卷ToolStripMenuItem";
            this.新建卷ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.新建卷ToolStripMenuItem.Text = "新建>>卷";
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 角色表ToolStripMenuItem
            // 
            this.角色表ToolStripMenuItem.Name = "角色表ToolStripMenuItem";
            this.角色表ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.角色表ToolStripMenuItem.Text = "新建>>角色表";
            // 
            // 查看角色表ToolStripMenuItem
            // 
            this.查看角色表ToolStripMenuItem.Name = "查看角色表ToolStripMenuItem";
            this.查看角色表ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.查看角色表ToolStripMenuItem.Text = "查看>>角色表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvCatalog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目录";
            // 
            // UserCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserCatalog";
            this.Size = new System.Drawing.Size(231, 268);
            this.Load += new System.EventHandler(this.UserCatalog_Load);
            this.contextMenuCatalog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvCatalog;
        private System.Windows.Forms.ContextMenuStrip contextMenuCatalog;
        private System.Windows.Forms.ToolStripMenuItem 新建章节ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建卷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看角色表ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
