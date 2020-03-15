using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class QuestionForm_submitErrors : QuestionForm
    {
        public QuestionForm_submitErrors(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement TextError => _driver.FindElement(By.XPath("//div[contains(@class,'input-container')]//div[contains(@class,'error')]"));

        private IWebElement NameError => _driver.FindElement(By.XPath("//div[contains(@class,'error')]//div[contains(text(),'Name')]"));

        private IWebElement EmailError => _driver.FindElement(By.XPath("//div[contains(@class,'error')]//div[contains(text(),'Email')]"));

        public string TextErrorMessage => TextError.Text;

        public string NameErrorMessage => NameError.Text;

        public string EmailErrorMessage => EmailError.Text;
    }
}
