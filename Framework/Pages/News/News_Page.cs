using Framework.Pages.BBC;
using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public abstract class News_Page : BBC_Page
    {
        public News_Menu NewsMenu { get; }

        public News_Page(IWebDriver driver) : base(driver)
        {
            NewsMenu = new News_Menu(_driver);
        }
    }
}
