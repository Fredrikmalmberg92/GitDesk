/*
 * using NUnit.Framework;
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
            //35:03 PASS!!
            IWebElement inloggKnapp = driver.FindElement(By.XPath("/html/body/gg-app/div/gg-header/header/nav/div/div[1]/div/div[2]/gg-menu-nav-nouser/ul/li[1]/a"));

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

            IWebElement signOut = driver.FindElement(By.XPath("/html/body/gg-app/div/gg-header/header/nav/div/div[1]/div/div[2]/gg-menu-nav-user/ul/li[2]/gg-my-geek/div/div/div/div[2]/a[9]"));

            signOut.Click();

            Assert.That(driver.FindElement(By.LinkText("Sign In")).Text, Is.EqualTo("Sign In"));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            //Inlogg no.2
            //TODO: Få den att inte stanna här
            //IWebElement Refresh = driver.FindElement(By.XPath("/html/body/gg-app/div/gg-header/header/nav/div/gg-menu-logo/div/a/img"));

            //Refresh.Click();
            IWebElement SignInKnapp = driver.FindElement(By.LinkText("Sign In"));

            SignInKnapp.Click();

            IWebElement userNamn = driver.FindElement(By.LinkText("Username"));
            userNamn.Click();

                userNamn.SendKeys("blabla222");


                password.Click();

                password.SendKeys("thisispassword");


                SignIn.Click();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);


                accountMenu.Click();


                signOut.Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            //Inlogg 3

            //Refresh.Click();


            inloggKnapp.Click();


            username.Click();

            username.SendKeys("blabla444");


            password.Click();

            password.SendKeys("thisispassword");


            SignIn.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            accountMenu.Click();


            signOut.Click();

            Assert.That(driver.FindElement(By.LinkText("Sign In")).Text, Is.EqualTo("Sign In"));


            driver.Close();
                driver.Quit();


            }
        }
    }
*/