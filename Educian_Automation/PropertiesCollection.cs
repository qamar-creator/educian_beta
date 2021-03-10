using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace Educian_Automation
{

    enum propertytype
    {
        Model,
        Repeater,
        Id,
        Name,
        CssSelector,
        Class,
        XPath,
        LinkText
    }

    class PropertiesCollection
    {

        //Auto implemented property
        public static IWebDriver ngdriver { get; set; }

    }


    //experimental
    enum employeeinfo
    {
        //this is how the css class is written, dont change
        profiles,
        myClasses,
        attendances,
        contacts,
        timetables,
        addresss,
        familys,
        educations,
        experiences,
        miscellenouss,
        statuss,
        schools,
        notess,
        //[Display(Name = "virtual-classes")] virtualclass,
        evaluation,
        assignments
    }

    enum department
    {
        Administration,
        English,
        Mathematics,
        Science,
        //[Display(Name = "Computer Science")] ComputerScience

    }

    enum relation
    {
        Stepfather,
        Stepmother,
        Brother,
        Sister,
        Guardian
    }

    enum contacttype
    {
        Phone,
        Fax,
        WhatsApp,
        Facebook,
        Email,
        Web
    }

    enum addressType
    {
        Physical,
        Correspondence
    }

    enum paymentmode
    {
        Cheque,
        DD,
        Cash, 
        Challan, 
        Credit_Debit,
        Net_Banking

    }
}

