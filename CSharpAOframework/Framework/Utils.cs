using OpenQA.Selenium;
using System;

namespace CSharpAOframework.Framework
{
    public static class Utils
    {
        public static void MakeScreenshot(IWebDriver driver, string testName)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();


            var screenshotName = "screenshots\\"
                                    + testName
                                    + DateTime.Now.ToString().Replace(".", "-").Replace(" ", "-").Replace(":", "-")
                                    + ".jpeg";

            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Jpeg);
        }
    }
}
