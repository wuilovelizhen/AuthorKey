namespace AuthorKey.ImpExp
{
    partial class frmImport
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colVol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatogry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatogryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.htmlTextBox1 = new McDull.Windows.Forms.HTMLTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c3 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkTilte = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.txtChapterNumber = new System.Windows.Forms.TextBox();
            this.radChapter = new System.Windows.Forms.RadioButton();
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radNull = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(1145, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(79, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "路径";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(55, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1084, 21);
            this.textBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(185, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 584);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "章节";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVol,
            this.colCatogry,
            this.colCatogryName});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 17);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 564);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.DragOver += new System.Windows.Forms.DragEventHandler(this.listView1_DragOver);
            this.listView1.DragLeave += new System.EventHandler(this.listView1_DragLeave);
            // 
            // colVol
            // 
            this.colVol.Text = "卷";
            // 
            // colCatogry
            // 
            this.colCatogry.Text = "章节";
            this.colCatogry.Width = 120;
            // 
            // colCatogryName
            // 
            this.colCatogryName.Text = "章节名称";
            this.colCatogryName.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.htmlTextBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(581, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 586);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预览内容";
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlTextBox1.Location = new System.Drawing.Point(4, 116);
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new System.Drawing.Size(650, 470);
            this.htmlTextBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c3);
            this.panel1.Controls.Add(this.c2);
            this.panel1.Controls.Add(this.c4);
            this.panel1.Controls.Add(this.c1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.chkTilte);
            this.panel1.Location = new System.Drawing.Point(4, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 100);
            this.panel1.TabIndex = 1;
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(339, 0);
            this.c3.Name = "c3";
            this.c3.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.c3.Size = new System.Drawing.Size(77, 31);
            this.c3.TabIndex = 10;
            this.c3.Text = "HexColorString";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(232, 0);
            this.c2.Name = "c2";
            this.c2.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.c2.Size = new System.Drawing.Size(31, 31);
            this.c2.TabIndex = 9;
            this.c2.Text = "Color";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(269, 0);
            this.c4.Name = "c4";
            this.c4.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.c4.Size = new System.Drawing.Size(64, 31);
            this.c4.TabIndex = 11;
            this.c4.Text = "Select Color";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(142, 0);
            this.c1.Name = "c1";
            this.c1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.c1.Size = new System.Drawing.Size(84, 31);
            this.c1.TabIndex = 8;
            this.c1.Text = "RibbonColorPart";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "章节标题";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkTilte
            // 
            this.chkTilte.AutoSize = true;
            this.chkTilte.Checked = true;
            this.chkTilte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilte.Location = new System.Drawing.Point(6, 7);
            this.chkTilte.Name = "chkTilte";
            this.chkTilte.Size = new System.Drawing.Size(120, 16);
            this.chkTilte.TabIndex = 0;
            this.chkTilte.Text = "章节标题和分割线";
            this.chkTilte.UseVisualStyleBackColor = true;
            this.chkTilte.CheckedChanged += new System.EventHandler(this.chkTilte_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.radCustom);
            this.groupBox3.Controls.Add(this.txtChapterNumber);
            this.groupBox3.Controls.Add(this.radChapter);
            this.groupBox3.Controls.Add(this.radOne);
            this.groupBox3.Controls.Add(this.radNull);
            this.groupBox3.Location = new System.Drawing.Point(12, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 585);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分卷设定";
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Location = new System.Drawing.Point(21, 116);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(83, 16);
            this.radCustom.TabIndex = 2;
            this.radCustom.Text = "自定义分卷";
            this.radCustom.UseVisualStyleBackColor = true;
            // 
            // txtChapterNumber
            // 
            this.txtChapterNumber.Enabled = false;
            this.txtChapterNumber.Location = new System.Drawing.Point(21, 87);
            this.txtChapterNumber.Name = "txtChapterNumber";
            this.txtChapterNumber.Size = new System.Drawing.Size(119, 21);
            this.txtChapterNumber.TabIndex = 1;
            // 
            // radChapter
            // 
            this.radChapter.AutoSize = true;
            this.radChapter.Location = new System.Drawing.Point(21, 64);
            this.radChapter.Name = "radChapter";
            this.radChapter.Size = new System.Drawing.Size(119, 16);
            this.radChapter.TabIndex = 0;
            this.radChapter.Text = "按章节数自动分卷";
            this.radChapter.UseVisualStyleBackColor = true;
            this.radChapter.CheckedChanged += new System.EventHandler(this.radChapter_CheckedChanged);
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.Location = new System.Drawing.Point(21, 42);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(83, 16);
            this.radOne.TabIndex = 0;
            this.radOne.Text = "全部为一卷";
            this.radOne.UseVisualStyleBackColor = true;
            // 
            // radNull
            // 
            this.radNull.AutoSize = true;
            this.radNull.Checked = true;
            this.radNull.Location = new System.Drawing.Point(21, 20);
            this.radNull.Name = "radNull";
            this.radNull.Size = new System.Drawing.Size(59, 16);
            this.radNull.TabIndex = 0;
            this.radNull.TabStop = true;
            this.radNull.Text = "不分卷";
            this.radNull.UseVisualStyleBackColor = true;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "frmImport";
            this.Text = "导入";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colVol;
        private System.Windows.Forms.ColumnHeader colCatogry;
        private System.Windows.Forms.ColumnHeader colCatogryName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtChapterNumber;
        private System.Windows.Forms.RadioButton radChapter;
        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.RadioButton radNull;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkTilte;
        private System.Windows.Forms.Label c3;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c4;
        private System.Windows.Forms.Label c1;
        private McDull.Windows.Forms.HTMLTextBox htmlTextBox1;
    }
}