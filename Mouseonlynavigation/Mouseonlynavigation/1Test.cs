// Generated by Selenium IDE
using System;
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
public class KeyboardTest {
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
  public void Keyboard() {
    driver.Navigate().GoToUrl("https://boardgamegeek.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
     driver.FindElement(By.CssSelector(".global-header-nav-primary > .ng-isolate-scope:nth-child(1) > .btn")).Click();
    driver.FindElement(By.LinkText("All Boardgames")).Click();
    driver.FindElement(By.CssSelector(".global-header-nav-session:nth-child(7) > .btn")).Click();
    driver.FindElement(By.Id("inputUsername")).SendKeys("blabla111");
    driver.FindElement(By.Id("inputPassword")).SendKeys("thisispassword");
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
  }
}