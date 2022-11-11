using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CRMTestFramework.Base
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;
        private static readonly string url = "https://demo.1crmcloud.com/";

        private readonly string username = "admin";
        private readonly string password = "admin";

        public string Username { get { return username; } }
        public string Password { get { return password; } }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            var browserOptions = new ChromeOptions();
            browserOptions.AddArguments("incognito", "start-maximized");

            driver = new ChromeDriver(browserOptions);
            driver.Navigate().GoToUrl(url);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Quit();
        }
    }
}