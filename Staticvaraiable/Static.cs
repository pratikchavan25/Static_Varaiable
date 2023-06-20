using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Staticvaraiable
{
    public class Static
    {
        private string name;
        private int empid;
        private double ta, da, pf, hra, bs, gs, ts;
        private static int count;

        public Static(string name, int bs)
        {
            count++;
            this.empid = count;
            this.name = name;
            this.bs = bs;
        }
        public static int GetCount()
        {
            return count;
        }
        public void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;

            ts = (hra + da + ta);

            gs = (hra + da +ta) - pf;
        }
        public string Printe()
        {
            return $"name is {name}\n id is {empid}\n basic salary is {bs}\n total salary is {ts}\n gross salary is {gs}";
            
        }
       
        
           
         
    }
           
   
}
