using Microsoft.AspNetCore.Mvc;
using Tournament.Model.Models;

namespace TournamentUI.Controllers
{
    public class GamesController : Controller
    {
        public ViewResult Index()
        {
            return View(new Game { Title="GTA",Id=1,Genre="Action"});
        }
    }
}
