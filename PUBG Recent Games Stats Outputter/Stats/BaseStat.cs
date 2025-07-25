using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.Stats
{
    public abstract class BaseStat
    {
        protected GameMode mode;
        protected string textFile;
        protected BaseStat(string modeString)
        {
            mode = ParseGameMode(modeString);
        }

        private GameMode ParseGameMode(string value)
        {
            foreach (GameMode gm in Enum.GetValues(typeof(GameMode)))
            {
                var member = typeof(GameMode).GetMember(gm.ToString()).First();
                var attr = member.GetCustomAttribute<EnumMemberAttribute>();
                if (attr != null && attr.Value == value)
                    return gm;
            }

            throw new ArgumentException($"Invalid GameMode: {value}");
        }

        public string TextFile => textFile; // read-only public access if needed
    }
}
