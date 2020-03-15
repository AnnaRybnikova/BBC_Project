using System.Linq;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class ScoresSection_More : ScoresSection
    {
        public ScoresSection_More(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement ScottishPremButton => _driver.FindElements(By.XPath("//h2[text()='Football Scores']/parent::div//ul[@role='menu' and @data-istats-container='competitionfilter-dropdown']/li/button[text()='Scottish Prem' and @role='menuitem']")).LastOrDefault();

        public ScoresSection_More_Match ScottishPremButtonClick()
        {
            ScottishPremButton.Click();

            return new ScoresSection_More_Match(_driver);
        }
    }
}
