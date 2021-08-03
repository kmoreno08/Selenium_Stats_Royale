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
      driver.Navigate().GoToUrl("https://www.statsroyale.com");
    }

    [TearDown]
    public void AfterEach()
    {
      driver.Close();
    }

    [Test]
    public void Ice_Spirit_is_on_Cards_page()
    {
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Maximize screen
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // click cards link in header nav
      var cardsPage = new CardsPage(driver);
      // Wait 3 seconds
      Thread.Sleep(3000);
      // Go to cards page and  Get card by name
      var iceSpirit = cardsPage.GoTo().GetCardByName("Ice+Spirit");
      // Maximize screen and 4 second wait time
      driver.Manage().Window.Maximize();
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Test to see if Ice spirit is displayed
      Assert.That(iceSpirit.Displayed);
    }

    [Test]
    public void Ice_Spirit_headers_are_correct_on_Card_Details_page()
    {
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Maximize screen and 4 second wait time
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // Click on Ice Spirit and get card details
      new CardsPage(driver).GoTo().GetCardByName("Ice+Spirit").Click();
      var cardDetails = new CardDetailsPage(driver);
      // Wait for 3 seconds
      Thread.Sleep(3000);
      //Fullscreen and 4 second wait time
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // Call method to split name and rarity in correct forms
      var (category, arena) = cardDetails.GetCardCategory();
      var cardName = cardDetails.Map.CardName.Text;
      var cardRarityCommon = cardDetails.Map.CardRarityCommon.Text;
      // Assert to make sure everything is correct for Ice Spirit
      Assert.AreEqual("Ice Spirit", cardName);
      Assert.AreEqual("Troop", category);
      Assert.AreEqual("Arena 8", arena);
      Assert.AreEqual("Common", cardRarityCommon);
    }

     [Test]
    public void Electro_Giant_is_on_Cards_page()
    {
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Maximize screen
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // click cards link in header nav
      var cardsPage = new CardsPage(driver);
      // Wait 3 seconds
      Thread.Sleep(3000);
      // Go to cards page and  Get card by name
      var electroGiant = cardsPage.GoTo().GetCardByName("Electro+Giant");
      // Maximize screen and 4 second wait time
      driver.Manage().Window.Maximize();
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Test to see if Electro Giant is displayed
      Assert.That(electroGiant.Displayed);
    }

    [Test]
    public void Electro_Giant_headers_are_correct_on_Card_Details_page()
    {

      Thread.Sleep(4000);
      // Maximize screen and 4 second wait time
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // Click on Electro Giant and get card details
      new CardsPage(driver).GoTo().GetCardByName("Electro+Giant").Click();
      var cardDetails = new CardDetailsPage(driver);
      //Fullscreen and 4 second wait time
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // Call method to split name and rarity in correct forms
      var (category, arena) = cardDetails.GetCardCategory();
      var cardName = cardDetails.Map.CardName.Text;
      var cardRarityEpic = cardDetails.Map.CardRarityEpic.Text;
      // Assert to make sure everything is correct for Electro Giant
      Assert.AreEqual("Electro Giant", cardName);
      Assert.AreEqual("Troop", category);
      Assert.AreEqual("Arena 11", arena);
      Assert.AreEqual("Epic", cardRarityEpic);
    }

    [Test]
    public void Mortar_is_on_Cards_page()
    {
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Maximize screen
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // click cards link in header nav
      var cardsPage = new CardsPage(driver);
      // Wait 3 seconds
      Thread.Sleep(3000);
      // Go to cards page and  Get card by name
      var mortar = cardsPage.GoTo().GetCardByName("Mortar");
      // Maximize screen and 4 second wait time
      driver.Manage().Window.Maximize();
      // Wait 4 seconds
      Thread.Sleep(4000);
      // Test to see if Mortar is displayed
      Assert.That(mortar.Displayed);
    }

    [Test]
    public void Mortar_headers_are_correct_on_Card_Details_page()
    {
      Thread.Sleep(4000);
      // Maximize screen and 4 second wait time
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // Click on Mortar and get card details
      new CardsPage(driver).GoTo().GetCardByName("Mortar").Click();
      var cardDetails = new CardDetailsPage(driver);
      //Fullscreen and 4 second wait time
      driver.Manage().Window.Maximize();
      Thread.Sleep(4000);
      // Call method to split name and rarity in correct forms
      var (category, arena) = cardDetails.GetCardCategory();
      var cardName = cardDetails.Map.CardName.Text;
      var cardRarityCommon = cardDetails.Map.CardRarityCommon.Text;
      // Assert to make sure everything is correct for Mortar
      Assert.AreEqual("Mortar", cardName);
      Assert.AreEqual("Building", category);
      Assert.AreEqual("Arena 6", arena);
      Assert.AreEqual("Common", cardRarityCommon);
    }


    [Test]
    public void Bomb_Tower_is_on_Cards_page()
      {
        // Wait 4 seconds
         Thread.Sleep(4000);
         // Maximize screen
         driver.Manage().Window.Maximize();
         Thread.Sleep(4000);
         // click cards link in header nav
         var cardsPage = new CardsPage(driver);
         // Wait 3 seconds
         Thread.Sleep(3000);
         // Go to cards page and  Get card by name
         var bombTower = cardsPage.GoTo().GetCardByName("Bomb+Tower");
         // Maximize screen and 4 second wait time
         driver.Manage().Window.Maximize();
         // Wait 4 seconds
         Thread.Sleep(4000);
         // Test to see if Mortar is displayed
         Assert.That(bombTower.Displayed);
        }

        [Test]
        public void Bomb_Tower_headers_are_correct_on_Card_Details_page()
        {
            Thread.Sleep(4000);
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Click on Mortar and get card details
            new CardsPage(driver).GoTo().GetCardByName("Bomb+Tower").Click();
            var cardDetails = new CardDetailsPage(driver);
            //Fullscreen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Call method to split name and rarity in correct forms
            var (category, arena) = cardDetails.GetCardCategory();
            var cardName = cardDetails.Map.CardName.Text;
            var cardRarityRare = cardDetails.Map.CardRarityRare.Text;
            // Assert to make sure everything is correct for Mortar
            Assert.AreEqual("Bomb Tower", cardName);
            Assert.AreEqual("Building", category);
            Assert.AreEqual("Arena 12", arena);
            Assert.AreEqual("Rare", cardRarityRare);
        }

        [Test]
        public void Rocket_is_on_Cards_page()
        {
            // Wait 4 seconds
            Thread.Sleep(4000);
            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // click cards link in header nav
            var cardsPage = new CardsPage(driver);
            // Wait 3 seconds
            Thread.Sleep(3000);
            // Go to cards page and  Get card by name
            var rocket = cardsPage.GoTo().GetCardByName("Rocket");
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            // Wait 4 seconds
            Thread.Sleep(4000);
            // Test to see if Rocket is displayed
            Assert.That(rocket.Displayed);
        }

        [Test]
        public void Rocket_headers_are_correct_on_Card_Details_page()
        {
            Thread.Sleep(4000);
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Click on Rocket and get card details
            new CardsPage(driver).GoTo().GetCardByName("Rocket").Click();
            var cardDetails = new CardDetailsPage(driver);
            //Fullscreen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Call method to split name and rarity in correct forms
            var (category, arena) = cardDetails.GetCardCategory();
            var cardName = cardDetails.Map.CardName.Text;
            var cardRarityRare = cardDetails.Map.CardRarityRare.Text;
            // Assert to make sure everything is correct for Rocket
            Assert.AreEqual("Rocket", cardName);
            Assert.AreEqual("Spell", category);
            Assert.AreEqual("Arena 6", arena);
            Assert.AreEqual("Rare", cardRarityRare);
        }


        [Test]
        public void Graveyard_is_on_Cards_page()
        {
            // Wait 4 seconds
            Thread.Sleep(4000);
            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // click cards link in header nav
            var cardsPage = new CardsPage(driver);
            // Wait 3 seconds
            Thread.Sleep(3000);
            // Go to cards page and  Get card by name
            var graveyard = cardsPage.GoTo().GetCardByName("Graveyard");
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            // Wait 4 seconds
            Thread.Sleep(4000);
            // Test to see if Graveyard is displayed
            Assert.That(graveyard.Displayed);
        }

        [Test]
        public void Graveyard_headers_are_correct_on_Card_Details_page()
        {
            Thread.Sleep(4000);
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Click on Graveyard and get card details
            new CardsPage(driver).GoTo().GetCardByName("Graveyard").Click();
            var cardDetails = new CardDetailsPage(driver);
            //Fullscreen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Call method to split name and rarity in correct forms
            var (category, arena) = cardDetails.GetCardCategory();
            var cardName = cardDetails.Map.CardName.Text;
            var cardRarityLegendary = cardDetails.Map.CardRarityLegendary.Text;
            // Assert to make sure everything is correct for Graveyard
            Assert.AreEqual("Graveyard", cardName);
            Assert.AreEqual("Spell", category);
            Assert.AreEqual("Arena 12", arena);
            Assert.AreEqual("Legendary", cardRarityLegendary);
        }

         [Test]
        public void Mirror_is_on_Cards_page()
        {
            // Wait 4 seconds
            Thread.Sleep(4000);
            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // click cards link in header nav
            var cardsPage = new CardsPage(driver);
            // Wait 3 seconds
            Thread.Sleep(3000);
            // Go to cards page and  Get card by name
            var mirror = cardsPage.GoTo().GetCardByName("Mirror");
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            // Wait 4 seconds
            Thread.Sleep(4000);
            // Test to see if Mirror is displayed
            Assert.That(mirror.Displayed);
        }

        [Test]
        public void Mirror_headers_are_correct_on_Card_Details_page()
        {
            Thread.Sleep(4000);
            // Maximize screen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Click on Mirror and get card details
            new CardsPage(driver).GoTo().GetCardByName("Mirror").Click();
            var cardDetails = new CardDetailsPage(driver);
            //Fullscreen and 4 second wait time
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            // Call method to split name and rarity in correct forms
            var (category, arena) = cardDetails.GetCardCategory();
            var cardName = cardDetails.Map.CardName.Text;
            //var cardRarityEpic = cardDetails.Map.CardRarityEpic.Text;
            // Assert to make sure everything is correct for Mirror
            Assert.AreEqual("Mirror", cardName);
            Assert.AreEqual("Spell", category);
            Assert.AreEqual("Arena 12", arena);
            //Assert.AreEqual("Epic", cardRarityEpic);
        }
    }
}