using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Sat003.FootballTeam
{
    internal class PlayerDTO: SharedClass
    {
        public int ShirtNumber { get; set; }

        public PlayerDTO(string code, string name, string address, double salary, string position, int shirtnr)
        {
            Code = code;
            Name = name;
            Address = address;
            Salary = salary;
            Position = position;
            ShirtNumber = shirtnr;
        }
    }
}
