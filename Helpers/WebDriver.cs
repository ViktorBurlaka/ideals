using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Helpers
{
    public static class WebDriver
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
        
        public static void MoveTo(this IWebDriver driver, By by)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + driver.FindElement(by).Location.Y + ")");
        }

        
        public static bool HasElement(this IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            
        }
        
    }

 
}