using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.Stats.Last20
{
    public class Last20 : BaseStat
    {
        private string adr;
        private string survivedTime;
        private string fraggerRating;

        public string Adr { get => adr; set => adr = value; }
        public string SurvivedTime { get => survivedTime; set => survivedTime = value; }
        public string FraggerRating { get => fraggerRating; set => fraggerRating = value; }


        public Last20(string mode) : base(mode)
        {
            this.textFile = "Last20.txt";
        }

        public override string ToString()
        {
            return $"ADR: {adr} | Survived Time: {survivedTime} | Fragger Rating: {fraggerRating} | ";
        }
    }
}
