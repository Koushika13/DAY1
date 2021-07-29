using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class stringcount
    {
        

        static void Main()
        {
            int count1 = 0;
            int count2=0;
            int digits = 0;
         string a;
            Console.WriteLine("Enter the string");
        a = Console.ReadLine();
            //Console.WriteLine(char.IsLower(a);
            for (int i = 0; i < a.Length; i++)
            {
                char x= a[i];
                if (char.IsLower(x))
                {
                    count1 = count1 + 1;

                }
                else if (char.IsUpper(x))
                {
                    count2 = count2 + 1;
                }
                else if (x >= '0' && x <= '9')
                {
                    digits++;
                }
                    
            }
            Console.WriteLine("Lower case:{0}", count1);
            Console.WriteLine("Upper Case:{0}", count2);
            Console.WriteLine("number of digits:{0}", digits);

        }
    }
}
