using Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTests
{
    [TestFixture]
    public class LogOutSuccesChrome : BaseTestChromeClass
    {
        [Test]
        public void LogOutSuccesChromeTest()
        {
            LogIn.LogInToSite(Driver, "arnoldovich1910@i.ua", "arnoldovich1910");
            Assert.IsTrue(Driver.HasElement(By.CssSelector("a[title='Orders']")));
            Assert.IsTrue(Driver.HasElement(By.CssSelector("a[title='My wishlists']")));
            Assert.IsTrue(Driver.Url.Contains(Urls.HomePage + "?controller=my-account"));
            Assert.IsTrue(Driver.PageSource.Contains("Welcome to your account."));
            Driver.FindElement(By.ClassName("logout")).Click();
            Assert.IsFalse(Driver.HasElement(By.CssSelector("a[title='Orders']")));
            Assert.IsFalse(Driver.HasElement(By.CssSelector("a[title='My wishlists']")));
            Assert.IsFalse(Driver.Url.Contains(Urls.HomePage + "?controller=my-account"));
            Assert.IsFalse(Driver.PageSource.Contains("Welcome to your account."));
        }
    }
}