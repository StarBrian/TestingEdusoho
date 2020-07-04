using ClassLibrary1.Models;
using ClassLibrary1.Pages;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1
{
    [Binding]
    public class BackgroundSystemSteps
    {
        [Given(@"I logged in as an admin")]
        public void GivenILoggedInAsAnAdmin(Table table)
        {
            Pages.Page.HomePage.Goto();
            Pages.Page.HomePage.ClickLogin();
            Pages.Page.LoginPage.TypeInUserInfo(table.Rows[0][0], table.Rows[0][1], table.Rows[0][2]);
            Pages.Page.LoginPage.Click();
        }
        
        [Given(@"I opened the order page\tin the background managing system")]
        public void GivenIOpenedTheOrderPageInTheBackgroundManagingSystem()
        {
            Pages.Page.HomePage.ClickManagingBackGround();
            Thread.Sleep(1000);
            Pages.Page.BackGroundManagingPage.ClickOrder();
        }
        
        [Given(@"I chose the course order option")]
        public void GivenIChoseTheCourseOrderOption()
        {

            Pages.Page.BackGroundManagingPage.ChooseOrderForCourse();
        }
        
        [Given(@"I chose the class order option")]
        public void GivenIChoseTheClassOrderOption()
        {
            Pages.Page.BackGroundManagingPage.ChooseOrderForClass();
        }
        
        [Given(@"I chose a (.*) and inserted a (.*)")]
        public void GivenIChoseDifferentAndInserted(string filter,string value)
        {

            Pages.Page.BackGroundManagingPage.UpdateFilters(filter,value);
            
        }
        
        [When(@"I click the sreach button")]
        public void WhenIClickTheSreachButton()
        {
            Pages.Page.BackGroundManagingPage.ClickSearchButton();
        }
        
        [Then(@"I can see the expected orders")]
        public void ThenICanSeeTheExpectedOrders( )
        {
            Pages.Page.BackGroundManagingPage.CheckResultsWithNoFilters();
        }
        
        [Then(@"I see (.*) orders")]
        public void ThenISeeCourseOrders(string result)
        {
            Pages.Page.BackGroundManagingPage.CheckFilterResults(result);
        }
    }
}
