
using Ninject.Modules;
using ParserGamer.Data.Repositories;
using ParserGamer.Domain.Interfaces.Repositories;

namespace ParserGamer.CrossCutting
{
    public class ModuloRepository : NinjectModule
    {
        public override void Load()
        {
            Bind<IPlayerRepository>().To<PlayerRepository>();
            Bind<IGameRepository>().To<GameRepository>();

            
        }
    }
}
