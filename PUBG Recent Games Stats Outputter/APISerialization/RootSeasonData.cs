using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.APISerialization.Seasons
{
    public class RootSeasonData
    {
        public List<SeasonData> data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
    }

    public class SeasonData
    {
        public string type { get; set; }
        public string id { get; set; }
        public SeasonAttributes attributes { get; set; }
    }

    public class SeasonAttributes
    {
        public bool isCurrentSeason { get; set; }
        public bool isOffseason { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class Meta
    {
        // Currently empty — add fields here if needed
    }

}
