using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthorKey;
using System.Reflection;
//========================================
//实现功能：
//  空白处右击弹出contextMenu，新建卷，新增角色表，查看角色表，人物关系表，背景，纲要
//  卷节  右击弹出contextMenu，新建章节，重命名，删除（含章），新增角色表，查看角色表，部分事件概括
//  章节  右击弹出contextMenu，重命名，删除，新建章节，新增角色表，查看角色表，部分事件概括
//========================================
namespace AuthorKey.UserFrom
{
    public partial class UserCatalog : UserControl
    {
        public string VolumeKey = "";
        public string ChapterKey = "";
        string BookID = "";
        static public ContextMenuStrip m_strip1;
        static public ContextMenuStrip m_strip2;
        static public ContextMenuStrip m_strip3;
        public UserCatalog(string ID)
        {
            InitializeComponent();
            BookID = ID;
        }

        private void UserCatalog_Load(object sender, EventArgs e)
        {
            IniContextMenuStrip();
            //ToolStripControlHost itm2 = new ToolStripControlHost(new MonthCalendar());
            //ToolStripControlHost itm3 = new ToolStripControlHost(new TextBox());
            //itm3.Control.Text = "Hello";
            //m_strip1.Items.Add(itm2);
            //m_strip2.Items.Add(itm3);

            //m_strip3 = new ContextMenuStrip();
            //ToolStripDropDownMenu itm = new ToolStripDropDownMenu();
            //itm.Items.Add(new ToolStripControlHost(new Label()));
            //((ToolStripControlHost)itm.Items[0]).Control.Text = "HahaHa";
            //itm.Items.Add(new ToolStripControlHost(new ComboBox()));
            //((ToolStripControlHost)itm.Items[1]).Control.Text = "This is a combo";
            //((ToolStripControlHost)itm.Items[1]).Control.Width = 150;
            //ToolStripMenuItem itm4 = new ToolStripMenuItem();
            //itm4.DropDown = itm;
            //itm4.Text = "Check this";
            //m_strip3.Items.Add(itm4);

            LoadCatalog(BookID);
            tvCatalog.ContextMenuStrip = m_strip1;
        }
        private void LoadCatalog(string BookID)
        {
             //Array AlList = new Array();
            //System.Data.DataTable Dt = new System.Data.DataTable();
            //string SqlCommandText = "Select * From Catalog Where BookID='" + BookID + "'"; ;
            //Dt = SQLiteHelper.ExecuteDataTable(SqlCommandText);
            //if (Dt != null && Dt.Rows.Count>0)
            //{
            //    TreeViewAddNode(tvCatalog, Dt);
            //}
        }
        private bool TreeViewAddNode(TreeView tv,DataTable Dt)
        {
            //NumFormat nf = new NumFormat();
            //DataRow[] Dr = Dt.Select(" VolumeName<>''", "VolumeKey ASC");
            //if (Dr.Length > 0)
            //{
            //    tv.BeginUpdate();
            //    for (int i = 0; i < Dr.Length; i++)
            //    {
            //        tvCatalog.Nodes.Add(Dr[i]["VolumeKey"].ToString(), "第" + NumFormat.NumToChn(Dr[i]["VolumeKey"].ToString()) +"卷 "+ Dr[i]["VolumeName"].ToString());
            //        tvCatalog.Nodes[i].ContextMenuStrip = m_strip2;
            //        TreeViewAddCNode(tvCatalog.Nodes[i], Dt);
            //    }
            //    tv.EndUpdate();
            //}
            return true;
        }
        private bool TreeViewAddCNode(TreeNode cTn, DataTable Dt)
        {
            //NumFormat nf = new NumFormat();
            //DataRow[] Dr = Dt.Select(" VolumeKey='" + cTn.Name + "' And ChapterName<>''", "ChapterKey ASC");
            //if (Dr.Length > 0)
            //{
            //    for (int i = 0; i < Dr.Length; i++)
            //    {
            //        cTn.Nodes.Add(Dr[i]["ChapterKey"].ToString(), "第" + NumFormat.NumToChn(Dr[i]["ChapterKey"].ToString()) + "章 " + Dr[i]["ChapterName"].ToString());
            //        cTn.Nodes[i].ContextMenuStrip = m_strip3;
            //    }
            //}
            return true;
        }

        private void tvCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.Parent != null)
            //{
            //    VolumeKey = e.Node.Parent.Name;
            //    ChapterKey = e.Node.Name;
            //    System.Data.DataTable Dt = new System.Data.DataTable();
            //    string SqlCommText = "Select * From Charpt Where BookID='" + BookID + "' And VolumeKey ='" + e.Node.Parent.Name + "' And ChapterKey='" + e.Node.Name + "'";
            //    Dt = SQLiteHelper.ExecuteDataTable(SqlCommText);
            //    if (Dt != null && Dt.Rows.Count > 0)
            //    {
            //        //frmMain.Uwr.htmlEditor.HtmlEditControl.DocumentText = Dt.Rows[0]["Comment"].ToString();
            //    }
            //    else
            //    {
            //        //frmMain.Uwr.htmlEditor.HtmlEditControl.DocumentText = "";
            //    }

            //}
        }
        private void IniContextMenuStrip()
        { 
            #region 空白处右击
            m_strip1 = new ContextMenuStrip();
            ToolStripButton cms11 = new ToolStripButton();
            cms11.Name="New_Vol";
            cms11.Text = "分卷";
            m_strip1.Items.Add(cms11);
            #endregion

            #region 卷右击
            m_strip2 = new ContextMenuStrip();
             ToolStripButton cms21 = new ToolStripButton();
            cms21.Name="New_Vol";
            cms21.Text = "新建=>分卷";
            m_strip2.Items.Add(cms21);
            ToolStripButton cms22 = new ToolStripButton();
            cms22.Name = "New_Charpt";
            cms22.Text = "新建=>章节";
            m_strip2.Items.Add(cms22);
            ToolStripButton cms23 = new ToolStripButton();
            cms23.Name="Rename";
            cms23.Text = "重命名";
            m_strip2.Items.Add(cms23);
            #endregion 

            #region 章右击
             m_strip3 = new ContextMenuStrip();
            ToolStripButton cms31 = new ToolStripButton();
            cms31.Name = "New_Charpt";
            cms31.Text = "新建=>章节";
            m_strip3.Items.Add(cms31);
            ToolStripButton cms32 = new ToolStripButton();
            cms32.Name = "Rename";
            cms32.Text = "重命名";
            m_strip3.Items.Add(cms32);
            #endregion
        }

    }
}
