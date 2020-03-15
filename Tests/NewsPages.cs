using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace BBC_Project
{   
    public class SearchResultPage : BBCPage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstArticle => _driver.FindElement(By.XPath("/html/body/div[6]/section[2]/ol[1]/li/article/div/h1/a"));
    }

    public class NewsMainPage : BBCPage
    {
        public NewsMainPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MainArticle => _driver.FindElement(By.XPath("//div[@data-entityid='container-top-stories#1']/div[1]//h3"));

        public List<string> SecondaryHeadings => _driver.FindElements(By.ClassName("gs-c-promo-heading")).Select(header => header.Text).Where(x => !string.IsNullOrEmpty(x)).Skip(1).Take(5).ToList();

        public IWebElement MainArticleTheme => _driver.FindElement(By.XPath("/html/body/div[6]/div/div[4]/div[2]/div/div/div/div/div[1]/div/div/div[1]/ul/li[2]/a/span"));


        public NewsMorePage MoreBtnClick()
        {
            _driver.FindElement(By.XPath("//button[contains(@class,'morebutton')]")).Click();

            return new NewsMorePage(_driver);
        }
    }

    public class NewsMorePage : NewsMainPage
    {
        public NewsMorePage(IWebDriver driver) : base(driver)
        {
        }

        public NewsHaveYouSayPage HaveYouSayBtnClick()
        {
            _driver.FindElement(By.XPath("//li[contains(@class,'display')]/a[contains(@href,'have_your_say')]")).Click();

            return new NewsHaveYouSayPage(_driver);
        }
    }

    public class NewsHaveYouSayPage : BBCPage
    {
        public NewsHaveYouSayPage(IWebDriver driver) : base(driver)
        {
        }

        public NewsQuestionsPage DoYouHaveQuestionsClick()
        {
            _driver.FindElement(By.XPath("//h3[text()='Do you have a question for BBC News?']/parent::a")).Click();

            return new NewsQuestionsPage(_driver);
        }
    }

    public class NewsQuestionsPage : BBCPage
    {
        public NewsQuestionsPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement TextInput => _driver.FindElement(By.XPath("//textarea[contains(@class,'text-input--long')]"));

        public IWebElement NameInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Name')]"));

        public IWebElement EmailInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Email')]"));

        public IWebElement AgeInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Age')]"));

        public IWebElement PostCodeInput => _driver.FindElement(By.XPath("//input[contains(@aria-label,'Post')]"));

        public NewsSubmitErrorsPage SubmitButtonClick()
        {
            _driver.FindElement(By.XPath("//button[@class='button' and text()='Submit']")).Click();

            return new NewsSubmitErrorsPage(_driver);
        } 
    }

    public class NewsSubmitErrorsPage : NewsQuestionsPage
    {
        public NewsSubmitErrorsPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement TextErrorMessage => _driver.FindElement(By.XPath("//*[@id='hearken-embed-module-3215-1e1f7']/div[1]/div[1]/div[2]"));

        public IWebElement NameErrorMessage => _driver.FindElement(By.XPath("//div[contains(@class,'error')]//div[contains(text(),'Name')]"));

        public IWebElement EmailErrorMessage => _driver.FindElement(By.XPath("//div[contains(@class,'error')]//div[contains(text(),'Email')]"));
    }
}
