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
        public static string GetText(IWebDriver driver, string findBy, string locator)
        {
            switch (findBy)
            {
                case ("Id"):
                    return driver.FindElement(By.Id(locator)).GetAttribute("value");
                case ("Name"):
                    return driver.FindElement(By.Name(locator)).GetAttribute("value");
                case ("XPath"):
                    return driver.FindElement(By.XPath(locator)).GetAttribute("value");
                default:
                    return String.Empty;
            }
        }

        // Get text from Drop-Down List
        public static string GetTextFromDDL(IWebDriver driver, string findBy, string locator)
        {
            switch (findBy)
            {
                case ("Id"):
                    return new SelectElement(driver.FindElement(By.Id(locator))).AllSelectedOptions.SingleOrDefault().Text;
                case ("Name"):
                    return new SelectElement(driver.FindElement(By.Name(locator))).AllSelectedOptions.SingleOrDefault().Text;
                case ("XPath"):
                    return new SelectElement(driver.FindElement(By.XPath(locator))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return String.Empty;
            }
        }
    }
}