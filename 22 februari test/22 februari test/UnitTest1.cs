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
    public class SeleniumTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");

            driver.Close();
            driver.Quit();

            // Olika typer av metoder

            /* 

            Exempel:

            (Hitta n?got med hj?lp av LinkText)
            IWebElement utbKnapp = driver.FindElement(By.LinkText("V?ra utbildningar")); // Steg 1 vi pekar ut knappen med l?nktexten "V?ra utbildningar" och ger den namnet utbKnapp
            utbKnapp.Click(); // Steg 2 vi klickar p? knappen som vi gjorde i tidigare steg

            ----OLIKA LOCATORS----

            (Du beh?ver byta namnet "ElementetsNamn")

            IWebElement ElementetsNamn = driver.FindElement(By.ClassName("Class-namnet skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.CssSelector("CSS-selectorn skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.Id("ID:t skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.LinkText("L?nktexten skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.Name("Namnet skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.PartialLinkText("Del av l?nktexten skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.TagName("Taggnamnet skrivs h?r"));
            IWebElement ElementetsNamn = driver.FindElement(By.Xpath(string xpath));

            ----OLIKA KOMMANDON----

            element.Click();

            ----OLIKA ASSERTS----

            EXEMPEL: 
            Assert.AreEqual("1,5 ?r", ElementetsNamn.Text); // fr?gar om det st?mmer att texten s?ger 1,5 ?r

            */

        }
    }
}