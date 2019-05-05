using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_MailOrder12
{
    public class customerInfo
    {
        public String name { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zipCode { get; set; }

        public customerInfo(String n, String a, String c, String s, String zip)
        {
            name = n;
            address = a;
            city = c;
            state = s;
            zipCode = zip;
        }


        public override string ToString()
        {
            return "Name: " + name + Environment.NewLine +
                "Address: " + address + Environment.NewLine +
                "City: " + city + Environment.NewLine +
                "State: " + state + Environment.NewLine +
                "ZIP Code: " + zipCode + Environment.NewLine;
        }
    }
}
