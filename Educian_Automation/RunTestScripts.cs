
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
    [TestClass]
    public class StudentClass

    {
        [TestInitialize]
        public void init()
        {
            Login.TestMethodLogin();
        }

        [TestMethod]
        [Priority(1)]
        public void a_Add_Student()

        {


            AddNewStudent.StudentAddNew();


        }

        [TestMethod]
        [Priority(2)]
        public void b_Enroll_Student()

        {

            EnrollStudent.StudentEnroll();

        }

        [TestMethod]
        [Priority(3)]
        public void c_Edit_Student()

        {

            EditStudent.StudentEdit();

        }

        [TestMethod]
        [Priority(4)]
        public void d_Add_StudentContact()

        {
            Contact.StudentAddContact();
        }

        [TestMethod]
        [Priority(4)]
        public void e_Edit_StudentContact()

        {

            Contact.StudentEditContact();
        }

        [TestMethod]
        [Priority(4)]
        public void f_Delete_StudentContact()

        {

            Contact.StudentDeleteContact();
        }

        [TestMethod]
        [Priority(5)]
        public void g_Add_StudentAddress()

        {
            Address.StudentAddaddress();
        }

        [TestMethod]
        [Priority(4)]
        public void h_Edit_StudentAddresst()

        {

            Address.StudentEditContact();
        }

        [TestMethod]
        [Priority(4)]
        public void i_Delete_StudentAddress()

        {

            Address.StudentDeleteContact();
        }

        [TestMethod]
        [Priority(5)]
        public void j_Add_Employee()
        {

            Employee.AddEmployee("107", "Edwin", "Ludolf", "male", "edwin@internationac.com", "9827367892", "01/23/2001", "10/12/2021", "Computer Science", "Instructor");
        }

        [TestMethod]
        [Priority(6)]
        public void k_List_Employees()
        {

            Navigate.RandomEmployee();
        }

        [TestMethod]
        [Priority(7)]
        public void l_View_Details()
        {
            //Employee.EmployeeDetails(employeeinfo.timetables);
            Employee.EmployeeDetails();
        }
        
        [TestMethod]
        [Priority(8)]
        public void m_Show_Fee_List()
        {
            Fee.ShowFeeList();
        }

        [TestMethod]
        [Priority(8)]
        public void n_AddPaymentCCLog()
        {
            /*not finished yet
            Fee.AddPaymentCClog(paymentmode.Cash, "00967522331", "200");
           // Fee.FeeCollection();
            */
        }
        [TestCleanup]
         
          public void cleanup()
         {
            Login.logout();
         }

    }
}
