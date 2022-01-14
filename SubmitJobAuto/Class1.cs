using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    public partial class UIMap
    {

        //    /// <summary>
        //    /// RecordedMethod1
        //    /// </summary>
        //    public void ResetWindowLayout()
        //    {
        //        #region Variable Declarations
        //        WpfEdit uITextEditorEdit = this.UIScopAll_In_OneMicrosWindow.UIItemTabList.UIWpfTextViewHostCustom.UITextEditorEdit;
        //        WpfMenuItem uIResetWindowLayoutMenuItem = this.UIScopAll_In_OneMicrosWindow.UIMenuBarMenuBar.UIWindowMenuItem.UIResetWindowLayoutMenuItem;
        //        WinButton uIYesButton = this.UIMicrosoftVisualStudiWindow.UIYesWindow.UIYesButton;
        //        #endregion

        //        // Click 'Text Editor' text box
        //        Mouse.Click(uITextEditorEdit, new Point(484, -156));

        //        // Click 'Window' -> 'Reset Window Layout' menu item
        //        Mouse.Click(uIResetWindowLayoutMenuItem, new Point(101, 10));

        //        // Click '&Yes' button
        //        Mouse.Click(uIYesButton, new Point(44, 12));
        //    }

        //    #region Properties
        //    public UIScopAll_In_OneMicrosWindow_TitleBar UIScopAll_In_OneMicrosWindow
        //    {
        //        get
        //        {
        //            if ((this.mUIScopAll_In_OneMicrosWindow == null))
        //            {
        //                this.mUIScopAll_In_OneMicrosWindow = new UIScopAll_In_OneMicrosWindow_TitleBar();
        //            }
        //            return this.mUIScopAll_In_OneMicrosWindow;
        //        }
        //    }

        //    public UIMicrosoftVisualStudiWindow UIMicrosoftVisualStudiWindow
        //    {
        //        get
        //        {
        //            if ((this.mUIMicrosoftVisualStudiWindow == null))
        //            {
        //                this.mUIMicrosoftVisualStudiWindow = new UIMicrosoftVisualStudiWindow();
        //            }
        //            return this.mUIMicrosoftVisualStudiWindow;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private UIScopAll_In_OneMicrosWindow_TitleBar mUIScopAll_In_OneMicrosWindow;

        //    private UIMicrosoftVisualStudiWindow mUIMicrosoftVisualStudiWindow;
        //    #endregion
        //}

        //public class UIScopAll_In_OneMicrosWindow_TitleBar : WpfWindow
        //{


        //    #region Properties
        //    public UIItemTabList UIItemTabList
        //    {
        //        get
        //        {
        //            if ((this.mUIItemTabList == null))
        //            {
        //                this.mUIItemTabList = new UIItemTabList(this);
        //            }
        //            return this.mUIItemTabList;
        //        }
        //    }

        //    public UIMenuBarMenuBar UIMenuBarMenuBar
        //    {
        //        get
        //        {
        //            if ((this.mUIMenuBarMenuBar == null))
        //            {
        //                this.mUIMenuBarMenuBar = new UIMenuBarMenuBar(this);
        //            }
        //            return this.mUIMenuBarMenuBar;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private UIItemTabList mUIItemTabList;

        //    private UIMenuBarMenuBar mUIMenuBarMenuBar;
        //    #endregion
        //}

        //public class UIItemTabList : WpfTabList
        //{

        //    public UIItemTabList(UITestControl searchLimitContainer) :
        //            base(searchLimitContainer)
        //    {
        //        #region Search Criteria
        //        this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
        //        #endregion
        //    }

        //    #region Properties
        //    public UIWpfTextViewHostCustom UIWpfTextViewHostCustom
        //    {
        //        get
        //        {
        //            if ((this.mUIWpfTextViewHostCustom == null))
        //            {
        //                this.mUIWpfTextViewHostCustom = new UIWpfTextViewHostCustom(this);
        //            }
        //            return this.mUIWpfTextViewHostCustom;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private UIWpfTextViewHostCustom mUIWpfTextViewHostCustom;
        //    #endregion
        //}

        //public class UIWpfTextViewHostCustom : WpfCustom
        //{

        //    public UIWpfTextViewHostCustom(UITestControl searchLimitContainer) :
        //            base(searchLimitContainer)
        //    {
        //        #region Search Criteria
        //        this.SearchProperties[WpfControl.PropertyNames.ClassName] = null;
        //        this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "WpfTextViewHost";
        //        this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
        //        #endregion
        //    }

        //    #region Properties
        //    public WpfEdit UITextEditorEdit
        //    {
        //        get
        //        {
        //            if ((this.mUITextEditorEdit == null))
        //            {
        //                this.mUITextEditorEdit = new WpfEdit(this);
        //                #region Search Criteria
        //                this.mUITextEditorEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "WpfTextView";
        //                this.mUITextEditorEdit.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
        //                #endregion
        //            }
        //            return this.mUITextEditorEdit;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private WpfEdit mUITextEditorEdit;
        //    #endregion
        //}

        //public class UIMenuBarMenuBar : WpfControl
        //{

        //    public UIMenuBarMenuBar(UITestControl searchLimitContainer) :
        //            base(searchLimitContainer)
        //    {
        //        #region Search Criteria
        //        this.SearchProperties[WpfControl.PropertyNames.ControlType] = "MenuBar";
        //        this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "MenuBar";
        //        this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
        //        #endregion
        //    }

        //    #region Properties
        //    public UIWindowMenuItem UIWindowMenuItem
        //    {
        //        get
        //        {
        //            if ((this.mUIWindowMenuItem == null))
        //            {
        //                this.mUIWindowMenuItem = new UIWindowMenuItem(this);
        //            }
        //            return this.mUIWindowMenuItem;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private UIWindowMenuItem mUIWindowMenuItem;
        //    #endregion
        //}

        //public class UIWindowMenuItem : WpfMenuItem
        //{

        //    public UIWindowMenuItem(UITestControl searchLimitContainer) :
        //            base(searchLimitContainer)
        //    {
        //        #region Search Criteria
        //        this.SearchProperties[WpfMenuItem.PropertyNames.Name] = "Window";
        //        this.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
        //        #endregion
        //    }

        //    #region Properties
        //    public WpfMenuItem UIResetWindowLayoutMenuItem
        //    {
        //        get
        //        {
        //            if ((this.mUIResetWindowLayoutMenuItem == null))
        //            {
        //                this.mUIResetWindowLayoutMenuItem = new WpfMenuItem(this);
        //                #region Search Criteria
        //                this.mUIResetWindowLayoutMenuItem.SearchProperties[WpfMenuItem.PropertyNames.Name] = "Reset Window Layout";
        //                this.mUIResetWindowLayoutMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
        //                this.mUIResetWindowLayoutMenuItem.WindowTitles.Add("ScopAll_In_One - Microsoft Visual Studio");
        //                #endregion
        //            }
        //            return this.mUIResetWindowLayoutMenuItem;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private WpfMenuItem mUIResetWindowLayoutMenuItem;
        //    #endregion
        //}

        //public class UIMicrosoftVisualStudiWindow : WinWindow
        //{

        //    public UIMicrosoftVisualStudiWindow()
        //    {
        //        #region Search Criteria
        //        this.SearchProperties[WinWindow.PropertyNames.Name] = "Microsoft Visual Studio";
        //        this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
        //        this.WindowTitles.Add("Microsoft Visual Studio");
        //        #endregion
        //    }

        //    #region Properties
        //    public UIYesWindow UIYesWindow
        //    {
        //        get
        //        {
        //            if ((this.mUIYesWindow == null))
        //            {
        //                this.mUIYesWindow = new UIYesWindow(this);
        //            }
        //            return this.mUIYesWindow;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private UIYesWindow mUIYesWindow;
        //    #endregion
        //}

        //public class UIYesWindow : WinWindow
        //{

        //    public UIYesWindow(UITestControl searchLimitContainer) :
        //            base(searchLimitContainer)
        //    {
        //        #region Search Criteria
        //        this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
        //        this.WindowTitles.Add("Microsoft Visual Studio");
        //        #endregion
        //    }

        //    #region Properties
        //    public WinButton UIYesButton
        //    {
        //        get
        //        {
        //            if ((this.mUIYesButton == null))
        //            {
        //                this.mUIYesButton = new WinButton(this);
        //                #region Search Criteria
        //                this.mUIYesButton.SearchProperties[WinButton.PropertyNames.Name] = "Yes";
        //                this.mUIYesButton.WindowTitles.Add("Microsoft Visual Studio");
        //                #endregion
        //            }
        //            return this.mUIYesButton;
        //        }
        //    }
        //    #endregion

        //    #region Fields
        //    private WinButton mUIYesButton;
        //    #endregion
        //}
    }
}
