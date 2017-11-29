using System;
using System.Linq;

namespace PageObjectTests
{
    internal class MainPage
    {
        private static string URL = "https://autotestdotnet.wordpress.com/";


        internal static void Open()
        {
            Browser.NavigateTo(URL);
        }

        internal static void OpenFirstNote()
        {
            var element = Browser.FindByXpath("//article/header");
            element.First().Click();
        }
    }
}