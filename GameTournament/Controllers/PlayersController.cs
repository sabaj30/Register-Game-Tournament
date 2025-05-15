using Microsoft.AspNetCore.Mvc;

namespace TournamentUI.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
