using System;
using TechTalk.SpecFlow;

namespace CRMTestFramework.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions
    {
        [Given(@"User is logged in")]
        public void GivenUserIsLoggedIn()
        {
            throw new PendingStepException();
        }
    }
}
