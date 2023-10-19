namespace PatikaDev_csharp_projects;
class Program
{
    static void Main(string[] args)
    {

        Employee employeeOne = new Employee();
        employeeOne.Name = "İrem";
        employeeOne.LastName = "Çelikkanat";
        employeeOne.Id = 123456;
        employeeOne.Department = "E-Commerce";

        employeeOne.EmployeeGet();
    }
}