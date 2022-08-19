using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopass2_attempt2
{
    internal class HumansAtThePrison
    {
        private string name;
        private int age;

        public HumansAtThePrison(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }
    }
}
