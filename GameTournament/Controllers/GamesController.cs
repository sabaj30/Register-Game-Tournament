using Microsoft.AspNetCore.Mvc;
using Tournament.InfraStructure.Repositories;
using Tournament.Model.Models;

namespace TournamentUI.Controllers
{
    public class GamesController : Controller
    {
        private readonly EFGameRepository gameRepository;
        public GamesController()
        {
            this.gameRepository = new EFGameRepository();
        }

        public ViewResult Index()
        {
            var games = gameRepository.GetAll();
            return View(games);
        }

        public ViewResult Detail(int id)
        {
            var game = gameRepository.GetById(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Add(Game game)
        {
            if (ModelState.IsValid)
            {
                gameRepository.Add(game);
                return RedirectToAction("Index", "Games");
            }
            return BadRequest();
        }

        public ViewResult Add()
        {
            return View();
        }
    }
}
