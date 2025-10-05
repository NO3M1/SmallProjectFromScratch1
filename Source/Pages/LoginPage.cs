using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Project2.Source.Drivers;
using SeleniumExtras.PageObjects;

namespace Project2.Source.Pages;
public class LoginPage : Driver
{
    //object of WebDriver
    IWebDriver _webDriver;

    [FindsBy(How = How.Id, Using = "ap_email_login")]
    private IWebElement _emailText;

    [FindsBy(How = How.ClassName, Using = "a-button-input")]
    private IWebElement _continueButton;

    [FindsBy(How = How.Id, Using = "ap_password")]
    private IWebElement _passwordText;

    [FindsBy(How = How.Id, Using = "signInSubmit")]
    private IWebElement _signInButton;


    [FindsBy(How = How.CssSelector, Using = ".a-button.a-button-primary.a-span12")]
    private IWebElement _continueShoppingButton;
   


    //constructor
    public LoginPage()
    {
        PageFactory.InitElements(_driver, this);
    }

    //LogIn method
    public void LogIn(string user, string password)
    {
        HomePage hP = new HomePage();
        _continueShoppingButton.Click();
        hP._signInLink.Click();
        _emailText.SendKeys(user);
        _continueButton.Click();
        _passwordText.SendKeys(password);
        _signInButton.Click();
    }
}
