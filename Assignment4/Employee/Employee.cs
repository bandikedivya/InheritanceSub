using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace Employee
{
    //public static void main(string[] args)
    //{ }
    public class Employee : Student
    {
        public int Empid { get; set; }
        public string Ename { get; set; }
        public double Sal { get; set; }

        public Employee(int empid, string studName, double sal) : base(studName)
        {
            Empid = empid;
            Ename = studName;
            Sal = sal;
        }
        public override void Calculate()
        {
            double HRA = 0, DA = 0, SA = 0;
            if (Sal > 10000 && Sal < 20000)
            {
                HRA = Sal * 0.1;
                DA = Sal * 0.05;
                SA = Sal * 0.1;
                double totalSalary = Sal + HRA + DA + SA;
                Console.WriteLine("Total Salary: " + totalSalary);
            }
            if (Sal > 20000 && Sal < 30000)
            {
                HRA = Sal * 0.12;
                DA = Sal * 0.07;
                SA = Sal * 0.12;
                double totalSalary = Sal + HRA + DA + SA;
                Console.WriteLine("Total Salary: " + totalSalary);
            }
        }
    }
}