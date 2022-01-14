using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;

namespace SubmitJobAuto.Submit
{
    public class SubmitJobPage
    {
        public void SubmitP()
        {
            #region Variable Declarations
            WpfEdit uITextBoxExtraCmdLineAEdit = this.UISubmitJobWindow.UIUserControl_1Custom.UIJobPropertiesExpander.UITextBoxExtraCmdLineAEdit;
            WpfCheckBox uIDebugModeCheckBoxCheckBox = this.UISubmitJobWindow.UIUserControl_1Custom.UIJobPropertiesExpander.UIDebugModeCheckBoxCheckBox;
            WpfComboBox uIDebugModeComboBoxComboBox = this.UISubmitJobWindow.UIUserControl_1Custom.UIJobPropertiesExpander.UIDebugModeComboBoxComboBox;
            #endregion

            // Type 'ssssssss' in 'textBoxExtraCmdLineArguments' text box
            uITextBoxExtraCmdLineAEdit.Text = this.RecordedMethod1Params.UITextBoxExtraCmdLineAEditText;

            // Select 'debugModeCheckBox' check box
            uIDebugModeCheckBoxCheckBox.Checked = this.RecordedMethod1Params.UIDebugModeCheckBoxCheckBoxChecked;

            // Select '72' in 'debugModeComboBox' combo box
            uIDebugModeComboBoxComboBox.SelectedItem = this.RecordedMethod1Params.UIDebugModeComboBoxComboBoxSelectedItem;
        }

        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }

        public UISubmitJobWindow UISubmitJobWindow
        {
            get
            {
                if ((this.mUISubmitJobWindow == null))
                {
                    this.mUISubmitJobWindow = new UISubmitJobWindow();
                }
                return this.mUISubmitJobWindow;
            }
        }
        #endregion

        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;

        private UISubmitJobWindow mUISubmitJobWindow;
        #endregion
    }

    public class RecordedMethod1Params
    {

        #region Fields
        /// <summary>
        /// Type 'ssssssss' in 'textBoxExtraCmdLineArguments' text box
        /// </summary>
        public string UITextBoxExtraCmdLineAEditText = "ssssssss";

        /// <summary>
        /// Select 'debugModeCheckBox' check box
        /// </summary>
        public bool UIDebugModeCheckBoxCheckBoxChecked = true;

        /// <summary>
        /// Select '72' in 'debugModeComboBox' combo box
        /// </summary>
        public string UIDebugModeComboBoxComboBoxSelectedItem = "72";
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UISubmitJobWindow : WpfWindow
    {

        public UISubmitJobWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Submit Job";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ScopAll_In_One");
            #endregion
        }

        #region Properties
        public UIUserControl_1Custom UIUserControl_1Custom
        {
            get
            {
                if ((this.mUIUserControl_1Custom == null))
                {
                    this.mUIUserControl_1Custom = new UIUserControl_1Custom(this);
                }
                return this.mUIUserControl_1Custom;
            }
        }
        #endregion

        #region Fields
        private UIUserControl_1Custom mUIUserControl_1Custom;
        #endregion
    }

    public class UIUserControl_1Custom : WpfCustom
    {

        public UIUserControl_1Custom(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.JobSubmissionDialog";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UserControl_1";
            this.WindowTitles.Add("ScopAll_In_One");
            #endregion
        }

        #region Properties
        public UIJobPropertiesExpander UIJobPropertiesExpander
        {
            get
            {
                if ((this.mUIJobPropertiesExpander == null))
                {
                    this.mUIJobPropertiesExpander = new UIJobPropertiesExpander(this);
                }
                return this.mUIJobPropertiesExpander;
            }
        }
        #endregion

        #region Fields
        private UIJobPropertiesExpander mUIJobPropertiesExpander;
        #endregion
    }

    public class UIJobPropertiesExpander : WpfExpander
    {

        public UIJobPropertiesExpander(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfExpander.PropertyNames.AutomationId] = "JobPropertiesExpander";
            this.WindowTitles.Add("ScopAll_In_One");
            #endregion
        }

        #region Properties
        public WpfEdit UITextBoxExtraCmdLineAEdit
        {
            get
            {
                if ((this.mUITextBoxExtraCmdLineAEdit == null))
                {
                    this.mUITextBoxExtraCmdLineAEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITextBoxExtraCmdLineAEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBoxExtraCmdLineArguments";
                    this.mUITextBoxExtraCmdLineAEdit.WindowTitles.Add("ScopAll_In_One");
                    #endregion
                }
                return this.mUITextBoxExtraCmdLineAEdit;
            }
        }

        public WpfCheckBox UIDebugModeCheckBoxCheckBox
        {
            get
            {
                if ((this.mUIDebugModeCheckBoxCheckBox == null))
                {
                    this.mUIDebugModeCheckBoxCheckBox = new WpfCheckBox(this);
                    #region Search Criteria
                    this.mUIDebugModeCheckBoxCheckBox.SearchProperties[WpfCheckBox.PropertyNames.AutomationId] = "debugModeCheckBox";
                    this.mUIDebugModeCheckBoxCheckBox.WindowTitles.Add("ScopAll_In_One");
                    #endregion
                }
                return this.mUIDebugModeCheckBoxCheckBox;
            }
        }

        public WpfComboBox UIDebugModeComboBoxComboBox
        {
            get
            {
                if ((this.mUIDebugModeComboBoxComboBox == null))
                {
                    this.mUIDebugModeComboBoxComboBox = new WpfComboBox(this);
                    #region Search Criteria
                    this.mUIDebugModeComboBoxComboBox.SearchProperties[WpfComboBox.PropertyNames.AutomationId] = "debugModeComboBox";
                    this.mUIDebugModeComboBoxComboBox.WindowTitles.Add("ScopAll_In_One");
                    #endregion
                }
                return this.mUIDebugModeComboBoxComboBox;
            }
        }
        #endregion

        #region Fields
        private WpfEdit mUITextBoxExtraCmdLineAEdit;

        private WpfCheckBox mUIDebugModeCheckBoxCheckBox;

        private WpfComboBox mUIDebugModeComboBoxComboBox;
        #endregion
    }
}
