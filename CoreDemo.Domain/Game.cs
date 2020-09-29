using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CoreDemo.Domain
{
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        [Description("第几轮")]
        public string Round { get; set; }
        [Description("比赛开始时间")]
        public DateTimeOffset? Start { get; set; }

        public List<GamePlayer> GamePlayers { get; set; }
    }
}
