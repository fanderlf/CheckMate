using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckMate.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace CheckMate.Tests.Acceptance
{
    [Binding]
    public class LoginSteps
    {
        private static FirefoxDriver _webDriver;
        private static UserLogin _userLogin;
        
        static LoginSteps()
        {
            _webDriver = new FirefoxDriver();
            _userLogin = new UserLogin(_webDriver);
        }
        [Given(@"I am on page UserLogin")]
        public void GivenIAmOnPageUserLogin()
        {
            _userLogin.Goto();
        }

        [Given(@"I have entered florian into the username")]
        public void GivenIHaveEnteredFlorianIntoTheUsername()
        {
            _userLogin.Username = "florian";
        }

        [Given(@"I have entered 1234 into the password")]
        public void GivenIHaveEntered1234IntoThePassword()
        {
            _userLogin.Password = "1234";
        }

        [When(@"I press the login button")]
        public void WhenIPressTheLoginButton()
        {
            _userLogin.Submit();
        }

        [Then(@"I should be redirected to UserHome")]
        public void ThenIShouldBeRedirectedToUserHome()
        {
            Assert.That(_webDriver.Url.ToLower(),Contains.Substring("user/home"));
        }
    }
}
