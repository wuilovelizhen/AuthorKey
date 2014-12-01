//关于导入和导出的Doc读取和写入操作再次处理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.XWPF.UserModel;
using System.IO;
namespace AuthorKey.Core
{
    public class WordAPI
    {
        public static string[] GetDocxDocumentBuilder(string fileName)
        {
            string[] texts = null;

            try
            {
                using (FileStream stream = File.OpenRead(fileName))
                {

                    XWPFDocument doc2 = new XWPFDocument(stream);
                    foreach (XWPFParagraph para in doc2.Paragraphs)
                    {
                        if (texts == null)
                        {
                            Array.Resize(ref texts, 1);
                        }
                        else
                        {
                            Array.Resize(ref texts, texts.Length + 1);
                        }
                        texts[texts.Length - 1] = para.GetParagraphText();
                    }
                }
            }
            catch (Exception ee)
            {
                throw new Exception(ee.Message);
            }
            return texts;
        }

    }
}
