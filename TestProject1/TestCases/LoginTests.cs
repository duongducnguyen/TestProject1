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
            driver.Navigate().GoToUrl("https://qldaotao.utehy.edu.vn/DangNhap/Login");

            // Thực hiện các hành động
            loginPage.EnterUsername("10121331");
            loginPage.EnterPassword("12345678");
            loginPage.ClickLogin();

            // Kiểm tra kết quả
            Assert.AreEqual("Cổng thông tin sinh viên", loginPage.GetPageTitle());
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            // Khởi tạo LoginPage
            LoginPage loginPage = new LoginPage(driver);

            // Mở trang Login
            driver.Navigate().GoToUrl("https://qldaotao.utehy.edu.vn/DangNhap/Login");

            // Thực hiện các hành động
            loginPage.EnterUsername("10121331");
            loginPage.EnterPassword("12345678");
            loginPage.ClickLogin();

            // Kiểm tra kết quả
            Assert.AreNotEqual("Cổng thông tin sinh viên", loginPage.GetPageTitle());
        }
    }

}
