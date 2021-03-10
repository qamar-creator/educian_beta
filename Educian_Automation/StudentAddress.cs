using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class Address
    {
        public static string Expectedresult;
        public static string Actualresult;
        public static void StudentAddaddress()
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


            CustomControls.click("//a[normalize-space()='Address']", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//button[normalize-space()='Add Address']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Selectdropdown("//select[@id='address-type']", "Correspondence", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='address-line1']", "Arazona South", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='city']", "New York", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='state']", "New York", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='pin']", "309877", propertytype.XPath);
            delayfor.delay();

            CustomControls.Selectdropdown("//select[@id='country']", "United States of America", propertytype.XPath);
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


            CustomControls.click("//a[normalize-space()='Address']", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//div[@class='addressGridView']//div[2]//div[1]//p[1]//span[1]//button[1]", propertytype.XPath);
            delayfor.delay();

            CustomControls.Selectdropdown("//select[@id='address-type']", "Physical", propertytype.XPath);
            delayfor.delay();

            CustomControls.ClearText("//input[@id='address-line1']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='address-line1']", "Arazona South", propertytype.XPath);
            delayfor.delay();

            CustomControls.ClearText("//input[@id='city']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='city']", "New York", propertytype.XPath);
            delayfor.delay();

            CustomControls.ClearText("//input[@id='state']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='state']", "New York", propertytype.XPath);
            delayfor.delay();

            CustomControls.ClearText("//input[@id='pin']", propertytype.XPath);
            delayfor.delay();

            CustomControls.Entertext("//input[@id='pin']", "309877", propertytype.XPath);
            delayfor.delay();

            CustomControls.Selectdropdown("//select[@id='country']", "United States of America", propertytype.XPath);
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


            CustomControls.click("//a[normalize-space()='Address']", propertytype.XPath);
            delayfor.delay();

            CustomControls.click("//div[contains(@class,'addressGridView')]//div[2]//div[1]//p[1]//span[1]//button[2]", propertytype.XPath);
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
