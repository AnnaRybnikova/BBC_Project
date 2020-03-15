using System;
using System.Linq;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class ScoresSection_More_Match : ScoresSection_More
    {
        public ScoresSection_More_Match(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement ViewAllLink => _driver.FindElements(By.XPath("//span[contains(text(),'View all')]/parent::a[contains(@href,'scores-fixtures')]")).LastOrDefault();

        public ScoresFootballFixtures ViewAllLinkClick()
        {
            ViewAllLink.Click();

            return new ScoresFootballFixtures(_driver);
        }
    }
}
