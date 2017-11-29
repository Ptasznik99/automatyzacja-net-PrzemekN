using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;

namespace PageObjectTests
{
    internal class Browser
    {
        private static IWebDriver driver;

        internal static IWebElement FindElementByID(string comment)
        {
            return driver.FindElement(By.Id(comment));
        }

        static Browser()
           {
             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromMilliseconds(500);
            }

        internal static void WaitForInvisible(By by)
        {
            throw new NotImplementedException();
        }

        //internal static void WaitForInvisible(ReadOnlyCollection<IWebElement> nameLabel)
        //{
        //    throw new NotImplementedException();
        //}

        internal static object FindElementXpath(string v)
        {
            throw new NotImplementedException();
        }

        internal static ReadOnlyCollection<IWebElement> FindByXpath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }

        internal static void NavigateTo(string URL)
        {
            driver.Navigate().GoToUrl(URL);
        }

        internal static void Close()
        {
            driver.Close();
        }
    }
}