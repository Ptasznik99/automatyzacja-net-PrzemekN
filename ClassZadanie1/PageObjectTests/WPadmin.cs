using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PageObjectTests
{
    internal class PostData
    {
        public string Title { get; set; }
        public string Post { get; set; }
    }

    class WPadmin
    {
        internal static void AddPost(PostData data)
        {
            var PostsButton = Browser.FindByXpath("//div[text() = 'Posts']").First();
            PostsButton.Click();
            var AddNewButton = Browser.FindByXpath("//*[@class = 'page-title-action']").First();
            AddNewButton.Click();
            var PostTitleField = Browser.FindElementById("title-prompt-text");
            PostTitleField.Click();
            PostTitleField.SendKeys(data.Title);
            var PostContentField = Browser.FindElementById("content");
            PostContentField.Click();
            PostContentField.SendKeys(data.Post);
            Browser.WaitForElementXpath("//button[text() = 'Edit']");
            Browser.WaitForElementId("publish");
            var PublishButton = Browser.FindElementById("publish");
            PublishButton.Click();

        }

        internal static void DeletePost()
        {
            var DeleteButton = Browser.FindElementById("delete-action");
            Browser.WaitForElementId("delete-action");
            DeleteButton.Click();
        }
    }
}