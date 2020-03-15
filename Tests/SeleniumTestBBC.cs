using System;
using Framework;
using Framework.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestFixture]
    public class SeleniumTestBBC
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = Driver.GetDriver();

            driver.Navigate().GoToUrl("https://www.bbc.com");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
