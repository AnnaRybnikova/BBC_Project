using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class Sport_Menu
    {
        protected readonly IWebDriver _driver;

        public Sport_Menu(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement FootballTab => _driver.FindElement(By.XPath("//a[text()='Football' and @role='menuitem']"));

        public SportFootballPage FootballTabClick()
        {
            FootballTab.Click();

            return new SportFootballPage(_driver);
        }
    }
}