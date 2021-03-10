using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Educian_Automation
{
   public class Login
    {
        public static string Expectedresult;
        public static string Actualresult;
      

        public  static void TestMethodLogin()
        {
            Expectedresult = "Dashboard";
            PropertiesCollection.ngdriver = new ChromeDriver();
            string url = ConfigurationManager.AppSettings.Get("url");
            PropertiesCollection.ngdriver.Manage().Window.Maximize();
            PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    if(PropertiesCollection.ngdriver.Title == "Expentor-GSF")
                    {
                        break;
                    }
                    else
                    {
                        PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            Console.WriteLine("landed on the login page");
            CustomControls.Entertext("#inputEmail", ConfigurationManager.AppSettings.Get("username"), propertytype.CssSelector);
            CustomControls.Entertext("#inputPassword", ConfigurationManager.AppSettings.Get("password"), propertytype.CssSelector);
            CustomControls.click("button[type='submit']", propertytype.CssSelector);
            delayfor.delay();
            Actualresult = CustomControlsGets.GettextfromLabel("h2[class='breadcumChangeTitle']", propertytype.CssSelector);
            Console.WriteLine("The landed page lands on " + Actualresult);
            Assertions.assertionequals(Actualresult, Expectedresult);
        }

        public static void logout()
        {
            CustomControls.click("//ul[@class='nav navbar-top-links navbar-right']//a[@class='logout'][normalize-space()='Log out']", propertytype.XPath);
            PropertiesCollection.ngdriver.Quit();
        }

        
    }
}
