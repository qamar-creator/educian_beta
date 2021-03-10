using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educian_Automation;
using OpenQA.Selenium;
/*INCOMPLETE CLASS */
namespace Educian_Automation
{
    class Fee
    {
        public static void ShowFeeList()
        {
            //Click Dashboard
            CustomControls.click("a[data-license-type='dashboard']", propertytype.CssSelector);
            //Click Fee
            CustomControls.click("//*[@id='side-menu']/li[7]/a", propertytype.XPath);
            //Click Show Fee List
            Wait.ImplicitWait(5);
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[7]/ul/li[2]/a", propertytype.XPath);
            Wait.ImplicitWait(5);
            //Click First Row
            CustomControls.click("//*[@id='feeTbl']/tbody/tr[1]/td[5]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Finish
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[3]/a", propertytype.XPath);


        }

        public static void AddPaymentCClog(paymentmode payment, string confirmationNumber, string amount, string bankCharges="0", string creditaccounts= "FDI-987768", string recievedfrom = "CLARENCE ONEILL", string country= "United States", string state = "IL", string city = "Illinois", string pin = "62033", string addressline1 = "2633  Spring Street, Gillespie")
        {
            //Click Dashboard
            CustomControls.click("a[data-license-type='dashboard']", propertytype.CssSelector);
            //Click Fee
            CustomControls.click("//*[@id='side-menu']/li[7]/a", propertytype.XPath);
            //Click Cash Control Log
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[7]/ul/li[4]/a", propertytype.XPath);
            //Click add button

            CustomControls.click("//*[@id='page-wrapper']/div[2]/div/div[2]/a", propertytype.XPath);
            //Recieved From
            delayfor.delay();
            CustomControls.Entertext("#receivedFrom", recievedfrom, propertytype.CssSelector);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#receivedFrom")).SendKeys(Keys.Down);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#receivedFrom")).SendKeys(Keys.Enter);
            delayfor.delay();
            //Select Student 
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[8]/a", propertytype.XPath);
            delayfor.delay();
            CustomControls.Entertext("#registrationNumber", "UID-1003-2021", propertytype.CssSelector);
            CustomControls.click("#searchStudents", propertytype.CssSelector);
            CustomControls.click("#completebatch", propertytype.CssSelector);
            CustomControls.click("##EnrollBtn", propertytype.CssSelector);
            //#addressline1
            delayfor.delay();
            CustomControls.Entertext("#addressline1", addressline1, propertytype.CssSelector);
            //country
            CustomControls.click("#country", propertytype.CssSelector);
            CustomControls.Selectdropdown("#country", country, propertytype.CssSelector);
            //#state
            CustomControls.Entertext("#state", state, propertytype.CssSelector);
            //#city
            CustomControls.Entertext("#city", city, propertytype.CssSelector);
            //#pin
            CustomControls.Entertext("#pin", pin, propertytype.CssSelector);
            //#confirmationNumber
            CustomControls.Entertext("#confirmationNumber", confirmationNumber, propertytype.CssSelector);
            //#amount
            CustomControls.Entertext("#amount", amount, propertytype.CssSelector);
            //#bankCharges
            CustomControls.Entertext("#bankCharges", bankCharges, propertytype.CssSelector);
            //payment mode
            CustomControls.click(String.Format("//*[@id='addForm']/div/div/div/div[9]/div/div[{0}]/input", payment), propertytype.XPath);
            //CreditAccounts
            CustomControls.click("#bankAccounts", propertytype.CssSelector);
            CustomControls.Selectdropdown("#bankAccounts", creditaccounts, propertytype.CssSelector);
            //OK
            CustomControls.click("button[class='btn btn-warning btn-outline']", propertytype.CssSelector);
            delayfor.delay();
            //Confirm OK
            CustomControls.click("button[class='confirm']", propertytype.CssSelector);
      

        }

        public static void FeeCollection()
        {
            /*
             * SHERRI RHODES
UID: UID-1025-2021
Class: 2nd
Roll No.: 2
Session: 2021
Date Of Birth: 12/23/2004
Admission Date: 02/18/2021
             */
            //Click Dashboard
            CustomControls.click("a[data-license-type='dashboard']", propertytype.CssSelector);
            //Click Fee
            CustomControls.click("//*[@id='side-menu']/li[7]/a", propertytype.XPath);
            //Click Fee Collection
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[7]/ul/li[5]/a", propertytype.XPath);
            //click Student Name
            CustomControls.Entertext("#studentName", "SHERRI RHODES", propertytype.CssSelector);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#studentName")).SendKeys(Keys.Down);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#studentName")).SendKeys(Keys.Enter);
        }
    }


}
