using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Project2.Source.Drivers;
public class Driver
{
    public static IWebDriver _driver;

    [SetUp]
    public void InitScript()
    {
      
        _driver = new ChromeDriver();
    }

    [TearDown]
    public void CleanUp()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver.Dispose();

        }

    }
}
