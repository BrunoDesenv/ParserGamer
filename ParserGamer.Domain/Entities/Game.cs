using System;

namespace ParserGamer.Domain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int TotalKills { get; set; }
        public DateTime DateRegister { get; set; }
        public int? IdInformation { get; set; }
        public Information Information { get; set; }
    
    }
}
