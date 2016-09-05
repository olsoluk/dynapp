using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Integration.MyFantasyLeague.Retrieve.DTOs
{
    internal class MultiPlayerDetailResult
    {
        public List<PlayerDetailResult> PlayerProfiles { get; set; }
    }

    internal class PlayerDetailResult
    {
        public PlayerDetailDTO PlayerProfile { get; set; }

    }

    public class PlayerDetailDTO
    {
        public string Name { get; set; }

        public PlayerNewsDTO News { get; set; }

        [JsonProperty("player")]
        public PlayerInfoDTO Info { get; set; }
    }

    public class PlayerInfoDTO
    {
        public string Dob { get; set; }
        public string Adp { get; set; }

        public string Weight { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }
    }

    public class PlayerNewsDTO
    {
        [JsonProperty("article")]
        public List<ArticleDTO> Articles { get; set; }

    }

    public class ArticleDTO
    {
        public string Published { get; set; }
        [JsonProperty("id")]
        public string Link { get; set; }
        public string Headline { get; set; }

    }
}
