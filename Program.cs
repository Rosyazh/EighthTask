using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Practice: Develop custom class Employee containing personal information and salary value. 
Make possible to sort a list of Employees by salary or by personal info.
*/

namespace EighthTask
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee r1 = new Employee { Name = "Arsenij", Surname = "Nikiforov", Salary = 570.52 };
            Employee r2 = new Employee { Name = "Vitalij", Surname = "Abramov", Salary = 450.52 };
            Employee r3 = new Employee { Name = "Boris", Surname = "Zurupov", Salary = 320.12 };

            List<Employee> employees = new List<Employee>();

            employees.Add(r1);
            employees.Add(r2);
            employees.Add(r3);

            employees.Sort(delegate (Employee rab1, Employee rab2)
            { return rab1.Salary.CompareTo(rab2.Salary); });

            Console.WriteLine("Sorting by salary.");
            foreach (Employee em in employees)
                Console.WriteLine(em.Salary + " " + em.Name + " " + em.Surname);

            employees.Sort(delegate (Employee rab1, Employee rab2)
            { return rab1.Name.CompareTo(rab2.Name); });

            Console.WriteLine("\nSorting by name.");
            foreach (Employee em in employees)
                Console.WriteLine(em.Salary.ToString() + " " + em.Name + " " + em.Surname);

            employees.Sort(delegate (Employee rab1, Employee rab2)
            { return rab1.Surname.CompareTo(rab2.Surname); });

            Console.WriteLine("\nSorting by surname.");
            foreach (Employee em in employees)
                Console.WriteLine(em.Salary.ToString() + " " + em.Name + " " + em.Surname);

            Console.ReadKey();
        }
    }
}
