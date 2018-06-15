using OpenQA.Selenium;


namespace SeleniumScripts
{
    enum PropertyType
    {
        Id,
        Name,
        Text,
        CssSelector,
        ClassName,
        XPath
    }
    class PropertiesCollection
    {
        //Auto-implemented property
        public static IWebDriver driver { get; set; }

        public static string startpage = "http://www.executeautomation.com/demosite/index.html";
    }
}