using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Sat003.FootballTeam
{
    internal class FootballTeam :IFootballTeam
    {
        List<PlayerDTO> playerList = new List<PlayerDTO>();

        List<PlayerDTO> IFootballTeam.GetPlayers()
        {
            return playerList;
        }

        public void addPlayer(PlayerDTO player)
        {
            playerList.Add(player);
        }

        public List<PlayerDTO> sortByShirtNumber()
        {
            var data = playerList.OrderBy(x => x.ShirtNumber).ToList();
            return data;
        }


    }
}
