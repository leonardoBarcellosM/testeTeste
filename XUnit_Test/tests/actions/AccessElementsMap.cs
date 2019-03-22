using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace XUnit_Test.tests.steps
{
    class AccessElementsMap
    {
        [FindsBy(How = How.XPath, Using = "//div//a[@class='logo']")]
        [CacheLookup]
        public IWebElement Logo { get; set; }
    }
}
