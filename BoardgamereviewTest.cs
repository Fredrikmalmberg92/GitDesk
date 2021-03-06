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
public class BoardgamereviewTest {
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
  public void boardgamereview() {
    driver.Navigate().GoToUrl("https://boardgamegeek.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Sign In")).Click();
    driver.FindElement(By.Id("inputUsername")).Click();
    driver.FindElement(By.Id("inputUsername")).SendKeys("blabla111");
    driver.FindElement(By.Id("inputPassword")).Click();
    driver.FindElement(By.Id("inputPassword")).SendKeys("thisispassword");
    driver.FindElement(By.Id("inputPassword")).SendKeys(Keys.Enter);
    driver.FindElement(By.Id("1")).Click();
    driver.FindElement(By.Id("1")).SendKeys("pandemic legacy");
    driver.FindElement(By.CssSelector("#ngb-typeahead-0-1 > ngb-highlight")).Click();
    {
      var element = driver.FindElement(By.LinkText("See Full Credits"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".glyphicon:nth-child(16)")).Click();
    driver.FindElement(By.Id("comment")).Click();
    driver.FindElement(By.Id("comment")).SendKeys("good game");
    driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".game-action > .btn-subtle:nth-child(1)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".glyphicon:nth-child(16)")).Click();
    driver.FindElement(By.CssSelector(".rating-stars-clear")).Click();
    driver.FindElement(By.CssSelector(".modal")).Click();
    driver.FindElement(By.CssSelector(".modal-footer > .ng-binding:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
    driver.FindElement(By.CssSelector(".mygeek-dropdown-username")).Click();
    driver.FindElement(By.LinkText("Sign Out")).Click();
  }
}
