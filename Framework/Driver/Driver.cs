using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Driver
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
                driver = new ChromeDriver();
            return driver;
        }
    }
}
