using OpenQA.Selenium;
using OrangehmrProject.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangehmrProject.PageObject
{
    class OrangeloginTest
    {
        public OrangeloginTest()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@id='txtUsername']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@id='txtPassword']"));
        IWebElement loginbutt => driver.FindElement(By.XPath("//input[@id='btnLogin']"));
        IWebElement profile => driver.FindElement(By.XPath("//a[@id='welcome']"));

        IWebElement notifiation => driver.FindElement(By.XPath("//span[@id='spanMessage']"));

        public void Navigateurl(String url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(5000);
           
        }
        
        public void EnterUsername(String uname)
        {
            username.SendKeys(uname);
        }

        public void Enterpass(String pword)
        {
            password.SendKeys(pword);
        }


        public void ClickLogin()
        {
            loginbutt.Click();

        }

        public bool CheckLogin()
        {
            return profile.Displayed;
           
        }

        public bool ViewNotification()
        {
            return notifiation.Displayed;
        }

        public void EnterinvalidPass(String pword)
        {
            password.SendKeys(pword);
        }

        public void EnterInvalidUsername(string uname)
        {
            username.SendKeys(uname);
        }

        public void PressEnter()
        {
            loginbutt.SendKeys(Keys.Enter);
        }
    }

}
