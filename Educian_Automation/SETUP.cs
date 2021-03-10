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
    public class SETUP
    {
        public static string Expectedresult;
        public static string Actualresult;


        public static void TestMethodLogin()
        {
            Expectedresult = "Dashboard";
            PropertiesCollection.ngdriver = new ChromeDriver();
            PropertiesCollection.ngdriver.Manage().Window.Maximize();
            string url = ConfigurationManager.AppSettings.Get("url");

            // retry if 500 - Internal server error 
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
                    if (PropertiesCollection.ngdriver.Title == "E D U C I A N")
                    {

                        break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            Wait.ImplicitWait(10);
            Console.WriteLine("landed on the login page");
            CustomControls.Entertext("#inputEmail", ConfigurationManager.AppSettings.Get("username"), propertytype.CssSelector);
            CustomControls.Entertext("#inputPassword", ConfigurationManager.AppSettings.Get("password"), propertytype.CssSelector);
            CustomControls.click("button[type='submit']", propertytype.CssSelector);
            Actualresult = CustomControlsGets.GettextfromLabel("h2[class='breadcumChangeTitle']", propertytype.CssSelector);
            Console.WriteLine("The landed page lands on " + Actualresult);
            Assertions.assertionequals(Actualresult, Expectedresult);


        }

    }

}
