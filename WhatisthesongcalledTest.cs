// Moment i IDE för att greppa selenium konceptuellt
/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class WhatisthesongcalledTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void whatisthesongcalled() {
    driver.Navigate().GoToUrl("https://www.spotify.com/se/");
    driver.Manage().Window.Size = new System.Drawing.Size(2576, 1416);
    driver.FindElement(By.CssSelector(".ButtonInner-peijbp-0")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    driver.FindElement(By.LinkText("Sök")).Click();
    driver.FindElement(By.CssSelector(".QO9loc33XC50mMRUCIvf")).SendKeys("darude");
    driver.FindElement(By.CssSelector(".\\_gB1lxCfXeR8_Wze5Cx9")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    {
      var element = driver.FindElement(By.CssSelector(".eRuZMo_HNLjb1IalIeRb"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    {
      WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(30));
      wait.Until(driver => driver.FindElement(By.CssSelector(".playback-bar__progress-time-elapsed")).Text == "0:25");
    }
    driver.FindElement(By.CssSelector(".A8NeSZBojOQuVvK4l1pS path")).Click();
  }
}
*/
