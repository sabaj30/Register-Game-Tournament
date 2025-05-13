using Microsoft.AspNetCore.Mvc;
using Tournament.Model.Models;

namespace GameTournament.Controllers
{
    public class GamesController : Controller
    {
        public ViewResult Index()
        {
            return View(new Game { Name="GTA",Id=1,Genre="Action"});
        }
    }
}
