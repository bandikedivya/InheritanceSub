using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Employee;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Maths = 90;
            s.English = 80;
            s.Science = 70;
            s.Calculate();
            Employee emp = new Employee(101, "Rohit", 15000);
            emp.Calculate();
            Console.ReadLine();



        }
    }
}