using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class ResetPasswordSystem
    {
        [Given(@"I have opened reset password page")]
        public void GivenIHaveOpenedResetPasswordPage()
        {
            Pages.Page.HomePage.Goto();
            Pages.Page.HomePage.ClickLogin();
            Pages.Page.LoginPage.ClickFindPassword();
        }
        
        [When(@"I typed in (.*) and I pressed reset password")]
        public void WhenITypedInAndIPressedResetPassword(string wrongEmail)
        {
            Pages.Page.LoginPage.ResetMyEmail(wrongEmail);
        }
        
        [Then(@"The (.*) should shows up")]
        public void ThenTheShouldShowsUp(string error)
        {
            Pages.Page.LoginPage.CheckEmailAlert(error);
        }
    }
}
