using Framework.Pages.BBC;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public abstract class Sport_Page : BBC_Page
    {
        public Sport_Menu SportMenu { get; }

        public Sport_Page(IWebDriver driver) : base(driver)
        {
            SportMenu = new Sport_Menu(_driver);
        }
    }
}
