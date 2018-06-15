using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumScripts
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        // Title text field
        [FindsBy(How = How.Name, Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }
        // Initial text field
        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial { get; set; }
        // First Name text field
        [FindsBy(How = How.XPath, Using = "//*[@id = 'FirstName']")]
        public IWebElement txtFirstName { get; set; }
        // Middle Name text field
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }
        // Language check box
        [FindsBy(How = How.Name, Using = "english")]
        public IWebElement chboxLangEnglish { get; set; }
        // Save button
        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public void FillUserForm(string initial, string firstName, string middleName)
        {
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            SeleniumSetMethods.ClickElement(chboxLangEnglish);
            SeleniumSetMethods.ClickElement(btnSave);
        } 
    }
}
