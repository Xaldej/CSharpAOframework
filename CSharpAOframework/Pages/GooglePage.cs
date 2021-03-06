using OpenQA.Selenium;

namespace CSharpAOframework.Pages
{
    public class GooglePage : BasePage
    {
        protected override string Url => "https://google.com";

        private IWebElement SearchInput => _driver.FindElement(By.Name("q"));


        public GooglePage(IWebDriver driver) : base(driver) { }


        public void SearchText(string textToSearch)
        {
            SearchInput.SendKeys(textToSearch);
            SearchInput.SendKeys(Keys.Enter);
        }

        public string GetTextAfterSearch()
        {
            return _driver.FindElement(By.Name("q")).GetAttribute("value");
        }
    }
}
