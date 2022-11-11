using CRMTestFramework.Base;
using CRMTestFramework.PageObjects.Home;
using OpenQA.Selenium;

namespace CRMTestFramework.PageObjects
{
    public class LoginPage : BaseTest
    {
        new readonly IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By usernameInput = By.Id("login_user");
        private readonly By passwordInput = By.Id("login_pass");

        private readonly By loginButton = By.Id("login_button");

        public HomePage LogIn(string username, string password)
        {
            driver.FindElement(usernameInput).SendKeys(username);
            driver.FindElement(passwordInput).SendKeys(password);

            driver.FindElement(loginButton).Click();

            return new HomePage(driver);
        }
    }
}