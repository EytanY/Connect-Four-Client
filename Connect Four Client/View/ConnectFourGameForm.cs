//using Connect_Four_Client.DB;
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

namespace Connect_Four_Client
{
    public partial class ConnectFourGameForm : Form
    {
        Game Game{ get; set; }

        private const int ANIMATION_INTERVAL = 200; // Time interval for animation in milliseconds
        private const int ANIMATION_DISTANCE = 25; // Distance to move the ball in each interval
        private const int BALL_SIZE = 50;
        private bool IsAnimating { get; set; } // Indicates if a ball is currently being animated
        private int CurrentColumn { get; set; } // The column where the ball is being dropped
        private int CurrentRow { get; set; }

        private bool IsSuccess { get; set; } 
        private PlayerTool Winner { get; set; }
        private int AnimationPosition { get; set; } // Current position of the ball during animation

        private Timer AnimationTimer { get; set; }
        PlayerTool CurrentPlayer { get; set; }

        //private GameDataBaseDataContext gameDataBaseDataContext = new GameDataBaseDataContext();

        public ConnectFourGameForm()
        {
            InitializeComponent();
            
            Game = new Game(10);

            // save the new game id in data base with the player id
            // save in server

            //save in client
            //gameDataBaseDataContext.GameTbls.InsertOnSubmit(new GameTbl { Id=Game.Id });
            //gameDataBaseDataContext.SubmitChanges();

            CurrentPlayer = PlayerTool.YELLOW;
            this.DoubleBuffered = true;
            // Set up the animation timer
            AnimationTimer = new Timer();
            AnimationTimer.Interval = ANIMATION_INTERVAL;
            AnimationTimer.Tick += AnimationTimer_Tick;
        }

        private void ConnectFourGame_Load(object sender, EventArgs e)
        {
            this.GamePanel.Location = new Point(
                this.ClientSize.Width / 2 - this.GamePanel.Size.Width / 2,
                this.ClientSize.Height / 2 - this.GamePanel.Size.Height / 2);
            this.GamePanel.Anchor = AnchorStyles.None;
            this.GamePanel.Size = new Size(BALL_SIZE * ConnectFourGameBoard.COLUMNS_NUM, BALL_SIZE * ConnectFourGameBoard.COLUMNS_NUM);
            StopAnimation();
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

        private void GamePanel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Move the ball animation downwards
            AnimationPosition += ANIMATION_DISTANCE;

            // Check if the ball animation is complete
            if (AnimationPosition >= (CurrentRow * BALL_SIZE))
            {

                StopAnimation();
                // Item2 contain the winner if we have
                if (IsSuccess && Winner != PlayerTool.NONE)
                {
                    GamePanel.Invalidate();
                    // Initializes the variables to pass to the MessageBox.Show method.
                    
                    string message = "Winner is " + (Winner == PlayerTool.YELLOW ? "YOU!" : "Server");
                    if (Winner == PlayerTool.TIE)
                        message = "It is a TIE!";

                    string title = "The game is finised";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult dialogResult;

                    // Displays the MessageBox.
                    dialogResult = MessageBox.Show(message, title, buttons);
                    if (dialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                }
                if (IsSuccess)
                    ChangeCurrentPlayer();
            }
            // Redraw the game board with the updated animation position
            GamePanel.Invalidate();
        }
        private void GamePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsAnimating) return;

            
            int col = e.X / BALL_SIZE;
            if (Game.IsColumnAvailable(col))
            {

                int row = Game.GetNextAvailableRowByCol(col);
                Tuple<bool, PlayerTool> result = Game.UpdateBoard(row, col, CurrentPlayer);

                // For the animation
                IsSuccess = result.Item1;
                if(IsSuccess)
                {
                    Winner = result.Item2;
                    //Add Move to the database
                    //gameDataBaseDataContext.HistoryGameTbls.InsertOnSubmit(new HistoryGameTbl { GameId=Game.Id, MoveNumber=Game.Moves.Count, Row=Game.Moves.Last().Row, Col=Game.Moves.Last().Col, YellowTool=Game.Moves.Last().YelloTool});
                    //gameDataBaseDataContext.SubmitChanges();
                    
                    ActivateAnimation(row, col);
                    
                }


                // get request to the server

                // update the board based on the server response


                // save the move of the server


            }

        }

        private void ChangeCurrentPlayer()
        {
            if(CurrentPlayer == PlayerTool.YELLOW)
                CurrentPlayer = PlayerTool.RED;
            else // CurrentPlayer == PlayerTool.Red
                CurrentPlayer = PlayerTool.YELLOW;
            
        }

        private void ActivateAnimation(int row, int col)
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
