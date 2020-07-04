using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class TestNameSteps
    {
        [Given(@"I have logged in my accout")]
        public void GivenIHaveLoggedInMyAccout(Table table)
        {
            Pages.Page.HomePage.Goto();
            Pages.Page.HomePage.ClickLogin();
            Pages.Page.LoginPage.TypeInUserInfo(table.Rows[0][0], table.Rows[0][1],table.Rows[0][2]);
            Pages.Page.LoginPage.Click();
        }
        
        [When(@"I click logout")]
        public void WhenIClickLogout()
        {
            Pages.Page.HomePage.ClickLogOut();
        }
        
        [Then(@"The page returns to homepage")]
        public void ThenThePageReturnsToHomepage()
        {
            Pages.Page.LoginPage.CheckLogInPage();
        }
    }
}
