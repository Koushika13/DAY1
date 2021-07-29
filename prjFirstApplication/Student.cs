using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prjFirstApplication
{
    class Student
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal DateTime dateofbirth { get; set; }
        internal static string collegeName = "KJSCE";

        public Student(int id, string name, DateTime dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;

        }
    }

    class Info
    {
        public static void display(Student student)
        {
            Console.WriteLine(student.id + " " + student.name + " " + (student.dateofbirth).ToString("dd/MM/yyyy"));
        }
    }

    class App
    {
        public static void Scenario1()
        {
            Student student1 = new Student(1, "Raj", Convert.ToDateTime("07/11/1999"));
            Student student2 = new Student(2, "Vatsal", Convert.ToDateTime("08/01/1999"));
            Student student3 = new Student(3, "Manav", Convert.ToDateTime("08/12/1999"));

            Info info = new Info();
            Info.display(student1);
            Info.display(student2);
            Info.display(student3);


        }
    

        public static void Scenario2()
        {
            Student[] students = new Student[3];
            students[0] = new Student(1, "Raj", Convert.ToDateTime("07/11/1999"));
            students[1] = new Student(2, "Vatsal", Convert.ToDateTime("08/01/1999"));
            students[2] = new Student(3, "Manav", Convert.ToDateTime("08/12/1999"));
            foreach (Student su in students)
            {
                Info.display(su);
            }

        }
        public static void Scenario3()
        {
            Console.WriteLine("Enter number of student:");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter roll no,name, and dob");
                int id = Convert.ToInt32(Console.ReadLine());
                String name = Console.ReadLine();
                DateTime date = DateTime.Parse(Console.ReadLine());
                students[i] = new Student(id, name, date);


            }
            foreach (Student su in students)
            {
                Info.display(su);
            }
        }

        public static void Scenario4()
        {
            Console.WriteLine("Enter number of student:");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayList students = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter roll no,name, and dob");
                int id = Convert.ToInt32(Console.ReadLine());
                String name = Console.ReadLine();
                DateTime date = DateTime.Parse(Console.ReadLine());
                //students[i] = new Student(id, name, date);
                students.Add(new Student(id, name, date));

            }
            foreach (Student su in students)
            {
                Info.display(su);
            }



        }

        static void Main()
        {
            App.Scenario1();
            App.Scenario2();
            App.Scenario3();
            App.Scenario4();
        }
    }

}
