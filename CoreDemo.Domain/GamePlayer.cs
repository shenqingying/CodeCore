using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Domain
{
  public  class GamePlayer
    {
        public int GameId { get; set; }
        public int PlayerId { get; set; }
     
        public Player Player { get; set; }
        public Game  Game { get; set; }
    }
}
