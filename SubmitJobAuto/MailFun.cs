using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;
using Attachment = System.Net.Mail.Attachment;

namespace SubmitJobAuto
{
    public class MailFun
    {
        public void sendemail()
        {

        
        Outlook.Application outlookObj = new Outlook.Application();
        MailItem Item = (Outlook.MailItem)
        outlookObj.CreateItem(Outlook.OlItemType.olMailItem);


        Item.To = MailTo;

　　　　 Item.Subject = "hello";

　　　　 Item.Body = "hello";

　　　　 Item.Send();
        }

        public bool Send()
        {
            try
            {
                Outlook.Application olApp = new Outlook.Application();
                MailItem mailItem = (Outlook.MailItem)
                olApp.CreateItem(Outlook.OlItemType.olMailItem);

                //  Outlook.Application olApp = new Outlook.Application();
                //  Outlook.MailItem mailItem = (Outlook.MailItem)olApp.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.To = MailTo;
                mailItem.CC = MailCC;
                mailItem.BCC = MailBCC;
                mailItem.Subject = "hello2";
                mailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;//内容格式
                mailItem.HTMLBody = MailHTMLBody;
                //foreach (var item in MailAttachments.Split(';'))
                //{
                //    mailItem.Attachments.Add(item);
                //}
                mailItem.Send();
                mailItem = null;
                olApp = null;
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        public static void SendMail(string fromMail, List<string> toMails, List<string> CCMails, string subject, string context, List<string> filenames)
        {
            System.Net.Mail.SmtpClient smtp = new SmtpClient("smtp.qq.com",25);
            System.Net.Mail.MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromMail);
            foreach (string toMail in toMails)
            {
                mail.To.Add(new MailAddress(toMail));
            }

            foreach (string ccmail in CCMails)
            {
                mail.CC.Add(new MailAddress(ccmail));
            }

            foreach (string filename in filenames)
            {
                mail.Attachments.Add(new Attachment(filename));
            }

            mail.Subject = subject;
            mail.Body = context;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mail);
        }



            /// <summary>
            /// 收件人，多个收件人用分号";"隔开
            /// </summary>
            public string MailTo { get; set; }

            /// <summary>
            /// 抄送，多个收件人用分号";"隔开
            /// </summary>
            public string MailCC { get; set; }

            /// <summary>
            /// 密送，多个收件人用分号";"隔开
            /// </summary>
            public string MailBCC { get; set; }

            /// <summary>
            /// 主题
            /// </summary>
            public string MailSubject { get; set; }

            /// <summary>
            /// 内容
            /// </summary>
            public string MailHTMLBody { get; set; }

            /// <summary>
            /// 多个附加用分号";"隔开
            /// </summary>
            public string MailAttachments { get; set; }

           
        

    }
}