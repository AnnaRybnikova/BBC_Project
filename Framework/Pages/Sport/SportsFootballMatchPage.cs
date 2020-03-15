using System.Linq;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class SportsFootballMatchPage : Sport_Page
    {
        public SportsFootballMatchPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstLeftTeamScoreElement => _driver.FindElements(By.XPath("//span[contains(@class,'number')]")).FirstOrDefault();

        private IWebElement FirstRightTeamScoreElement => _driver.FindElements(By.XPath("//span[contains(@class,'number')]")).Skip(1).FirstOrDefault();


        public string FirstLeftTeamScore => FirstLeftTeamScoreElement.Text;

        public string FirstRightTeamScore => FirstRightTeamScoreElement.Text;
    }
}
