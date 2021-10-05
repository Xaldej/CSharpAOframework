using NUnit.Framework;

namespace CSharpAOframework.Tests
{
    public class GooglePageTests : BaseTest
    {
        [Test]
        public void TestGoogleSearch_TextInput_TextFromInputInResults()
        {
            var textToSearch = "Selenium";

            _pages.Google.Open();
            _pages.Google.SearchText(textToSearch);
            var result = _pages.Google.GetTextAfterSearch();

            Assert.AreEqual(textToSearch, result);
        }
    }
}
