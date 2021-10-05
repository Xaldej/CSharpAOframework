using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpAOframework.Framework
{
    public static class Settings
    {
        public static IWebDriver GetDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments("--incognito");
            return new ChromeDriver(options);
        }
    }
}
