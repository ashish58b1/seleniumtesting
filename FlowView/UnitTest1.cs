namespace FlowView
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.PhantomJS;
    using System;
    using System.Collections.ObjectModel;
    using System.Threading;

    [TestClass]
    public class ChucksClass1
    {
        private string baseURL = "https://login.microsoftonline.com/adswastewater.onmicrosoft.com/oauth2/authorize?response_type=id_token&client_id=6b3c3863-2d40-4328-8bd8-9f65a21980ab&redirect_uri=http%3A%2F%2Fadscoredev.azurewebsites.net%2F&state=9c561a12-80ba-4f45-8b7b-139af09540b6&client-request-id=4bb3f974-cdc7-42a1-a2fe-c542607b5770&x-client-SKU=Js&x-client-Ver=1.0.13&nonce=b7a52095-da3d-4fe7-8e4d-523788e415d0";
        private RemoteWebDriver driver;
        private string browser;
        private string existingWindowHandle;

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

           // driver.FindElement(By.XPath(".//html/body/app-root/md-sidenav-container/div[2]/header/app-topnav/md-toolbar/div/md-toolbar-row/button[2]")).Click();
            //string popupHandle = string.Empty;
          //  ReadOnlyCollection<string> windowHandles = driver.WindowHandles;

          //  foreach (string handle in windowHandles)
          //  {
           //     if (handle != existingWindowHandle)
           //     {
            //        popupHandle = handle; break;
             //   }
           // }

            //switch to new window 
           // driver.SwitchTo().Window(popupHandle);

            driver.FindElement(By.Id("cred_userid_inputtext")).SendKeys("www.ashish06@gmail.com");
            driver.FindElementById("cred_password_inputtext").Click();

            driver.FindElement(By.XPath("//div[@class='has-focus placeholder']")).SendKeys("ashish007");
            driver.FindElement(By.Id("idSIButton9")).Click();
            driver.FindElement(By.XPath(".//html/body/app-root/md-sidenav-container/div[2]/header/app-topnav/md-toolbar/div/md-toolbar-row/button[2]")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
           
           // driver.FindElement(By.Id("menu-toggler")).Click();
            
           // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
           //  driver.FindElement(By.XPath("//span[text()='Dashboard']")).Click();
            driver.FindElement(By.Id("user-dropdown-toggler")).Click();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.FindElement(By.XPath("//div[@id='cdk-overlay-0']/div/div/button[4]")).Click();
          



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