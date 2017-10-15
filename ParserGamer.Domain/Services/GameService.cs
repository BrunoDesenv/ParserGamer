using ParserGamer.Domain.Entities;
using ParserGamer.Domain.Interfaces.Repositories;
using ParserGamer.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.IO;


namespace ParserGamer.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly IPlayerService _playerService;
        private readonly IGameRepository _gameRepository;
        private readonly string Kill = "Kill";
        private readonly string PlayerWorld = "<world>";
        List<Player> players = new List<Player>();
        Game game = new Game();

        public GameService(IPlayerService playerService, IGameRepository gameRepository)
        {
            _playerService = playerService;
            _gameRepository = gameRepository;
        }

        public void LerArquivo()
        {
            var todasAsLinhas = File.ReadAllLines(@"C:\Users\Bruno-PC\Desktop\games.log.txt");

            foreach (string linha in todasAsLinhas)
            {
                if (linha.Contains(Kill))
                {
                    var palavras = linha.Split();

                    var playerQueMatou = _playerService.ObterPlayerPeloNome(palavras[6], players);
                    var playerMorto = _playerService.ObterPlayerPeloNome(palavras[8], players);

                    game.TotalKills++;

                    if (EPlayerWorldQueMatou(playerQueMatou.Name))
                    {
                        playerMorto.Kills--;
                    }
                    else
                    {
                        playerQueMatou.Kills++;
                    }
                }
            }
            _gameRepository.Add(game);
        }

        private bool EPlayerWorldQueMatou(string player)
        {
            if (player.Contains(PlayerWorld))
            {
                return true;
            }
            return false;
        }
    }
}
