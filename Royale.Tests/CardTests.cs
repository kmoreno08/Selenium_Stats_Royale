using System;
using System.IO;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Royale.Pages;

namespace Royale.Tests
{
  public class CardTests
  {
    IWebDriver driver;
    [SetUp]
    public void BeforeEach()
    {
      driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
      // Go to statsroyale.com
      driver.Url = ("https://www.statsroyale.com");



    }

    [TearDown]
    public void AfterEach()
    {
      //driver.Close();
    }

    [Test]
    public void Ice_Spirit_is_on_Cards_page()
    {
      // Maximize screen
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);
      // click cards link in header nav
      var cardsPage = new CardsPage(driver);
      // get card by name
      var iceSpirit = cardsPage.GoTo().GetCardByName("Ice+Spirit");


      // Maximize screen and 4 second wait time
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);

      // Test to see if Ice spirit is displayed
      Assert.That(iceSpirit.Displayed);

    }

    [Test]
    public void Ice_Sprit_headers_are_correct_on_Card_Details_page()
    {

      Thread.Sleep(4000);
      // Maximize screen and 4 second wait time
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);


      // Click on Ice Spirit and get card details
      new CardsPage(driver).GoTo().GetCardByName("Ice+Spirit").Click();
      var cardDetails = new CardDetailsPage(driver);

      //Fullscreen and 4 second wait time
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);

      // Call method to split name and rarity in correct forms
      var (category, arena) = cardDetails.GetCardCategory();
      var cardName = cardDetails.Map.CardName.Text;
      var cardRarity = cardDetails.Map.CardRarity.Text;


      // Assert to make sure everything is correct for Ice Spirit
      Assert.AreEqual("Ice Spirit", cardName);
      Assert.AreEqual("Troop", category);
      Assert.AreEqual("Arena 8", arena);
      Assert.AreEqual("Common", cardRarity);




    }
  }
}