using Connect_Four_Client.Model.Serialization;
using Connect_Four_Client.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model.HTTP
{
    public static class HttpClientServerRequest
    {
        private static HttpClient HttpClient { get; set; } = new HttpClient();
        private static bool IsHttpClientSet { get; set;} = false;
        private static void LoadHttpClient()
        {
            HttpClient.BaseAddress = new Uri("https://localhost:7114/");
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }
        public static async Task<PlayersTbl> GetPlayerAsync(string id)
        {
            if(!IsHttpClientSet)
            {
                LoadHttpClient();
                IsHttpClientSet = true;
            }

            PlayersTbl playersTbl = null;
            string path = "api/PlayersTbls/" + id;

            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                playersTbl = await response.Content.ReadAsAsync<PlayersTbl>();
            }
            return playersTbl;
        }
        public static async Task<Uri> CreateGameAsync(GamesTbl gamesTbl)
        {
            if (!IsHttpClientSet)
            {
                LoadHttpClient();
                IsHttpClientSet = true;
            }

            HttpResponseMessage response = await HttpClient.PostAsJsonAsync(
                "api/GamesTbls", gamesTbl);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public static async Task<GamesTbl> GetGameTblAsync(string id)
        {

            if (!IsHttpClientSet)
            {
                LoadHttpClient();
                IsHttpClientSet = true;
            }
            string path = "api/GamesTbls/" + id;
            GamesTbl gamesTbl = null;
            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                gamesTbl = await response.Content.ReadAsAsync<GamesTbl>();
            }
            return gamesTbl;
        }

        public static async Task<GamesTbl> UpdateGamesTblsAsync(GamesTbl gamesTbl)
        {

            if (!IsHttpClientSet)
            {
                LoadHttpClient();
                IsHttpClientSet = true;
            }
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync(
                $"api/GamesTbls/{gamesTbl.Id}", gamesTbl);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            gamesTbl = await response.Content.ReadAsAsync<GamesTbl>();
            return gamesTbl;


        }

        public static async Task<Move> PostGameBoardAndGetNextMoveAsync(ConnectFourGameBoard connectFourGameBoard)
        {

            if (!IsHttpClientSet)
            {
                LoadHttpClient();
                IsHttpClientSet = true;
            }

            SerialConnectFourGameBoard serialConnectFourGameBoard = new SerialConnectFourGameBoard(connectFourGameBoard);
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync(
        "api/ConnectFourGameBoard", serialConnectFourGameBoard);

            // check if the server return success response
            if (response.IsSuccessStatusCode)
            {

                Move move = await response.Content.ReadAsAsync<Move>();

                return move;
            }

            // return URI of the created resource.
            return null;
        }
    }
}
