using OpenQA.Selenium;

namespace TestProject1.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Web elements
        private IWebElement UsernameField => driver.FindElement(By.Id("Username"));
        private IWebElement PasswordField => driver.FindElement(By.Id("login-password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("btnlogin"));

        // Actions
        public void EnterUsername(string username)
        {
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}