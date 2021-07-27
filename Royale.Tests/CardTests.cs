using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Royale.Tests
{
  public class CardTests
  {
    IWebDriver driver;
    [SetUp]
    public void BeforeEach()
    {
      driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
    }

    [TearDown]
    public void AfterEach()
    {

    }

    [Test]
    public void Ice_Sprit_is_on_Cards_page()
    {
      // Go to statsroyale.com
      driver.Url = ("https://www.statsroyale.com");
      // click cards link in header nav
      driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
      // Assert ice spirit is displayed
      var iceSpirit = driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
      Assert.That(iceSpirit.Displayed);
    }

    [Test]
    public void Ice_Sprit_headers_are_correct_on_Card_Details_page()
    {
      // Go to statsroyale.com
      driver.Url = ("https://www.statsroyale.com");
      // click cards link in header nav
      driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
      // Go to ice spirit
      var iceSpirit = driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
      // Assert basic header stats
      var cardname = driver.FindElement(By.CssSelector("[class*='cardName']")).Text;
      // Split both categories
      var cardCategories = driver.FindElement(By.CssSelector(".card__rarity")).Text.Split(", ");
      var cardType = cardCategories[0];
      var cardArena = cardCategories[1];
      var cardRarity = driver.FindElement(By.CssSelector(".card__common")).Text;

      Assert.AreEqual("Ice Spirit", cardname);
      Assert.AreEqual("Troop", cardType);
      Assert.AreEqual("Arena 8", cardArena);
      Assert.AreEqual("common", cardRarity);


    }
  }
}