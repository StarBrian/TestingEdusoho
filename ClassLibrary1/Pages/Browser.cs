﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace ClassLibrary1.Pages
{
    public static class Browser
    {
        static IWebDriver webDriver;
        
        public static void InitDriver()
        {

            webDriver = new FirefoxDriver();

        }

        public static void ScrollTo(IWebElement element)
        {

            Actions actions = new Actions(webDriver);
            actions.MoveToElement(element);
            actions.Perform();

        }
         
        public static string Title
        {

            get { return webDriver.Title; }

        }

        public static ISearchContext Driver
        {

            get { return webDriver; }

        }

        public static IWebDriver Driver2
        {

            get { return webDriver; }

        }

        public static void maxWindow()
        {

            webDriver.Manage().Window.Maximize();

        }

        public static void Goto(string url)
        {

            webDriver.Url = url;

        }
        public static void Close()
        {

            webDriver.Quit();

        }

       

        
    }
}

