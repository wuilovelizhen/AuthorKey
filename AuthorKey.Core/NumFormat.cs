﻿//中英文数字格式转化相关在此处理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorKey.Core
{
    public static class NumFormat
    {
        /// <summary>
        /// 将阿拉伯数字转成中文
        /// </summary>
        // 转换数字 
        public static char ToNum(char x)
        {
            string strChnNames = "零一二三四五六七八九";
            string strNumNames = "0123456789";
            return strChnNames[strNumNames.IndexOf(x)];
        }
        public static char ToChn(char x)
        {
            string strChnNames = "零一二三四五六七八九";
            string strNumNames = "0123456789";
            return strNumNames[strChnNames.IndexOf(x)];
        }

        public static int IndexChn(char x)
        {
            string strChnNames = "零一二三四五六七八九十百千";
            return strChnNames.IndexOf(x);
        }

        public static int IdexChnUpper(char x)
        {
            string strChnNames = "零壹贰叁肆伍陆柒捌玖拾佰仟";
            return strChnNames.IndexOf(x);
        }

        public static int IndexNum(char x)
        {
            string strNumNames = "0123456789";
            return strNumNames.IndexOf(x);
        }

        // 转换万以下整数 
        private static string ChangeInt(string x)
        {
            string[] strArrayLevelNames = new string[4] { "", "十", "百", "千" };
            string ret = "";
            int i;
            for (i = x.Length - 1; i >= 0; i--)
                if (x[i] == '0')
                    ret = ToNum(x[i]) + ret;
                else
                    ret = ToNum(x[i]) + strArrayLevelNames[x.Length - 1 - i] + ret;
            while ((i = ret.IndexOf("零零")) != -1)
                ret = ret.Remove(i, 1);
            if (ret[ret.Length - 1] == '零' && ret.Length > 1)
                ret = ret.Remove(ret.Length - 1, 1);
            if (ret.Length >= 2 && ret.Substring(0, 2) == "一十")
                ret = ret.Remove(0, 1);
            return ret;
        }
        // 转换整数 
        private static string ToInt(string x)
        {
            int len = x.Length;
            string ret, temp;
            if (len <= 4)
                ret = ChangeInt(x);
            else if (len <= 8)
            {
                ret = ChangeInt(x.Substring(0, len - 4)) + "万";
                temp = ChangeInt(x.Substring(len - 4, 4));
                if (temp.IndexOf("千") == -1 && temp != "")
                    ret += "零" + temp;
                else
                    ret += temp;
            }
            else
            {
                ret = ChangeInt(x.Substring(0, len - 8)) + "亿";
                temp = ChangeInt(x.Substring(len - 8, 4));
                if (temp.IndexOf("千") == -1 && temp != "")
                    ret += "零" + temp;
                else
                    ret += temp;
                ret += "万";
                temp = ChangeInt(x.Substring(len - 4, 4));
                if (temp.IndexOf("千") == -1 && temp != "")
                    ret += "零" + temp;
                else
                    ret += temp;
            }
            int i;
            if ((i = ret.IndexOf("零万")) != -1)
                ret = ret.Remove(i + 1, 1);
            while ((i = ret.IndexOf("零零")) != -1)
                ret = ret.Remove(i, 1);
            if (ret[ret.Length - 1] == '零' && ret.Length > 1)
                ret = ret.Remove(ret.Length - 1, 1);
            return ret;
        }
        private static string ToDecimal(string x)
        {
            string ret = "";
            for (int i = 0; i < x.Length; i++)
                ret += ToNum(x[i]);
            return ret;
        }
        public static string NumToChn(string x)
        {
            if (x.Length == 0)
                return "";
            string ret = "";
            if (x[0] == '-')
            {
                ret = "负";
                x = x.Remove(0, 1);
            }
            if (x[0].ToString() == ".")
                x = "0" + x;
            if (x[x.Length - 1].ToString() == ".")
                x = x.Remove(x.Length - 1, 1);
            if (x.IndexOf(".") > -1)
                ret += ToInt(x.Substring(0, x.IndexOf("."))) + "点" + ToDecimal(x.Substring(x.IndexOf(".") + 1));
            else
                ret += ToInt(x);
            return ret;
        }
    } 
}
