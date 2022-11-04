using OpenQA.Selenium;

namespace TestBar
{
    public class BarPage
    {
        private IWebDriver _driver;

        public BarPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement GetButton(string textContains)
        {
            return ByExtension.ByName(_driver,textContains);
        } 

        public Token GetToken(string color)
        {
            var element = _driver.FindElement(
                By.XPath($"//div[contains(@class, 'rounded-full') and contains(@style, 'background-color: {color}')]"));
            return new Token(element);
        }

        public class Token
        {
            private IWebElement _element;

            public Token(IWebElement element)
            {
                _element = element;
            }

            public string Text()
            {
                return _element.FindElements(By.XPath(".//span"))[0].Text;
            }
        }
    }
}