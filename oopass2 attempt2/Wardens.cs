using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopass2_attempt2
{
    internal class Wardens : HumansAtThePrison
    {
        private string shift;
        private double salary;
        public Wardens(string name, int age, string shift, double salary) : base(name, age)
        {
            this.shift = shift;
            this.salary = salary;   
        }
        public string Shift()
        {
            return shift;
        }
        public double getSalary()
        {
           return salary;
        }
    }
}
