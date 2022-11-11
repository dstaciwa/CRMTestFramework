using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CRMTestFramework.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;
        private static readonly string url = "https://demo.1crmcloud.com/";

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Navigate().GoToUrl(url);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Quit();
        }
    }
}