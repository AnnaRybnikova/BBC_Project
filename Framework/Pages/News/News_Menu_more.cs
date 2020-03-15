using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class News_Menu_more : News_Menu
    {
        public News_Menu_more(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement HaveYouSayButton => _driver.FindElement(By.XPath("//li[contains(@class,'display')]/a[contains(@href,'have_your_say')]"));

        public NewsHaveYouSayPage HaveYouSayBtnClick()
        {
            HaveYouSayButton.Click();

            return new NewsHaveYouSayPage(_driver);
        }
    }
}
