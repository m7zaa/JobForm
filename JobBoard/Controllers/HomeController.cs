using Microsoft.AspNetCore.Mvc;
using JobBoards.Models;

namespace JobBoards.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}