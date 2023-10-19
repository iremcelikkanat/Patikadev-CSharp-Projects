using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Constructor
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string LastName;
        public string Department;


        public Employee() { }

        public Employee(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;

        }
        public Employee(string name, string lastName, int id, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
            this.Department = department;

        }

        public void EmployeeGet()
        {

            Console.WriteLine("Name of the employee: {0}", Name);
            Console.WriteLine("Last Name of the employee: {0}", LastName);
            Console.WriteLine("Id of the employee {0}:", Id);
            Console.WriteLine("Departman of the employee: {0}", Department);

        }

    }
}
