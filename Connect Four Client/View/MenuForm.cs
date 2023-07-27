using Connect_Four_Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect_Four_Client.Model.Tables;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Connect_Four_Client.View;
using Connect_Four_Client.Services.DB;
using Connect_Four_Client.Model.HTTP;

namespace Connect_Four_Client
{

    public partial class MenuForm : Form
    {
        private HistoryGameDataBaseDataContext HistoryGameDataBaseDataContext = new HistoryGameDataBaseDataContext();
        private LoginForm LoginForm { get; set; }
        private HttpClient Client { get; set; }
        public MenuForm(Player player, LoginForm loginForm)
        {
            InitializeComponent();
            Player = player;
            LoginForm = loginForm;
            LoginForm.Hide();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://localhost:7114/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }


        private async void StartGameButton_Click(object sender, EventArgs e)
        {
            // send the info of the new game to the server 
            try
            {
                GamesTbl gameTbl = new GamesTbl
                {
                    PlayerId = Player.Id,
                    Date = DateTime.Now,
                    Winner = (int)PlayerTool.NONE
                };

                Uri url = await HttpClientServerRequest.CreateGameAsync(gameTbl);
                int GameId=Int32.Parse(url.Segments.LastOrDefault());
                Player.GamesNum++;
                Invalidate();
                new ConnectFourGameForm(GameId, Player).Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot send the new game to the server", "Error");
            }
            

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuForm_Load(object ObjectSender, EventArgs e)
        {
            FirstNameInputLbl.Text = Player.FirstName;
            LastNameInputLbl.Text = Player.LastName;
            IDInputLbl.Text = Player.Id + "";
            PhoneInputLbl.Text = Player.Phone;
            CountryInputLbl.Text = Enum.GetName(typeof(Country), Player.Counrty);
            GamesNumberInputLbl.Text = Player.GamesNum + "";

            

        }



        private void MenuForm_Paint(object sender, PaintEventArgs e)
        {
            GamesNumberInputLbl.Text = Player.GamesNum + "";
        }

        private async void ShowInformationButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> gamesId = HistoryGameDataBaseDataContext.HistoryGameTbls.Where(row => row.PlayerId == Player.Id).Select(row => row.GameId).Distinct().ToList();
                List<int> gamesInServerAndInClient = new List<int>();
                foreach (int gameId in gamesId)
                {
                    GamesTbl gamesTbl = await HttpClientServerRequest.GetGameTblAsync(gameId + "");
                    if (gamesTbl != null)
                    {
                        gamesInServerAndInClient.Add(gameId);
                    }
                }
                AllRecordedGamesForm allRecordedGamesForm = new AllRecordedGamesForm(gamesInServerAndInClient, Player);
                allRecordedGamesForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Show();
        }
    }
}
