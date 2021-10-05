using OpenQA.Selenium;

namespace CSharpAOframework.Pages
{
    public abstract class BasePage
    {
        protected abstract string Url { get; }

        protected readonly IWebDriver _driver;


        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }


        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }
    }
}
