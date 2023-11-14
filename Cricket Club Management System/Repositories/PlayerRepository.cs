using Cricket_Club_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_Club_Management_System.Repositories
{
    public interface IPlayerRepository<T>
    {
        Player SelectPlayer(T data);
        void InsertPlayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(T data);
        IEnumerable<Player> GetAllPlayer();
    }


    public class PlayerRepository : IPlayerRepository<int>
    {
        public Player SelectPlayer(int data)
        {
            Player player = PlayerDB.PlayerList.FirstOrDefault(x => x.PlayerId == data);
            return player;
        }

        public void InsertPlayer(Player player)
        {
            PlayerDB.PlayerList.Add(player);
        }

        public void UpdatePlayer(Player player)
        {
            Player _player = PlayerDB.PlayerList.FirstOrDefault(x => x.PlayerId == player.PlayerId);
            if (player.PlayerName != null)
            {
                _player.PlayerName = player.PlayerName;
            }
            if (player.Age != 0)
            {
                _player.Age = player.Age;
            }
            if (player.Role != 0)
            {
                _player.Role = player.Role;
            }
            if (player.Country != null)
            {
                _player.Country = player.Country;
            }
        }

        public void DeletePlayer(int data)
        {
            Player player = PlayerDB.PlayerList.FirstOrDefault(x => x.PlayerId == data);
            PlayerDB.PlayerList.Remove(player);
        }

        public IEnumerable<Player> GetAllPlayer()
        {
            return PlayerDB.PlayerList;
        }

    }
}
