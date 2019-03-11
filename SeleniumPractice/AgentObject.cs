using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
//using DotNetSeleniumExtras;

namespace SeleniumPractice
{
    class AgentObject
    {

        public AgentObject() =>
            // constructor which initiliaze object of this page
            PageFactory.InitElements(PropertiesCollection.driver, this);




        [FindsBy(How = How.Id, Using = "nav-create-player")]

        public IWebElement createPlayer { get; set; }


    }
}
