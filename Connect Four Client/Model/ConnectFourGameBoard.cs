using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four_Client.Model
{

    public enum PlayerTool
    {
        RED,
        YELLOW,
        NONE
    }
    public class ConnectFourGameBoard
    {
        public const int ROWS_NUM = 6;
        public const int COLUMNS_NUM = 7;
        public const int CONNECT_NUM = 4;
        public PlayerTool[,] Board { get; set; }
        public ConnectFourGameBoard() {
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            /***
             * Initialize game board by PlayerTool.NONE 
             * ***/

            Board = new PlayerTool[ROWS_NUM, COLUMNS_NUM];
            for(int row = 0; row < ROWS_NUM; row ++)
            {
                for(int col = 0; col < COLUMNS_NUM; col ++)
                {
                    Board[row, col] = PlayerTool.NONE;
                }
            }
        }

        private bool IsIndexIsEmpty(int row, int col)
        {
            // check if the index if empty = PlayerTool.NONE
            if(row < 0 || col < 0 || col > COLUMNS_NUM - 1 || row > ROWS_NUM - 1 ) 
                return false;
            
            return Board[row, col] == PlayerTool.NONE;
        }

        private Tuple<bool, PlayerTool> UpdateBoard(int row, int col, PlayerTool playerTool)
        {
            // ***
            // The function update the game board and retrun Tuple<bool, PlayerTool>
            // If the update is successed the bool result in the Tuple will be true
            // If we have a winner in the game after the update the function will return the Player Tool, else it is return playerToo.None
            //

            if (playerTool == PlayerTool.NONE)
                return  Tuple.Create(false, PlayerTool.NONE); 
            
            if(IsIndexIsEmpty(row, col))
            {
                Board[row, col] = playerTool;
                if(IsWinner(row, col, playerTool))
                    return Tuple.Create(true, playerTool);
                else
                    return Tuple.Create(true, PlayerTool.NONE);
            }

            return Tuple.Create(false, PlayerTool.NONE);
        }

        private bool IsWinner(int row, int col, PlayerTool playerTool)
        {
            //The function will return if the player is a winner

            // check winner in rows
            if(IsWinnerInRows(row, col, playerTool))
                return true;
            // check winner in cols
            if (IsWinnerInCols(row, col, playerTool))
                return true;
            // check winner in diagonals
            if (IsWinnerInDiagonal(row, col, playerTool))
                return true;
            return false;

        }

        private bool IsWinnerInDiagonal(int row, int col, PlayerTool playerTool)
        {
            
            throw new NotImplementedException();
        }

        private bool IsWinnerInCols(int row, int col, PlayerTool playerTool)
        {
            throw new NotImplementedException();
        }

        private bool IsWinnerInRows(int row, int col, PlayerTool playerTool)
        {
            int counter = 0;
            for(int i=0; i < CONNECT_NUM; i ++)
            {
                if (col + i < COLUMNS_NUM && Board[row,col + i] == playerTool) 
                    counter += 1;
            }
            throw new NotImplementedException();
        }
    }
}
