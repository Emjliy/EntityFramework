using EntFramework.DataAccess;
using EntFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntFramework.Controller
{
    class EmployeeController
    {
        private readonly AppDbContext _context;
        public EmployeeController()//database obyektini yaratmaq
        {
            _context = new AppDbContext();
        }
        public  List<Employee> GetAll()
        {
            return _context.employees.ToList();
        }
        public void GetEmpById(int id)
        {
            Employee emp = _context.employees.Find(id);
            if (emp == null)
            {
                Console.WriteLine("not found");
                return;
            }
            Console.WriteLine(emp.Name);
        }

        public void AddEmployee(string name)
        {
            Employee emp = new Employee { Name = name };
            _context.employees.Add(emp);
            _context.SaveChanges();
            Console.WriteLine($"{name}  added");
        }
        public void DeleteEmployee(int id)
        {
            Employee emp = _context.employees.Find(id);
            if (emp == null)
            {
                Console.WriteLine("not found");
                return;
            }
            _context.employees.Remove(emp);
            _context.SaveChanges();
            Console.WriteLine($"{id} deleted");
        }
        public void FilterByName(string exist)
        {
            List<Employee> employees = _context.employees.ToList();
            bool isExist = true;
            foreach (var item in employees)
            {
                if (item.Name.ToLower().Contains(exist) || item.Name.ToUpper().Contains(exist))
                {
                    Console.WriteLine(item.Name);
                    isExist = false;
                }
            }
            if (isExist)
            {
                Console.WriteLine("not exist");
            }
        }
    }
}