using System;
using System.IO;
using System.Threading;
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
      //   // Maximize screen
      //   driver.Manage().Window.FullScreen();

      //       System.setProperty("webdriver.chrome.driver",prop.getProperty("driverpath"));
      // ChromeOptions chromeOptions = new ChromeOptions();
      // chromeOptions.addArguments("--start-maximized");
      // IWebDriver driver= new ChromeDriver(chromeOptions);

      //ChromeOptions options = new ChromeOptions();
      //options.addArguments("start-maximized");
      //   ChromeOptions options = new ChromeOptions();
      //     options.addArguments("--start-maximized");
      //         driver = new ChromeDriver( options )
    }

    [TearDown]
    public void AfterEach()
    {
      driver.Close();
    }

    [Test]
    public void Ice_Spirit_is_on_Cards_page()
    {
      Console.Write("Running Ice Spirit on cards page..");
      // Go to statsroyale.com
      driver.Url = ("https://www.statsroyale.com");
      // Maximize screen
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);
      // click cards link in header nav
      driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
      // Maximize screen
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);
      // Assert ice spirit is displayed
      var iceSpirit = driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
      Assert.That(iceSpirit.Displayed);
      Console.Write("Running Ice Spirit on cards page => Finished");
    }

    [Test]
    public void Ice_Sprit_headers_are_correct_on_Card_Details_page()
    {
      // Go to statsroyale.com
      driver.Url = ("https://www.statsroyale.com");
      // Maximize screen
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);
      // click cards link in header nav
      driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
      // Maximize screen
      driver.Manage().Window.FullScreen();
      Thread.Sleep(4000);
      // Go to ice spirit
      var iceSpirit = driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
      iceSpirit.Click();

      Thread.Sleep(4000);
      // Assert basic header stats
      var cardname = driver.FindElement(By.CssSelector("[class*='card__cardName']")).Text;
      // Split both categories
      var cardCategories = driver.FindElement(By.CssSelector(".card__rarity")).Text.Split(", ");
      var cardType = cardCategories[0];
      var cardArena = cardCategories[1];
      var cardRarity = driver.FindElement(By.CssSelector(".card__common")).Text;


      Assert.AreEqual("Ice Spirit", cardname);
      Assert.AreEqual("Troop", cardType);
      Assert.AreEqual("Arena 8", cardArena);
      Assert.AreEqual("Common", cardRarity);

      Console.Write("Running Ice Spirit headers => Finished");


    }
  }
}