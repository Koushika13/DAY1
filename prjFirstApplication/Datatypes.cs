using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Datatypes
    {
        void Types()
        {
            string name;
            int age;
            float salary = 67900.89f;
            Console.WriteLine("Enter the Name and Age");
            name = Console.ReadLine(); //for string
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Name:{0} && Age{1}  && float{2}", name, age,salary); //placeholder 0 and 1 keys   
        }

        void TypeConversion()
        {
            //Implicit type conversion
            //int->float->double
            int num = 100;
            float petrol = num;
            double diesel = petrol;
            Console.WriteLine("Implicit type conversion:{0}", diesel);

            //explicit type conversion
            double num1 = 765.12;

            int num2 = (int)num1;

            Console.WriteLine("Explicit type conversion:{0} ",num2);
        }

        void BoxingandUnboxing()
        {
            int salary = 20000; //value type
            Object obj = salary;// VALUE TYPE TO REFERENCE TYPE BOXING TYPE
            int number = (int)obj; //REFERENCE TYPE TO VALUE TYPE UNBOXING
            Console.WriteLine("BoxingandUnboxing:{0}",number); 
        }

        void NullableTypes()
        {
            //int age = null; error
            int? age = null;
            Console.WriteLine("Age is {0}",age??0); //null-coalescing operator- if age is null, 0 gets printed else the value gets printed
            //string City = null; gives warning
            string? City = null; //nullable type
            Console.WriteLine("city is{0}",City??"Chennai"); //if city is null, chennai gets printed else the value gets printed

        }
    static void Main()
    {

        Datatypes datatypes = new Datatypes();
        //new for creating memory(object)
        datatypes.Types();
        Console.WriteLine("------------------");
        datatypes.TypeConversion();
        Console.WriteLine("------------------");
        datatypes.BoxingandUnboxing();
        Console.WriteLine("------------------");
        datatypes.NullableTypes();
    }


    }

}
   


