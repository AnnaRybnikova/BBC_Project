using Framework.Pages.BBC;
using Framework.Pages.News;
using Framework.Pages.Sport;
using Framework.Types;

namespace Framework.Business_Logic
{
    public class BL_Commands
    {
        public NewsQuestionsPage GetInTouchBBC(BBC_HomePage homepage)
        {
            return homepage
                .MainMenu
                .GoToNewsPage()
                .NewsMenu
                .MoreBtnClick()
                .HaveYouSayBtnClick()
                .DoYouHaveQuestionsClick();
        }

        public QuestionForm FillQuestionForm(QuestionForm questionForm, QuestionRequest request)
        {
            questionForm.FillInTextField(request.TextInput);

            questionForm.FillInNameField(request.NameInput);

            questionForm.FillInEmailField(request.EmailInput);

            questionForm.FillInAgeField(request.AgeInput);

            questionForm.FillInPostCodeField(request.PostCodeInput);

            return questionForm;
        }

       public ScoresFootballFixtures_ThisMonthResults GoToActualMonthFootballScottishPremResults(BBC_HomePage homepage)
        {
            return homepage
                .MainMenu
                .GoToSportPage()
                .SportMenu
                .FootballTabClick()
                .FootballScores
                .MoreListButtonClick()
                .ScottishPremButtonClick()
                .ViewAllLinkClick()
                .ThisMonthResultsClick();
        }   
    }
}
