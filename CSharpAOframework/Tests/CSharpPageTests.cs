using NUnit.Framework;

namespace CSharpAOframework.Tests
{
    public class CSharpPageTests : BaseTest
    {
        [Test]
        public void TestCSharpSearch_TextInput_TextFromInputInResults()
        {
            var textToSearch = "Selenium";

            _pages.CSharp.Open();
            _pages.CSharp.SearchText(textToSearch);
            var result = _pages.CSharp.GetTextAfterSearch();

            Assert.AreEqual(textToSearch, result);
        }
    }
}
