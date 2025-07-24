using PUBG_Recent_Games_Stats_Outputter.AccountID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter.APISerialization
{
    public class RootPlayerSeasonData
    {
        public PlayerSeasonData data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
    }

    public class PlayerSeasonData
    {
        public string type { get; set; }
        public PlayerSeasonAttributes attributes { get; set; }
        public Relationships relationships { get; set; }
    }

    public class PlayerSeasonAttributes
    {
        public GameModeStats gameModeStats { get; set; }
        public int bestRankPoint { get; set; }
    }

    public class GameModeStats
    {
        public GameStats duo { get; set; }
        public GameStats duo_fpp { get; set; }
        public GameStats solo { get; set; }
        public GameStats solo_fpp { get; set; }
        public GameStats squad { get; set; }
        public GameStats squad_fpp { get; set; }
    }

    public class GameStats
    {
        public int assists { get; set; }
        public int boosts { get; set; }
        public int dBNOs { get; set; }
        public int dailyKills { get; set; }
        public int dailyWins { get; set; }
        public double damageDealt { get; set; }
        public int days { get; set; }
        public int headshotKills { get; set; }
        public int heals { get; set; }
        public int killPoints { get; set; }
        public int kills { get; set; }
        public double longestKill { get; set; }
        public double longestTimeSurvived { get; set; }
        public int losses { get; set; }
        public int maxKillStreaks { get; set; }
        public double mostSurvivalTime { get; set; }
        public int rankPoints { get; set; }
        public string rankPointsTitle { get; set; }
        public int revives { get; set; }
        public double rideDistance { get; set; }
        public int roadKills { get; set; }
        public int roundMostKills { get; set; }
        public int roundsPlayed { get; set; }
        public int suicides { get; set; }
        public double swimDistance { get; set; }
        public int teamKills { get; set; }
        public double timeSurvived { get; set; }
        public int top10s { get; set; }
        public int vehicleDestroys { get; set; }
        public double walkDistance { get; set; }
        public int weaponsAcquired { get; set; }
        public int weeklyKills { get; set; }
        public int weeklyWins { get; set; }
        public int winPoints { get; set; }
        public int wins { get; set; }
    }

    public class Relationships
    {
        public MatchList matchesSoloFPP { get; set; }
        public MatchList matchesDuo { get; set; }
        public MatchList matchesDuoFPP { get; set; }
        public MatchList matchesSquad { get; set; }
        public MatchList matchesSquadFPP { get; set; }
        public MatchData season { get; set; }
        public MatchData player { get; set; }
        public MatchList matchesSolo { get; set; }
    }

    public class MatchList
    {
        public List<MatchItem> data { get; set; }
    }

    public class MatchItem
    {
        public string type { get; set; }
        public string id { get; set; }
    }




}
