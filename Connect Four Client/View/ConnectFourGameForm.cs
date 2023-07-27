using Connect_Four_Client.Services.DB;
using Connect_Four_Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect_Four_Client.Model.Tables;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Connect_Four_Client.Model.Serialization;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using Connect_Four_Client.Model.HTTP;

namespace Connect_Four_Client
{
    public partial class ConnectFourGameForm : Form
    {
        Game Game{ get; set; }
        Player Player { get; set; }
        public static int ANIMATION_INTERVAL = 150; // Time interval for animation in milliseconds
        public static int ANIMATION_DISTANCE = 25; // Distance to move the ball in each interval
        public static int BALL_SIZE = 50;
        private bool IsAnimating { get; set; } // Indicates if a ball is currently being animated
        private int CurrentColumn { get; set; } // The column where the ball is being dropped
        private int CurrentRow { get; set; }

        private bool IsSuccess { get; set; } 
        private PlayerTool Winner { get; set; }
        private int AnimationPosition { get; set; } // Current position of the ball during animation
        private bool IsGameOver { get; set; }
        private Timer AnimationTimer { get; set; }
        PlayerTool CurrentPlayer { get; set; }

        private HistoryGameDataBaseDataContext historyGameDataBaseDataContext = new HistoryGameDataBaseDataContext();

        private HttpClient Client { get; set; }
        public ConnectFourGameForm(int gameId, Player player)
        {
            InitializeComponent();
            // init the games / the game id is from the response of the server
            Game = new Game(gameId, player);
            Player = player;
            CurrentPlayer = PlayerTool.YELLOW;
            this.DoubleBuffered = true;
            // Set up the animation timer
            AnimationTimer = new Timer();
            AnimationTimer.Interval = ANIMATION_INTERVAL;
            AnimationTimer.Tick += AnimationTimer_Tick;
            // set GameOver to false
            IsGameOver = false;
            Client = new HttpClient();
        }

        private void ConnectFourGame_Load(object objectSender, EventArgs e)
        {
            this.GamePanel.Location = new Point(
                this.ClientSize.Width / 2 - this.GamePanel.Size.Width / 2,
                this.ClientSize.Height / 2 - this.GamePanel.Size.Height / 2);
            this.GamePanel.Anchor = AnchorStyles.None;
            this.GamePanel.Size = new Size(BALL_SIZE * ConnectFourGameBoard.COLUMNS_NUM, BALL_SIZE * ConnectFourGameBoard.COLUMNS_NUM);
            StopAnimation();


            // for the put and get requests
            Client.BaseAddress = new Uri("https://localhost:7114/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

        }

        private void ConnectFourGame_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int row = 0; row < ConnectFourGameBoard.ROWS_NUM; row++)
            {
                for (int col = 0; col < ConnectFourGameBoard.COLUMNS_NUM; col++)
                {
                    PlayerTool value = Game.GameBoard.Board[row, col];
                    Brush brush = value == PlayerTool.RED ? Brushes.Red : (value == PlayerTool.YELLOW ? Brushes.Yellow : Brushes.White);
                    if (CurrentRow == row && CurrentColumn == col) // print empty cell
                        g.FillEllipse(Brushes.White, col * BALL_SIZE, row * BALL_SIZE, BALL_SIZE, BALL_SIZE);

                    else
                        g.FillEllipse(brush, col * BALL_SIZE, row * BALL_SIZE, BALL_SIZE, BALL_SIZE);

                    g.DrawEllipse(Pens.Black, col * BALL_SIZE, row * BALL_SIZE, BALL_SIZE, BALL_SIZE);

                }
            }
            // the animation
            if(CurrentColumn != -1)
            {
                Brush brush = CurrentPlayer == PlayerTool.RED ? Brushes.Red :  Brushes.Yellow;
                g.FillEllipse(brush, CurrentColumn * BALL_SIZE, AnimationPosition , BALL_SIZE, BALL_SIZE);
                g.DrawEllipse(Pens.Black, CurrentColumn * BALL_SIZE, AnimationPosition, BALL_SIZE, BALL_SIZE);

            }

        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Move the ball animation downwards
            AnimationPosition += ANIMATION_DISTANCE;

