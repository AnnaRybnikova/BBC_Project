using System.Linq;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class ScoresFootballFixtures_ThisMonthResults : ScoresFootballFixtures
    {
        public ScoresFootballFixtures_ThisMonthResults(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstLeftTeamName => _driver.FindElements(By.XPath("//a[@data-istats-container='match_link']//span/span/span/span")).FirstOrDefault();

        private IWebElement FirstLeftTeamScoreElement => _driver.FindElements(By.XPath("//a[@data-istats-container='match_link']//span/span/span[contains(@class,'number')]")).FirstOrDefault();

        private IWebElement FirstRightTeamScoreElement => _driver.FindElements(By.XPath("//a[@data-istats-container='match_link']//span/span/span[contains(@class,'number')]")).Skip(1).FirstOrDefault();


        public string FirstLeftTeamScore => FirstLeftTeamScoreElement.Text;

        public string FirstRightTeamScore => FirstRightTeamScoreElement.Text;


        public SportsFootballMatchPage TeamNameClick()
        {
           // WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
           // wait.Until(ExpectedConditions.ElementVisible(FirstLeftTeamName));
            FirstLeftTeamName.Click();

            return new SportsFootballMatchPage(_driver);
        }
    }
}
