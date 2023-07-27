using Connect_Four_Client.Model;
using Connect_Four_Client.Model.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four_Client.View
{
    public partial class RecordedConnectFourGameForm : Form
    {
        private Game Game { get; set; }
        private int CurrentRow { get; set; }
        private int CurrentColumn { get; set; }
        private int AnimationPosition { get; set; } 
        private int CurrentMove { get; set; }
        private bool IsGameOver { get; set; }
        private Timer AnimationTimer { get; set; }
        private PlayerTool CurrentPlayer;
        public RecordedConnectFourGameForm(Game game)
        {
            InitializeComponent();
            // init Game Board
            Game = game;
            CurrentRow = -1;
            CurrentColumn = -1;
            CurrentMove = 0;
            AnimationPosition = 0;
            CurrentPlayer = (PlayerTool)Enum.ToObject(typeof(PlayerTool), Game.Moves.ElementAt(CurrentMove).YelloTool);
            this.DoubleBuffered = true;
            // Set up the animation timer
            AnimationTimer = new Timer();
            AnimationTimer.Interval = ConnectFourGameForm.ANIMATION_INTERVAL;
            AnimationTimer.Tick += AnimationTimer_Tick;
            // set GameOver to false
            IsGameOver = false;
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
                        g.FillEllipse(Brushes.White, col * ConnectFourGameForm.BALL_SIZE, row * ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE);

                    else
                        g.FillEllipse(brush, col * ConnectFourGameForm.BALL_SIZE, row * ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE);

                    g.DrawEllipse(Pens.Black, col * ConnectFourGameForm.BALL_SIZE, row * ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE);

                }
            }
            // the animation
            if (CurrentColumn != -1)
            {
                Brush brush = CurrentPlayer == PlayerTool.RED ? Brushes.Red : Brushes.Yellow;
                g.FillEllipse(brush, CurrentColumn * ConnectFourGameForm.BALL_SIZE, AnimationPosition, ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE);
                g.DrawEllipse(Pens.Black, CurrentColumn * ConnectFourGameForm.BALL_SIZE, AnimationPosition, ConnectFourGameForm.BALL_SIZE, ConnectFourGameForm.BALL_SIZE);

            }
        }

        private void RecordedConnectFourGameForm_Load(object sender, EventArgs e)
        {

            GameIdInputLbl.Text = Game.Id + "";
            GameDateLbl.Text = Game.Date.ToString();
            GameWinnerInputLbl.Text = Enum.GetName(typeof(PlayerTool), Game.Winner);

        }

        private  void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Move the ball animation downwards
            AnimationPosition += ConnectFourGameForm.ANIMATION_DISTANCE;
            // Check if the ball animation is complete
            
            if (AnimationPosition >= (CurrentRow * ConnectFourGameForm.BALL_SIZE))
            {
                if (CurrentMove == Game.Moves.Count)
                {
                    CurrentColumn = -1;
                    CurrentRow = -1;
                    AnimationPosition = 0;
                    AnimationTimer.Stop();
                    IsGameOver = true;
                    GamePanel.Invalidate();
                    //Displays the Winner.
                    MessageBox.Show("Winner is " + Enum.GetName(typeof(PlayerTool), Game.Winner), "The game is finised");
                    return;
                }
                AnimationTimer.Stop();
                // reset animation and do the next move
                Move move = Game.Moves.ElementAt(CurrentMove);
                //MessageBox.Show($"{CurrentRow} {CurrentColumn} {CurrentPlayer}");
                CurrentColumn = move.Col;
                CurrentRow = move.Row;
                CurrentPlayer = move.YelloTool == 1? PlayerTool.YELLOW : PlayerTool.RED;
                Game.GameBoard.Board[CurrentRow, CurrentColumn] = CurrentPlayer;
                AnimationPosition = 0;
                CurrentMove += 1;
                AnimationTimer.Start();





            }
            // Redraw the game board with the updated animation position
            GamePanel.Invalidate();
        }

        private void startRecordedGameBtn_Click(object sender, EventArgs e)
        {
            AnimationTimer.Start();

        }

        private void RecordedConnectFourGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnimationTimer.Stop();
        }
    }
}
