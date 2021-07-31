using System;
using OpenQA.Selenium;

namespace Royale.Pages
{
  public class HeaderNav
  {
    public readonly HeaderNavMap Map;

    // Constructor passing driver
    public HeaderNav(IWebDriver driver)
    {
      Map = new HeaderNavMap(driver);
    }

    // Method that clicks 'Cards' link in header 
    public void GoToCardsPage()
    {
      Map.CardsTabLink.Click();
    }
  }



  public class HeaderNavMap
  {
    IWebDriver _driver;

    public HeaderNavMap(IWebDriver driver)
    {
      _driver = driver;
    }

    // Get cardsTabLink by CssSelector using 'a' tag and href
    public IWebElement CardsTabLink => _driver.FindElement(By.CssSelector("a[href='/cards']"));

  }
}
