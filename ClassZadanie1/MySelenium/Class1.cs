using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MySelenium
{

    public class Example : IDisposable

    {

        private IWebDriver driver;

        private StringBuilder verificationErrors;

        private string baseURL;

       // private bool AcceptNextAlert = true;



        public Example()

        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
            baseURL = "https://www.google.pl/";

            verificationErrors = new StringBuilder();

        }

        [Fact]

        public void TheExampleTest()

        {
            driver.Navigate().GoToUrl(baseURL);

            driver.FindElement(By.Id("lst-ib")).Clear();

            driver.FindElement(By.Id("lst-ib")).SendKeys("codesprinters");
            driver.FindElement(By.Id("lst-ib")).Submit();

            driver.FindElement(By.LinkText("Code Sprinters -")).Click();

            var element = driver.FindElement(By.LinkText("Poznaj nasze podejście"));

            Assert.NotNull(element);

            var elements = driver.FindElements(By.LinkText("Poznaj nasze podejście"));

            Assert.Single(elements);

            driver.FindElement(By.LinkText("Akceptuję")).Click();

            Thread.Sleep(2000);
            waitForElementPresent(By.LinkText("Poznaj nasze podejście"), 5);

            driver.FindElement(By.LinkText("Poznaj nasze podejście")).Click();


            //ver 1

            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);

            //ver 2

            Assert.Single(driver.FindElements(By.TagName("h2"))
                .Where(tag => tag.Text == "WIEDZA NA PIERWSZYM MIEJSCU"));

        }
            protected void waitForElementPresent(By by, int seconds)

            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

                wait.Until(ExpectedConditions.ElementToBeClickable(by));

            }



            protected void waitForElementPresent(IWebElement by, int seconds)

            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

                wait.Until(ExpectedConditions.ElementToBeClickable(by));

            }
        

        //private bool IsElementPresent(By by)

        //{

        //    try

        //    {

        //        driver.FindElement(by);

        //        return true;

        //    }

        //    catch (NoSuchElementException)

        //    {

        //        return false;

        //    }

        //}



        //private bool IsAlertPresent()

        //{

        //    try

        //    {

        //        driver.SwitchTo().Alert();

        //        return true;

        //    }

        //    catch (NoAlertPresentException)

        //    {

        //        return false;

        //    }

        //}



        //private string CloseAlertAndGetItsText()

        //{

        //    try

        //    {

        //        IAlert alert = driver.SwitchTo().Alert();

        //        string alertText = alert.Text;

        //        if (acceptNextAlert)

        //        {

        //            alert.Accept();

        //        }

        //        else

        //        {

        //            alert.Dismiss();

        //        }

        //        return alertText;

        //    }

        //    finally

        //    {

        //        acceptNextAlert = true;

        //    }

        //}



        public void Dispose()

        {

            try

            {

                driver.Quit();

            }

            catch (Exception)

            {

                // Ignore errors if unable to close the browser

            }

            Assert.Equal("", verificationErrors.ToString());

        }

    }

}