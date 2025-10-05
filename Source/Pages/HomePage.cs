using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Project2.Source.Drivers;
using SeleniumExtras.PageObjects;

namespace Project2.Source.Pages;
public class HomePage : Driver
{

    [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
    private IWebElement _searchTextBox;

    [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
    private IWebElement _searchButton;

    [FindsBy(How = How.Id, Using = "nav-link-accountList")]
    public IWebElement _signInLink;



    public HomePage()
    {
      
        PageFactory.InitElements(_driver, this);
    }

    public void Search(string searchText)
    {
        //_driver.FindElement(By.Id("twotabsearchtextbox"));
        _searchTextBox.SendKeys(searchText);
        _searchButton.Click();
        
    }




}
