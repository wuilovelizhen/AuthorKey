using AuthorKey.SqlConn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REFSQLite= System.Data.SQLite;
using System.Data;
using AuthorKey.Mod;
namespace AuthorKey
{
    public partial class frmMain : Form
    {
        public static UserFrom.UserWriting Uwr;
        public static UserFrom.UserCatalog Uc;
        public static UserFrom.UserWhole Uwh;
      
        string BookID = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                InitalBook();
                InitalUserCatalog();
            }
            catch (Exception ee)
            {
                System.Console.Write(ee.Message);//ssass
            }
            finally
            {

            }
        }
        public bool InitalUserCatalog()
        {
            Uwr = new UserFrom.UserWriting();
            Uc = new UserFrom.UserCatalog(BookID);
            Uwh = new UserFrom.UserWhole(BookID);
            CommFunction.PanelControlInitial(panel1, Uwh);
            CommFunction.SplitterPanelControlInitial(splLeft.Panel1, Uc);
            CommFunction.SplitterPanelControlInitial(splMain.Panel2, Uwr);
            CommFunction.SplitterPanelControlInitial(splLeft.Panel2, new UserFrom.UserFigure());
            return true;
        }
        public bool InitalBook()
        {
            //Array AlList = new Array();
            System.Data.DataTable Dt = new System.Data.DataTable();
            string SqlCommText = "Select * From Book";
            Dt = SQLiteHelper.ExecuteDataTable(SqlCommText);
            if (Dt != null && Dt.Rows.Count > 0)
            {
                cboBook.ComboBox.DataSource = Dt;
                cboBook.ComboBox.DisplayMember = "BookName";
                cboBook.ComboBox.ValueMember = "BookID";
            }
            BookID = cboBook.ComboBox.SelectedValue.ToString();
            return true;
        }
        private void TsmiFigure_Click(object sender, EventArgs e)
        {
            CommFunction.SplitterPanelControlInitial(splLeft.Panel2, new UserFrom.UserFigure());
        }

        private void TsmiDiagram_Click(object sender, EventArgs e)
        {
            CommFunction.SplitterPanelControlInitial(splLeft.Panel2, new UserFrom.UserDiagram());
        }

        private void TsmiCurrentSearch_Click(object sender, EventArgs e)
        {
            frmSearch Search = new frmSearch();
            if (Search.ShowDialog() == DialogResult.OK)
            {
                CommFunction.SplitterPanelControlInitial(splLeft.Panel2, new UserFrom.UserSearch());
            }
        }

        private void TsmiAncientMen_Click(object sender, EventArgs e)
        {
            frmAIProcess AiProcess = new frmAIProcess();
            AiProcess.Show();
        }

        private void TsmiProgram_Click(object sender, EventArgs e)
        {
            CommFunction.SplitterPanelControlInitial(splLeft.Panel1, new UserFrom.UserProgram());
        }

        private void TsmiCatalog_Click(object sender, EventArgs e)
        {
            CommFunction.SplitterPanelControlInitial(splLeft.Panel1, new UserFrom.UserCatalog(BookID));
           
        }
        /// <summary>
        /// 本地保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiLocSave_Click(object sender, EventArgs e)
        {
            string HtmlText = Uwr.htmlEditor.HtmlEditControl.DocumentText;
            DataTable dt;
            int Ret = 0;
            dt = SQLiteHelper.ExecuteDataTable("Select top 0 BookID, VolumeKey,ChapterKey,Comment from Charpt");
            if (dt != null)
            {
                 dt.Rows.Clear();
                 dt.Rows.Add(dt.NewRow());
                 dt.Rows[0]["BookID"] = BookID;
                 dt.Rows[0]["VolumeKey"] = Uc.VolumeKey;
                 dt.Rows[0]["ChapterKey"] = Uc.ChapterKey;
                 dt.Rows[0]["Comment"] = HtmlText;
                string[] strlist="BookID,VolumeKey,ChapterKey".Split(',');
                Ret = ModFunction.AutoUpdateOrInsert(dt, strlist, "Charpt");
            }
           
            if (Ret > 0)
            { MessageBox.Show("本地保存成功！"); }
        }
    }
}
