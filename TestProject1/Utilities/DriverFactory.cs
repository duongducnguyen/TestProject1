using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            // Khởi tạo ChromeDriver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }

}