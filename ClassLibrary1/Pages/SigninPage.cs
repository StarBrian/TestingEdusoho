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
    public class SigninPage
    {

        [FindsBy(How = How.Id, Using = "register_email")]
        private IWebElement emailAddressBar;



        [FindsBy(How = How.Id, Using = "register_nickname")]
        private IWebElement userNameBar;



        [FindsBy(How = How.Id, Using = "register_password")]
        private IWebElement passwordBar;



        [FindsBy(How = How.Id, Using = "captcha_code")]
        private IWebElement verificationCodeBar;



        [FindsBy(How = How.Id, Using = "user_terms")]
        private IWebElement userTermBox;



        [FindsBy(How = How.Id, Using = "register-btn")]
        private IWebElement registerButton;


        public void InputerrorSignInInfo(string invalidUsername, string invalidPassword,string invalidEmail,string wrongVerifiCode) {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email")));          
            emailAddressBar.SendKeys(invalidEmail);
            userNameBar.SendKeys(invalidUsername);
            passwordBar.SendKeys(invalidPassword);
            verificationCodeBar.SendKeys(wrongVerifiCode);

        }

        public void clickSignInButton() {

            registerButton.Click();

        }

        public void CheckAlertMessage( string error) {

            Assert.IsTrue(Browser.Driver2.PageSource.Contains(error));
          
        }
       
    }
}
