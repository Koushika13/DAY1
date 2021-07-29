using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Organization
    {
        internal static string OrgName = "LTI";//Static variable
        string City = "Chennai"; //non-static variable

        internal static void GetOrgDtails()
        {
            int value = 90;
            Console.WriteLine(OrgName);
            //Console.WriteLine(City); //it can access only static variable
        }
    }

    class Employee
    {
        //Property
        int Eid { get; set; } //get- gets value for the variable, set- assigns value for the variable
        string? Empname { get; set; }
        string? Location { get; set; }
        int salary { get; set; }

        int Did { get; } //read only property

        //constructor
        //initialise the values
        Employee()
        {
            Did = 101;
        } 
        //constructor overloading //differs with number of parameters and date type also
        Employee(int Eid ,string Empname, string Location, int Sal)
        {
            //this represents current class instance(employee) variable
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            salary = Sal;
        }

        void DisplayEmployee(Employee emp) //void DisplayEmployee()
        {
            Console.WriteLine("Eid:{0} || Empname:{1} || Location{2} || salary{3} || Did{4} || Orgname:{5}", Eid, Empname, Location, salary,Did,Organization.OrgName);

        }

        static void Main()
        {
            int Empid, Esalary;
            string Elocation, Ename;
            Employee employee = new Employee();
            //Propery
           employee.Eid=1001;
             employee.Empname="ANU";
            employee.Location = "Chennai";
            employee.salary = 670000;
            //employee.Did=101; //error is read only
            Console.WriteLine("eid:{0} ename:{1} location:{2} salary:{3} did:{4}",
                employee.Eid, employee.Empname, employee.Location, employee.salary, employee.Did);

            //array of objects
            int n = 2;
            Employee[] employee2 = new Employee[2];

            for (int i = 0; i < n; i++)
            {
                //constructor
                Console.WriteLine("Enter the Eid");
                Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name");
                Ename = Console.ReadLine();
                Console.WriteLine("Enter the location");
                Elocation = Console.ReadLine();
                Console.WriteLine("Enter the salary");
                Esalary = Convert.ToInt32(Console.ReadLine());
                employee2[i] = new Employee(Empid, Ename, Elocation, Esalary);
            }
            //Employee employee1 = new Employee(Empid, Ename, Elocation, Esalary);

            for(int i = 0; i < n; i++)
            {
                employee2[i].DisplayEmployee(employee);
            }
            //employee1.DisplayEmployee();
            //employee1.DisplayEmployee(employee);
            //method can take object as a parameter
            


        }
    }
}
