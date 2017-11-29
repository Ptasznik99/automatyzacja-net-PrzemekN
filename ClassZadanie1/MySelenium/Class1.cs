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
        private const string SearchTextBox = "lst-ib";
        private const string Google = "https://www.google.com";
        private const string TextToSearch = "Code Sprinters";
        private const string PageTitle = "Code Sprinters -";
        private const string LinkTextToFind = "Poznaj nasze podejście";
        private const string AkceptCookies = "Akceptuję";
        
        private StringBuilder verificationErrors;
        private IWebDriver driver;

        private string baseURL;

        public string BaseURL { get => baseURL; set => baseURL = value; }

        // private bool AcceptNextAlert = true;

        public Example()

        {
            driver = new ChromeDriver();
            BaseURL = "https://www.google.pl/";
            verificationErrors = new StringBuilder();
        }

        [Fact]

        public void TheExampleTest()

        {
            GoToGoogle();
            Search(TextToSearch);
            //driver.findelement(by.id(searchtextbox)).clear();
            //driver.findelement(by.id(searchtextbox)).sendkeys("codesprinters");
            //driver.findelement(by.id(searchtextbox)).submit();
            ClickSearchResultByPageTitle(PageTitle);
            ClickSearchResultCookies(AkceptCookies);

            //var element = driver.FindElement(By.LinkText("Poznaj nasze podejście"));
            //Assert.NotNull(element);

            // var elements = GetElements(LinkTextToFind);
            Assert.Single(GetElements(LinkTextToFind));
            
            //Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));
            wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText("Akceptuję"), "Akceptuję"));

            waitForElementPresent(By.LinkText("Poznaj nasze podejście"), 11);

            driver.FindElement(By.LinkText("Poznaj nasze podejście")).Click();


            //ver 1
            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);

            //ver 2
            Assert.Single(driver.FindElements(By.TagName("h2"))
                .Where(tag => tag.Text == "WIEDZA NA PIERWSZYM MIEJSCU"));

        }

        private void  ClickSearchResultCookies (String Cookies )
        {
            driver.FindElement(By.LinkText(Cookies)).Click();
        }

        private IReadOnlyCollection<IWebElement> GetElements(String LinkTextToFind)
        {
            return driver.FindElements(By.LinkText("Poznaj nasze podejście"));
        }

        private void Search(string query)
        {
            var searchBbox = GetSearchBbox();
            searchBbox.Clear();
            searchBbox.SendKeys(query);
            searchBbox.Submit();
        }

        private void ClickSearchResultByPageTitle(string title)
        {
            driver.FindElement(By.LinkText(title)).Click();
        }

        private void GoToGoogle()
        {
            driver.Navigate().GoToUrl(BaseURL);
        }

        private IWebElement GetSearchBbox()
        {
            return driver.FindElement(By.Id(SearchTextBox));
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