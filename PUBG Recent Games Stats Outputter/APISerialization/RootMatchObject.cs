using System;
using System.Collections.Generic;
using System.Text.Json;

namespace PUBG_Recent_Games_Stats_Outputter.APISerialization
{
    public class MatchRoot
    {
        public MatchData Data { get; set; }
        public List<IncludedObject> Included { get; set; }
        public MatchLinks Links { get; set; }
    }

    public class MatchData
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public MatchAttributes Attributes { get; set; }
        public MatchRelationships Relationships { get; set; }
    }

    public class MatchAttributes
    {
        public string MapName { get; set; }
        public int Duration { get; set; }
        public string GameMode { get; set; }
        public string TitleId { get; set; }
        public string ShardId { get; set; }
        public bool IsCustomMatch { get; set; }
        public string CreatedAt { get; set; }
        public string SeasonState { get; set; }
        public string MatchType { get; set; }
    }

    public class MatchRelationships
    {
        public RelationshipList Rosters { get; set; }
        public RelationshipList Assets { get; set; }
    }

    public class RelationshipList
    {
        public List<RelationshipData> Data { get; set; }
    }

    public class RelationshipData
    {
        public string Type { get; set; }
        public string Id { get; set; }
    }

    public class IncludedObject
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public IncludedAttributes Attributes { get; set; }
        public IncludedRelationships Relationships { get; set; }
    }
    public class IncludedAttributes
    {
        public string ShardId { get; set; }
        public string Actor { get; set; }  // Some include this
        public PlayerStats Stats { get; set; }
    }
    public class PlayerStats
    {
        public int DBNOs { get; set; }
        public int Assists { get; set; }
        public int Boosts { get; set; }
        public float DamageDealt { get; set; }
        public string DeathType { get; set; }
        public int HeadshotKills { get; set; }
        public int Heals { get; set; }
        public int KillPlace { get; set; }
        public int KillStreaks { get; set; }
        public int Kills { get; set; }
        public float LongestKill { get; set; }
        public string Name { get; set; }
        public string PlayerId { get; set; }
        public int Revives { get; set; }
        public float RideDistance { get; set; }
        public int RoadKills { get; set; }
        public float SwimDistance { get; set; }
        public int TeamKills { get; set; }
        public float TimeSurvived { get; set; }
        public int VehicleDestroys { get; set; }
        public float WalkDistance { get; set; }
        public int WeaponsAcquired { get; set; }
        public int WinPlace { get; set; }
    }
    public class IncludedRelationships
    {
        public RelationshipList Participants { get; set; }
        public object Team { get; set; }  // Often null
    }
    public class MatchLinks
    {
        public string Self { get; set; }
        public string Schema { get; set; }
    }

}
