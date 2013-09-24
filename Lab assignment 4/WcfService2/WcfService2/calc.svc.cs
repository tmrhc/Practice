using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : calc
    {
        public string Addition(string a, string b)
        {
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int r1 = a1 + b1;
            string r= Convert.ToString(r1);
            return r;

        }

        public string Subtraction(string a, string b)
        {
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int r1 = a1 - b1;
            string r = Convert.ToString(r1);
            return r;
        }

        public string Multiplication(string a, string b)
        {
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int r1 = a1 * b1;
            string r = Convert.ToString(r1);
            return r;

        }
        
        public string Division(string a, string b)
        {
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int r1 = a1 / b1;
            string r = Convert.ToString(r1);
            return r;

        }

           }


}
