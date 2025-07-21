using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PUBG_Recent_Games_Stats_Outputter
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GameMode
    {
        [EnumMember(Value = "solo")]
        Solo,

        [EnumMember(Value = "solo-fpp")]
        SoloFpp,

        [EnumMember(Value = "duo")]
        Duo,

        [EnumMember(Value = "duo-fpp")]
        DuoFpp,

        [EnumMember(Value = "squad")]
        Squad,

        [EnumMember(Value = "squad-fpp")]
        SquadFpp
    }
}
