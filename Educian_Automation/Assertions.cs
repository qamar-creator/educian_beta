using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    class Assertions //assertion
    {

        public static void assertionequals(string expectedresult, string actualresult)

        {
            Assert.AreEqual(actualresult, expectedresult, "strings are not equal");
        }
    }
}
