using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Domain
{
    public class Player
    {
        public Player()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }
        public Resume Resume { get; set; }
    }
}
