using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class EnrollStudent
    {
        public static void StudentEnroll()
        {
            delayfor.delay();
            CustomControls.click("//a[@data-action='Students']", propertytype.XPath);

            delayfor.delay();
            CustomControls.click("//a[@id='enrollmentnav']", propertytype.XPath);
            delayfor.delay();
            CustomControls.click("//a[normalize-space()='Students Enrollment']", propertytype.XPath);

            //Search
            CustomControls.Entertext("#studentNameSearch", "John", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("#searchStudents", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("#completebatch", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("#EnrollBtn", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Selectdropdown("#enrollPrograms", "4th", propertytype.CssSelector);
            delayfor.delay();

            //Enroll
            CustomControls.click("#preViewBtn", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("#preViewConfirmBtn", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("button[class='confirm']", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("button[class='confirm']", propertytype.CssSelector);
            delayfor.delay();



        }

        }
    }
