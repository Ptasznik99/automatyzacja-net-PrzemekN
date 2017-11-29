using OpenQA.Selenium;
using System;
using System.Linq;

namespace PageObjectTests
{
    internal class NotePage
    {
        internal static void AddComment(Comment testData)
        {
         var commentBox = Browser.FindElementByID("comment");
            commentBox.Click();
            commentBox.SendKeys(testData.Text);

            var email = Browser.FindElementByID("email");
            email.Click();
            email.SendKeys(testData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']");
            nameLabel.First().Click();

            ///Browser.WaitForInvisible(By.XPath("//label[@for='author']"));
           /// Thread.Sleep(2000);

            var name = Browser.FindElementByID("author");
            name.Click();
            name.SendKeys(testData.User);

            var submit = Browser.FindElementByID("comment-submit");
            submit.Click();
        }
    }
}