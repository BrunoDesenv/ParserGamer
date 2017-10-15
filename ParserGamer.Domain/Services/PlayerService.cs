using ParserGamer.Domain.Entities;
using ParserGamer.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ParserGamer.Domain.Services
{
    public class PlayerService : IPlayerService
    {

        public bool ExistePlayerComMesmoNome(string name, List<Player> players)
        {
            bool alreadyExists = players.Any(x => x.Name == name);
            return alreadyExists;
        }

        public Player ObterPlayerPeloNome(string name, List<Player> players)
        {
            if (ExistePlayerComMesmoNome(name, players))
            {
                return players.Find(x => x.Name == name);
            }
            else
            {
                var playerNovo =  new Player
                {
                    Name = name,
                };

                players.Add(playerNovo);

                return playerNovo;
            }
        }
    }
}
