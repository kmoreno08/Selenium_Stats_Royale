using OpenQA.Selenium;

namespace Royale.Pages
{
  public class CardsPage : PageBase
  {
    public readonly CardsPageMap Map;

    // Constructor passing driver
    public CardsPage(IWebDriver driver) : base(driver)
    {
      Map = new CardsPageMap(driver);
    }


    public CardsPage GoTo()
    {
      HeaderNav.GoToCardsPage();
      return this;
    }

    /* If card name has just one name then it does not need to be replaced with a '+'. If it has more then one name then it does need to be replaced. 
    For example 'ice spirit' will be changed to 'ice+spirit' to find the correct Card name element
    */
    public IWebElement GetCardByName(string cardName)
    {
      if (cardName.Contains(" "))
      {
        cardName.Replace(" ", "+");
      }

      return Map.Card(cardName);
    }

  }

  public class CardsPageMap
  {
    IWebDriver _driver;

    // Constructor passing driver
    public CardsPageMap(IWebDriver driver)
    {
      _driver = driver;
    }


    // Find card name by CssSelector with 'a' tag and 'href'
    public IWebElement Card(string name) => _driver.FindElement(By.CssSelector($"a[href*='{name}']"));
  }
}