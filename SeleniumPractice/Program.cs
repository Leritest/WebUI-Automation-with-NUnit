using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice
{
    class Program
    {

       


        static void Main(string[] args)
        {
            


        }
        [SetUp]
        public void Initialize()
        {
            Console.ReadLine();
            // Create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();

            // Navigate to page
            PropertiesCollection.driver.Navigate().GoToUrl("https://agent.apostamina.bet/");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            Console.WriteLine("OpenedURL");
        }
        [Test]
        public void ExecuteTets()
        {
            Console.WriteLine();
            ExcelLib.PopulateInCollection(@"C:\Users\Bojan.Milovanovic\Desktop\Data2.xlsx");

            // Login to Application - initialization of page object
            LoginPageObject pageLogin = new LoginPageObject();
            AgentObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          //  Assert.AreEqual("//*[@id='nav - create - player']", PropertiesCollection.driver.FindElement(By.XPath("//*[@id='nav - create - player']")));
           // [FindsBy(How = How.Id, Using = "nav-create-player")]
    }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }

        
    }
}
