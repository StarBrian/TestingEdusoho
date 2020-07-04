using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Specflow
{
    [Binding]
    public class LogInSystemSteps
    {
        [Given(@"I am on Edu Website")]
        public void GivenIAmOnEduWebsite()
        {
            Pages.Page.HomePage.Goto();
        }
        
        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            Pages.Page.HomePage.ClickLogin();
        }

        [Given(@"I login with user")]
        public void GivenILoginWithUser(Table table)
        {
            Pages.Page.LoginPage.TypeInUserInfo(table.Rows[0][0],table.Rows[0][1],table.Rows[0][2]);
        }


      
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            Pages.Page.LoginPage.Click();
        }
        
        [Then(@"the user icon should be shown on the top right corner of the screen")]
        public void ThenTheUserIconShouldBeShownOnTheTopRightCornerOfTheScreen()
        {
            Pages.Page.HomePage.CheckUserIcon();
            Pages.Browser.Close();
         
        }
        
        [Then(@"the alert bar should be shown on the login page")]
        public void ThenTheAlertBarShouldBeShownOnTheLoginPage()
        {
            Pages.Page.LoginPage.CheckAlertBar();
            Pages.Browser.Close();
            
        }
    }
}
