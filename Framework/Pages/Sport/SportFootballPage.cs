using System;
using OpenQA.Selenium;

namespace Framework.Pages.Sport
{
    public class SportFootballPage : Sport_Page
    {
        public ScoresSection FootballScores { get; }

        public SportFootballPage(IWebDriver driver) : base(driver)
        {
            FootballScores = new ScoresSection(_driver);
        }
    }
      
}