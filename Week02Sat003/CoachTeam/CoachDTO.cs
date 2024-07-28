using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Sat003.CoachTeam
{//Data Transform Object DTO
    internal class CoachDTO : SharedClass
    {
        public int YearsOfExperience { get; set; }

        public CoachDTO(string name, string address, double salary, string position, int yrsexp)
        {
            Name = name;
            Address = address;
            Salary = salary;
            Position = position;
            YearsOfExperience = yrsexp;
        }

            
    }
}
