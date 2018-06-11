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
    class SeleniumSetMethods
    {
        //public static object SelectElement { get; private set; }

        //Enter Text
        public static void EnterText(PropertyType elementType, string locator, string text)
        {
            switch (elementType) {
                case (PropertyType.Id):
                    PropertiesCollection.driver.FindElement(By.Id(locator)).SendKeys(text);
                    break;
                case (PropertyType.Name):
                    PropertiesCollection.driver.FindElement(By.Name(locator)).SendKeys(text);
                    break;
                case (PropertyType.XPath):
                    PropertiesCollection.driver.FindElement(By.XPath(locator)).SendKeys(text);
                    break;
            }
        }

        // Click any element
        public static void ClickElement(PropertyType elementType, string locator)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    PropertiesCollection.driver.FindElement(By.Id(locator)).Click();
                    break;
                case (PropertyType.Name):
                    PropertiesCollection.driver.FindElement(By.Name(locator)).Click();
                    break;
                case (PropertyType.XPath):
                    PropertiesCollection.driver.FindElement(By.XPath(locator)).Click();
                    break;
            }
        }

        // Select a drop down control
        public static void SelectDropDown(PropertyType elementType, string locator, string text)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(locator))).SelectByText(text);
                    break;
                case (PropertyType.Name):
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(locator))).SelectByText(text);
                    break;
                case (PropertyType.XPath):
                    new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(locator))).SelectByText(text);
                    break;
            }
        }
    }
}