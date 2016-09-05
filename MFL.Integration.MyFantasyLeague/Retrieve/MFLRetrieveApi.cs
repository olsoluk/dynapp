using MFL.Integration.MyFantasyLeague.Retrieve.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Web.Http;

namespace MFL.Integration.MyFantasyLeague.Retrieve
{
    public static class MFLClientApi
    {
        private static string _urlFormat = "http://www03.myfantasyleague.com/2016/export?JSON=1&TYPE={0}{1}";

        //private static string _leagueWeekFormat = "&L={1}&W={2}";

        public async static Task<IEnumerable<PlayerDTO>> GetPlayers(bool details)
        {
            var url = string.Format(_urlFormat, "players", details ? "&DETAILS=1" : string.Empty);

            var des = await GetAndDeserialize<PlayerRetrieveResult>(url);

            return des.Players.Player;
        }
       
        public async static Task<IEnumerable<PlayerDetailDTO>> GetPlayerInfo(IEnumerable<int> playerIds)
        {
            var url = string.Format(_urlFormat, "playerProfile", string.Format("&PLAYERS={0}", string.Join(",", playerIds)));

            if (playerIds.Count() > 1)
            {
                var des = await GetAndDeserialize<MultiPlayerDetailResult>(url);

                return des.PlayerProfiles.Select(p => p.PlayerProfile);
            }
            else
            {
                var des = await GetAndDeserialize<PlayerDetailResult>(url);

                return new PlayerDetailDTO[] { des.PlayerProfile };
            }
        }

        private async static Task<T> GetAndDeserialize<T>(string url)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(new Uri(url));

            var result = await response.Content.ReadAsStringAsync();

            var des = JsonConvert.DeserializeObject<T>(result);

            return des;
        }
    }
}
