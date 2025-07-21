using Newtonsoft.Json;
using PUBG_Recent_Games_Stats_Outputter.AccountID;
using PUBG_Recent_Games_Stats_Outputter.APISerialization;
using PUBG_Recent_Games_Stats_Outputter.APISerialization.Seasons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter
{
    public class JsonParser
    {
        public RootAccountIDObject SerializeAccountIDObject(string json)
        {
            return JsonConvert.DeserializeObject<AccountID.RootAccountIDObject>(json);
        }

        public RootSeasonData SerializeSeasonData(string json)
        {
            return JsonConvert.DeserializeObject<APISerialization.Seasons.RootSeasonData>(json);
        }

        public RootPlayerSeasonData SerializePlayerSeasonData(string json)
        {
            return JsonConvert.DeserializeObject<APISerialization.RootPlayerSeasonData>(json);
        }
    }
}
