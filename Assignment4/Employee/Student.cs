using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;


namespace Employee
{
    public class Student
    {
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(int studId, string studName)
        {
            StudId = studId;
            StudName = studName;
        }
        public Student(int studId, string studName, int age)
        {
            StudId = studId;
            StudName = studName;
            Age = age;
        }
        public Student(string studName)
        {
            StudName = studName;
        }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
        public virtual void Calculate()
        {
            int total = (Maths + Science + English);
            Console.WriteLine("Total marks = " + total);
        }
    }
}