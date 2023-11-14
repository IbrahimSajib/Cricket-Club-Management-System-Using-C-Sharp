using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_Club_Management_System.Models
{
    public enum Role_Type
    {
        Batter = 1,
        Bowler,
        Wicket_Keeper,
        All_Rounder
    }

    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public Role_Type Role { get; set; }
        public string Country { get; set; }
    }

    public static class PlayerDB
    {
        public static List<Player> PlayerList = new List<Player>()
        {
            new Player(){PlayerId=1,PlayerName="Nitish Rana",Age=29, Role=Role_Type.Batter,Country="India"},
            new Player(){PlayerId=2,PlayerName="Rinku Singh",Age=26, Role = Role_Type.Batter, Country="India"},
            new Player(){PlayerId=3,PlayerName="Sakib Al Hasan",Age=36, Role = Role_Type.All_Rounder, Country="Bangladesh"},
            new Player(){PlayerId=4,PlayerName="Ankul Roy",Age=24, Role = Role_Type.All_Rounder, Country="India"},
            new Player(){PlayerId=5,PlayerName="Aarya Desai",Age=20, Role = Role_Type.Batter, Country="India"},
            new Player(){PlayerId=6,PlayerName="Andre Russell",Age=35, Role = Role_Type.All_Rounder, Country="West Indies"},
            new Player(){PlayerId=7,PlayerName="David Wiese",Age=38, Role = Role_Type.All_Rounder, Country="Namibia"},
            new Player(){PlayerId=8,PlayerName="Harshit Rana",Age=21, Role = Role_Type.Bowler, Country="India"},
            new Player(){PlayerId=9,PlayerName="Jason Roy ",Age=33, Role = Role_Type.Batter, Country="England"},
            new Player(){PlayerId=10,PlayerName="Johnson Charles",Age=34, Role = Role_Type.Batter, Country="West Indies"},
            new Player(){PlayerId=11,PlayerName="Kulwant Khejroliya",Age=31, Role = Role_Type.Bowler, Country="India"},
            new Player(){PlayerId=12,PlayerName="Lockie Ferguson",Age=32, Role = Role_Type.Bowler, Country="New Zealand"},
            new Player(){PlayerId=13,PlayerName="Mandeep Singh",Age=31, Role = Role_Type.Batter, Country="India"},
            new Player(){PlayerId=14,PlayerName="Litton Das",Age=29, Role = Role_Type.Wicket_Keeper, Country="Bangladesh"},
            new Player(){PlayerId=15,PlayerName="Narayan Jagadeesan",Age=27, Role = Role_Type.Wicket_Keeper, Country="India"},
            new Player(){PlayerId=16,PlayerName="Rahmanullah Gurbaz",Age=21, Role = Role_Type.Wicket_Keeper, Country="Afghanistan"},
            new Player(){PlayerId=17,PlayerName="Shardul Thakur",Age=32, Role = Role_Type.All_Rounder, Country="India"},
            new Player(){PlayerId=18,PlayerName="Shreyas Iyer",Age=28, Role = Role_Type.Batter, Country="India"},
            new Player(){PlayerId=19,PlayerName="Sunil Narine",Age=35, Role = Role_Type.All_Rounder, Country="West Indies"},
            new Player(){PlayerId=20,PlayerName="Suyash Sharma",Age=20, Role = Role_Type.Bowler, Country="India"},
            new Player(){PlayerId=21,PlayerName="Tim Southee",Age=34, Role = Role_Type.Bowler, Country="New Zealand"},
            new Player(){PlayerId=22,PlayerName="Umesh Yadav",Age=36, Role = Role_Type.Bowler, Country="India"},
            new Player(){PlayerId=23,PlayerName="Vaibhab Arora ",Age=25, Role = Role_Type.Bowler, Country="India"},
            new Player(){PlayerId=24,PlayerName="Varun Chakravarthy",Age=32, Role = Role_Type.Bowler, Country="India"},
            new Player(){PlayerId=25,PlayerName="Venkatesh Iyer",Age=28, Role = Role_Type.All_Rounder, Country="India"},
        };
    }

}
