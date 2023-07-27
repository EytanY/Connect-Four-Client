using Connect_Four_Client.Model;
using Connect_Four_Client.Model.HTTP;
using Connect_Four_Client.Model.Tables;
using Connect_Four_Client.Services.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four_Client.View
{
    public partial class AllRecordedGamesForm : Form
    {
        private List<int> AllGamesId { get; set; }
        private Player Player { get; set; }
        public AllRecordedGamesForm(List<int> allGamesId, Player player)
        {
            InitializeComponent();
            AllGamesId = allGamesId;
            Player = player;
            titleLbl.Text += $"{Player.FirstName} {Player.LastName} ID:{Player.Id}";
           

        }

        private async void RecordedGameButton_ClickAsync(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int gameId = (int)button.Tag;

            Game game = new Game(gameId, Player);
            // get from the server the game information
            GamesTbl gamesTbl = await HttpClientServerRequest.GetGameTblAsync(gameId+"");
            game.Date = gamesTbl.Date;
            game.Winner = (PlayerTool)Enum.ToObject(typeof(PlayerTool), gamesTbl.Winner);
            // get from the local DB the history moves
            HistoryGameDataBaseDataContext historyGameDataBaseDataContext = new HistoryGameDataBaseDataContext();
            var gamesMove = historyGameDataBaseDataContext.HistoryGameTbls.Where(row=> row.GameId == gameId).OrderBy(row=> row.MoveNum).ToList();
            PlayerTool playerTool;
            foreach ( var move in  gamesMove )
            {
               playerTool = move.YellowTool == 1 ? PlayerTool.YELLOW : PlayerTool.RED;
                game.Moves.Add(new Move(move.Row, move.Col, playerTool));
            }
            // Open the new form and pass the game 
            new RecordedConnectFourGameForm(game).Show();

        }
        private void AllRecordedGamesForm_Load(object ObjectSender, EventArgs e)
        {
            
            buttonsGamesPanel.AutoScroll = true;
            if (AllGamesId == null)
            {
                MessageBox.Show("Error with local DB");
                Close();
            }
            else
            {
                if (AllGamesId.Count == 0)
                {
                    buttonsGamesPanel.Controls.Add(new Label { Text = "The Player does'nt has recoreded games in this Local DB" });
                }
                // Create the game buttons dynamically
                int count = 40;
                foreach (var id in AllGamesId)
                {
                    var button = new Button
                    {
                        Text = $"Show Game {id}",
                        Tag = id,
                        Width = 100,
                        Height = 30,
                        Margin = new Padding(5),
                        Location = new Point(20, count)

                    };
                    count += 50;
                    button.Click += RecordedGameButton_ClickAsync;
                    buttonsGamesPanel.Controls.Add(button);
                }
            }
        }


    }
}
