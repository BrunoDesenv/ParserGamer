using System;

namespace ParserGamer.Domain.Entities
{
    public class Information
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int IdPlayer1 { get; set; }
        public virtual Player Player1 { get; set; }
        public int IdPlayer2 { get; set; }
        public virtual Player Player2 { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