            // Check if the ball animation is complete
            if (AnimationPosition >= (CurrentRow * BALL_SIZE))
            {

                StopAnimation();
                // Item2 contain the winner if we have
                if (!IsGameOver && IsSuccess && Winner != PlayerTool.NONE)
                {
                    IsGameOver = true;
                    GamePanel.Invalidate();
                    // Initializes the variables to pass to the MessageBox.Show method.

                    string message = "Winner is " + (Winner == PlayerTool.YELLOW ? "YOU!" : "Server");
                    if (Winner == PlayerTool.TIE)
                        message = "It is a TIE!";

                    string title = "The game is finised";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult dialogResult;

                    // post the winner in the game
                    try
                    {
                        await HttpClientServerRequest.UpdateGamesTblsAsync(new GamesTbl { Id = Game.Id, PlayerId = Player.Id, Date = Game.Date, Winner = (int)Winner });
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error with save the winner in the server", "Error");
                    }

                    // Displays the Winner.
                    dialogResult = MessageBox.Show(message, title, buttons);
                    if (dialogResult == DialogResult.OK)
                    {
                        // Closes the parent form.
                        this.Close();
                    }


                }
                if(CurrentPlayer == PlayerTool.YELLOW)
                {
                    ChangeCurrentPlayer();
                    ServerMove();
                }
                else
                {
                    ChangeCurrentPlayer();
                }
               
                
            }
            // Redraw the game board with the updated animation position
            GamePanel.Invalidate();
        }

        private async void ServerMove()
        {
            // server trun
            try
            {
                //post request to the server
                Move move = await HttpClientServerRequest.PostGameBoardAndGetNextMoveAsync(Game.GameBoard);
                if (move != null && !IsGameOver)
                {
                    ActivateClientAnimation(move.Row, move.Col);
                    Tuple<bool, PlayerTool> result = Game.UpdateBoard(move.Row, move.Col, CurrentPlayer);

                    // activate annimation of the client move
                    ActivateClientAnimation(move.Row, move.Col);
                    //save the move in database
                    SaveMoveInHistory(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message);

            }
        }
        private  void GamePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsAnimating) return;

            
            int col = e.X / BALL_SIZE;
            if (Game.IsColumnAvailable(col))
            {

                int row = Game.GetNextAvailableRowByCol(col);
                Tuple<bool, PlayerTool> result = Game.UpdateBoard(row, col, CurrentPlayer);

                // activate annimation of the client move
                ActivateClientAnimation(row, col);
                //save the move in database
                SaveMoveInHistory(result);

            }
        }
        private void SaveMoveInHistory(Tuple<bool, PlayerTool> result)
        {
            // For the animation
            IsSuccess = result.Item1; // return if the board was updated 
            if (IsSuccess)
            {
                Winner = result.Item2; // return the winner if we have, or return TIE/NONE
                //Add Move to the database
                historyGameDataBaseDataContext.HistoryGameTbls.InsertOnSubmit(new HistoryGameTbl { PlayerId = Player.Id, GameId = Game.Id, MoveNum = Game.Moves.Count, Row = Game.Moves.Last().Row, Col = Game.Moves.Last().Col, YellowTool = Game.Moves.Last().YelloTool });
                historyGameDataBaseDataContext.SubmitChanges();   
            }
        }
        private void ChangeCurrentPlayer()
        {
            if(CurrentPlayer == PlayerTool.YELLOW)
                CurrentPlayer = PlayerTool.RED;
            else // CurrentPlayer == PlayerTool.Red
                CurrentPlayer = PlayerTool.YELLOW;
            
        }

        private void ActivateClientAnimation(int row, int col)
        {
            CurrentColumn = col;
            CurrentRow = row;
            AnimationTimer.Start();
            IsAnimating = true;
            AnimationPosition = 0;
        }

        private void StopAnimation()
        {
            // Stop the animation
            AnimationTimer.Stop();
            IsAnimating = false;
            // Reset the Current Row and CurrentCol
            CurrentRow = -1;
            CurrentColumn = -1;
            AnimationPosition = 0;
        }
    }

    

}
