using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSharpAOframework.Pages
{
    public class CSharpPage : BasePage
    {
        protected override string Url => "https://docs.microsoft.com/en-us/dotnet/csharp/";

        private IWebElement SearchInput => _searchInput ??= _driver.FindElement(By.XPath("//*[@class='nav-bar-search']//input[@name='terms']"));
        private IWebElement _searchInput;


        public CSharpPage(IWebDriver driver) : base(driver) { }

        public void SearchText(string textToSearch)
        {
            SearchInput.SendKeys(textToSearch);
            SearchInput.SendKeys(Keys.Enter);
        }

        public string GetTextAfterSearch()
        {
            var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("facet-search-input")));

            return _driver.FindElement(By.Id("facet-search-input")).GetAttribute("value");
        }
    }
}
