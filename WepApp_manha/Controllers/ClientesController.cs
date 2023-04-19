using Microsoft.AspNetCore.Mvc;
using WepApp_manha.Models;

namespace WepApp_manha.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClienteViewModel> lista = new List<ClienteViewModel>();
        public IActionResult Lista()
        {

    

            //for (int i = 0; i < 30; i++)
            //{
            //    ClienteViewModel novo = new ClienteViewModel();
            //    novo.Nome = "Gustavo D. Silva";
            //    novo.Telefone = "16 9 9627-8054";
            //    novo.Id = 1+i;
            //    lista.Add(novo);
            //}

            return View(lista);
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

        [HttpPost]
        public IActionResult SalvarDados(ClienteViewModel model) 
        {
            if (model.Id > 0)
            {
               int indice = lista.FindIndex(a => a.Id == model.Id);
                lista[indice] = model;
            }
            else
            {
                Random random = new Random();
                model.Id = random.Next(1, 9999);
                lista.Add(model);
            }
            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == id);
            if (cliente != null)
            {
                return View(cliente);
            }
            else
            {
               return RedirectToAction("Lista");
            }
        }

        public IActionResult Excluir(int id)
        {
            ClienteViewModel cliente = lista.Find(x => x.Id == id);
            if (cliente != null)
            {
                lista.Remove(cliente);
            }
            return RedirectToAction("Lista");
        }

        public IActionResult Compras(int id)
        {
            return View();
        }

        
    }
}
