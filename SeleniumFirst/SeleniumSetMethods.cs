using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumScripts
{
    class SeleniumSetMethods
    {
        public static IWebDriver driver = PropertiesCollection.driver;
        //Enter Text
        public static void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        // Click any element
        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        // Select a drop down control
        public static void SelectDropDown(IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }
    }
}