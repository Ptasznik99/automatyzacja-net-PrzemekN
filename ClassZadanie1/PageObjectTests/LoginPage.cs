using System;
using System.Linq;

namespace PageObjectTests
{
    internal class LoginPage
    {

        private static string url = "https://autotestdotnet.wordpress.com/wp-admin/";
        private static string user = "autotestdotnet@gmail.com";
        private static string pass = "P@ssw0rd1";

        internal static void GoTo()
        {
            Browser.NavigateTo(url);
        }
        internal static void LogIn()
        {
            var logInField = Browser.FindByXpath("//*[@name='usernameOrEmail']").First();

            logInField.Click();

            logInField.SendKeys(user);

            var passField = Browser.FindByXpath("//*[@name='password']").First();

            passField.Click();

            passField.SendKeys(pass);

            var LogInButon = Browser.FindByXpath("//button[contains(text(),'Log In')]").First();

            LogInButon.Click();
        }

       
    }
}