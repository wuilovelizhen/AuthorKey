using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorKey
{
    public class CommFunction
    {
        #region "Control"
        /// <summary>
        /// 加载UserControl界面到Main上
        /// </summary>
        /// <param name="CrlMain">SplitterPanel控件</param>
        /// <param name="CrlChildren">UserControl控件</param>
        /// <returns>属性Dock = DockStyle.Fill，错误则提示Message</returns>
        public static bool SplitterPanelControlInitial(SplitterPanel CrlMain, UserControl CrlChildren)
        {
            try
            {
                if (CrlMain!=null && CrlMain.Controls.Count > 0)
                {
                    CrlMain.Controls.Clear();
                }
                UserControl UC = CrlChildren;
                UC.Dock = DockStyle.Fill;
                CrlMain.Controls.Add(UC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            return true;
        }
        /// <summary>
        /// 加载UserControl界面到Main上
        /// </summary>
        /// <param name="CrlMain">Panel控件</param>
        /// <param name="CrlChildren">UserControl控件</param>
        /// <returns>属性Dock = DockStyle.Fill，错误则提示Message</returns>
        public static bool PanelControlInitial(Panel CrlMain, UserControl CrlChildren)
        {
            try
            {
                UserControl UC = CrlChildren;
                UC.Dock = DockStyle.Fill;
                CrlMain.Controls.Add(UC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            return true;
        }
        #endregion
    }
}
