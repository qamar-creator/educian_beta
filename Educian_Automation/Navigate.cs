using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class Navigate
    {
        //Randomly selects a student
        public static void RandomStudent()
        {
            /*Views a random student between 1 and 70*/
            //click dashboard
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[3]/a", propertytype.XPath);
            Wait.ImplicitWait(10);
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div/a[1]/div/div", propertytype.XPath);
            Wait.ImplicitWait(10);

            //click "records per page" button and select 100
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div[3]/div/div/div[1]/div[1]/div/label/select", propertytype.XPath);
            Wait.ImplicitWait(5);
            CustomControls.Selectdropdown("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div[3]/div/div/div[1]/div[1]/div/label/select", "100", propertytype.XPath);
            Wait.ImplicitWait(10);
            //pick a random student
            int num = new Random().Next(1, 70);
            Wait.ajaxWait(3);
            String s = String.Format("//tbody/tr[{0}]/td[10]/a[1]", num);
            //actions>view
            Wait.ajaxWait(3);

            CustomControls.click(s, propertytype.XPath);
            //switch window
            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            Wait.ImplicitWait(20); //next task
        }
        //Randomly selects an employee
        public static void RandomEmployee()
        {
            //click dashboard
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[3]/a", propertytype.XPath);
            Wait.ImplicitWait(10);
            //click activeEmployee 
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div/a[2]/div/div", propertytype.XPath);
            Wait.ImplicitWait(10);
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div/div[2]/div/div/div/div[3]/label/select", propertytype.XPath);
            Wait.ImplicitWait(10);
            CustomControls.Selectdropdown("/html/body/div[2]/div[2]/div[2]/div/div/div[2]/div/div/div/div[3]/label/select", "100", propertytype.XPath);
            Wait.ImplicitWait(10);

            // pick a random student
            int num = new Random().Next(1, 20);
            String s = String.Format("//tbody/tr[{0}]/td[8]/a[1]", num);
            //actions>view
            CustomControls.click(s, propertytype.XPath);
            //switch window
            PropertiesCollection.ngdriver.SwitchTo().Window(PropertiesCollection.ngdriver.WindowHandles.Last());
            Wait.ImplicitWait(20); //next task

        }
        
        //View an employee with given ID
        public static void ShowEmployee(string id)
        {
            //click dashboard
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[3]/a", propertytype.XPath);
            Wait.ImplicitWait(10);
            //click activeEmployee 
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div/a[2]/div/div", propertytype.XPath);
            Wait.ImplicitWait(10);
            CustomControls.Entertext("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[4]/label[1]/input[1]", id, propertytype.XPath);
            CustomControls.click("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[4]/label[1]/span[1]/button[1]", propertytype.XPath);
            CustomControls.click("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/a[1]", propertytype.XPath);
        }

    }
}
