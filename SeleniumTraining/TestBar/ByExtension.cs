using OpenQA.Selenium;

namespace TestBar
{
    public class ByExtension
    {
        public static IWebElement ByName(IWebDriver driver, string name)
        {
            return driver.FindElement(By.XPath($"//*[text()='{name}']"));
        } 
    }
}