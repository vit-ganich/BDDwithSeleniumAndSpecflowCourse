using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumFirst
{   
    [TestFixture]
    class Program
    {
        public static void Main(string[] args)
        {
        }
        static int run = 0;
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15.0);
            Console.WriteLine("Set Up");
        }
        [Test]
        public void ExecuteText()
        {
          
            // Title
            SeleniumSetMethods.SelectDropDown(driver, "Name", "TitleId", "Mr.");

            // Initial
            SeleniumSetMethods.EnterText(driver, "Id", "Initial", "H.V.A.");

            
            // First Name
            SeleniumSetMethods.EnterText(driver, "XPath", "//*[@id = 'FirstName']", "Vitali");

            // Middle Name
            SeleniumSetMethods.EnterText(driver, "Name", "MiddleName", "Hanich");

            // Get values
            Console.WriteLine($"The value from my Title is: {SeleniumGetMethods.GetText(driver, "Name", "TitleId")}");

            Console.WriteLine($"The value from my Initial is: {SeleniumGetMethods.GetText(driver, "Id", "Initial")}");

            Console.WriteLine($"The value from my First Name is: {SeleniumGetMethods.GetText(driver, "XPath", "//*[@id = 'FirstName']")}");

            Console.WriteLine($"The value from my Middle Name is: {SeleniumGetMethods.GetText(driver, "Name", "MiddleName")}");

            // Click Language check box
            SeleniumSetMethods.ClickElement(driver, "Name", "english");

            // Click Save
            SeleniumSetMethods.ClickElement(driver, "Name", "Save");
    
        }
        [TearDown]
        public void tearDown()
        {
            driver.Close();
            Console.WriteLine("Tear Down");
        }
    }
}