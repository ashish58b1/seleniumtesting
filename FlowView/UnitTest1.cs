﻿namespace FlowView
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.PhantomJS;
    using System;

    [TestClass]
    public class ChucksClass1
    {
        private string baseURL = "https://fv3test.azurewebsites.net/";
        private RemoteWebDriver driver;
        private string browser;
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("FireFox")]

        public void TireSearch_Any()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(this.baseURL);
            driver.FindElementById("userName").SendKeys("flname1");
            driver.FindElementById("userPassword").SendKeys("Temp~1");
           
            //do other Selenium things here!
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}