using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using NUnit.Framework;
using ClassLibrary1.Models;
namespace ClassLibrary1.Pages
{
   public class BackGroundManagingPage
    {

        //top bar

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")]
        private IWebElement order;
       
        //orders

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/a[1]")]
        private IWebElement orderForCourse;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/a[2]")]
        private IWebElement orderForClass;

        //buttons

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/button")]
        private IWebElement searchOrderButton;

        //search conditions - order

        [FindsBy(How = How.Id, Using = "startDate")]
        private IWebElement creationTime;



        [FindsBy(How = How.Id, Using = "endDate")]
        private IWebElement endTime;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")]
        private IWebElement paymentStatus;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")]
        private IWebElement paymentWay;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[3]/select")]
        private IWebElement keywordType;

       

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[1]/h1")]
        private IWebElement classOrderText;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/table/tbody")]
        private IWebElement orderList;

        //search info - operation

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[3]/a")]
        private IWebElement operation;

       

        [FindsBy(How = How.XPath, Using = " /html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[2]/span/a")]
        private IWebElement inforTitle;

   

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[1]/div/a/span[1]")]
        private IWebElement category;

       

        [FindsBy(How = How.XPath, Using = " /html/body/div[7]/div/input")]
        private IWebElement categoryInput;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/input")]
        private IWebElement keyword;

      
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[3]/select")]
        private IWebElement property;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[4]/select")]
        private IWebElement status;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/button")]
        private IWebElement searchInforButton;

        

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[2]")]
        private IWebElement dropdownTag;
        


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/ul/li[1]/a")]
        private IWebElement publish;



        static bool publishStatus = false;     



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[6]/span")]
        private IWebElement publishText;

       

        [FindsBy(How = How.XPath, Using = " /html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[1]")]
        private IWebElement editButton;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody")]
        private IWebElement inforList;

     

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[1]/input")]
        private IWebElement inforID;

      // Add new article

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[1]/div/a")]
        private IWebElement addInforButton;

        

        [FindsBy(How = How.Id, Using = "article-title-field")]
        private IWebElement articleTitle;



        [FindsBy(How = How.XPath, Using = "/ html / body / div[2] / div / div[2] / form / div / div[1] / div[2] / div / div[1] / a / span[1]")]
        private IWebElement articleCategory;



        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/input")]
        private IWebElement categoryBar;
       


        [FindsBy(How = How.Id, Using = "s2id_autogen2")]
        private IWebElement articleTag;

       

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div/div[1]/div[4]/div/div[1]/div/div/iframe")]
        private IWebElement article;
        


        [FindsBy(How = How.Id, Using = "article-operate-save")]
        private IWebElement saveArticleButton;

        //Order

        public void ChooseOrderForCourse()
        {
            orderForCourse.Click();
        }

        public void ChooseOrderForClass()
        {
            orderForClass.Click();
        }

        public void ClickSearchButton()
        {
            searchOrderButton.Click();
        }

        public void ClickOrder()
        {
            order.Click();
        }
     
        public void UpdateFilters(string filter,string value )
        {

            IWebElement[] filters = { creationTime, paymentStatus, paymentWay, keywordType };

            foreach (IWebElement filterName in filters)
            {
                if (filterName.GetAttribute("name") == filter)
                {

                    filterName.Click();
                    
                    filterName.SendKeys(value);
                    break;
                }
               
            }

        }

        public IList<IWebElement> GetOrders()
        {
            IList<IWebElement> selectElements = orderList.FindElements(By.TagName("tr"));
            return selectElements;
        }

        public void CheckFilterResults(string result)
        {
               
            int rowcount = GetOrders().Count();
       
            if (rowcount == 1)
            {
                if (GetOrders().ElementAt(0).GetAttribute("style") == "word-break: break-all;word-wrap: break-word;")
                {
                    rowcount = 1;
                }
                else
                {
                    rowcount = 0;
                }
            } 

            string myString = rowcount.ToString(); 
            
            Assert.IsTrue(myString == result);

        }

        public void CheckResultsWithNoFilters()
        {
           
            int rowcount = GetOrders().Count();
          
             if (rowcount == 1)
              {
                  if (GetOrders().ElementAt(0).GetAttribute("style") == "word-break: break-all;word-wrap: break-word;")
                  {
                      rowcount = 1;
                  }
                  else
                  {
                      rowcount = 0;
                  }

              }  
             
            Assert.IsTrue(rowcount>0);

        }



        // Information management

        public void ClickOperation()
        {

            operation.Click();
            Thread.Sleep(2000);
        
        }

        public void ClickSearchInforButton()
        {

            searchInforButton.Click();

        }

        public void UpdateInforBar(string filter,string value)
        {
            
            if (filter == "category")
            {

                category.Click();
                categoryInput.Click();
                categoryInput.SendKeys(value);
                categoryInput.SendKeys(OpenQA.Selenium.Keys.Enter);

            }
            else
            {

                IWebElement[] filters = { category, keyword, property, status };

                foreach (IWebElement filterName in filters)
                {

                    if (filterName.GetAttribute("name") == filter)
                    {

                        filterName.Click();
                        filterName.SendKeys(value);
                        break;

                    }

                }
            }

            Thread.Sleep(2000);
        }

        public IList<IWebElement> GetInforList()
        {

            IList<IWebElement> selectElements = inforList.FindElements(By.TagName("tr"));
            return selectElements;

        }

        //Change publish status


        public void CheckUpdatedInfor(string word)
        {

            bool result = true;

            foreach (var infor in GetInforList())
            {

                if (!infor.Text.Contains(word)) { result = false; }

            }

            Assert.IsTrue(result);

        }

        public void GetOriginalPublishStatus()
        {

            if (publishText.Text == "未发布")
            {

                publishStatus = false;

            }

            else if (publishText.Text == "已发布")
            {

                publishStatus = true;

            }

        }

        public void UpdatePublishStatus()
        {

            GetOriginalPublishStatus();
            dropdownTag.Click();
            publish.Click();
            Thread.Sleep(3000);

        }

        public void CheckPublishStatus()
        {
            
            if (publishStatus)
            {
                Assert.IsTrue(publishText.Text == "未发布");
            }
            else if (!publishStatus)
            {
                Assert.IsTrue(publishText.Text == "已发布");
            }
            
        }


        public void ClickAddInforButton()
        {
            
            addInforButton.Click();

        }

        //Create a new article

        public void ClickAddArticleButton()
        {

            addInforButton.Click();
        }

        public void CreateArticle(string title,string value,string tag,string content)
        {

            articleTitle.Click();
            articleTitle.SendKeys(title);
            articleCategory.Click();
            categoryBar.Click();          
            categoryBar.SendKeys(value);
            Thread.Sleep(2000);
            categoryBar.SendKeys(OpenQA.Selenium.Keys.Enter);
            articleTag.Click();         
            articleTag.SendKeys(tag);
            Thread.Sleep(2000);
            articleTag.SendKeys(OpenQA.Selenium.Keys.Enter);
            article.Click();
            article.SendKeys(content);
            Thread.Sleep(1000);
          
        }

        public void SaveArticle()
        {

            saveArticleButton.Click();

        }

        public void CheckArticle(string title)
        {

            Thread.Sleep(3000);
         
            Assert.IsTrue(inforTitle.Text == title);

        }


        public void ClickEditButton()
        {

            editButton.Click();

        }

        public void ChangeCategoryName(string name)
        {

            articleTitle.Click();
            articleTitle.Clear();
            articleTitle.SendKeys(name);

        }

        public void CheckCategoryTitle(string title)
        {

            Assert.IsTrue(inforTitle.Text == title);

        }

    }
}
