using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserGamer.Domain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public Information Information { get; set; }
        public int TotalKills { get; set; }
    }
}
