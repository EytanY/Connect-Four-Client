using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model
{
    public class Move
    {
        public int Row { get; set; }    
        public int Col { get; set; }
        public int YelloTool { get; set; }


        public Move(int row, int col, PlayerTool playerTool)
        {
            Row = row;
            Col = col;
            YelloTool = playerTool == PlayerTool.YELLOW ? 1 : 0;
        }

        public Move(int row, int col, int yellowTool)
        {
            Row = row;
            Col = col;
            YelloTool = yellowTool;
        }

    }
}
