using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student(70, "John", 15);
            student student2 = new student(40, "Tim", 10);

            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());

            Console.ReadLine();
        }
    }
}
