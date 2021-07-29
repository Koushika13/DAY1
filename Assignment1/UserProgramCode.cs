using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class UserProgramCode
    {
        internal static int Salary;
        internal static int MI = 678;
        
        public static void CalculateHomeSalary()
        {
            Console.WriteLine("Enter salary");
            Salary = Convert.ToInt32(Console.ReadLine());
            if (Salary < 15000 && Salary>0)
            {
                Salary = Salary - 750 - MI;
                Console.WriteLine(Salary);
            }
            else if (Salary > 15000 && Salary < 22001)
            {
                Salary = Salary - 850 - MI;
                Console.WriteLine(Salary);

            }
            else if (Salary > 22000 && Salary < 300001)
            {
                Salary = Salary - 925 - MI;
                Console.WriteLine(Salary);
            }
            else if (Salary > 300000)
            {
                Salary = Salary - 1000 - MI;
                Console.WriteLine(Salary);
            }
            else
            {
                Console.WriteLine("Invalid Input ");
            }

        }
        static void Main()
        {       

            CalculateHomeSalary();
        }
    }
}
