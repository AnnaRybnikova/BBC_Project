using Framework.Pages.News;
using Framework.Pages.Sport;
using OpenQA.Selenium;

namespace Framework.Pages.BBC
{
    public class BBC_Menu
    {
        protected readonly IWebDriver _driver;

        public BBC_Menu(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SearchInput => _driver.FindElement(By.XPath("//*[@id='orb-search-q']"));

        private IWebElement NewsSection => _driver.FindElement(By.XPath("//nav[@role='navigation']//a[text()='News']"));

        private IWebElement SportSection => _driver.FindElement(By.XPath("//nav[@role='navigation']//a[text()='Sport']"));

        private IWebElement SearchButton => _driver.FindElement(By.XPath("//*[@id='orb-search-button']"));


        public void FillInSearchField(string text)
        {
            SearchInput.SendKeys(text);
        }

        public NewsMainPage GoToNewsPage()
        {
            NewsSection.Click();

            return new NewsMainPage(_driver);
        }

        public SportMainPage GoToSportPage()
        {
            SportSection.Click();

            return new SportMainPage(_driver);
        }

        public SearchResultPage SearchButtonClick()
        {
            SearchButton.Click();

            return new SearchResultPage(_driver);
        }
    }
}
