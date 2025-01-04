using NUnit.Framework;
using TestProject1.PageObjects;
using TestProject1.Utilities;

namespace TestProject1.TestCases
{

    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // Khởi tạo LoginPage
            LoginPage loginPage = new LoginPage(driver);

            // Mở trang Login
            driver.Navigate().GoToUrl("https://example.com/login");

            // Thực hiện các hành động
            loginPage.EnterUsername("testuser");
            loginPage.EnterPassword("password123");
            loginPage.ClickLogin();

            // Kiểm tra kết quả
            Assert.AreEqual("Dashboard - Example", loginPage.GetPageTitle());
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            // Khởi tạo LoginPage
            LoginPage loginPage = new LoginPage(driver);

            // Mở trang Login
            driver.Navigate().GoToUrl("https://example.com/login");

            // Thực hiện các hành động
            loginPage.EnterUsername("invaliduser");
            loginPage.EnterPassword("wrongpassword");
            loginPage.ClickLogin();

            // Kiểm tra kết quả
            Assert.AreNotEqual("Dashboard - Example", loginPage.GetPageTitle());
        }
    }

}
