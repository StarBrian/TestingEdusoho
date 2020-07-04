using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassLibrary1.Pages
{
    public class Page
    {
        public static HomePage HomePage
        {
            get
            {
                var homepage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homepage);
                return homepage;
            }

        }

        public static LoginPage LoginPage
        {
            get
            {
                var loginpage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginpage);
                return loginpage;
            }

        }

        public static SigninPage SigninPage
        {
            get
            {
                var signinpage = new SigninPage();
                PageFactory.InitElements(Browser.Driver, signinpage);
                return signinpage;
            }

        }


        public static BackGroundManagingPage BackGroundManagingPage
        {
            get
            {
                var backGroundManagingPage = new BackGroundManagingPage();
                PageFactory.InitElements(Browser.Driver, backGroundManagingPage);
                return backGroundManagingPage;
            }

        }

    }
}
