using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;
using Newtonsoft.Json;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://prod-16.eastus2.logic.azure.com:443/workflows/28eecf48b48d4616a1045475b0857361/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=AMU8o0R4rVQwmfyNyVZqKtNZEsuPWOI18J-DhN-5UX8";
            //string result = PostUrl(url, "Body:{'Body':'Test','Subject':'DRI report','To':'v-hozhao@microsoft.com','CC':'v-hozhao@microsoft.com'}"); // key=4da4193e-384b-44d8-8a7f-2dd8b076d784
            //string result = PostUrl(url, "{\"Body\":\"Test\",\"Subject\":\"DRI report\",\"To\":\"v-hozhao@microsoft.com\",\"CC\":\"v-hozhao@microsoft.com\"}"); // key=4da4193e-384b-44d8-8a7f-2dd8b076d784

            //string a = Json.Readjson("submit_job_information");
            //Json.Updatejson("aaa", "submit_job_information", "Submit link");


            string scriptName = Json.ReadRjson("submit_job_information", "Script Name");
            string jobName = Json.ReadRjson("submit_job_information", "Job Name");
            string vsVerson = Json.ReadRjson("submit_job_information", "VS Verson");
            string projectName = Json.ReadRjson("submit_job_information", "Project Name");
            string submitLink = Json.ReadRjson("submit_job_information", "Submit link");
            string submitStatue = Json.ReadRjson("submit_job_information", "Submit Statue");

            string MailHTMLBody = "<HTML><head><title></title></head> <body>Hello all，<br/> <br/>below is the information for submitting job：<br/> <br/>Script Name : " + scriptName 
                + "<br/> <br/>Job Name : " + jobName + "<br/> <br/>VS Verson : " + vsVerson + "<br/> <br/>Project Name : " + projectName + "<br/> <br/>Submit link : " + submitLink
                + "<br/> <br/>Submit Statue : " + submitStatue + "</body></HTML>";



            string result = PostUrl(url, 
                "{\n \"MailBody\": \""+ MailHTMLBody + "\",\n \"Subject\": \"Scope test\",\n \"To\": \"v-jiaqihou@microsoft.com\",\n \"CC\": \"v-jiaqihou@microsoft.com\",\n \"Attachments\": \"\",\n \"AttachmentName\": \"\"\n}");
            //Console.WriteLine(body);
            //Console.WriteLine("OVER");
            //Console.ReadLine();

        }
        private static string PostUrl(string url, string postData)
        {
            HttpWebRequest request = null;
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                request = WebRequest.Create(url) as HttpWebRequest;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request.ProtocolVersion = HttpVersion.Version11;
                // 这里设置了协议类型。
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;// SecurityProtocolType.Tls1.2; 
                request.KeepAlive = false;
                ServicePointManager.CheckCertificateRevocationList = true;
                ServicePointManager.DefaultConnectionLimit = 100;
                ServicePointManager.Expect100Continue = false;
            }
            else
            {
                request = (HttpWebRequest)WebRequest.Create(url);
            }

            request.Method = "POST";    //使用get方式发送数据
            request.ContentType = "application/json";
            request.Referer = null;
            request.AllowAutoRedirect = true;
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            request.Accept = "*/*";

            byte[] data = Encoding.UTF8.GetBytes(postData);
            Stream newStream = request.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            //获取网页响应结果
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            //client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string result = string.Empty;
            using (StreamReader sr = new StreamReader(stream))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
        }
    }

    internal class Mail
    {
    }
}
