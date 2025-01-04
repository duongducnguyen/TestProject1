using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.Utilities
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // Khởi tạo WebDriver
            driver = DriverFactory.GetDriver();
        }

        [TearDown]
        public void TearDown()
        {
            // Đóng trình duyệt
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}