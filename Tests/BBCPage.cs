using System;
using OpenQA.Selenium;

namespace BBC_Project
{
    public class BBCPage
    {
        protected readonly IWebDriver _driver;

        public BBCPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public NewsMainPage GoToNewsPage()
        {
            _driver.FindElement(By.XPath("//*[@id='orb-nav-links']/ul/li[2]/a")).Click();

            return new NewsMainPage(_driver);
        }

        public IWebElement SearchInput => _driver.FindElement(By.XPath("//*[@id='orb-search-q']"));

        public SearchResultPage SearchButtonClick()
        {
            _driver.FindElement(By.XPath("//*[@id='orb-search-button']")).Click();

            return new SearchResultPage(_driver);
        }
    }
}
