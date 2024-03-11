using OpenQA.Selenium;

namespace BugHunterWait
{
    public class Expected
    {
        // Wait until visible
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

        public static Func<IWebDriver, IWebElement> ElementTextIsEqualTo(IWebElement element, string value)
        {
            return delegate (IWebDriver driver)
            {

                try
                {
                    if (element != null && element.Displayed && element.Text.Contains(value))
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

        public static Func<IWebDriver, IWebElement> ElementValueIsEqualTo(IWebElement element, string value)
        {
            return delegate (IWebDriver driver)
            {

                try
                {
                    if (element != null && element.Displayed && element.GetAttribute("value").Contains(value))
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
    }
}
