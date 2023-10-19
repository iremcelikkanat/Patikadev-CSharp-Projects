using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_csharp_projects
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string LastName;
        public string Department;


        public void EmployeeGet()
        {

        Console.WriteLine("Name of the employee: {0}", Name);
        Console.WriteLine("Last Name of the employee: {0}", LastName);
        Console.WriteLine("Id of the employee {0}:", Id);
        Console.WriteLine("Departman of the employee: {0}", Department);

        }

    }

}


//1. Public : Her yerden erişilebilir.

//2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

//3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

//4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.