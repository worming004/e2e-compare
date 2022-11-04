using OpenQA.Selenium;
using Xunit;

namespace TestBar;

public class UnitTest1 : IClassFixture<Setup>
{
    private IWebDriver _driver;
    private BarPage _barPage;

    public UnitTest1(Setup setup)
    {
        _driver = setup.Driver;
        _barPage = new BarPage(_driver);
    }

    [Fact]
    public void Test1()
    {
        _driver.Navigate().GoToUrl("https://bar.craftlabit.be");
        var button  = _barPage.GetButton("SANS GLUTEN");
        button.Click();
        
        var token = _barPage.GetToken("orange");
        Assert.Equal("1", token.Text());
    }
}