using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model.Tables
{
    public class GamesTbl
    {
        
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public DateTime Date { get; set; }
        public int Winner { get; set; }
    }
}
