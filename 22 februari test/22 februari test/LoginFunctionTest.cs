using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTestProject
{
    [TestClass]
    public class SeleniumTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");
            //35:03 PASS!!
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

            IWebElement signOut = driver.FindElement(By.XPath("/html/body/gg-app/div/gg-header/header/nav/div/div[1]/div/div[2]/gg-menu-nav-user/ul/li[2]/gg-my-geek/div/div/div/div[2]/a[9]"));

            signOut.Click();

            //Assert.AreEqual



            driver.Close();
            driver.Quit();

            // Olika typer av metoder

            /* 

            Exempel:

            (Hitta n�got med hj�lp av LinkText)
            IWebElement utbKnapp = driver.FindElement(By.LinkText("V�ra utbildningar")); // Steg 1 vi pekar ut knappen med l�nktexten "V�ra utbildningar" och ger den namnet utbKnapp
            utbKnapp.Click(); // Steg 2 vi klickar p� knappen som vi gjorde i tidigare steg

            ----OLIKA LOCATORS----

            (Du beh�ver byta namnet "ElementetsNamn")

            IWebElement ElementetsNamn = driver.FindElement(By.ClassName("Class-namnet skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.CssSelector("CSS-selectorn skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.Id("ID:t skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.LinkText("L�nktexten skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.Name("Namnet skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.PartialLinkText("Del av l�nktexten skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.TagName("Taggnamnet skrivs h�r"));
            IWebElement ElementetsNamn = driver.FindElement(By.Xpath(string xpath));

            ----OLIKA KOMMANDON----

            element.Click();

            ----OLIKA ASSERTS----

            EXEMPEL: 
            Assert.AreEqual("1,5 �r", ElementetsNamn.Text); // fr�gar om det st�mmer att texten s�ger 1,5 �r

            */

        }
    }
}