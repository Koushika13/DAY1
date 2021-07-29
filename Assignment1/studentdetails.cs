using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class studentdetails
    {
        public int marks { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public char Grade { get; set; }
        public string feedback1 { get; set; }

        public studentdetails(string name, int age, int marks)
        {

            this.name = name;
            this.age = age;
            this.marks = marks;
        }

        public void Calculategrade()
        {
            
            if (marks>=90)
            {
                Grade= 'S';
                //Console.WriteLine("Grade is:{0}", Grade);
                
            }
            else if(marks>=80 && marks < 90)
            {
                Grade = 'A';
                //Console.WriteLine("Grade is:{0}", Grade);
                

            }

            else
            {
                Grade = 'B';
                //Console.WriteLine("Grade is:{0}", Grade);
            }
        }

        public enum Feedback
        {
            Excellent,
            Verygood,
            Good
        }

        public void DisplayResult()
        {
            Console.WriteLine("Student name:{0} || Age:{1} || Marks:{2} || Grade:{3}",name,age,marks,Grade);
        }

        static void Main()
        {
            string sname;
            int age1;
            int marks1;

            int n;
            Console.WriteLine("Number of Students");
            n = Convert.ToInt32(Console.ReadLine());
            studentdetails[] students = new studentdetails[n];
             for(int i = 0;i< n; i++)
            {
                Console.WriteLine("Enter student name");
                sname = Console.ReadLine();
                Console.WriteLine("Enter student age");
                age1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks");
                marks1 = Convert.ToInt32(Console.ReadLine());
                students[i] = new studentdetails(sname, age1, marks1);
            }

             for(int i = 0; i < n; i++)
            {
                students[i].Calculategrade();
                students[i].DisplayResult();
            }
            
        }




    }
}








    

        

        
    

