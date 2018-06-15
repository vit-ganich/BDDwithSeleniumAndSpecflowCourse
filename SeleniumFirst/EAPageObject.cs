using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




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
    }
}
