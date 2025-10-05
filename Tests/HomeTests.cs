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
public class HomeTests : Driver
{

    [Test]
    public void SearchBook()
    {
        HomePage homePage = new HomePage();
        _driver.Navigate().GoToUrl("http://amazon.com");
        homePage.Search("webdriver book");
        Assert.True(_driver.Title.Contains("webdriver book"));

    }

}