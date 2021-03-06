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
public class Signin3userstest {
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
  public void inloggIDEVer() {
    driver.Navigate().GoToUrl("https://boardgamegeek.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(2576, 1416);
    driver.FindElement(By.LinkText("Sign In")).Click();
    driver.FindElement(By.Id("inputUsername")).Click();
    driver.FindElement(By.Id("inputUsername")).SendKeys("blabla111");
    driver.FindElement(By.Id("inputPassword")).Click();
    driver.FindElement(By.Id("inputPassword")).SendKeys("thisispassword");
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
    driver.FindElement(By.XPath("/html/body/gg-app/div/gg-header/header/nav/div/div[1]/div/div[2]/gg-menu-nav-user/ul/li[2]/gg-my-geek/div/button")).Click();
    driver.FindElement(By.LinkText("Sign Out")).Click();
    driver.FindElement(By.LinkText("Sign In")).Click();
    driver.FindElement(By.Id("inputUsername")).Click();
    driver.FindElement(By.Id("inputUsername")).SendKeys("blabla222");
    driver.FindElement(By.Id("inputPassword")).SendKeys("thisispassword");
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    driver.FindElement(By.CssSelector(".mygeek-dropdown-username")).Click();
    driver.FindElement(By.LinkText("Sign Out")).Click();
    driver.FindElement(By.LinkText("Sign In")).Click();
    driver.FindElement(By.Id("inputUsername")).Click();
    driver.FindElement(By.Id("inputUsername")).SendKeys("blabla444");
    driver.FindElement(By.Id("inputPassword")).SendKeys("thisispassword");
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    driver.FindElement(By.CssSelector(".mygeek-dropdown-username")).Click();
    driver.FindElement(By.LinkText("Sign Out")).Click();
  }
}
