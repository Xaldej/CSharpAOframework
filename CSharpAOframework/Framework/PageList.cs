using CSharpAOframework.Pages;
using OpenQA.Selenium;

namespace CSharpAOframework.Framework
{
    public class PageList
    {
        public GooglePage Google => _google ??= new GooglePage(_driver);
        private GooglePage _google;

        public CSharpPage CSharp => _cSharp ??= new CSharpPage(_driver);
        private CSharpPage _cSharp;


        private readonly IWebDriver _driver;


        public PageList(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
