using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Sample
{
    public partial class MailSender : Form
    {
        public MailSender()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string host = "192.168.22.12";
            int port = 25;
            string userid = "jay.liu";
            string password = "1111";

            MailMessage message = BuildMessage();

            SmtpClient smtp = new SmtpClient(host, port);
            smtp.Credentials = new NetworkCredential(userid, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);

                MessageBox.Show("Success!", "Sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! \r\n" + ex.Message, "Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private MailMessage BuildMessage()
        {
            string from = "sample@sample.sample";
            string to = textBoxTo.Text;
            string subproject = textBoxSubject.Text;
            string[] images = htmlTextBoxBody.Images;
            string body = htmlTextBoxBody.Text;

            MailMessage message = new MailMessage();

            message.From = new MailAddress(from);
            message.To.Add(new MailAddress(to));
            message.Subject = subproject;

            //message.IsBodyHtml = true;

            if (images.Length != 0)
            {
                for (int i = 0, count = images.Length; i < count; ++i)
                {
                    string image = images[i];

                    if (image.Trim() == "")
                    {
                        continue;
                    }

                    if (!image.StartsWith("file"))
                    {
                        continue;
                    }

                    string path = Path.GetFullPath(image.Replace("%20", " ").Replace("file:///", ""));
                    string cid = string.Format("image_{0:00}", i);

                    Attachment attach = new Attachment(path);
                    attach.Name = Path.GetFileNameWithoutExtension(path);
                    attach.ContentId = cid;
                    message.Attachments.Add(attach);

                    body = body.Replace(path, string.Format("cid:{0}", cid));
                }
            }

            message.Body = body;

            return message;
        }
    }
}