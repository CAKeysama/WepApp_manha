using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WepApp_manha.Models;

namespace WepApp_manha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto db;


        public HomeController(Contexto db,  ILogger<HomeController> logger)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(  db.Produtos.ToList()  );
        }

        public IActionResult BemVindo()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}