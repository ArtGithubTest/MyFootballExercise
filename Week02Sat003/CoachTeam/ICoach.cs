using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week02Sat003.FootballTeam;

namespace Week02Sat003.CoachTeam
{
    internal interface ICoach
    {
        List<CoachDTO> GetCoaches();

        void AddCoach(CoachDTO coachNr);

        CoachDTO maxSalary();
    }
}
