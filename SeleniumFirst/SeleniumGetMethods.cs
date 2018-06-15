using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumScripts
{

    class SeleniumGetMethods
    {
        public static IWebDriver driver = PropertiesCollection.driver;

        public static string GetText(PropertyType elementType, string locator)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    return driver.FindElement(By.Id(locator)).GetAttribute("value");
                case (PropertyType.Name):
                    return driver.FindElement(By.Name(locator)).GetAttribute("value");
                case (PropertyType.XPath):
                    return driver.FindElement(By.XPath(locator)).GetAttribute("value");
                default:
                    return String.Empty;
            }
        }

        // Get text from Drop-Down List
        public static string GetTextFromDDL(PropertyType elementType, string locator)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    return new SelectElement(driver.FindElement(By.Id(locator))).AllSelectedOptions.SingleOrDefault().Text;
                case (PropertyType.Name):
                    return new SelectElement(driver.FindElement(By.Name(locator))).AllSelectedOptions.SingleOrDefault().Text;
                case (PropertyType.XPath):
                    return new SelectElement(driver.FindElement(By.XPath(locator))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return String.Empty;
            }
        }
    }
}