using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestBar
{
    public class Setup : IDisposable
    {
        public IWebDriver Driver;

        public Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}