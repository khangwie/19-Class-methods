using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{
    internal class student
    {
        public double Weight;
        public string Name;
        public int Age;

        public student(double aWeight, string aName, int aAge)
        {
            this.Weight = aWeight;
            this.Name = aName;
            this.Age = aAge;
        }

        public bool IsObese()
        {
            if (Weight > 60)
            {
                return true;
            }
            else return false;

        }
    }
}
