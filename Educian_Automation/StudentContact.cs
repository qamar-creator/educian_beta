using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class Contact
    {


        public static string Expectedresult;
        public static string Actualresult;
        public static void StudentAddContact()
        {
            delayfor.delay();

            CustomControls.click("//a[@data-action='Students']", propertytype.XPath);
            delayfor.delay();
            CustomControls.click("//a[normalize-space()='Students List']", propertytype.XPath);
            delayfor.delay();


            //Search
            CustomControls.Entertext("//input[@placeholder='Name or Class or Roll No.']", "Waltar", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[contains(@class,'btn btn-primary btn-outline')]", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//i[@class='fa fa-eye']", propertytype.XPath);
            delayfor.delay();



            //Screen Switch


            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            delayfor.delay();


            CustomControls.click("//button[normalize-space()='Add Contact']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Selectdropdown("//select[@id='contact-type']", "Phone", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='contact-type-value']", "987623456719", propertytype.XPath);
            delayfor.delay();

            Expectedresult = "Request Transfer Certificate";



            CustomControls.click("//button[normalize-space()='Save & Close']", propertytype.XPath);
            delayfor.delay();

            CustomControls.click(" //button[normalize-space()='Ok']", propertytype.XPath);
            delayfor.delay();

            Actualresult = CustomControlsGets.GettextfromLabel("//button[normalize-space()='Request Transfer Certificate']", propertytype.XPath);
            Console.WriteLine("The landed page lands on " + Actualresult);
            Assertions.assertionequals(Actualresult, Expectedresult);

            if (Expectedresult == Actualresult)
            {
                Console.WriteLine("Test Paases");
            }

        }

        public static void StudentEditContact()
        {
            delayfor.delay();

            CustomControls.click("//a[@data-action='Students']", propertytype.XPath);
            delayfor.delay();
            CustomControls.click("//a[normalize-space()='Students List']", propertytype.XPath);
            delayfor.delay();


            //Search
            CustomControls.Entertext("//input[@placeholder='Name or Class or Roll No.']", "Waltar", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[contains(@class,'btn btn-primary btn-outline')]", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//i[@class='fa fa-eye']", propertytype.XPath);
            delayfor.delay();



            //Screen Switch


            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            delayfor.delay();


            CustomControls.click("//tbody/tr[3]/td[3]/button[1]/i[1]", propertytype.XPath);
            delayfor.delay();

            CustomControls.Selectdropdown("//select[@id='contact-type']", "Phone", propertytype.XPath);
            delayfor.delay();

            CustomControls.ClearText("//input[@id='contact-type-value']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='contact-type-value']", "563487129876", propertytype.XPath);
            delayfor.delay();

            Expectedresult = "Request Transfer Certificate";



            CustomControls.click("//button[normalize-space()='Save & Close']", propertytype.XPath);
            delayfor.delay();

            CustomControls.click(" //button[normalize-space()='Ok']", propertytype.XPath);
            delayfor.delay();

            Actualresult = CustomControlsGets.GettextfromLabel("//button[normalize-space()='Request Transfer Certificate']", propertytype.XPath);
            Console.WriteLine("The landed page lands on " + Actualresult);
            Assertions.assertionequals(Actualresult, Expectedresult);

            if (Expectedresult == Actualresult)
            {
                Console.WriteLine("Test Paases");
            }

        }

        public static void StudentDeleteContact()
        {
            delayfor.delay();

            CustomControls.click("//a[@data-action='Students']", propertytype.XPath);
            delayfor.delay();
            CustomControls.click("//a[normalize-space()='Students List']", propertytype.XPath);
            delayfor.delay();


            //Search
            CustomControls.Entertext("//input[@placeholder='Name or Class or Roll No.']", "Waltar", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[contains(@class,'btn btn-primary btn-outline')]", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//i[@class='fa fa-eye']", propertytype.XPath);
            delayfor.delay();



            //Screen Switch


            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            delayfor.delay();


            CustomControls.click("//tbody/tr[3]/td[3]/button[2]/i[1]", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[normalize-space()='Yes, Delete It']", propertytype.XPath);
            delayfor.delay();

            Expectedresult = "Request Transfer Certificate";

            CustomControls.click(" //button[normalize-space()='Ok']", propertytype.XPath);
            delayfor.delay();

            Actualresult = CustomControlsGets.GettextfromLabel("//button[normalize-space()='Request Transfer Certificate']", propertytype.XPath);
            Console.WriteLine("The landed page lands on " + Actualresult);
            Assertions.assertionequals(Actualresult, Expectedresult);

            if (Expectedresult == Actualresult)
            {
                Console.WriteLine("Test Paases");
            }

        }
    }
}
