using CRMTestFramework.Base;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CRMTestFramework.StepDefinitions
{
    [Binding]
    public class ContactsPageStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;

        [When(@"User adds new Contact")]
        public void WhenUserAddsNewContact()
        {
            throw new PendingStepException();
        }

        [Then(@"User opens created Contact")]
        public void ThenUserOpensCreatedContact()
        {
            throw new PendingStepException();
        }

        [Then(@"User verifies if its data matches the entered ones")]
        public void ThenUserVerifiesIfItsDataMatchesTheEnteredOnes()
        {
            throw new PendingStepException();
        }
    }
}