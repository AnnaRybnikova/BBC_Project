using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class NewsHaveYouSayPage : News_Page
    {
        public NewsHaveYouSayPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement DoYouHaveQuastionsArcticle => _driver.FindElement(By.XPath("//h3[text()='Do you have a question for BBC News?']/parent::a"));

        public NewsQuestionsPage DoYouHaveQuestionsClick()
        {
            DoYouHaveQuastionsArcticle.Click();

            return new NewsQuestionsPage(_driver);
        }
    }
}
