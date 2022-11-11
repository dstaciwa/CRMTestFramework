using CRMTestFramework.Base;
using CRMTestFramework.PageObjects.Home;

namespace CRMTestFramework.StepDefinitions
{
    [Binding]
    public class NavigationStepDefinitions : BaseTest
    {
        readonly HomePage _homePage = new HomePage(driver);

        [When(@"User navigates to Activity Log")]
        public void WhenUserNavigatesToActivityLog()
        {
            throw new PendingStepException();
        }

        [When(@"User navigates to Contacts")]
        public void WhenUserNavigatesToContacts()
        {
            throw new PendingStepException();
        }

        [When(@"User navigates to Reports")]
        public void WhenUserNavigatesToReports()
        {
            throw new PendingStepException();
        }
    }
}