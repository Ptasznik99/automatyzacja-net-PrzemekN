using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class NewNotes :IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            LoginPage.Open();

            {
                Text = Guid.NewGuid().ToString(),
                Mail = "test@test.com",
                User = "Ptasznik99"
            };
         //   NotePage.AddComment(comment);
         //   NotePage.AssertCommentText(comment);
          
        }
        public void Dispose()
        {
            Browser1.Close();
        }
    }   
}
