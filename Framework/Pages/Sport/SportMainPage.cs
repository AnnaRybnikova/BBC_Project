using System;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class SportMainPage : Sport_Page
    {
        public ScoresSection FootballScores { get; }

        public SportMainPage(IWebDriver driver) : base(driver)
        {
            FootballScores = new ScoresSection(_driver);
        }
    }
}
