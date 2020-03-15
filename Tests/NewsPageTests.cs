using System.Collections.Generic;
using System.Linq;
using Framework.Business_Logic;
using Framework.Pages.BBC;
using Framework.Pages.News;
using Framework.Types;
using NUnit.Framework;
using Tests;

namespace NewsPageTests
{
    [TestFixture]
    public class Tests : SeleniumTestBBC
    {
        private readonly BL_Commands _bbcService = new BL_Commands();

        [Test]
        public void HardCodedMainArticleTest()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            NewsMainPage newsMainPage = HomePage.MainMenu.GoToNewsPage();

            var topNews = newsMainPage.MainArticle;

            string actualTopNews = topNews;

            string expectedTopNews = "Top Iran health official gets virus as fears grow";

            Assert.AreEqual(expectedTopNews, actualTopNews);
        }

        [Test]
        public void HardCodedSecondaryArticlesTest()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            NewsMainPage newsMainPage = HomePage.MainMenu.GoToNewsPage();

            var headers = newsMainPage.SecondaryHeadings;

            List<string> h3List = new List<string>
            {
                "Tenerife hotel locked down over coronavirus",
                "Thirteen killed as mobs clash in Delhi",
                "Clashes erupt over new Greek migrant camps",
                "Plácido Domingo apologises to accusers",
                "China jails Hong Kong bookseller for 10 years"
            };

            bool equals = headers.Count == h3List.Count && !headers.Except(h3List).Any();


            Assert.IsTrue(equals);
        }

        [Test]
        public void SearchWithAreaTest()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            NewsMainPage newsMainPage = HomePage.MainMenu.GoToNewsPage();


            var expectedFirstArticle = "Middle East weather forecast";


            newsMainPage.MainMenu.FillInSearchField(newsMainPage.MainArticleTheme);


            SearchResultPage searchResultPage = newsMainPage.MainMenu.SearchButtonClick();


            var actualFirstArticle = searchResultPage.FirstArticle;


            Assert.AreEqual(expectedFirstArticle, actualFirstArticle);
        }

        [Test]
        public void RequestFormTest_correctinfo()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            var newsQuestionsPage = _bbcService.GetInTouchBBC(HomePage);

            var formRequest = new QuestionRequest
            {
                TextInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc congue sapien non risus consequat luctus. Donec vulputate interdum massa amket.",
                NameInput = "Vasia Pupkin",
                EmailInput = "Vasia.Pupkin@gmail.com",
                AgeInput = "20",
                PostCodeInput = "04567",
            };

            _bbcService.FillQuestionForm(newsQuestionsPage.QuestionAskingForm, formRequest);

            Assert.AreEqual(newsQuestionsPage.NewsQuestionSiteAdress, driver.Url);
        }

        [Test]
        public void RequestFormTest_EmptyName()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            var newsQuestionsPage = _bbcService.GetInTouchBBC(HomePage);

            var formRequest = new QuestionRequest
            {
                TextInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc congue sapien non risus consequat luctus. Donec vulputate interdum massa amket.",
                NameInput = "",
                EmailInput = "Vasia.Pupkin@gmail.com",
                AgeInput = "20",
                PostCodeInput = "04567",
            };

            _bbcService.FillQuestionForm(newsQuestionsPage.QuestionAskingForm, formRequest);

            QuestionForm_submitErrors questionForm_SubmitErrors = newsQuestionsPage.QuestionAskingForm.SubmitButtonClick();


            Assert.IsNotNull(questionForm_SubmitErrors.NameErrorMessage);
        }

        [Test]
        public void RequestFormTest_EmptyEmail()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            var newsQuestionsPage = _bbcService.GetInTouchBBC(HomePage);

            var formRequest = new QuestionRequest
            {
                TextInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc congue sapien non risus consequat luctus. Donec vulputate interdum massa amket.",
                NameInput = "Vasia Pupkin",
                EmailInput = "",
                AgeInput = "20",
                PostCodeInput = "04567",
            };

            _bbcService.FillQuestionForm(newsQuestionsPage.QuestionAskingForm, formRequest);

            QuestionForm_submitErrors questionForm_SubmitErrors = newsQuestionsPage.QuestionAskingForm.SubmitButtonClick();


            Assert.IsNotNull(questionForm_SubmitErrors.EmailErrorMessage);
        }
    }
}