using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PageObjectTests
{
    public class AddingBlogCommentsTests  : IDisposable
    {

        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.Open();
            MainPage.OpenFirstNote();
            NotePage.AddComment(new Comment
            {
                Text = "lorem ipsum dolar sit",
                Mail = "test@test.com",
                User = "białko",
            });
            //wejdź na stronę bloga
             //otwórz pierwszą notkę
             //dodaj komenatarz
             //sprawdź czy komentarz się dodał
        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
