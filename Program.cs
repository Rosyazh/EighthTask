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
    class Employee: IComparable<Employee>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            if (Equals(other)) return 0;
            return Surname.CompareTo(other.Surname);
        }
    }

    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee _rab1, Employee _rab2)
        {
            if (_rab1.Salary > _rab2.Salary)
                return -1;
            else if (_rab1.Salary < _rab2.Salary)
                return 1;
            else
                return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            var employees = new List<Employee>();

            employees.Add(new Employee { Name = "Boris", Surname = "Nikiforov", Salary = 570.52 });
            employees.Add(new Employee { Name = "Vitalij", Surname = "Abramov", Salary = 250.52 });
            employees.Add(new Employee { Name = "Alina", Surname = "Zuratova", Salary = 320.12 });
            employees.Add(new Employee { Name = "Olya", Surname = "Rusaya", Salary = 450.89 });
            employees.Add(new Employee { Name = "Adam", Surname = "Zako", Salary = 320.12 });

            employees.Sort(); //sorting by name
            employees.Sort(new EmployeeComparer()); //descending sorting by salary

            foreach (Employee rab in employees)
            {
                Console.WriteLine("{0} {1} {2}", rab.Name.PadRight(15), rab.Surname.PadRight(15), rab.Salary.ToString().PadRight(10));
            }

            Console.ReadKey();
        }
    }
}
