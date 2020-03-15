using OpenQA.Selenium;

namespace Framework.Pages.News
{
    public class QuestionForm
    {
        protected readonly IWebDriver _driver;

        public QuestionForm(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement TextInput => _driver.FindElement(By.XPath("//textarea[contains(@class,'text-input--long')]"));

        private IWebElement NameInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Name')]"));

        private IWebElement EmailInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Email')]"));

        private IWebElement AgeInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Age')]"));

        private IWebElement PostCodeInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Post')]"));

        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@class='button' and text()='Submit']"));


        public void FillInTextField(string text)
        {
            TextInput.SendKeys(text);
        }

        public void FillInNameField(string name)
        {
            NameInput.SendKeys(name);
        }

        public void FillInEmailField(string email)
        {
            EmailInput.SendKeys(email);
        }

        public void FillInAgeField(string age)
        {
            AgeInput.SendKeys(age);
        }

        public void FillInPostCodeField(string code)
        {
            PostCodeInput.SendKeys(code);
        }


        public QuestionForm_submitErrors SubmitButtonClick()
        {
            SubmitButton.Click();

            return new QuestionForm_submitErrors(_driver);
        }
    }
}
