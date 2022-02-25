using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumTest2
    {
        [Test]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");
            
            IWebElement inloggKnapp = driver.FindElement(By.LinkText("Sign In"));

            inloggKnapp.Click();

            IWebElement username = driver.FindElement(By.Id("inputUsername"));

            username.Click();

            username.SendKeys("blabla111");

            IWebElement password = driver.FindElement(By.Id("inputPassword"));

            password.Click();

            password.SendKeys("thisispassword");

            IWebElement SignIn = driver.FindElement(By.XPath("/html/body/ngb-modal-window/div/div/gg-login-modal/gg-login-form/form/fieldset/div[3]/button[1]"));

            SignIn.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement accountMenu = driver.FindElement(By.XPath("/html/body/gg-app/div/gg-header/header/nav/div/div[1]/div/div[2]/gg-menu-nav-user/ul/li[2]/gg-my-geek/div/button/span[2]"));

            accountMenu.Click();

            IWebElement searchBar = driver.FindElement(By.Id("1"));

            searchBar.Click();

            searchBar.SendKeys("Pandemic Legacy Season 1");

            searchBar.SendKeys(Keys.Return);

            IWebElement gameName1 = driver.FindElement(By.XPath("/html/body/div[2]/main/div/div[1]/div[1]/div/div/div[3]/div[3]/table/tbody/tr[2]/td[3]/div[2]/a"));

            gameName1.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Här slutar det funka som jag vill
            IWebElement rating8 = driver.FindElement(By.XPath("/html/body/div[4]/main/div/div[1]/div[1]/div[2]/ng-include/div/ng-include/div/div[2]/div[2]/div[4]/span[1]/div/div/span[1]/span/span/i[8]"));

            rating8.Click();

            rating8.Click();
        }
    }
}