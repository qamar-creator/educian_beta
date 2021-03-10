using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Educian_Automation
{
    class EditStudent
    {

     
        public static void StudentEdit()
        {
            delayfor.delay();

            CustomControls.click("//a[@data-action='Students']", propertytype.XPath);
            delayfor.delay();
            CustomControls.click("//a[normalize-space()='Students List']", propertytype.XPath);
            delayfor.delay();


            //Search
            CustomControls.Entertext("//input[@placeholder='Name or Class or Roll No.']", "Waltor", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[contains(@class,'btn btn-primary btn-outline')]", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//i[@class='fa fa-eye']", propertytype.XPath);
            delayfor.delay();



            //Screen Switch


            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            delayfor.delay();


            CustomControls.click("//button[normalize-space()='Edit Student']", propertytype.XPath);
            delayfor.delay();

            Globalelements.Expectedresult = "Request Transfer Certificate";



            CustomControls.ClearText("//input[@id='first_name']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='first_name']", "Waltar" ,propertytype.XPath);
            delayfor.delay();

            CustomControls.ClearText("//input[@id='last_Name']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='last_Name']", "David", propertytype.XPath);
            delayfor.delay();
                       
            CustomControls.Selectdropdown("//select[@id='student_category']", "Scholarship", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[@name='save']", propertytype.XPath);
            delayfor.delay();

            CustomControls.click(" //button[normalize-space()='Ok']", propertytype.XPath);
            delayfor.delay();

            Globalelements.Actualresult = CustomControlsGets.GettextfromLabel("//button[normalize-space()='Request Transfer Certificate']", propertytype.XPath);
            Console.WriteLine("The landed page lands on " + Globalelements.Actualresult);
            Assertions.assertionequals(Globalelements.Actualresult, Globalelements.Expectedresult);

            if (Globalelements.Expectedresult == Globalelements.Actualresult)
            {
                Console.WriteLine("Test Paases");
            }

        }
        }
}
