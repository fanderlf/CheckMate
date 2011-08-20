using OpenQA.Selenium;

namespace CheckMate.Tests.Pages
{
    public class UserLogin
    {
        private readonly IWebDriver _webDriver;

        public UserLogin(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string Username
        {
            get { return _webDriver.FindElement(By.Id("username")).Text; }
            set { _webDriver.FindElement(By.Id("username")).SendKeys(value); }
        }

        public string Password
        {
            get { return _webDriver.FindElement(By.Id("password")).Text; }
            set { _webDriver.FindElement(By.Id("password")).SendKeys(value); }
        }

        public void Submit()
        {
            _webDriver.FindElement(By.Id("login")).Click();
        }

        public void Goto()
        {
            _webDriver.Navigate().GoToUrl("http://www.checkmate.de/User/Login");
        }
    }
}