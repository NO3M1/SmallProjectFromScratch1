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
public class LoginPageTests : Driver
{

    [Test]
    public void InvalidLogin()
    {
        //create object of LoginPage
        LoginPage lp = new LoginPage();
        _driver.Navigate().GoToUrl("http://amazon.com");

        lp.LogIn("test@gmail.com","password");
        Assert.True(_driver.Title.Contains("Amazon Sign-In"));

    }


}

