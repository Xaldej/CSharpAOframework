using CSharpAOframework.Framework;
using CSharpAOframework.Framework.TestData;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace CSharpAOframework.Tests
{
    public class BaseTest
    {
        protected PageList _pages { get; private set; }
        protected TestDataManager _testData { get; private set; }

        private IWebDriver Driver;



        [SetUp]
        public virtual void Init()
        {
            Driver = Settings.GetDriver();
            _pages = new PageList(Driver);
            _testData = new TestDataManager();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public virtual void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                try
                {
                    Utils.MakeScreenshot(Driver, TestContext.CurrentContext.Test.MethodName);
                }
                catch
                {
                    //todo: log error
                }
                
            }

            Driver.Quit();
            Driver.Dispose();
        }
    }
}
