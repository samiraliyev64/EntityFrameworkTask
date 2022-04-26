using EntityFramework.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework.Controllers
{
    class EmployeeController
    {
        private readonly AppDbContext _context;

        public EmployeeController()
        {
            _context = new AppDbContext();
        }

        public void GetEmployeeById(int? id)
        {
           
            if(id == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Employee employee = _context.Employees.Find(id);
                if (employee == null)
                {
                    Console.WriteLine("bele bir ishci yoxdur");
                }
                else
                {
                    Console.WriteLine(employee.Fullname);
                }
            }
            
        }
        
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public void AddEmployee(string fullname)
        {
            if (fullname == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Employee newEmployee = new Employee { Fullname = fullname };
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
                Console.WriteLine($"{fullname} added to Employee table");
            }
         
        }

        public void DeleteEmployee(int? id)
        {
            if(id == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Employee newEmployee = _context.Employees.Find(id);
                if(newEmployee == null)
                {
                    Console.WriteLine("ischi yoxdur");
                }
                else
                {
                    _context.Employees.Remove(newEmployee);
                    _context.SaveChanges();
                }
             
            }
           
        }

        public void FilterByName(string? search)
        {
            List<Employee> employeess = _context.Employees.ToList();
            bool isExist = false;
            if(search == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                foreach (var item in employeess)
                {
                    
                    if (item.Fullname.ToLower().Contains(search) || item.Fullname.ToUpper().Contains(search))
                    {
                        isExist = true;
                        Console.WriteLine(item.Fullname);
                    }
                }
                if (isExist == false)
                {
                    Console.WriteLine("bele bir ishci yoxdur");

                }
            }
            
        }
    }
}
