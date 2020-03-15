using OpenQA.Selenium;

namespace Framework.Pages.BBC
{
    public class SearchResultPage : BBC_Page
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstArticleElement => _driver.FindElement(By.XPath("//ol[contains(@class,'search')]/li[@data-result-number='1']//h1[@itemprop ='headline']/a"));

        public string FirstArticle => FirstArticleElement.Text;
    }
}
