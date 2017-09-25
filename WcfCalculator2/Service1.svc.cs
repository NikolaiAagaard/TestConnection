using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Calculator22;

namespace WcfCalculator2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public decimal add(decimal a, decimal b)
        {
            Calculator22.Calculator c = new Calculator();
            return c.Add(a, b);
        }

        public decimal Subtract(decimal a, decimal b)
        {
            Calculator22.Calculator sub = new Calculator();
            return sub.Subtract(a, b);
        }

        public decimal Multiply(decimal a, decimal b)
        {
            Calculator22.Calculator mul = new Calculator();
            return mul.Multiply(a, b);
        }

        public decimal Divide(decimal a, decimal b)
        {
            Calculator22.Calculator div = new Calculator();
            return div.Divide(a, b);
        }

        public string Student(string a)
        {
           return a;
        }
    }
}
