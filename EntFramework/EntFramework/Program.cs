using EntFramework.Controller;
using System;

namespace EntFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController emp = new EmployeeController();
            //emp.AddEmployee("Nargiz Bayramova");
            //emp.FilterByName("l");
            emp.DeleteEmployee(14);


        }
    }
}
