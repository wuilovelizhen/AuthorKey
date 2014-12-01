using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                System.Console.Write(ee.Message);
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
            ////Array AlList = new Array();
            //System.Data.DataTable Dt = new System.Data.DataTable();
            //string SqlCommText = "Select * From Book";
            //Dt = SQLiteHelper.ExecuteDataTable(SqlCommText);
            //if (Dt != null && Dt.Rows.Count > 0)
            //{
            //    cboBook.ComboBox.DataSource = Dt;
            //    cboBook.ComboBox.DisplayMember = "BookName";
            //    cboBook.ComboBox.ValueMember = "BookID";
            //}
            //BookID = cboBook.ComboBox.SelectedValue.ToString();
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
            //string oldString = @"'";
            //string NewString = @"''";
            //string SqlCommText = "Select BookID from Charpt  Where BookID='" + BookID + "' And VolumeKey='" + Uc.VolumeKey + "' And ChapterKey='" + Uc.ChapterKey + "'";
            //System.Data.DataTable Dt = SQLiteHelper.ExecuteDataTable(SqlCommText);
            //int Ret = 0;
            //if (Dt!=null && Dt.Rows.Count > 0)
            //{
            //    //SqlCommText = "Update Charpt Set Comment='" + HtmlText.Replace(oldString, NewString) + "' Where BookID='" + BookID + "' And VolumeKey='" + Uc.VolumeKey + "' And ChapterKey='" + Uc.ChapterKey + "'";
            //    Ret = SQLiteHelper.ExecuteNonQuery(SqlCommText);
            //}
            //else
            //{
            //    //SqlCommText = "Insert into Charpt (BookID,VolumeKey,ChapterKey,Comment) values('" + BookID + "','" + Uc.VolumeKey + "','" + Uc.ChapterKey + "','" + HtmlText.Replace(oldString, NewString) + "')";
            //    Ret = SQLiteHelper.ExecuteNonQuery(SqlCommText);
            //}
            //if (Ret > 0)
            //{ MessageBox.Show("本地保存成功！"); }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
            ////Microsoft.Office.Interop.Word.Document aDoc;
            ////Type wordType = WordApp.GetType();

            //ofd.Filter = "Doc Files(*.Doc;*.Docx)|*.Doc;*.Docx";
            //ofd.Multiselect = false;
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    object fileName = ofd.FileName; //文件名称
            //    //object nullobj = System.Reflection.Missing.Value;
            //    //Microsoft.Office.Interop.Word.Document doc = WordApp.Documents.Open(
            //    //ref fileName, ref nullobj, ref nullobj,
            //    //                      ref nullobj, ref nullobj, ref nullobj,
            //    //                      ref nullobj, ref nullobj, ref nullobj,
            //    //                      ref nullobj, ref nullobj, ref nullobj);
            //    //doc.ActiveWindow.Selection.WholeStory();
            //    //doc.ActiveWindow.Selection.Copy();

            //    //IDataObject data = Clipboard.GetDataObject();
            //    //// 退出 Word
            //    //wordType.InvokeMember("Quit", System.Reflection.BindingFlags.InvokeMethod, null, WordApp, null);
            //    ////垃圾回收
            //    //GC.Collect();
            //    //GC.WaitForPendingFinalizers();
            //    //string txtFileContent = data.GetData(DataFormats.Text).ToString();
            //    //doc.Close();
            //    WordAPI Wapi = new WordAPI(fileName);
            //    string aaa = Wapi.getText();
            //    string bbb = Wapi.getDocument();
            //    Wapi.Exit();
            //}
        }
    }
}
