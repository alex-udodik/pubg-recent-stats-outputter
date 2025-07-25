using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.Stats.CurrentSeason
{
    public class CurrentSeason : BaseStat
    {
        private string adr;
        private string survivedTime;
        private string fraggerRating;
        private string winRate;

        public string Adr { get => adr; set => adr = value; }
        public string SurvivedTime { get => survivedTime; set => survivedTime = value; }
        public string FraggerRating { get => fraggerRating; set => fraggerRating = value; }
        public string WinRate { get => winRate; set => winRate = value; }

        public CurrentSeason(string mode) : base(mode)
        {
            this.textFile = "currentSeason.txt";
        }

        public override string ToString()
        {
            return $"ADR: {adr} | Survived Time: {survivedTime} | Fragger Rating: {fraggerRating} | Win Rate: {winRate} | ";        
        }

        

    }
}
