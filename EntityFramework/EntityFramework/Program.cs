using EntityFramework.Controllers;
using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employee1 = new EmployeeController();
            //employee1.GetEmployeeById(99);

            //employee1.GetAllEmployees();

            //foreach (var item in employee1.GetAllEmployees())
            //{
            //    Console.WriteLine(item.Fullname);
            //}

            //employee1.DeleteEmployee(99);
           employee1.FilterByName("j");
          
        }
    }
}
