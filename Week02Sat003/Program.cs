//
using Week02Sat003;
using Week02Sat003.CoachTeam;
using System.Linq;

namespace Classes
{

    class Program
    {

        public static void Main(string[] args)
        {
            CoachDTO p1 = new CoachDTO("Coach01", "Addr1", 200, "Pos1", 5);
            CoachDTO p2 = new CoachDTO("Coach02", "Addr2", 300, "Pos2", 3);
            CoachDTO p3 = new CoachDTO("Coach03", "Addr3", 100, "Pos3", 1);

            CoachTeam team1 = new CoachTeam();
            team1.AddCoach(p1);
            team1.AddCoach(p2);
            team1.AddCoach(p3);

            team1.GetCoaches();

            Console.WriteLine($"Maxsalary is {team1.maxSalary().Salary}");


        }

    }

}