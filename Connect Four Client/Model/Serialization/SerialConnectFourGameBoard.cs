using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model.Serialization
{
    public class SerialConnectFourGameBoard
    {
        [JsonProperty]
        private int CountUpdate { get; set; }
        [JsonProperty]
        public int[] Board { get; set; }

        [JsonConstructor]
        public SerialConnectFourGameBoard(int countUpdate, int[] board) {
            CountUpdate = countUpdate;
            Board = board;
        }

        public SerialConnectFourGameBoard() { 
        }
        public SerialConnectFourGameBoard(ConnectFourGameBoard connectFourGameBoard)
        {
            CountUpdate = connectFourGameBoard.CountUpdate;
            Board = new int[ConnectFourGameBoard.ROWS_NUM * ConnectFourGameBoard.COLUMNS_NUM];
            for (int i = 0; i < ConnectFourGameBoard.ROWS_NUM; i++)
            {
                for (int j = 0; j < ConnectFourGameBoard.COLUMNS_NUM; j++)
                {
                    Board[i * ConnectFourGameBoard.COLUMNS_NUM + j] = (int)connectFourGameBoard.Board[i, j];
                }
            }
        }

        public ConnectFourGameBoard GetConnectFourGameBoard()
        {
            ConnectFourGameBoard connectFourGameBoard = new ConnectFourGameBoard();
            connectFourGameBoard.CountUpdate = CountUpdate;
            for (int i = 0; i < ConnectFourGameBoard.ROWS_NUM; i++)
            {
                for (int j = 0; j < ConnectFourGameBoard.COLUMNS_NUM; j++)
                {
                    connectFourGameBoard.Board[i, j] = (PlayerTool)Enum.ToObject(typeof(PlayerTool), Board[i * ConnectFourGameBoard.COLUMNS_NUM + j]);
                }
            }
            return connectFourGameBoard;

        }
    }
}
