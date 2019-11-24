using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher teacher = new Teacher("Tom", 350f);
            // teacher work for 20Hr/month
            Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                teacher.CalculateCharge(20f));
            Console.ReadLine();



        }
    }
    
}
