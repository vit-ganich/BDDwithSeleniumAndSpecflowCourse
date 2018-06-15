using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumScripts
{
    class SeleniumGetMethods
    {
        public static IWebDriver driver = PropertiesCollection.driver;

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value"); 
        }

        // Get text from Drop-Down List
        public static string GetTextFromDDL(IWebElement element)
        {
             return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}