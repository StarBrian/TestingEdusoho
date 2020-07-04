using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class DataManagementSteps
    {
        [Given(@"I chose the operation option")]
        public void GivenIChoseTheOperationOption()
        {
            Pages.Page.BackGroundManagingPage.ClickOperation();
        }
        
        [Given(@"I selected a (.*) and entered a (.*)")]
        public void GivenISelectedACategoryAndEnteredAEduSoho(string filter,string value)
        {
            Pages.Page.BackGroundManagingPage.UpdateInforBar(filter,value);
        }

        [Given(@"I clicked AddInfor button")]
        public void GivenIClickedAddInforButton()
        {
            Pages.Page.BackGroundManagingPage.ClickAddArticleButton();
        }

        [Given(@"I filled out the article form")]
        public void GivenIFilledOutTheArticleForm(Table table)
        {
            Pages.Page.BackGroundManagingPage.CreateArticle(table.Rows[0][0], table.Rows[0][1], table.Rows[0][2],table.Rows[0][3]);
        }

        [Given(@"I clicked edit button of the top article")]
        public void GivenIClickedEditButtonOfTheTopArticle()
        {
            Pages.Page.BackGroundManagingPage.ClickEditButton();
        }

        [Given(@"I changed category name to (.*)")]
        public void GivenIChangedCategoryNameToTestingEditFunction(string name)
        {
            Pages.Page.BackGroundManagingPage.ChangeCategoryName(name);
        }




        [When(@"I clicked the sreach button")]
        public void WhenIClickedTheSreachButton()
        {
            Pages.Page.BackGroundManagingPage.ClickSearchInforButton();
        }
        
        [When(@"I change the publish status on a info")]
        public void WhenIChangeThePublishStatusOnAInfo()
        {
            Pages.Page.BackGroundManagingPage.UpdatePublishStatus();
        }

        [When(@"I clicked save button")]
        public void WhenIClickedSaveButton()
        {
            Pages.Page.BackGroundManagingPage.SaveArticle();
        }


        [Then(@"I saw the articles contained a (.*)")]
        public void ThenISawTheArticlesContainedAEduSoho(string word)
        {
            Pages.Page.BackGroundManagingPage.CheckUpdatedInfor(word);
        }
        
        [Then(@"I saw the updated publish status was popping up")]
        public void ThenISawTheUpdatedPublishStatusWasPoppingUp()
        {
            Pages.Page.BackGroundManagingPage.CheckPublishStatus();
        }

        [Then(@"the new article (.*) should pop up on information management page")]
        public void ThenTheNewArticleShouldPopUpOnInforationManagementPage(string title)
        {
            Pages.Page.BackGroundManagingPage.CheckArticle(title);
        }

        [Then(@"the article should show the new name (.*)")]
        public void ThenTheArticleShouldShowTheNewNameTestingEditFunction(string title)
        {
            Pages.Page.BackGroundManagingPage.CheckCategoryTitle(title);
        }


    }
}
