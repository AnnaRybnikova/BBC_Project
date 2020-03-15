using System;
using System.Linq;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class ScoresSection
    {
        protected readonly IWebDriver _driver;

        public ScoresSection(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement MoreListButton => _driver.FindElement(By.XPath("//div[contains(@class, 'gel-1')]//button[contains(@data-reactid, 'football-scores')]/span"));
        public ScoresSection_More MoreListButtonClick()
        {
            MoreListButton.Click();

            return new ScoresSection_More(_driver);
        }
    }
}
