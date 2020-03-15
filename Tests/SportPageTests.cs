using Framework.Business_Logic;
using Framework.Pages.BBC;
using Framework.Pages.Sport;
using NUnit.Framework;
using Tests;

namespace SportPageTests
{
    [TestFixture]
    public class Tests : SeleniumTestBBC
    {
        private readonly BL_Commands _bbcService = new BL_Commands();

        [Test]
        public void MatchResultsCheckTest()
        {
            BBC_HomePage HomePage = new BBC_HomePage(driver);

            _bbcService.GoToActualMonthFootballScottishPremResults(HomePage).TeamNameClick();


            ScoresFootballFixtures_ThisMonthResults ThisMonthResults = new ScoresFootballFixtures_ThisMonthResults(driver);

            SportsFootballMatchPage MatchPage = new SportsFootballMatchPage(driver);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(ThisMonthResults.FirstLeftTeamScore, MatchPage.FirstLeftTeamScore);
                Assert.AreEqual(ThisMonthResults.FirstRightTeamScore, MatchPage.FirstRightTeamScore);
            });


        }
    }
}
