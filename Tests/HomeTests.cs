using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project2.Source.Drivers;
using Project2.Source.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Project2.Tests;
[Parallelizable(ParallelScope.All)] // enables parallel execution of tests in this class
public class HomeTests : Driver
{

    [Test]
    public void SearchBook()
    {
        HomePage homePage = new HomePage();
        _driver.Navigate().GoToUrl("http://amazon.com");
        homePage._continueShopping.Click();
        homePage.Search("webdriver book");
        Assert.True(_driver.Title.Contains("webdriver book"));

    }

    [Test]
    public void SearchPhone()
    {
        HomePage homePage = new HomePage();
        _driver.Navigate().GoToUrl("http://amazon.com");
        homePage._continueShopping.Click();
        homePage.Search("iphone 12");
        Assert.True(_driver.Title.Contains("iphone 12"));

    }

    [Test]
    public void SearchWatch()
    {
        HomePage homePage = new HomePage();
        _driver.Navigate().GoToUrl("http://amazon.com");
        homePage._continueShopping.Click();
        homePage.Search("apple watch");
        Assert.True(_driver.Title.Contains("apple watch"));

    }

}