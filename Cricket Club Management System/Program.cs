using Cricket_Club_Management_System.Models;
using Cricket_Club_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_Club_Management_System
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("=================================================================================================================");
            Console.WriteLine("==================================  Welcome to Cricket Club Management System  ==================================");
            Console.WriteLine("=================================================================================================================");
            DisplayOption();

            Console.ReadKey();
        }


        public static void DisplayOption()
        {
            Console.WriteLine("=>");
            Console.WriteLine("1. Display Club Information");
            Console.WriteLine("=>");
            Console.WriteLine("2. Show All Player");
            Console.WriteLine("3. Insert Player");
            Console.WriteLine("4. Update Player");
            Console.WriteLine("5. Delete Player");
            Console.WriteLine("=>");
            Console.WriteLine("6. Show All SupportStuff");
            Console.WriteLine("7. Insert SupportStuff");
            Console.WriteLine("8. Update SupportStuff");
            Console.WriteLine("9. Delete SupportStuff");
            Console.WriteLine();

            var index = int.Parse(Console.ReadLine());
            Show(index);
        }


        public static void Show(int index)
        {
            PlayerRepository playerRepository = new PlayerRepository();
            SupportStuffRepository supportStuffRepository = new SupportStuffRepository();

            //Index 1 for display Club Information
            if (index == 1)
            {
                    Console.WriteLine("================================================ Club Information ===============================================");
                Console.WriteLine("ClubName = "+ClubInfo.ClubName);
                Console.WriteLine("Location = " + ClubInfo.Location);
                Console.WriteLine("Captain = " + ClubInfo.Captain);
                Console.WriteLine("Coach = " + ClubInfo.Coach);
                Console.WriteLine("CEO = " + ClubInfo.CEO);
                Console.WriteLine("Owner = " + ClubInfo.Owner);
                Console.WriteLine("Home Ground = " + ClubInfo.Home_Ground);
                Console.WriteLine("Total Player = " + playerRepository.GetAllPlayer().Count());
                Console.WriteLine("Total Support-Stuff = " + supportStuffRepository.GetAllSupportStuff().Count());
                Console.WriteLine("====================================================== End  ======================================================\n");
                    DisplayOption();    
            }

            //index 2 for show all Player
            else if (index == 2)
            {
                var playerList = playerRepository.GetAllPlayer();
                if (playerList.Count() == 0)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("No player found in the list!!!");
                    Console.WriteLine("===============================");
                }
                else
                {
                    Console.WriteLine("================================================== Player List ==================================================");
                    foreach (var item in playerRepository.GetAllPlayer())
                    {
                        Console.WriteLine($"Player Id : {item.PlayerId} | Name : {item.PlayerName} | Age : {item.Age} | Role : {item.Role} | Country : {item.Country}");

                    }
                    Console.WriteLine("================================================== End of List ==================================================\n");
                    DisplayOption();
                }
            }

            //index 3 for insert new Player
            else if (index == 3)
            {
                Console.WriteLine("================================================ Add New Player =================================================");
                Console.Write("Player Name : ");
                string name = Console.ReadLine();
                Console.Write("Player Age  : ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Player Role[1=Batter / 2=Wicket_Keeper / 3=All_Rounder / 4=Bowler] : ");
                Role_Type role = (Role_Type)int.Parse(Console.ReadLine());
                Console.Write("Country Name : ");
                string country = Console.ReadLine();

                int maxId = playerRepository.GetAllPlayer().Any() ? playerRepository.GetAllPlayer().Max(x => x.PlayerId) : 0;

                Player player = new Player
                {
                    PlayerId = maxId + 1,
                    PlayerName = name,
                    Age = age,
                    Role = role,
                    Country = country
                };
                playerRepository.InsertPlayer(player);
                Console.WriteLine("New Player data inserted successfully!!");
                Console.WriteLine("=================================================================================================================\n");
                DisplayOption();
            }
            //index 4 for update Player info
            else if (index == 4)
            {
                Console.WriteLine("=================================================================================================================");
                Console.Write("Enter PlayerId to Update   : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var _player = playerRepository.SelectPlayer(id);
                if (_player == null)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Player id is invalid!!!");
                    Console.WriteLine("==========================");
                    return;
                }
                else
                {

                    Console.WriteLine($"============ Update Info for PlayerId ~> {id} ===========");
                    Console.Write("Player Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Player Age  : ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Player Role [1=Batter / 2=Wicket_Keeper / 3=All_Rounder / 4=Bowler] : ");
                    Role_Type role = (Role_Type)int.Parse(Console.ReadLine());
                    Console.Write("Country Name : ");
                    string country = Console.ReadLine();

                    Player player = new Player
                    {
                        PlayerId = id,
                        PlayerName = name,
                        Age = age,
                        Role = role,
                        Country = country
                    };
                    playerRepository.UpdatePlayer(player);
                    Console.WriteLine("Player data updated successfully!!");
                    Console.WriteLine("=================================================================================================================\n");
                    DisplayOption();
                }
            }
            //index 5 for delete Player data
            else if (index == 5)
            {
                Console.WriteLine("================================================== Remove Player ==================================================");
                Console.Write("Enter PlayerId to delete : ");

                int id = Convert.ToInt32(Console.ReadLine());
                var _player = playerRepository.SelectPlayer(id);

                if (_player == null)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Player id is invalid!!!");
                    Console.WriteLine("==========================");
                    return;
                }
                else
                {
                    playerRepository.DeletePlayer(id);
                    Console.WriteLine("Player data deleted successfully!!!");
                    Console.WriteLine("===================================================================================================================\n");
                    DisplayOption();
                }
            }

            //index 6 for show all SupportStuff
            else if (index == 6)
            {
                var supportStuffList = supportStuffRepository.GetAllSupportStuff();
                if (supportStuffList.Count() == 0)
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine("No SupportStuff found in the list!!!");
                    Console.WriteLine("====================================");
                }
                else
                {
                    Console.WriteLine("================================================ SupportStuff List ================================================");
                    foreach (var item in supportStuffRepository.GetAllSupportStuff())
                    {
                        Console.WriteLine($"SupportStuff Id : {item.SupportStufId} | Name : {item.SupportStufName} | Position : {item.Position} | Country : {item.Country}");

                    }
                    Console.WriteLine("=================================================== End of List ==================================================\n");
                    DisplayOption();
                }
            }

            //index 7 for insert new SupportStuff
            else if (index == 7)
            {
                Console.WriteLine("=============================================== Add New SupportStuff ================================================");
                Console.Write("SupportStuff Name : ");
                string name = Console.ReadLine();
                Console.Write("Position : ");
                string position = Console.ReadLine();
                Console.Write("Country Name : ");
                string country = Console.ReadLine();

                int maxId = supportStuffRepository.GetAllSupportStuff().Any() ? supportStuffRepository.GetAllSupportStuff().Max(x => x.SupportStufId) : 0;

                SupportStuff supportStuff = new SupportStuff
                {
                    SupportStufId = maxId + 1,
                    SupportStufName = name,
                    Position= position,
                    Country = country
                };
                supportStuffRepository.InsertSupportStuff(supportStuff);
                Console.WriteLine("New SupportStuff data inserted successfully!!");
                Console.WriteLine("======================================================================================================================\n");
                DisplayOption();
            }
            //index 8 for update SupportStuff info
            else if (index == 8)
            {
                Console.WriteLine("=======================================================================================================================");
                Console.Write("Enter SupportStuffId to Update   : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var _supportStuff = supportStuffRepository.SelectSupportStuff(id);
                if (_supportStuff == null)
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine("SupportStuff id is invalid!!!");
                    Console.WriteLine("==============================");
                    return;
                }
                else
                {

                    Console.WriteLine($"============ Update Info for SupportStuffId ~> {id} ===========");
                    Console.Write("SupportStuff Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Position : ");
                    string position = Console.ReadLine();
                    Console.Write("Country Name : ");
                    string country = Console.ReadLine();

                    SupportStuff supportStuff = new SupportStuff
                    {
                        SupportStufId = id,
                        SupportStufName = name,
                        Position= position,
                        Country = country
                    };
                    supportStuffRepository.UpdateSupportStuff(supportStuff);
                    Console.WriteLine("SupportStuff data updated successfully!!");
                    Console.WriteLine("========================================================================================================================\n");
                    DisplayOption();
                }
            }
            //index 9 for delete SupportStuff data
            else if (index == 9)
            {
                Console.WriteLine("================================================= Remove SupportStuff =================================================");
                Console.Write("Enter SupportStuffId to delete : ");

                int id = Convert.ToInt32(Console.ReadLine());
                var _supportStuff = supportStuffRepository.SelectSupportStuff(id);

                if (_supportStuff == null)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("SupportStuff id is invalid!!!");
                    Console.WriteLine("=============================");
                    return;
                }
                else
                {
                    supportStuffRepository.DeleteSupportStuff(id);
                    Console.WriteLine("SupportStuff data deleted successfully!!!");
                    Console.WriteLine("=======================================================================================================================\n");
                    DisplayOption();
                }
            }

        }
    }

}
