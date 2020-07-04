using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class SpecFlowFeature4Steps
    {
        [Given(@"I have opened sign in page")]
        public void GivenIHaveOpenedSignInPage()
        {
            Pages.Page.HomePage.Goto();
            Pages.Page.HomePage.ClickSignIn();
        }
        
        [Given(@"I register with (.*) and (.*) and (.*) ,typing in (.*)")]
        public void GivenIRegisterWithAndAndTypingIn(string name, string password, string email, string verificationCode)
        {
            Pages.Page.SigninPage.InputerrorSignInInfo(name, password, email, verificationCode);
        }
        
        [When(@"I press signin button")]
        public void WhenIPressSigninButton()
        {
            Pages.Page.SigninPage.clickSignInButton();
        }
        
        [Then(@"the (.*) error alert should shows up")]
        public void ThenTheErrorAlertShouldShowsUp(string error)
        {
            Pages.Page.SigninPage.CheckAlertMessage(error);
         
           
        }
    }
}
