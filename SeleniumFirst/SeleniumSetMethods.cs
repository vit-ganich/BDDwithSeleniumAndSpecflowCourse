using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumScripts
{
    
    class SeleniumSetMethods
    {
        public static IWebDriver driver = PropertiesCollection.driver;
        //Enter Text
        public static void EnterText(PropertyType elementType, string locator, string text)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    driver.FindElement(By.Id(locator)).SendKeys(text);
                    break;
                case (PropertyType.Name):
                    driver.FindElement(By.Name(locator)).SendKeys(text);
                    break;
                case (PropertyType.XPath):
                    driver.FindElement(By.XPath(locator)).SendKeys(text);
                    break;
            }
        }

        // Click any element
        public static void ClickElement(PropertyType elementType, string locator)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    driver.FindElement(By.Id(locator)).Click();
                    break;
                case (PropertyType.Name):
                    driver.FindElement(By.Name(locator)).Click();
                    break;
                case (PropertyType.XPath):
                    driver.FindElement(By.XPath(locator)).Click();
                    break;
            }
        }

        // Select a drop down control
        public static void SelectDropDown(PropertyType elementType, string locator, string text)
        {
            switch (elementType)
            {
                case (PropertyType.Id):
                    new SelectElement(driver.FindElement(By.Id(locator))).SelectByText(text);
                    break;
                case (PropertyType.Name):
                    new SelectElement(driver.FindElement(By.Name(locator))).SelectByText(text);
                    break;
                case (PropertyType.XPath):
                    new SelectElement(driver.FindElement(By.XPath(locator))).SelectByText(text);
                    break;
            }
        }
    }
}