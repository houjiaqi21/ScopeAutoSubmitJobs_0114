namespace SubmitJobAuto
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;


    public partial class TitleBar
    {

        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void ResetWindowLayout()
        {
            #region Variable Declarations
            WpfMenuItem uIResetWindowLayoutMenuItem = this.UIScopAll_In_OneMicrosWindow.UIMenuBarMenuBar.UIWindowMenuItem.UIResetWindowLayoutMenuItem;
            WinButton uIYesButton = this.UIMicrosoftVisualStudiWindow.UIYesWindow.UIYesButton;
            #endregion

            // Click 'Window' -> 'Reset Window Layout' menu item
            Mouse.Click(uIResetWindowLayoutMenuItem, new Point(105, 8));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(48, 5));
        }

        #region Properties
        public UIScopAll_In_OneMicrosWindow_TitleBar UIScopAll_In_OneMicrosWindow
        {
            get
            {
                if ((this.mUIScopAll_In_OneMicrosWindow_TitleBar == null))
                {
                    this.mUIScopAll_In_OneMicrosWindow_TitleBar = new UIScopAll_In_OneMicrosWindow_TitleBar();
                }
                return this.mUIScopAll_In_OneMicrosWindow_TitleBar;
            }
        }

        public UIMicrosoftVisualStudiWindow UIMicrosoftVisualStudiWindow
        {
            get
            {
                if ((this.mUIMicrosoftVisualStudiWindow == null))
                {
                    this.mUIMicrosoftVisualStudiWindow = new UIMicrosoftVisualStudiWindow();
                }
                return this.mUIMicrosoftVisualStudiWindow;
            }
        }
        #endregion

        #region Fields
        private UIScopAll_In_OneMicrosWindow_TitleBar mUIScopAll_In_OneMicrosWindow_TitleBar;

        private UIMicrosoftVisualStudiWindow mUIMicrosoftVisualStudiWindow;
        #endregion
    }

    public class UIScopAll_In_OneMicrosWindow_TitleBar : WpfWindow
    {

        public UIScopAll_In_OneMicrosWindow_TitleBar()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "ScopAll_In_One - Microsoft Visual Studio";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
            #endregion
        }

        #region Properties
        public UIMenuBarMenuBar UIMenuBarMenuBar
        {
            get
            {
                if ((this.mUIMenuBarMenuBar == null))
                {
                    this.mUIMenuBarMenuBar = new UIMenuBarMenuBar(this);
                }
                return this.mUIMenuBarMenuBar;
            }
        }
        #endregion

        #region Fields
        private UIMenuBarMenuBar mUIMenuBarMenuBar;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenuBarMenuBar : WpfControl
    {

        public UIMenuBarMenuBar(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ControlType] = "MenuBar";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "MenuBar";
            this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
            #endregion
        }

        #region Properties
        public UIWindowMenuItem UIWindowMenuItem
        {
            get
            {
                if ((this.mUIWindowMenuItem == null))
                {
                    this.mUIWindowMenuItem = new UIWindowMenuItem(this);
                }
                return this.mUIWindowMenuItem;
            }
        }
        #endregion

        #region Fields
        private UIWindowMenuItem mUIWindowMenuItem;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIWindowMenuItem : WpfMenuItem
    {

        public UIWindowMenuItem(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfMenuItem.PropertyNames.Name] = "Window";
            this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
            #endregion
        }

        #region Properties
        public WpfMenuItem UIResetWindowLayoutMenuItem
        {
            get
            {
                if ((this.mUIResetWindowLayoutMenuItem == null))
                {
                    this.mUIResetWindowLayoutMenuItem = new WpfMenuItem(this);
                    #region Search Criteria
                    this.mUIResetWindowLayoutMenuItem.SearchProperties[WpfMenuItem.PropertyNames.Name] = "Reset Window Layout";
                    this.mUIResetWindowLayoutMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIResetWindowLayoutMenuItem.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIResetWindowLayoutMenuItem;
            }
        }
        #endregion

        #region Fields
        private WpfMenuItem mUIResetWindowLayoutMenuItem;
        #endregion
    }

    public class UIMicrosoftVisualStudiWindow : WinWindow
    {

        public UIMicrosoftVisualStudiWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Microsoft Visual Studio";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }

        #region Properties
        public UIYesWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow(this);
                }
                return this.mUIYesWindow;
            }
        }
        #endregion

        #region Fields
        private UIYesWindow mUIYesWindow;
        #endregion
    }

    public class UIYesWindow : WinWindow
    {

        public UIYesWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }

        #region Properties
        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIYesButton.SearchProperties[WinButton.PropertyNames.Name] = "Yes";
                    this.mUIYesButton.WindowTitles.Add("Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIYesButton;
            }
        }
        #endregion

        #region Fields
        private WinButton mUIYesButton;
        #endregion
    }
}

