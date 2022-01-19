

namespace SubmitJobAuto
{
    public class MailFun
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            CreateMailItem();
        }

        private void CreateMailItem()
        {
            Outlook.MailItem mailItem = (Outlook.MailItem)
                this.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "This is the subject";
            mailItem.To = "someone@example.com";
            mailItem.Body = "This is the message.";
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;
            mailItem.Display(false);
        }
    }
}
