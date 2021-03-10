using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System.Threading;

namespace Educian_Automation
{
    class Employee
    {
        public static void AddEmployee(string id, string first, string last, string gender, string email, string phone, string DOB, string joindate, string department, string role)
        {

            CustomControls.click("/html[1]/body[1]/div[2]/nav[1]/div[1]/ul[1]/li[5]/a[1]/span[1]", propertytype.XPath);
            CustomControls.click("/html[1]/body[1]/div[2]/nav[1]/div[1]/ul[1]/li[5]/ul[1]/li[1]/a[1]", propertytype.XPath);
            Wait.ImplicitWait(10);
            CustomControls.Entertext("employee_number", id, propertytype.Id);
            CustomControls.Entertext("employee_first_name", first, propertytype.Id);
            CustomControls.Entertext("employee_last_name", last, propertytype.Id);
            if ((String.Equals(gender, "female")))
            {
                CustomControls.click("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/fieldset[1]/div[5]/div[1]/div[2]/label[1]", propertytype.XPath);
            }
            CustomControls.Entertext("employee_email_id", email, propertytype.Id);
            CustomControls.Entertext("employee_phone_number", phone, propertytype.Id);
            CustomControls.Entertext("employee_dob", DOB, propertytype.Id);
            CustomControls.Entertext("employee_status_date", joindate, propertytype.Id);
            CustomControls.Selectdropdown("employee_department", department, propertytype.Id);
            CustomControls.Selectdropdown("employee_job_title", role, propertytype.Id);

            //submit
            CustomControls.clickable("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/button[2]", propertytype.XPath);
            Wait.ImplicitWait(10);
            //ok
            CustomControls.click("/html/body/div[8]/div[7]/button[2]", propertytype.XPath);
            Wait.ImplicitWait(10);
            //Goback to dashboard
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[3]/a", propertytype.XPath);

        }
        public static void ListEmployees()
        {
            //CustomControls.click("/html/body/div[2]/nav/div/ul/li[5]/ul/li[2]/a", propertytype.XPath);
            for (int i = 0; i <= 2; i++)
            {
                try
                {

                    CustomControls.click("/html/body/div[2]/nav/div/ul/li[5]/ul/li[2]/a", propertytype.XPath);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //click "records per page" button
            CustomControls.click("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[3]/label[1]/select[1]", propertytype.XPath);
            CustomControls.Selectdropdown("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[3]/label[1]/select[1]", "100", propertytype.XPath);
        }

        //This method opens the required tab regarding the employee
        public static void EmployeeDetails(employeeinfo info)
        {
            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            string cssclass = String.Format("#li-{0}", info);
            CustomControls.click(cssclass, propertytype.CssSelector);

        }

        //Displays all the employee profile fields, like classes, addresses, timetables
        public static void EmployeeDetails()
        {
            Navigate.RandomEmployee();
            //Switch to next(last) tab
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    foreach (employeeinfo emp in Enum.GetValues(typeof(employeeinfo)))
                    {
                        string cssclass = String.Format("#li-{0}", emp);
                        CustomControls.click(cssclass, propertytype.CssSelector);
                        //Thread.Sleep(2000); to slow down the clicks
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

    }
}

