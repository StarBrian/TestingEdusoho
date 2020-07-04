using ClassLibrary1.Models;
using ClassLibrary1.Pages;
using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace ClassLibrary1
{
    [Binding]
    public class PersonalSettingSteps
    {
        

        [Given(@"I opened personal setting")]
        public void GivenIOpenedPersonalSetting()
        {
            Pages.Page.HomePage.ClickPersonalSetting();
        }
        
        [Given(@"I updated my personal information")]
        public void GivenIUpdatedMyPersonalInformation(Table table)
        {
            var info = table.CreateInstance<PersonalInfo>();
            Pages.Page.HomePage.UpdateUserInformation(info);
        }
        
        [When(@"I pressed save button")]
        public void WhenIPressedSaveButton()
        {
            Pages.Page.HomePage.ClickSaveButton();
        }
        
       
        
        [Then(@"The error messages should show up on the page")]
        public void ThenTheErrorMessagesShouldShowUpOnThePage(Table table)
        {
            var errors = table.CreateSet<PersonalInfo>().Select(p => p.error);
            foreach (var err in errors)
            {
                Assert.IsTrue(Browser.Driver2.PageSource.Contains(err));
            }

        }
        
        [Then(@"The (.*) message should show upon the page")]
        public void ThenSuccessfulMessageShouldShowUponThePage(string message)
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(message));
        }
    }
}
