using Microsoft.AspNetCore.Mvc;

namespace WepApp_manha.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            return View();
        }

        public IActionResult Compras(int id)
        {
            return View();
        }
    }
}
