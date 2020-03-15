using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class NewsMainPage : News_Page
    {
        public NewsMainPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement MainArticleElement => _driver.FindElement(By.XPath("//div[@data-entityid='container-top-stories#1']//h3"));

        private IWebElement MainArticleThemeElement => _driver.FindElement(By.XPath("//div[@data-entityid='container-top-stories#1']//div[contains(@class,'inline')]/ul//a"));


        public List<string> SecondaryHeadings => _driver.FindElements(By.ClassName("gs-c-promo-heading")).Select(header => header.Text).Where(x => !string.IsNullOrEmpty(x)).Skip(1).Take(5).ToList();

        public string MainArticle => MainArticleElement.Text;

        public string MainArticleTheme => MainArticleThemeElement.Text;
    }
}
