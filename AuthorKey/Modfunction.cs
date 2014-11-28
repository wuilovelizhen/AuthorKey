using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorKey.SqlConn;
using REFSQLite = System.Data.SQLite;
using System.Data;

namespace AuthorKey.Mod
{
        public static class ModFunction
    {
            public static string SqlSafe(string strValue)
        {
            string oldString = @"'";
            string NewString = @"''";
            return strValue.Replace(oldString, NewString);
        }

            public static string ReplaceWithNull(object Value, int strDataType)
        {
            if (Value == null)
            { return "NULL"; }
            else
            {
                if (((String)Value) == "")
                { return "NULL"; }
                if (strDataType == 2)
                {
                    return "'" + ((DateTime)Value).ToShortDateString().ToString() + "'";
                }
                else if (strDataType == 0)
                {
                    return "'" + SqlSafe((String)Value) + "'";
                }
                else if (strDataType == 1)
                {
                    return ((String)Value);
                }
                else
                {
                    return "NULL";
                }

            }
        }

            public static int getDataTypeByName(string strDataType)
        {
            if (strDataType == "DateTime" || strDataType == "Date")
            {
                return 2;
            }
            else if (strDataType == "String" || strDataType == "Char")
            {
                return 0;
            }
            else if (strDataType == "short" || strDataType == "ushort" || strDataType == "ulong" || strDataType == "long" || strDataType == "uint" || strDataType == "int" || strDataType == "float" || strDataType == "double" || strDataType == "decimal")
            {
                return 1;
            }
            else
            { return -1; }
        }

            public static string ReplaceWithNullByDataRow(DataRow dtRow, string strKey)
        {
            return "strKey = " + ReplaceWithNull(dtRow[strKey], getDataTypeByName(dtRow[strKey].GetType().Name));
        }

        public static int SqlSave(string strUpdate)
        {
            int Ret = 0;
            Ret = SQLiteHelper.ExecuteNonQuery(strUpdate);
            return Ret;
        }

        public static int AutoUpdateOrInsert(DataTable dt, string[] strKeys, string strTableName)
        {
            string strFilter = "";
            string strKey1 = "";
            foreach (string strKey in strKeys)
            {
                if (strKey1 == "")
                { strKey1 = strKey; }
                if (strFilter == "")
                { strFilter = ReplaceWithNullByDataRow(dt.Rows[0], strKey); }
                else
                { strFilter = strFilter + " AND " + ReplaceWithNullByDataRow(dt.Rows[0], strKey); }
            }
            string SqlCommText = "Select " + strKey1 + " from " + strTableName + "  Where " + strFilter;
            System.Data.DataTable Dt = SQLiteHelper.ExecuteDataTable(SqlCommText);
            int Ret = 0;
            if (Dt != null && Dt.Rows.Count > 0)
            {
                SqlCommText = "";
                foreach (DataColumn a in dt.Columns)
                {
                    if (SqlCommText == "")
                    { SqlCommText = ReplaceWithNullByDataRow(dt.Rows[0], a.ColumnName); }
                    else
                    { SqlCommText = SqlCommText + "," + ReplaceWithNullByDataRow(dt.Rows[0], a.ColumnName); }
                }
                SqlCommText = "Update " + strTableName + " Set " + SqlCommText + "  Where " + strFilter;
            }
            else
            {
                string strFieldList = "";
                string strValueList = "";
                foreach (DataColumn a in dt.Columns)
                {
                    if (strFieldList == "")
                    {
                        strFieldList = a.ColumnName;
                        strValueList = ReplaceWithNull(dt.Rows[0][a.ColumnName], getDataTypeByName(a.DataType.Name));
                    }
                    else
                    {
                        strFieldList = strFieldList + "," + a.ColumnName;
                        strValueList = strValueList + "," + ReplaceWithNull(dt.Rows[0][a.ColumnName], getDataTypeByName(a.DataType.Name));
                    }
                }
                SqlCommText = "Insert into " + strTableName + " (" + strFieldList + ") values(" + strValueList + ")";
            }
            Ret = SQLiteHelper.ExecuteNonQuery(SqlCommText);
            return -1;
        }
    }
}
