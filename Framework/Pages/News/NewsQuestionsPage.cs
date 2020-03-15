using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class NewsQuestionsPage : News_Page
    {
        public QuestionForm QuestionAskingForm { get; }

        public NewsQuestionsPage(IWebDriver driver) : base(driver)
        {
            QuestionAskingForm = new QuestionForm(_driver);
        }

        public string NewsQuestionSiteAdress = "https://www.bbc.com/news/uk-47933096";

    }
}
