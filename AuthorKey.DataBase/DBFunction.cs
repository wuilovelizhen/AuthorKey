using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorKey.DataBase
{
   public class DBFunction
    {
        #region "DataTableSet"
        /// <summary>
        /// DataSet合并DataTable
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public DataSet DsSet(DataTable[] Dt)
        {
            DataSet Ds = new DataSet();
            for (int i = 0; i < Dt.Length - 1; i++)
            {
                Ds.Tables.Add(Dt[i]);
            }
            return Ds;
        }
        /// <summary>
        /// 增加表
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="DColumns"></param>
        /// <returns></returns>
        public DataTable DtTable(string TableName, DataColumn[] DColumns)
        {
            DataTable Dt = new DataTable();
            Dt.TableName = TableName;
            foreach (var Columns in DColumns)
            {
                Dt.Columns.Add(Columns);
            }
            return Dt;
        }
        #endregion
    }
}
