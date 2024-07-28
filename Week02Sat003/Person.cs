using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Sat003
{
    internal class Person: SharedClass
    {
        public Person(string name, string address, double salary, string position)
        {
            this.Name = name;
            this.Address = address;
            this.Salary = salary;
            this.Position = position;
        }
    }
}
