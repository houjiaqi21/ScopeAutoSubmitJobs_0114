using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System.Configuration;
using SubmitJobAuto.Submit;
using System.Threading.Tasks;
using System.Threading;

namespace SubmitJobAuto
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {

        static string projectName = ConfigurationSettings.AppSettings["ProjectName"];
        static string testProjectPath = ConfigurationSettings.AppSettings["TestProjectPath"];

        static DateTime time = DateTime.Now;
        static string timenow = DateTimeTool.DateTimeToStamp(time);
        static string jobName;

        static WinWindow VisualStudioStart = MyFun._window("Microsoft Visual Studio");
        static WinWindow VsProjectN = MyFun._window(projectName + " - Microsoft Visual Studio");
        static WinWindow VsProject = MyFun._window("test" + timenow + " - Microsoft Visual Studio");

        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            #region Variable Declarations
            WinWindow VsProjectN = MyFun._window("ScopAll_In_One" + " - Microsoft Visual Studio");

            string scopeProjectPath = Json.Readjson("scope_project_path", "ScopAll_In_One");
            #endregion

            this.MyFun.Openscopeproject(scopeProjectPath);

            Json.Updatejson("2019", "submit_job_information", "VS Verson");
            Json.Updatejson("ScopAll_In_One", "submit_job_information", "Project Name");

            CustomFun.Maximized();
            TitleBar.ResetWindowLayout();

            CustomFun.LogText("open successed" + CustomFun.MyDateTime);

            WpfPane solution = MyFun._MyWpfPane(VsProjectN, "Solution Explorer");
            WinTreeItem projectn = MyFun._MyWinTreeItem(solution, "Scope19.script");
            Mouse.Click(projectn);

            this.MenuFun.ClickSubmit();

            WpfPane submitJob = MyFun._MyWpfPane(VsProjectN, "Submit Job");
            Json.Updatejson("Scope19.script", "submit_job_information", "Script Name");
            WpfEdit editbox1 = new WpfEdit(submitJob);


            UITestControlCollection editbox = editbox1.FindMatchingControls();
            foreach (UITestControl x in editbox)
            {

                Mouse.Click(x);
                Keyboard.SendKeys("A", ModifierKeys.Control);
                jobName = "ScopAll_In_One_Scope_houjiaqi" + timenow;
                Keyboard.SendKeys(jobName);
                Json.Updatejson(jobName, "submit_job_information", "Job Name");
                break;
            }
            WpfButton jobProperties = MyFun._MyWpfButton(submitJob, "Job Properties");
            Mouse.Click(jobProperties);

            SubmitJobPage.SubmitP();

            SubmitJobPage.ClickSubmit();

            //Playback.Wait(2000);

            WpfButton submitYes = MyFun._MyWpfButton(VsProjectN, "Yes");
            //submitYes.DrawHighlight();
            Mouse.Click(submitYes);


            WinPane jobView = MyFun._MyWinPane(VsProjectN, "Job view: " + jobName);
            //WinText finalizing = MyFun._MyWinText(VsProjectN, "Finalizing");
            WinEdit jobResult = MyFun._WinEdit(VsProjectN, "Job Result");

            while (!jobView.Exists)
            {
                jobView = MyFun._MyWinPane(VsProjectN, "Job view: " + jobName);
            }
            if (jobView.Exists)
            {
                //log
                CustomFun.LogText("Job View opened" + timenow);
                //shot
                WinButton copy = MyFun._MyWinButton(VsProjectN, "Copy URL to clipboard");
                Mouse.Hover(copy);
                Mouse.Click();
                string message = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));

                Json.Updatejson(message, "submit_job_information", "Submit link");

                while (!jobResult.Exists)
                {
                    jobResult = MyFun._WinEdit(VsProjectN, "Job Result");
                }
                if (jobResult.Exists)
                {
                    //shot
                    while (!(jobResult.Text == "Succeeded"))
                    {

                    }
                    if (jobResult.Text == "Succeeded")
                    {
                        //log
                        CustomFun.LogText("Submit job succeeded" + timenow);
                        //shot
                        Json.Updatejson("Succeeded", "submit_job_information", "Submit Statue");
                    }
                }
            }

            ApplicationUnderTest.Launch(@"D:\SubmitJobAuto\SendEmail\bin\Release\SendEmail.exe");
            Playback.Wait(3000);
        }




        [TestMethod]
        public void CodedUITestMethod2()
        {
            //MailFun mailFun1 = new MailFun();
            //mailFun1.MailTo = "744863071@qq.com";
            //mailFun1.MailSubject = "Scope Submit Report";

            //string scriptName = Json.ReadRjson("submit_job_information", "Script Name");
            //string jobName = Json.ReadRjson("submit_job_information", "Job Name");
            //Json.ReadRjson("submit_job_information", "VS Verson");
            //Json.ReadRjson("submit_job_information", "Project Name");
            //Json.ReadRjson("submit_job_information", "Submit link");
            //Json.ReadRjson("submit_job_information", "Submit Statue");
            ////mailFun1.MailHTMLBody = "<HTML><BODY><table><tr><td>" + "Script Name" + "</td><td>" + scriptName + "</td></tr><tr><td>" + "Job Name" + "</td><td>" + jobName + "</td></tr></table></BODY></HTML>";
            //mailFun1.MailHTMLBody = "<HTML><head><title></title></head> <body>Hello all，<br/> <br/>below is the information for submitting job：<br/> <br/>Script Name : " + scriptName +
            //    "<br/> <br/>Job Name : " + jobName + "</body></HTML>";

            //mailFun1.Send();
            //MailFun.SendAPI();
           
        }
       


        #region Additional test attributes

            // You can use the following additional attributes as you write your tests:

            //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            //string a = Json.Readjson("A2","B1");
            //MessageBox.Show(a);
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
        #region instantiate
        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;

        public MenuFun MenuFun
        {
            get
            {
                if (this.menuFun == null)
                {
                    this.menuFun = new MenuFun();
                }

                return this.menuFun;
            }
        }

        private MenuFun menuFun;

        public MyFun MyFun
        {
            get
            {
                if (this.myFun == null)
                {
                    this.myFun = new MyFun();
                }

                return this.myFun;
            }
        }

        private MyFun myFun;

        public TitleBar TitleBar
        {
            get
            {
                if (this.titleBar == null)
                {
                    this.titleBar = new TitleBar();
                }

                return this.titleBar;
            }
        }

        private TitleBar titleBar;

        public CustomFun CustomFun
        {
            get
            {
                if (this.customFun == null)
                {
                    this.customFun = new CustomFun();
                }

                return this.customFun;
            }
        }

        private CustomFun customFun;

        public SubmitJobPage SubmitJobPage
        {
            get
            {
                if (this.submitJobPage == null)
                {
                    this.submitJobPage = new SubmitJobPage();
                }

                return this.submitJobPage;
            }
        }

        private SubmitJobPage submitJobPage;

        public MailFun MailFun
        {
            get
            {
                if (this.mailFun == null)
                {
                    this.mailFun = new MailFun();
                }

                return this.mailFun;
            }
        }

        private MailFun mailFun;
        #endregion
    }


}
