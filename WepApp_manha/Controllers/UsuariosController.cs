using Microsoft.AspNetCore.Mvc;

namespace WepApp_manha.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
