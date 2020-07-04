using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        [Given(@"I have logged in my account")]
        public void GivenIHaveLoggedInMyAccount(Table table)
        {
            Pages.Page.HomePage.Goto();
            Pages.Page.HomePage.ClickLogin();
            Pages.Page.LoginPage.TypeInUserInfo(table.Rows[0][0], table.Rows[0][1], table.Rows[0][2]);
            Pages.Page.LoginPage.Click();


        }

        [When(@"I click uploadingProfileButton")]
        public void WhenIClickUploadingProfileButton()
        {
            Pages.Page.HomePage.ClickPersonalSetting();
            Pages.Page.HomePage.ClickProfileSetting();
            Pages.Page.HomePage.UploadingProfile();
        }
        
        [Then(@"The new photo is uploaded")]
        public void ThenTheNewPhotoIsUploaded()
        {
            Pages.Page.HomePage.checkImage();
        }
    }
}
