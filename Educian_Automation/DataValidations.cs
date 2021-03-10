using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class DataValidations
    {
        public static void Locationinfosdatavalidations()
        {
            string locationname = CustomControlsGets.Geettextfromtextbox("/html[1]/body[1]/div[5]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/span[2]/div[1]/span[1]/input[1]", propertytype.XPath);           
            Assert.AreEqual( locationname,Globalelements.locationinfo, "The location name in submission form and subsidary form do not match");

            string address1 = CustomControlsGets.Geettextfromtextbox("/html[1]/body[1]/div[5]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/span[2]/div[1]/span[1]/input[1]", propertytype.XPath);
            Assert.AreEqual(locationname, Globalelements.locationinfo, "  Address1 in submission form and subsidary form do not match");


        }
    }
}
