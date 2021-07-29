using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_off
{
    class electricity
    {
        static void Main()
        {
            int units;
            double bill;
            //double spu = 1.2;
            Console.WriteLine("Enter the number of units");
            //units =Console.Read();
            units = Convert.ToInt32(Console.ReadLine());
            if (units < 100)
            {
                bill = units * 1.2;
                Console.WriteLine("Bill is:{0}", bill); 
            }
            else if(units>=100 && units <= 300)
            {
                bill = 100 * 1.2 + (units - 100) * 2;
                Console.WriteLine("Bill is:{0}", bill);
            }
            else if (units > 300)
            {
                bill = 100 * 1.2 + 200 * 2 + (units - 300) * 3;
                Console.WriteLine("Bill is:{0}", bill);

            }
            //Console.WriteLine(50 * 1.2);

        }
    }
}
