using PUBG_Recent_Games_Stats_Outputter.Stats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter
{
    public static class Output
    {

        public static void UpdateTextFile(bool verticalOutput, BaseStat statObj)
        {
            File.WriteAllText(statObj.TextFile, statObj.ToString());
        }
    }
}
