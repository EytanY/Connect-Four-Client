using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_Client.Model
{
    public enum COUNTRY
    {
        ISRAEL,
        USA,
        FRANCE,
        GERMANY,
        SPAIN,
        JAPAN,
        CHINA,
        RUSSIA,

    }
    public class Player : User
    {
        public string  FirstName { get; set; }  
        public string LastName { get; set; }
        public int Id { get; set; }

        public int GamesNum { get; set; }

        public COUNTRY Couunrty { get; set; }
        public string Phone { get; set; }



        public Player(string email, string pass, string firstName, string lastName, int id, COUNTRY couunrty, string phone): base(email, pass)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Couunrty = couunrty;
            Phone = phone;
            GamesNum = 0;
        }
        public Player(string email, string pass, string firstName, string lastName, int id, COUNTRY couunrty, string phone, int gameNum) : base(email, pass)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Couunrty = couunrty;
            Phone = phone;
            GamesNum = gameNum;
        }

        public int AddGame()
        {
            return GamesNum++;
        }
        
    }
}
