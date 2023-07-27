using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Connect_Four_Client.Model.Tables;

namespace Connect_Four_Client.API
{
    public static class PlayersAPI
    {
        static HttpClient client = new HttpClient();



        public static async Task<PlayersTbl> GetPlayerAsync(string id)
        {
            PlayersTbl playersTbl = null;
            InitClientBaseAddress();
            string path = "api/PlayersTbls/" + id;

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                playersTbl = await response.Content.ReadAsAsync<PlayersTbl>();
            }
            return playersTbl;
        }

        private static void InitClientBaseAddress()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:7114/" );
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
