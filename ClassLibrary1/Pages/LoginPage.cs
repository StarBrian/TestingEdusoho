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

namespace ClassLibrary1.Pages
{

    public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement usernameBar;



        [FindsBy(How = How.Id, Using = "login_password")]
        private IWebElement passwordBar;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")]
        private IWebElement loginButton;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[1]")]
        private IWebElement alertBar;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[3]/div/input")]
        private IWebElement clickBox;
        


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/span[2]")]
        private IWebElement FindText;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/a[1]")]
        private IWebElement FindMyPassword;

        //reset password

        [FindsBy(How = How.Id, Using = "form_email")]
        private IWebElement emailAddress;



        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")]
        private IWebElement resetPasswordButton;



        [FindsBy(How = How.Id, Using = "alertxx")]
        private IWebElement emailAlert;



        [FindsBy(How = How.Id, Using = "form_email-error")]
        private IWebElement formEmaiError; 



        public void TypeInUserInfo(string username, string password,string rmb)
        {
           
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            usernameBar.SendKeys(username);
            passwordBar.SendKeys(password);
            if (rmb=="true") {
                FindText.Click();
                clickBox.Click();
            }

        }

        public void Click()
        {

            loginButton.Click();

        }

        public bool CheckAlertBar()
        {

            return alertBar.Displayed;
            
        }

        public void ClickFindPassword()
        {

            FindMyPassword.Click();

        }

        public bool CheckLogInPage()
        {

            Thread.Sleep(2000);
            return usernameBar.Displayed;

        }

        public void ResetMyEmail(string email )
        {
            
            emailAddress.SendKeys(email);
            resetPasswordButton.Click();

        }

        public void CheckEmailAlert(string error)
        {

            Assert.IsTrue(Browser.Driver2.PageSource.Contains(error));

        }

    }
}
