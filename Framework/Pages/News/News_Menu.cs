using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class News_Menu
    {
        protected readonly IWebDriver _driver;

        public News_Menu(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement MoreButton => _driver.FindElement(By.XPath("//button[contains(@class,'morebutton')]"));

        public News_Menu_more MoreBtnClick()
        {
            MoreButton.Click();

            return new News_Menu_more(_driver);
        }
    }
}
