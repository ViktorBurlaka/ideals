using OpenQA.Selenium;

namespace Helpers
{
    public static class WebElement
    {
        public static void ClearSendKeys(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}