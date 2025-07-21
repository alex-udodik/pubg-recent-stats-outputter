using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.Stats.LastGame
{
    public class LastGame : BaseStat
    {

        public string textFile = "LastGame.txt";
        private string adr;
        private string survivedTime;
        private string kills;
        private string placement;

        public string Adr { get => adr; set => adr = value; }
        public string SurvivedTime { get => survivedTime; set => survivedTime = value; }
        public string Kills { get => kills; set => kills = value; }
        public string Placement { get => placement; set => placement = value; }

        public LastGame(string mode) : base(mode) { }

        public override string ToString()
        {
            return $"ADR: {adr} | Survived Time: {survivedTime} | Kills: {kills} | Placement: {placement} | ";

        }
    }
}
