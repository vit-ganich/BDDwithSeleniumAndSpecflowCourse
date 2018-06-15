using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumScripts
{
    class LoggingPageObject
    {

        public LoggingPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // Login text field
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }
        // Password text field
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }
        // Login button
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string userName, string password)
        {
            txtUserName.SendKeys(userName); // Username
            txtPassword.SendKeys(password); // Password
            btnLogin.Submit(); // Click button
            // Return the page object
            return new EAPageObject();
        }

    }
}
