using System.Collections.Generic;

namespace Week02Sat003.CoachTeam
{
    internal class CoachTeam : ICoach
    {
        private List<CoachDTO> coachList = new List<CoachDTO>();//global properties

        public void AddCoach(CoachDTO coachNr) { coachList.Add(coachNr); }

        public List<CoachDTO> GetCoaches() { return coachList; }

        public CoachDTO maxSalary() {
            var maxObject = coachList.OrderByDescending(x => x.Salary).First();   //Select(x => x.Salary);
            return maxObject;
        }
        //LINQ ,, FirstOrDefault, Take(nr),, Etc. (x=>x.AttributeOfObject) in the List of Objects
    }
}
