using CRMTestFramework.Base;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CRMTestFramework.StepDefinitions
{
    [Binding]
    public class ReportsPageStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;

        [When(@"User finds (.*) report")]
        public void WhenUserFindsGivenReport(string reportName)
        {
            throw new PendingStepException();
        }

        [Then(@"User runs report")]
        public void ThenUserRunsReport()
        {
            throw new PendingStepException();
        }

        [Then(@"User verifies if some results were returned")]
        public void ThenUserVerifiesIfSomeResultsWereReturned()
        {
            throw new PendingStepException();
        }
    }
}