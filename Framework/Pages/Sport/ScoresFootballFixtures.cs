using System;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class ScoresFootballFixtures : Sport_Page
    {
        public ScoresFootballFixtures(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement ThisMonthResults => _driver.FindElement(By.XPath("//span[text()='RESULTS']/parent::a"));


        public ScoresFootballFixtures_ThisMonthResults ThisMonthResultsClick()
        {
            ThisMonthResults.Click();

            return new ScoresFootballFixtures_ThisMonthResults(_driver);
        }
    }
}
