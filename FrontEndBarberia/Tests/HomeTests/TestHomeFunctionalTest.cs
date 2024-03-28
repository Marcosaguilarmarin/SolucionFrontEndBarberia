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
public class TestHomeFunctionalTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void testHomeFunctional() {
    driver.Navigate().GoToUrl("http://localhost:5000/Home/Index");
    driver.Manage().Window.Size = new System.Drawing.Size(1907, 1040);
    driver.FindElement(By.LinkText("Servicios")).Click();
    driver.FindElement(By.LinkText("Inicio")).Click();
    driver.FindElement(By.CssSelector(".SecButtom")).Click();
    driver.FindElement(By.LinkText("Inicio")).Click();
    driver.FindElement(By.Id("BackArrow")).Click();
    driver.FindElement(By.Id("BackArrow")).Click();
    driver.FindElement(By.LinkText("Previous")).Click();
    driver.FindElement(By.LinkText("Previous")).Click();
    driver.FindElement(By.Id("ServiciosButtom")).Click();
    driver.SwitchTo().Frame(0);
    {
      var element = driver.FindElement(By.LinkText("Ampliar el mapa"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.SwitchTo().DefaultContent();
    driver.FindElement(By.LinkText("Inicio")).Click();
    driver.SwitchTo().Frame(0);
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector(".gm-style:nth-child(3) > div > div:nth-child(2)")).Click();
    driver.SwitchTo().DefaultContent();
    driver.FindElement(By.CssSelector(".sponsors-width:nth-child(2)")).Click();
    driver.Manage().Window.Size = new System.Drawing.Size(1000, 1040);
    driver.FindElement(By.CssSelector(".fa-solid")).Click();
    driver.FindElement(By.CssSelector(".fa-solid")).Click();
    driver.FindElement(By.CssSelector(".fa-solid")).Click();
  }
}
