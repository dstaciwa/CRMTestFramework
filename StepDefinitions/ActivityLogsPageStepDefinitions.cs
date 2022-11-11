using System;
using TechTalk.SpecFlow;

namespace CRMTestFramework.StepDefinitions
{
    [Binding]
    public class ActivityLogsPageStepDefinitions
    {
        [When(@"User selects first (.*) items in the table")]
        public void WhenUserSelectsFirstItemsInTheTable(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"User deletes selected items")]
        public void WhenUserDeletesSelectedItems()
        {
            throw new PendingStepException();
        }

        [Then(@"User verifies if selected items were deleted")]
        public void ThenUserVerifiesIfSelectedItemsWereDeleted()
        {
            throw new PendingStepException();
        }
    }
}
