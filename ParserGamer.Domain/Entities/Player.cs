using System;
using System.Collections.Generic;

namespace ParserGamer.Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Kills { get; set; }
        public DateTime DateRegister { get; set; }
        public int IdGame { get; set; }
        public virtual Game Game { get; set; }
    }
}
