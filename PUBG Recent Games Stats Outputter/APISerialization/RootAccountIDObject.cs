using PUBG_Recent_Games_Stats_Outputter.APISerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.AccountID
{
    public class RootAccountIDObject
    {
        public List<Data> data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
    }

    public class Relationships
    {
        public Assets assets { get; set; }
        public MatchList matches { get; set; }
    }

    public class Meta
    {
        public object obj { get; set; }
    }


    public class Links
    {
        public string self { get; set; }
        public string schema { get; set; }
    }



    public class Data
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }

        public Relationships relationships { get; set; }
        public Links links { get; set; }
    }

    public class Attributes
    {
        public string patchVersion { get; set; }
        public string name { get; set; }
        public object stats { get; set; }
        public string titleId { get; set; }
        public string shardId { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class Assets
    {
        public List<Data> data { get; set; }
    }
}
