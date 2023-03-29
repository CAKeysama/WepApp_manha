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

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["ERRO 666"] = "O campo Nome não pode estar em branco.";
            }

            if (string.IsNullOrEmpty(Telefone))
            {
                TempData["ERRO 666"] = "O campo Telefone não pode estar em branco.";
            }
            else
            {
                TempData["OK"] = "Cliente cadastrado!";
            }
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
