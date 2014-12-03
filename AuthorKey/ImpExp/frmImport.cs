using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AuthorKey.Core;
namespace AuthorKey.ImpExp
{
    public partial class frmImport : Form
    {
        private DataSet Ds;
        private DataTable DtChapt = new DataTable();

        public frmImport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Doc Files(*.Docx)|*.Docx";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                string[] kStrings = null;
                string paths = @"E:\1.docx";
                string fileName = openFileDialog1.FileName; //文件名称
                textBox1.Text = fileName;
                kStrings = WordAPI.GetDocxDocumentBuilder(fileName);
                Ds = ImpExp.Import.ImpCatalog(kStrings);
                CreateCategory(Ds.Tables[1]);
                DtChapt = Ds.Tables[2];
            }
        }
        /// <summary>
        /// 创建目录章节
        /// </summary>
        /// <param name="Dt"></param>
        public void CreateCategory(DataTable Dt)
        {
            if (Dt != null && Dt.Rows.Count > 0)
            {
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(Dt.Rows[i][0].ToString());
                    item.Checked = true;
                    item.SubItems.Add("第" + Dt.Rows[i][1].ToString() + "章");
                    item.SubItems.Add(Dt.Rows[i][2].ToString());
                    item.Tag = Dt.Rows[i][1].ToString();
                    listView1.Items.Add(item);
                }
            }

        }

        private void radChapter_CheckedChanged(object sender, EventArgs e)
        {
            if (radChapter.Checked)
            {
                txtChapterNumber.Enabled = true;
            }
            else
            {
                txtChapterNumber.Enabled = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).FocusedItem != null)
            {
                string Id = ((ListView)sender).FocusedItem.Tag.ToString();
                this.htmlTextBox1.Text=CreateBuiltString(Id);
            }
        }
        public string CreateBuiltString(string Id)
        {
            DataRow[] Dr = DtChapt.Select("Catogry='" + Id + "'");

            string DocumentText = "";
            if (chkTilte.Checked)
            {
                DocumentText = "<h1 style=\"text-align:center;\"><span style=\"font-family:NSimSun;color:#003399;font-size:32px;line-height:1.5;\">" + listView1.FocusedItem.SubItems[1].Text + "&nbsp;&nbsp;" + listView1.FocusedItem.SubItems[2].Text + "</span></h1><hr />"; ;
            }
            for (int i = 0; i < Dr.Length - 1; i++)
            {
                string JText = Dr[i]["Charpt"].ToString().Trim();
                JText = JText.Replace("“", "“<span style=\"color:#E53333;line-height:1.5;\">");
                JText = JText.Replace("”", "”</span>");
                JText = "<span style=\"font-family:NSimSun;font-size:16px;line-height:1.5;\">&nbsp;&nbsp;" + JText + "</span>";
                //&nbsp;空格
                DocumentText = DocumentText + JText + "<br/>"; //<br/>换行
                DocumentText = "" + DocumentText + "";
            }
            return DocumentText;
        }

        // 初始化listView1.
        private void InitializeListView()
        {
            listView1.ListViewItemSorter = new ListViewIndexComparer();
            //初始化插入标记
            listView1.InsertionMark.Color = Color.Red;
            //
            listView1.AllowDrop = true;
        }

        #region  ListView内部位置移动
       
        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }
        #endregion 

        private void frmImport_Load(object sender, EventArgs e)
        {
            InitializeListView();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            // 返回插入标记的索引值  
            int index = listView1.InsertionMark.Index;
            // 如果插入标记不可见，则退出.  
            if (index == -1)
            {
                return;
            }
            // 如果插入标记在项目的右面，使目标索引值加一  
            if (listView1.InsertionMark.AppearsAfterItem)
            {
                index++;
            }

            // 返回拖拽项  
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            //在目标索引位置插入一个拖拽项目的副本   
            listView1.Items.Insert(index, (ListViewItem)item.Clone());
            // 移除拖拽项目的原文件  
            listView1.Items.Remove(item);  
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;  
        }

        private void listView1_DragLeave(object sender, EventArgs e)
        {
            listView1.InsertionMark.Index = -1;  
        }

        private void listView1_DragOver(object sender, DragEventArgs e)
        {
            // 获得鼠标坐标  
            Point point = listView1.PointToClient(new Point(e.X, e.Y));
            // 返回离鼠标最近的项目的索引  
            int index = listView1.InsertionMark.NearestIndex(point);
            // 确定光标不在拖拽项目上  
            if (index > -1)
            {
                Rectangle itemBounds = listView1.GetItemRect(index);
                if (point.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    listView1.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    listView1.InsertionMark.AppearsAfterItem = false;
                }
            }
            listView1.InsertionMark.Index = index;  
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(e.Item, DragDropEffects.Move);  
        }

        private void chkTilte_CheckedChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                string Id = listView1.FocusedItem.Tag.ToString();
                this.htmlTextBox1.Text = CreateBuiltString(Id);
            }
        }
       
    }
    
}
