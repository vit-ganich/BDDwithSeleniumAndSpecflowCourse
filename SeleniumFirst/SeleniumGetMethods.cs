using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        public static string GetText(PropertyType elementType, string locator)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    return PropertiesCollection.driver.FindElement(By.Id(locator)).GetAttribute("value");
                case (PropertyType.Name):
                    return PropertiesCollection.driver.FindElement(By.Name(locator)).GetAttribute("value");
                case (PropertyType.XPath):
                    return PropertiesCollection.driver.FindElement(By.XPath(locator)).GetAttribute("value");
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
                    return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(locator))).AllSelectedOptions.SingleOrDefault().Text;
                case (PropertyType.Name):
                    return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(locator))).AllSelectedOptions.SingleOrDefault().Text;
                case (PropertyType.XPath):
                    return new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(locator))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return String.Empty;
            }
        }
    }
}