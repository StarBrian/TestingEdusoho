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
    public class HomePage
    {
        static string Url = "http://lyratesting2.co.nz/";

        //Original home page

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[2]/a")]
        private IWebElement login;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        private IWebElement userIcon;

       

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a")]
        private IWebElement logoutButton;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a")]
        private IWebElement settingButtton;

        //Personal setting > Profile setting

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a")]
        private IWebElement profileSetting;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[3]/div[2]/a/div[2]/label")]
        private IWebElement upLoadingProfileButton;



        [FindsBy(How = How.Id, Using = "upload-avatar-btn")]
        private IWebElement save;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[1]/div[2]/img")]
        private IWebElement uploadedImage;



        [FindsBy(How = How.Name, Using = "file")]
        private IWebElement fileInput;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[3]/a")]
        private IWebElement registerButton;

        //Personal setting > Basic information 

        [FindsBy(How = How.Id, Using = "profile-save-btn")]
        private IWebElement saveButton;



        [FindsBy(How = How.Id, Using = "profile_truename")] 
        private IWebElement nameField;



        [FindsBy(How = How.Id, Using = "profile_idcard")]  
        private IWebElement idField;



        [FindsBy(How = How.Id, Using = "profile_mobile")]  
        private IWebElement phoneNumberField;


     
        [FindsBy(How = How.Id, Using = "profile_title")]
        private IWebElement titleField;



        [FindsBy(How = How.Id, Using = "profile_site")]
        private IWebElement siteField;



        [FindsBy(How = How.Id, Using = "weibo")]
        private IWebElement weiboField;



        [FindsBy(How = How.Id, Using = "profile_qq")]
        private IWebElement qqField;
     


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[6]/a")]
        private IWebElement managingBackGround;


        public void Goto()
        {

            Browser.maxWindow();
            Browser.Goto(Url);

        }

        public void ClickLogin()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[2]/a")));
            login.Click();

        }    

        public bool CheckUserIcon()
        {

            return userIcon.Displayed;

        }

        public void ClickLogOut()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));
            Browser.ScrollTo(userIcon);
            Thread.Sleep(2000);
            logoutButton.Click();

        }

        //Test uploading profile

        public void ClickPersonalSetting()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));
            Browser.ScrollTo(userIcon);
            Thread.Sleep(2000);
            settingButtton.Click();

        }

        public void ClickProfileSetting()
        { 

            profileSetting.Click();
            upLoadingProfileButton.Click();

        }

        public void UploadingProfile()
        {

            fileInput.SendKeys(@"C:\Users\Brian\Desktop\Selenium\spqcflow_nil\img\img1.png");
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("upload-avatar-btn")));
            Thread.Sleep(3000);
            save.Click();

        }

        public bool checkImage()
        {

            Thread.Sleep(3000);
            return uploadedImage.Displayed;

        }

        //Go to sign in page

        public void ClickSignIn()
        {

            registerButton.Click();

        }

        //Test user information page

        public void UpdateUserInformation(PersonalInfo person)
        {

            UpdateName(person.Name);
            UpdateId(person.ID);
            UpdatePhoneNumber(person.Phone);
            UpdateQQ(person.QQ);
            UpdateSite(person.Site);
            UpdateTitle(person.Title);
            UpdateWeibo(person.Weibo);
               
        }

        public void UpdateName(string name)
        {

            if (!string.IsNullOrWhiteSpace(name))
            {
                nameField.Clear();
                nameField.SendKeys(name);

            }

        }

        public void UpdateId(string id)
        {

            if (!string.IsNullOrWhiteSpace(id))
            {
                idField.Clear();
                idField.SendKeys(id);

            }

        }

        public void UpdatePhoneNumber(string phone)
        {

            if (!string.IsNullOrWhiteSpace(phone))
            {
                phoneNumberField.Clear();
                phoneNumberField.SendKeys(phone);

            }

        }

        public void UpdateTitle(string title)
        {

            if (!string.IsNullOrWhiteSpace(title))
            {
                titleField.Clear();
                titleField.SendKeys(title);

            }

        }

        public void UpdateSite(string site)
        {

            if (!string.IsNullOrWhiteSpace(site))
            {
                siteField.Clear();
                siteField.SendKeys(site);

            }

        }

        public void UpdateWeibo(string weibo)
        {

            if (!string.IsNullOrWhiteSpace(weibo))
            {
                weiboField.Clear();
                weiboField.SendKeys(weibo);

            }

        }

        public void UpdateQQ(string qq)
        {

            if (!string.IsNullOrWhiteSpace(qq))
            {
                qqField.Clear();
                qqField.SendKeys(qq);

            }

        }

        public void ClickSaveButton()
        {

            saveButton.Click();

        }

        public void ClickManagingBackGround()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));
            Browser.ScrollTo(userIcon);
            Thread.Sleep(2000);
            managingBackGround.Click();

        }

      

       
    }
}