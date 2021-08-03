using OpenQA.Selenium;

namespace Royale.Pages
{

  public class CardDetailsPage : PageBase
  {
    public readonly CardDetailsPageMap Map;

    public CardDetailsPage(IWebDriver driver) : base(driver)
    {
      Map = new CardDetailsPageMap(driver);
    }

    //This method splits name and rarity in to separate text 
    public (string Category, string Arena) GetCardCategory()
    {
      var categories = Map.CardCategory.Text.Split(',');
      return (categories[0].Trim(), categories[1].Trim());
    }


  }

  public class CardDetailsPageMap
  {
    IWebDriver _driver;


    public CardDetailsPageMap(IWebDriver driver)
    {
      _driver = driver;
    }
    // Grab cardName by CssSelector using class
    public IWebElement CardName => _driver.FindElement(By.CssSelector("[class*='card__cardName']"));

    // Grab cardCategory by CssSelector using class
    public IWebElement CardCategory => _driver.FindElement(By.CssSelector("[class*='card__rarity']"));

    // Grab cardRarity common by CssSelector using class
    public IWebElement CardRarityCommon => _driver.FindElement(By.CssSelector("[class*='card__common']"));

     // Grab cardRarity epic by CssSelector using class
      public IWebElement CardRarityRare => _driver.FindElement(By.CssSelector("[class*='card__rare']"));


     // Grab cardRarity epic by CssSelector using class
     public IWebElement CardRarityEpic => _driver.FindElement(By.CssSelector("[class*='card__epic']"));

  }









}