using OpenQA.Selenium;

namespace BugHunterWait
{
    public class Expected
    {
        public static Func<IWebDriver, IWebElement> ElementIsVisible(IWebElement element)
        {
            return delegate (IWebDriver driver)
            {

                try
                {
                    if (element != null && element.Displayed)
                    {
                        return element;
                    }

                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }

        public static Func<IWebDriver, IWebElement> ElementIsInvisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    if (element != null && !element.Displayed)
                    {
                        return element;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }
    }
}
