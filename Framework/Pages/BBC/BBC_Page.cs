using OpenQA.Selenium;

namespace Framework.Pages.BBC
{
    public abstract class BBC_Page
    {
        protected readonly IWebDriver _driver;

        public BBC_Menu MainMenu { get; }

        public BBC_Page(IWebDriver driver)
        {
            _driver = driver;

            MainMenu = new BBC_Menu(_driver);
        }
    }
}
