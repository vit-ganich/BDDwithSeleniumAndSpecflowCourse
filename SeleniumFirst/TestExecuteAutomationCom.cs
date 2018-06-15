using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;


namespace SeleniumScripts
{
    [TestFixture]
    class TestExecuteAutomationCom
    {
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
            // Fill User Detais
            pageEA.FillUserForm("Sir", "Vitali", "Hanich");

        }
        [TearDown]
        public void tearDown()
        {
            PropertiesCollection.driver.Close();
        }
    }
}