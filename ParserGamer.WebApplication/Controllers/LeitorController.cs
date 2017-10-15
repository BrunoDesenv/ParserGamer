using ParserGamer.Domain.Interfaces.Services;
using System.Web.Mvc;

namespace ParserGamer.WebApplication.Controllers
{
    public class LeitorController : Controller
    {
        private readonly IGameService _toolsService;

        public LeitorController(IGameService toolsService)
        {
            _toolsService = toolsService;
        }


        // GET: Leitor
        public ActionResult Index()
        {
            _toolsService.LerArquivo();
            return View();
        }
    }
}