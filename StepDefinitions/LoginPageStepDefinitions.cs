using CRMTestFramework.Base;
using CRMTestFramework.PageObjects;

namespace CRMTestFramework.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions : BaseTest
    {
        readonly LoginPage _loginPage = new LoginPage(driver);

        [Given(@"User is logged in")]
        public void GivenUserIsLoggedIn()
        {
            _loginPage.LogIn(Username, Password);
        }
    }
}