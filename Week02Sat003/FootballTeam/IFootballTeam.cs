using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Sat003.FootballTeam
{
    internal interface IFootballTeam
    {
        List<PlayerDTO> GetPlayers();

        void addPlayer(PlayerDTO player);

        List<PlayerDTO> sortByShirtNumber();

    }
}
