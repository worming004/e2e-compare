using OpenQA.Selenium;
using Xunit;

namespace TestBar;

public class BarPageTest : IClassFixture<Setup>
{
    private IWebDriver _driver;
    private BarPage _barPage;

    public BarPageTest(Setup setup)
    {
        _driver = setup.Driver;
        _barPage = new BarPage(_driver);
    }

    [Fact]
    public void Test1()
    {
        _driver.Navigate().GoToUrl("https://bar.craftlabit.be");
        var noGluttenButton  = _barPage.GetButton("SANS GLUTEN");
        noGluttenButton.Click();
        
        var token = _barPage.GetToken("orange");
        Assert.Equal("1", token.Text());
        
        var maesButton  = _barPage.GetButton("SANS GLUTEN");
        maesButton.Click();
        Assert.Equal("2", token.Text());
    }
}