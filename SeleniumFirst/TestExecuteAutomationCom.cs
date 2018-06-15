using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using SeleniumScripts;

namespace SeleniumScripts
{
    [TestFixture]
    class TestExecuteAutomationCom
    {
        public static void Main(string[] args)
        {
        }
        static int run = 0;
        [SetUp]
        public void SetUp()
        {
            PropertiesCollection.driver = new FirefoxDriver();
            PropertiesCollection.driver.Navigate().GoToUrl(PropertiesCollection.startpage);
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15.0);
        }
        [Test]
        public void ExecuteText()
        {
            // Login to Application
            LoggingPageObject pageLogin = new LoggingPageObject();
            EAPageObject pageEA = pageLogin.Login("user1", "pass123");

            pageEA.FillUserForm("Sir", "Vitali", "Hanich");

            // Initialazing the page by calling its reference
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("Sir");
            page.txtFirstName.SendKeys("Vitali");
            page.txtMiddleName.SendKeys("Hanich");
            page.chboxLangEnglish.Click();
            page.btnSave.Click();

            //// Title
            //SeleniumSetMethods.SelectDropDown(PropertyType.Name, "TitleId", "Mr.");
            //// Initial
            //SeleniumSetMethods.EnterText(PropertyType.Id, "Initial", "H.V.A.");
            //// First Name
            //SeleniumSetMethods.EnterText(PropertyType.XPath, "//*[@id = 'FirstName']", "Vitali");
            //// Middle Name
            //SeleniumSetMethods.EnterText(PropertyType.Name, "MiddleName", "Hanich");
            //// Get values
            //Console.WriteLine($"The value from my Title is: {SeleniumGetMethods.GetText(PropertyType.Name, "TitleId")}");
            //Console.WriteLine($"The value from my Initial is: {SeleniumGetMethods.GetText(PropertyType.Id, "Initial")}");
            //Console.WriteLine($"The value from my First Name is: {SeleniumGetMethods.GetText(PropertyType.XPath, "//*[@id = 'FirstName']")}");
            //Console.WriteLine($"The value from my Middle Name is: {SeleniumGetMethods.GetText(PropertyType.Name, "MiddleName")}");
            //// Click Language check box
            //SeleniumSetMethods.ClickElement(PropertyType.Name, "english");
            //// Click Save
            //SeleniumSetMethods.ClickElement(PropertyType.Name, "Save");
        }
        [TearDown]
        public void tearDown()
        {
            PropertiesCollection.driver.Close();
        }
    }
}