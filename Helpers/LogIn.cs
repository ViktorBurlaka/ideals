using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Helpers
{
    public static class LogIn
    {
        public static void LogInToSite(IWebDriver driver, string login, string pass)
        {
            driver.Navigate().GoToUrl(Urls.HomePage + "?controller=authentication&back=my-account");
            driver.MoveTo(By.ClassName("icon-home"));
            Assert.IsFalse(driver.HasElement(By.CssSelector("a[title='Orders']")));
            Assert.IsFalse(driver.HasElement(By.CssSelector("a[title='My wishlists']")));
            driver.FindElement(By.Id("email")).ClearSendKeys(login);
            driver.FindElement(By.Id("passwd")).ClearSendKeys(pass);
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(1000);
        }
        
    }
}