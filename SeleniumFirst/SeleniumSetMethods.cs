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
        public static object SelectElement { get; private set; }

        //Enter Text
        public static void EnterText(IWebDriver driver, string findBy, string locator, string text)
        {
            switch (findBy) {
                case ("Id"):
                    driver.FindElement(By.Id(locator)).SendKeys(text);
                    break;
                case ("Name"):
                    driver.FindElement(By.Name(locator)).SendKeys(text);
                    break;
                case ("XPath"):
                    driver.FindElement(By.XPath(locator)).SendKeys(text);
                    break;
            }
        }

        // Click any element
        public static void ClickElement(IWebDriver driver, string findBy, string locator)
        {
            switch (findBy)
            {
                case ("Id"):
                    driver.FindElement(By.Id(locator)).Click();
                    break;
                case ("Name"):
                    driver.FindElement(By.Name(locator)).Click();
                    break;
                case ("XPath"):
                    driver.FindElement(By.XPath(locator)).Click();
                    break;
            }
        }

        // Select a drop down control
        public static void SelectDropDown(IWebDriver driver, string findBy, string locator, string text)
        {
            switch (findBy)
            {
                case ("Id"):
                    new SelectElement(driver.FindElement(By.Id(locator))).SelectByText(text);
                    break;
                case ("Name"):
                    new SelectElement(driver.FindElement(By.Name(locator))).SelectByText(text);
                    break;
                case ("XPath"):
                    new SelectElement(driver.FindElement(By.XPath(locator))).SelectByText(text);
                    break;
            }
        }
    }
}
