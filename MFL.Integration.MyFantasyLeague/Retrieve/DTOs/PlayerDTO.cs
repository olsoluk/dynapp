using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Integration.MyFantasyLeague.Retrieve.DTOs
{
    internal class PlayerRetrieveResult
    {
        public PlayerResult Players { get; set; }
    }

    internal class PlayerResult
    {

        public int TimeStamp { get; set; }

        public List<PlayerDTO> Player { get; set; }
    }

    public class PlayerDTO
    {
        public int Id { get; set; }

        public string Position { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }

        //------ details -----------

        public string Weight { get; set; }

        public string Height { get; set; }

        public int BirthDate { get; set; }

        [JsonProperty("draft_year")]
        public string DraftYear { get; set; }

        [JsonProperty("draft_pick")]
        public string DraftPick { get; set; }

        [JsonProperty("draft_team")]
        public string DraftTeam { get; set; }

        public string College { get; set; }

        public string Jersey { get; set; }

        //------------IDS-----------

        [JsonProperty("rotoworld_id")]
        public string RotoWorldId { get; set; }

        [JsonProperty("nfl_id")]
        public string NflId { get; set; }

        [JsonProperty("draft_round")]
        public string DraftRound { get; set; }

        [JsonProperty("stats_id")]
        public string StatsId { get; set; }

        [JsonProperty("espn_id")]
        public string EspnId { get; set; }

        [JsonProperty("kffl_id")]
        public string KfflId { get; set; }

        [JsonProperty("fleaflicker_id")]
        public string FleaflickerId { get; set; }

        [JsonProperty("sportsdata_id")]
        public string SportsDataId { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("cbs_id")]
        public string CbsId { get; set; }
    }
}

//draft_team="NEP" 
//draft_pick="9" 
//college="LSU" 
//height="71"
//jersey="39"
//sportsdata_id="170b4c5f-a345-4899-8d81-e8982b0f3d65"
//twitter_username="StevanRidley" 
//cbs_id="1244982"