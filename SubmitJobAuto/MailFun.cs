using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;
//using Attachment = System.Net.Mail.Attachment;
using System.IO;
using Newtonsoft.Json;
//using System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

namespace SubmitJobAuto
{
    public class MailFun
    {

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
                mailItem.Subject = MailSubject;
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


        /// <summary>
        /// Recipients, multiple recipients are separated by a semicolon ";"
        /// </summary>
        public string MailTo { get; set; }

        /// <summary>
        /// Cc, multiple recipients are separated by a semicolon ";"
        /// </summary>
        public string MailCC { get; set; }

        /// <summary>
        /// Bcc, multiple recipients are separated by a semicolon ";"
        /// </summary>
        public string MailBCC { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        public string MailSubject { get; set; }

        /// <summary>
        /// content
        /// </summary>
        public string MailHTMLBody { get; set; }

        /// <summary>
        /// Multiple appends are separated by semicolons ";"
        /// </summary>
        public string MailAttachments { get; set; }






        public static void SendAPI()
        {
            string url = "https://prod-16.eastus2.logic.azure.com:443/workflows/28eecf48b48d4616a1045475b0857361/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=AMU8o0R4rVQwmfyNyVZqKtNZEsuPWOI18J-DhN-5UX8";
           


            string strContent = "{\n \"MailBody\": \"testmaill\",\n \"Subject\": \"testmail\",\n \"To\": \"v-jiaqihou@microsoft.com\",\n \"CC\": \"v-jiaqihou@microsoft.com\",\n \"Attachments\": \"\",\n \"AttachmentName\": \"\"\n}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/json";

            using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
            {
                dataStream.Write(strContent);
                dataStream.Close();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8";
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();

        }




        

        
        

    }
}