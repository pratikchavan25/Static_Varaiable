using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticvaraiable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Static r1 = new Static("Rocky", 50000);
            r1.CalculateSalary();
            Console.WriteLine(r1.Printe());

            Static r2 = new Static("Pankaj", 1500000);
            r2.CalculateSalary();
            Console.WriteLine(r2.Printe());

            Console.WriteLine(Static.GetCount());
        }
             
    }
}
