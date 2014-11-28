using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthorKey.SqlConn;

namespace AuthorKey.UserFrom
{
    public partial class UserWhole : UserControl
    {
        string BookID = "";
        public UserWhole(string ID)
        {
            InitializeComponent();
            BookID = ID;
        }

        private void UserWhole_Load(object sender, EventArgs e)
        {
            System.Data.DataTable Dt = new System.Data.DataTable();
            string SqlCommandText = "Select * From Book Where BookID='" + BookID + "'"; ;
            Dt = SQLiteHelper.ExecuteDataTable(SqlCommandText);
            if (Dt != null && Dt.Rows.Count > 0)
            {
                for(int i=0;i<Dt.Columns.Count;i++)
                {// Create three items and three sets of subitems for each item.
                ListViewItem item = new ListViewItem(Dt.Columns[i].ColumnName);
                // Place a check mark next to the item.
                item.Checked = true;
                item.SubItems.Add(Dt.Rows[0][Dt.Columns[i].ColumnName].ToString());
                lvWhole.Items.Add(item);
                }
            }
        }
    }
}
