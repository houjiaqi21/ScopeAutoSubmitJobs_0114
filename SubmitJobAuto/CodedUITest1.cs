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

            //this.MyFun.Openscopeproject(scopeProjectPath);

            //CustomFun.Maximized();
            //TitleBar.ResetWindowLayout();

            //CustomFun.LogText("open successed" + CustomFun.MyDateTime);

            //WpfPane solution = MyFun._MyWpfPane(VsProjectN, "Solution Explorer");
            //WinTreeItem projectn = MyFun._MyWinTreeItem(solution, "Scope19.script");
            //Mouse.Click(projectn);

            //this.MenuFun.ClickSubmit();

            //WpfPane submitJob = MyFun._MyWpfPane(VsProjectN, "Submit Job");
            //Json.Updatejson("19","submit_job_information", "Script Name");
            //WpfEdit editbox1 = new WpfEdit(submitJob);
            //UITestControlCollection editbox = editbox1.FindMatchingControls();
            //foreach (UITestControl x in editbox)
            //{

            //    Mouse.Click(x);
            //    Keyboard.SendKeys("A", ModifierKeys.Control);
            //    Keyboard.SendKeys("ScopAll_In_One_Scope_houjiaqi" + timenow);
            //    Json.Updatejson("19", "submit_job_information", "Job Name");
            //    break;
            //}
            //WpfButton jobProperties = MyFun._MyWpfButton(submitJob, "Job Properties");
            //Mouse.Click(jobProperties);

            //SubmitJobPage.SubmitP();

            //SubmitJobPage.ClickSubmit();

            WinButton copy = MyFun._MyWinButton(VsProjectN, "Copy URL to clipboard");
            Mouse.Hover(copy);
            Mouse.Click();

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
        #endregion
    }

}
