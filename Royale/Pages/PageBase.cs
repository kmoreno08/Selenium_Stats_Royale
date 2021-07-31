using OpenQA.Selenium;

namespace Royale.Pages
{
  // All page object classes will extend pagebase
  public abstract class PageBase
  {
    public readonly HeaderNav HeaderNav;

    public PageBase(IWebDriver driver)
    {
      HeaderNav = new HeaderNav(driver);
    }
  }
}