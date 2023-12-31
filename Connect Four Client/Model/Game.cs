﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model
{
    public class Game
    {
        public ConnectFourGameBoard GameBoard { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public List<Move> Moves { get; set; }
        public Player Player { get; set; }
        public PlayerTool Winner { get; set; }

        public Game(int id, Player player)
        {
            GameBoard = new ConnectFourGameBoard();
            Date = DateTime.Now;
            Moves = new List<Move>();
            Id = id;
            Player = player;
            Winner = PlayerTool.NONE;
        }

        public Tuple<bool, PlayerTool> UpdateBoard(int row, int col, PlayerTool playerTool)
        {
            Tuple<bool, PlayerTool> result =  GameBoard.UpdateBoard(row, col, playerTool);
            if (result.Item1) // the update was success
            {
                // add the new move to moves history
                Moves.Add(new Move(row, col, playerTool));
                
            }
            return result;
        }

        public int GetNextAvailableRowByCol(int col)
        {
            return GameBoard.GetNextAvailableRowByCol(col);
        }


        public bool IsColumnAvailable(int col)
        {
            return GameBoard.IsColumnAvailable(col);
        }







    }
}
