using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Array_static
    {
        static void Main()
        {
            ArrayEg newarray = new ArrayEg();
            newarray.Getfruits();

            StrinEg stringEg1 = new StrinEg();
            stringEg1.stringFunctionEg();
        }
    }
    class ArrayEg
    {
        //by default access specifier for member and member funtion is private
        //single dimensional array
        //datatype[] arrayname = new datatype[size];

        string[] fruits = new string[3];
        int[] mark = { 89, 78, 90 };

        internal void Getfruits()
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("Enyer the fruitname");
                fruits[i] = Console.ReadLine();

            }

            //foreach (string fu in fruits)
            //implicitly typed variable
            foreach (var fu in fruits)
            {
                Console.WriteLine("FruitName:{0}", fu);
            }

        }

    }

    class StrinEg
    {
        internal void stringFunctionEg()
        {
            string Firstname = "Sai";
            string Name = "Monisha Devi";
            Console.WriteLine("To UPPER : {0}", Firstname.ToUpper());
            Console.WriteLine("To Lower:{0}", Firstname.ToLower());
            Console.WriteLine("Length:{0}", Name.Length);
            bool isContains = Name.Contains("UP");
            Console.WriteLine("Contains UP:{0}", isContains);
            Console.WriteLine("Substring : {0}", Name.Substring(3, 5));

        }
    }
    }

