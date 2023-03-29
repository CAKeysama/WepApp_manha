using Microsoft.AspNetCore.Mvc;

namespace WepApp_manha.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
