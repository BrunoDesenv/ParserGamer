using ParserGamer.Domain.Entities;
using ParserGamer.Domain.Interfaces.Repositories;

namespace ParserGamer.Data.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
    }
}
