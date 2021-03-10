using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Educian_Automation
{
    class CustomControls
    {

        // EnterText

        public static void Entertext(string webelementvalue, string value, propertytype elementtype)

        {
            switch (elementtype)
            {
                case propertytype.Model:
                    PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).SendKeys(value);
                    break;
                case propertytype.Name:
                    PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).SendKeys(value);
                    break;

                case propertytype.XPath:
                    PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).SendKeys(value);
                    break;
                case propertytype.CssSelector:
                    PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).SendKeys(value);
                    break;

                case propertytype.Id:
                    PropertiesCollection.ngdriver.FindElement(By.Id(webelementvalue)).SendKeys(value);
                    break;
            }
        }


        // click button, checkbox,radio buttion,check boxal

        public static void click(string webelementvalue, propertytype elementtype)

        {
            switch (elementtype)
            {
                case propertytype.Model:

                    PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).Click();
                    break;
                case propertytype.Name:
                    PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).Click();
                    break;
                case propertytype.XPath:

                    PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).Click();
                    break;
                case propertytype.CssSelector:

                    PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).Click();
                    break;
                case propertytype.Class:

                    PropertiesCollection.ngdriver.FindElement(By.ClassName(webelementvalue)).Click();
                    break;
                case propertytype.LinkText:

                    PropertiesCollection.ngdriver.FindElement(By.LinkText(webelementvalue)).Click();
                    break;

            }

        }

        //Selecting value from dropdown using text property

        public static void Selectdropdown(string webelementvalue, string Text, propertytype elementtype)
        {
            switch (elementtype)
            {
                case propertytype.Id:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id(webelementvalue))).SelectByText(Text);
                    break;
                case propertytype.Name:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue))).SelectByText(Text);
                    break;
                case propertytype.XPath:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue))).SelectByText(Text);
                    break;
                case propertytype.CssSelector:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue))).SelectByText(Text);

                    break;
            }
        }

        //Selecting value from dropdown using value property

        public static void Selectdropdownindex(string webelementvalue, int Text, propertytype elementtype)
        {

            switch (elementtype)
            {
                case propertytype.Id:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id(webelementvalue))).SelectByIndex(Text);
                    break;
                case propertytype.Name:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue))).SelectByIndex(Text);
                    break;
                case propertytype.XPath:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue))).SelectByIndex(Text);
                    break;
                case propertytype.CssSelector:

                    new SelectElement(PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue))).SelectByIndex(Text);
                    break;

            }
        }

        public static void clickable(string webelementvalue, propertytype elementtype)
        {


            if (elementtype == propertytype.Model)

                PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).Click();
            else
            if (elementtype == propertytype.Name)

                PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).Click();
            else
            if (elementtype == propertytype.XPath)

                PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).Click();
            else
            if (elementtype == propertytype.CssSelector)

                PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).Click();
            else
            if (elementtype == propertytype.Class)

                PropertiesCollection.ngdriver.FindElement(By.ClassName(webelementvalue)).Click();
            else
            if (elementtype == propertytype.LinkText)

                PropertiesCollection.ngdriver.FindElement(By.LinkText(webelementvalue)).Click();
        }

        // ClearText

        public static void ClearText(string webelementvalue, propertytype elementtype)

        {
            switch (elementtype)
            {
                case propertytype.Model:
                    PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).Clear();
                    break;
                case propertytype.Name:
                    PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).Clear();
                    break;

                case propertytype.XPath:
                    PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).Clear();
                    break;
                case propertytype.CssSelector:
                    PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).Clear();
                    break;

                case propertytype.Id:
                    PropertiesCollection.ngdriver.FindElement(By.Id(webelementvalue)).Clear();
                    break;
            }

        }

    }

}
