using Ninject.Modules;
using ParserGamer.Domain.Interfaces.Services;
using ParserGamer.Domain.Services;

namespace ParserGamer.CrossCutting
{
    public class ModuloService : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameService>().To<GameService>();
            Bind<IPlayerService>().To<PlayerService>();
        }
    }
}
