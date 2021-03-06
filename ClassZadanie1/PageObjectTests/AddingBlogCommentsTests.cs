﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PageObjectTests
{
    public class WordpressProblemTest : IDisposable
    {

        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.Open();
            MainPage.OpenFirstNote();
            var comment = new Comment
            {
               Text = Guid.NewGuid().ToString(),
                Mail = "test@test.com",
                User = "Ptasznik99"
            };
            NotePage.AddComment(comment);
            NotePage.AssertCommentText(comment);
            //wejdź na stronę bloga
            //otwórz pierwszą notkę
            //dodaj komenatarz
            //sprawdź czy komentarz się dodał
        }
        public void Dispose()
        {
            Browser.Close();
        }




        [Fact]
        public void NewNote()
        {
           // LoginPage.Open();
            var userlogin = new PostData
            {
                Title = Guid.NewGuid().ToString(),
                Post = "test@test.com"
            };
            LoginPage.GoTo();
            LoginPage.LogIn();
            WPadmin.AddPost(userlogin);
            WPadmin.DeletePost();

        }
        //[Fact]

        //public void Test()

        //{

        //    var driver = new OpenQA.Selenium.Firefox.FirefoxDriver();

        //    driver.Navigate().GoToUrl("https://autotestdotnet.wordpress.com/2017/11/29/hello-world/");



        //    var text = driver.FindElementById("comment");

        //    text.Click();

        //    text.SendKeys("hello");



        //    var mailLabel = driver.FindElementByXPath("//label[@for='email']");

        //    mailLabel.Click();



        //    var mail = driver.FindElementById("email");



        //    //var mail2 = driver.FindElementsById("email").First();



        //    //mail i mail2 dostają takie samo GetHashCode

        //    // jesli usune na stronie elemnt i jeszcze

        //    // raz sprawdze czy istnieje to selenium juz nie

        //    // znajduje tego - wniosek, sprawdza za kazdym razem

        //    // nie cache-uje - zresztą nie ma cachea w źródłach

        //    // jedyny cache w źródłach selenium jest na

        //    // atrybut - któego tutaj nie uzywamy



        //    // wniosek - nieprawidłowe zachowanie strony

        //    // wordpress.com zmienił temat lub coś w bebechach ich word pressa



        //    mail.Click();

        //    mail.SendKeys(Guid.NewGuid() + "@onet.pl");



        //    var name = driver.FindElementById("author");

        //    name.Click();

        //    name.SendKeys("test");



        //    driver.Quit();

        //}



        //[Fact]

        //public void Test2()

        //{

        //    var driver = new OpenQA.Selenium.Chrome.ChromeDriver();

        //    driver.Navigate().GoToUrl("https://autotestdotnet.wordpress.com/2017/11/29/hello-world/");



        //    var text = driver.FindElementById("comment");

        //    text.Click();

        //    text.SendKeys("hello");



        //    var mailLabel = driver.FindElementByCssSelector(".comment-form-email > label");

        //    mailLabel.Click();



        //    Thread.Sleep(4000);

        //    var mail = driver.FindElementById("email");

        //    mail.Click();

        //    mail.SendKeys(Guid.NewGuid() + "@onet.pl");



        //    //var name = driver.FindElementById("author");

        //    //name.Click();

        //    //name.SendKeys("t");

        //    //name.SendKeys("e");

        //    //name.SendKeys("s");

        //    //name.SendKeys("t");



        //    driver.Quit();

        //}
    }
}
