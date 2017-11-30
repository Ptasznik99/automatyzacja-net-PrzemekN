using OpenQA.Selenium;
using System;
using System.Linq;
using Xunit;

namespace PageObjectTests
{
    internal class NotePage
    {
        internal static void AddComment(Comment testData)
        {
         var commentBox = Browser.FindElementByID("comment");
            commentBox.Click();
            commentBox.SendKeys(testData.Text);

            var emailLabel = Browser.FindByXpath("//label[@for = 'email']");
            emailLabel.First().Click();
            ///email.SendKeys(testData.Mail);
            ///
            var email = Browser.FindElementByID("email");
            email.SendKeys(testData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']").First();
            nameLabel.Click();

            ///Browser.WaitForInvisible(By.XPath("//label[@for='author']"));
           /// Thread.Sleep(2000);

            var name = Browser.FindElementByID("author");
            name.SendKeys(testData.User);

            var submit = Browser.FindElementByID("comment-submit");
            submit.Click();


        }

        //    Assert.Contains("lorem ipsum dolar sit", driver.PageSource);
        public static void AssertCommentText(Comment comment)
        {
            Assert.Contains(comment.Text, Browser.ReturnPageSource());
        }
    }
}