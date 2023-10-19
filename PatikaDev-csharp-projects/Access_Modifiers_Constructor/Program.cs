namespace Access_Modifiers_Constructor;

class Program
{
    static void Main(string[] args)
    {

        Employee employee = new Employee("İrem","Çelikkanat");
        employee.EmployeeGet();


        Employee employee2 = new Employee("İrem", "Çelikkanat", 123456, "E-Commerce");
        employee2.EmployeeGet();


    }
}