using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class CommonElements
    {
        public static void addContact(bool student, contacttype type, string phone)
        {
            if (student)
            {
                Navigate.RandomStudent();
                CustomControls.click("//*[@id=\"tab-profile\"]/div[2]/div/ul/li[1]/a", propertytype.XPath);
                CustomControls.click("//*[@id=\"btn-contact\"]", propertytype.XPath);
            }
            else
            {
                Navigate.RandomEmployee();
                CustomControls.click("//*[@id=\"li-contacts\"]", propertytype.XPath);
                CustomControls.click("//*[@id=\"btn-contact\"]", propertytype.XPath);
            }
            Wait.ImplicitWait(5);
            CustomControls.click("//*[@id=\"contact-type\"]", propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Selectdropdown("//*[@id=\"contact-type\"]", Enum.GetName(typeof(contacttype), type), propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Entertext("//*[@id=\"contact-type-value\"]", phone, propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.click("//*[@id=\"save-close-button\"]", propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.click("//*[@id=\"appbody\"]/div[6]/div[7]/button[2]", propertytype.XPath);
            Wait.ImplicitWait(5);
        }

        public static void addAddress(bool student, addressType type, string address1, string city, string state, string pincode, string country = "Algeria")
        {

            if (student)
            {
                Navigate.RandomStudent();
                Wait.ImplicitWait(5);
                CustomControls.click("//*[@id=\"tab-profile\"]/div[2]/div/ul/li[2]/a", propertytype.XPath);
            }
            else
            {
                Navigate.RandomEmployee();
                CustomControls.click("//*[@id=\"li-addresss\"]", propertytype.XPath);
            }
            CustomControls.click("//*[@id=\"btn-address\"]", propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.click("//select[@id=\"address-type\"]", propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Selectdropdown("//select[@id=\"address-type\"]", Enum.GetName(typeof(addressType), type), propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Entertext("//*[@id=\"address-line1\"]", address1, propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Entertext("//input[@id='city']", city, propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Entertext("//input[@id='state']", state, propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Entertext("//input[@id='pin']", pincode, propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Entertext("//select[@id='country']", country, propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.click("//*[@id=\"save-close-button\"]", propertytype.XPath);
            delayfor.delay(); //WHAT IS THE ALTERNATIVE HERE, THE ELEMENT IS PRESENT BUT ITS NOT DOING THE JOB ???????
            CustomControls.click("//*[@id=\"appbody\"]/div[6]/div[7]/button[2]", propertytype.XPath);
            if (student)
            {
                CustomControls.click("//*[@id=\"tab-profile\"]/div[2]/div/ul/li[2]/a", propertytype.XPath);
            }
        }

        public static void editMisc(bool student, string biometric, string bloodgroup = "B+", string height = "170", string weight = "50", string placeofbirth = "Georgia", string language = "English", string nationality = "Dominican", string race = "Other Race", string religion = "Other")
        {
            if (student)
            {
                Navigate.RandomStudent();
                CustomControls.click("//*[@id=\"tab-profile\"]/div[2]/div/ul/li[3]/a", propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"tab-miscellenaous\"]/div/div[1]/button", propertytype.XPath);
                Wait.ImplicitWait(10);
                delayfor.delay();
                CustomControls.Entertext("#biometric_id", biometric, propertytype.CssSelector);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"blood_group\"]", propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Selectdropdown("//*[@id=\"blood_group\"]", bloodgroup, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Entertext("//*[@id=\"height\"]", height, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Entertext("//*[@id=\"weight\"]", weight, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Entertext("//*[@id=\"place_of_birth\"]", placeofbirth, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"language\"]", propertytype.XPath);
                CustomControls.Selectdropdown("//*[@id=\"language\"]", language, propertytype.XPath);
                CustomControls.click("//*[@id=\"nationality\"]", propertytype.XPath);
                CustomControls.Selectdropdown("//*[@id=\"nationality\"]", nationality, propertytype.XPath);
                CustomControls.click("//*[@id=\"race\"]", propertytype.XPath);
                CustomControls.Selectdropdown("//*[@id=\"race\"]", race, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"religion\"]", propertytype.XPath);
                CustomControls.Selectdropdown("//*[@id=\"religion\"]", religion, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"save-close-button\"]", propertytype.XPath);
                Wait.ImplicitWait(10);
                //ok
                CustomControls.click("//*[@id=\"appbody\"]/div[6]/div[7]/button[2]", propertytype.XPath);
            }
            else
            {
                Navigate.RandomEmployee();
                CustomControls.click("//*[@id=\"li-miscellenouss\"]", propertytype.XPath);
                CustomControls.click("//*[@id=\"tab-miscellenous\"]/div[1]/button", propertytype.XPath);
                Wait.ImplicitWait(10);
                delayfor.delay(); //REQUIRED. ASK ALTERNATIVE
                CustomControls.Entertext("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/div/form/div/div[1]/div/input", biometric, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"employee_blood_group\"]", propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Selectdropdown("//*[@id=\"employee_blood_group\"]", bloodgroup, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Entertext("//*[@id=\"employee_height\"]", height, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"employee_religion\"]", propertytype.XPath);
                CustomControls.Selectdropdown("//*[@id=\"employee_religion\"]", religion, propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.click("//*[@id=\"save-close-button\"]", propertytype.XPath);
                delayfor.delay();
                //ok
                CustomControls.click("//*[@id=\"appbody\"]/div[6]/div[7]/button[2]", propertytype.XPath);
            }

        }

        public static void addNote(bool student, string mynote)
        {
            if (student)
            {
                Navigate.RandomStudent();
                CustomControls.click("li[id = 'li-notes'] a[class='rToggle']", propertytype.CssSelector);

            }
            else
            {
                Navigate.RandomEmployee();
                CustomControls.click("li[id='li-notess'] a[class='rToggle']", propertytype.CssSelector);
            }

            Wait.ImplicitWait(5);
            CustomControls.click("#btn-notes", propertytype.CssSelector);
            CustomControls.click("#note-type", propertytype.CssSelector);
            CustomControls.Selectdropdown("#note-type", "Reminder", propertytype.CssSelector);
            CustomControls.Entertext("#note-description", mynote, propertytype.CssSelector);
            CustomControls.click("#save-close-button", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("button[class='confirm']", propertytype.CssSelector);
        }

        public static void addFamily(bool student, relation relationship, string first, string last, string contact, string email, string empRelation = "Brother")
        {
            if (student)
            {
                Navigate.RandomStudent();
                CustomControls.click("li[id='li-family'] a[class='rToggle']", propertytype.CssSelector);
                CustomControls.click("#btn-family", propertytype.CssSelector);
                Wait.ImplicitWait(10);
                //select relation type, for that we need to click the drop down and select the relation type
                CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[1]/div/select", propertytype.XPath);
                CustomControls.Selectdropdown("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[1]/div/select", Enum.GetName(typeof(relation), relationship), propertytype.XPath);
                Wait.ImplicitWait(10);
                CustomControls.Entertext("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[3]/div/input", first, propertytype.XPath);
                CustomControls.Entertext("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[5]/div/input", last, propertytype.XPath);
                CustomControls.Entertext("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[6]/div/input", contact, propertytype.XPath);
                CustomControls.Entertext("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[7]/div/input", email, propertytype.XPath);
                //submit
                CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div/div/div/div/form/div/div[10]/button[3]", propertytype.XPath);
                //confirmation OK
                CustomControls.click("/html/body/div[6]/div[7]/button[2]", propertytype.XPath);
                delayfor.delay();
            }
            else
            {
                Navigate.RandomEmployee();
                CustomControls.click("li[id='li-familys'] a[class='rToggle']", propertytype.CssSelector);
                CustomControls.click("#btn-family", propertytype.CssSelector);
                Wait.ImplicitWait(10);
                CustomControls.Entertext("#contact-type-name", first + " " + last, propertytype.CssSelector);
                CustomControls.click("#relationship-type", propertytype.CssSelector);
                CustomControls.Selectdropdown("#relationship-type", empRelation, propertytype.CssSelector);
                CustomControls.Entertext("#contact-type-number", contact, propertytype.CssSelector);
                CustomControls.click("//*[@id=\"save-close-button\"]", propertytype.CssSelector);
                delayfor.delay();
                CustomControls.click("button[class='confirm']", propertytype.CssSelector);
                delayfor.delay();

            }

        }

    }

}
