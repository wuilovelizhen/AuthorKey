using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AuthorKey.Core;
namespace AuthorKey.ImpExp
{
    public class Import
    {
        public static DataSet ImpCatalog(string[] txtCommText)
        {
            DataSet Ds = new DataSet();
            try
            {
                DataTable DtVol = new DataTable();
                DtVol.Columns.Add("Vol");
                DataRow drVol = DtVol.NewRow();
                DataTable DtCatogry = new DataTable();
                DtCatogry.Columns.Add("Vol");
                DtCatogry.Columns.Add("Catogry");
                DtCatogry.Columns.Add("CatogryName");
                DataTable DtCharpt = new DataTable();
                DtCharpt.Columns.Add("Vol");
                DtCharpt.Columns.Add("Catogry");
                DtCharpt.Columns.Add("Charpt");
                DtCharpt.Columns.Add("iRow");
                int iFlg = 0;
                int iRow = 0;
                string intCatory = "";
                string stringCatory = "";
                for (int i = 0; i < txtCommText.Length; i++)
                {

                    string gettxtCommText = txtCommText[i];

                    iFlg = GetCatalog(gettxtCommText, iRow, ref intCatory, ref stringCatory);
                    if (iFlg > 0)
                    {
                        DataRow drCatogry = DtCatogry.NewRow();
                        drCatogry["Catogry"] = intCatory;
                        drCatogry["CatogryName"] = stringCatory;
                        DtCatogry.Rows.Add(drCatogry);
                        iRow = 0;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(intCatory))
                        {
                            DataRow drCharpt = DtCharpt.NewRow();
                            drCharpt["Catogry"] = intCatory;
                            drCharpt["Charpt"] = gettxtCommText;
                            drCharpt["iRow"] = iRow;
                            DtCharpt.Rows.Add(drCharpt);
                            iRow += 1;
                        }
                    }
                }
                Ds.Tables.Add(DtVol);
                Ds.Tables.Add(DtCatogry);
                Ds.Tables.Add(DtCharpt);
            }
            catch (Exception ee)
            {
                throw new Exception("打印发生错误" + ee.Message);
            }
            finally
            {
            }
            return Ds;
        }

        public static int GetCatalog(string S, int iRow, ref string iCatalog, ref string StrCatalog)
        {
            int ret = 0;
            //string sqianyan = "前言";
            //string sxiezi = "楔子";   
            if (string.IsNullOrEmpty(S))
            {
                return 0;
            }
            if (iRow < 15 && iRow != 0)
            {
                return 0;
            }
            int iMaxLength = PublicConst.iMaxCaptionLength;

            string StratChar = "第";
            string EndChar = "章";
            int iStartChar = S.IndexOf(StratChar);
            int iEndChar = S.IndexOf(EndChar);
            int iChnLength = iEndChar - iStartChar-1;
            if (iStartChar > -1 && iEndChar > 1 && iChnLength > 0 && S.Length < iMaxLength)
            {
                //bool blnCatalog = true;
                string strNum = "";
                
                strNum = S.Substring(iStartChar + 1, iChnLength);
                foreach (char cc in strNum)
                {
                    if (AuthorKey.Core.NumFormat.IndexChn(cc) < 0 && NumFormat.IndexNum(cc) < 0 && NumFormat.IdexChnUpper(cc) < 0)
                    {
                        return 0;
                    }
                }
                if (PublicConst.blnChn)
                {
                    iCatalog = strNum;
                }
                if (S.Length > iEndChar + 1)
                {
                    StrCatalog = S.Substring(iEndChar + 1).Trim();
                }
                ret = 1;
            }
            return ret;
        }
    }
}
