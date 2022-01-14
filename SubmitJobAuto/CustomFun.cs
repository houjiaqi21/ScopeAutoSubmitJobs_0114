using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitJobAuto
{
    public class CustomFun
    {
        public static string LogFolderpath = ConfigurationSettings.AppSettings["LogFinalPath"];
        public static string FinalPath = ConfigurationSettings.AppSettings["LogFinalPath"];
        public static string FileName = "ScopeReport";

        static string imagePath = ConfigurationSettings.AppSettings["ImagePath"];

        public static string MyDateTime = DateTime.Now.ToString("_yyyyMMdd_HHmmss");
        public static string LogText(string WritingText)
        {

            FinalPath = @"..\..\..\SubmitJobAuto\testlogs" + "\\" + FileName /*+ MyDateTime*/ + ".txt";

            if (!File.Exists(FinalPath))
            {
                using (StreamWriter sw = File.CreateText(FinalPath))
                {
                }
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(FinalPath, true))
            {
                file.WriteLine(WritingText);
            }
            return FinalPath;
        }


        public static void CaptureImage(UITestControl MyWindow, string name)
        {
            Image shot = MyWindow.CaptureImage();
            shot.Save(imagePath + name + MyDateTime + ".png");
        }

        public static string randomstring(int rEPEATcHAR)
        {
            var chars = "ABC--DEFGHIJ+_k LMNOPQRSTUVWXYZ0__12345--6789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, rEPEATcHAR).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }


        public void Maximized()
        {
            #region Variable Declarations
            WpfWindow uIScopAll_In_OneMicrosWindow = this.UIScopAll_In_OneMicrosWindow;
            #endregion

            // Maximize window 'ScopAll_In_One - Microsoft Visual Studio'
            uIScopAll_In_OneMicrosWindow.SetProperty("State", ControlStates.Maximized);
        }

        #region Properties
        UIScopAll_In_OneMicrosWindow UIScopAll_In_OneMicrosWindow
        {
            get
            {
                if ((this.mUIScopAll_In_OneMicrosWindow == null))
                {
                    this.mUIScopAll_In_OneMicrosWindow = new UIScopAll_In_OneMicrosWindow();
                }
                return this.mUIScopAll_In_OneMicrosWindow;
            }
        }
        #endregion

        #region Fields
        private UIScopAll_In_OneMicrosWindow mUIScopAll_In_OneMicrosWindow;
        #endregion
    }
}

