using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class AddNewStudent
    {
        public static void StudentAddNew()
        {
            CustomControls.click("a[data-action='Students']", propertytype.CssSelector);
            CustomControls.click("#studentSaveStudent", propertytype.CssSelector);
            //Personal Information
            CustomControls.Entertext("#first_name","Johnson",propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#last_Name", "Doughlas", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#dob", "04232009", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("#student_gender_male", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Selectdropdown("#student_category", "General", propertytype.CssSelector);
            delayfor.delay();

            //Phone
            CustomControls.Selectdropdown("#classname", "4th", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Selectdropdown("#section", "A", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#phoneNumber", "567890234567", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#emailId", "john@gmail.com", propertytype.CssSelector);
            delayfor.delay();

            //Parent Details
            CustomControls.Entertext("//input[@id='father_first_name']", "helbert", propertytype.XPath);
            delayfor.delay();
            CustomControls.Entertext("#father_last_name", "Doe", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("//input[@id='mother_first_name']", "Richea", propertytype.XPath);
            delayfor.delay();
            CustomControls.Entertext("#mother_last_name", "Sameouls", propertytype.CssSelector);
            delayfor.delay();

            //Address
            CustomControls.Entertext("#addressline1Physical", "Green View Avuenue", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#cityPhysical", "Adamsville", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#statePhysical", "Alabama", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#pinPhysical", "132908", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#countryPhysical", "United States", propertytype.CssSelector);
            delayfor.delay();

            //Click Event
            CustomControls.click("#sameAsPhysical", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("button[name = 'save']", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click(" button[name = 'submit']", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click(" //button[normalize-space()='Ok']", propertytype.XPath);

        }

    }
}
