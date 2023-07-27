using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model
{
    public class Player 
    {
        public string  FirstName { get; set; }  
        public string LastName { get; set; }
        public int Id { get; set; }

        public int GamesNum { get; set; }

        public string Phone { get; set; }

        public Country Counrty { get; set; }

        public Player(string firstName, string lastName, int id, Country couunrty, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Counrty = couunrty;
            Phone = phone;
            GamesNum = 0;
        }
        public Player(string firstName, string lastName, int id, Country counrty, string phone, int gameNum) 
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Counrty = counrty;
            Phone = phone;
            GamesNum = gameNum;
        }

        public int AddGame()
        {
            return GamesNum++;
        }
        
    }
}
