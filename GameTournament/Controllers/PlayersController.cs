using Microsoft.AspNetCore.Mvc;

namespace GameTournament.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
