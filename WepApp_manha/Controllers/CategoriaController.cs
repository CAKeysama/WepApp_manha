using Microsoft.AspNetCore.Mvc;
using WepApp_manha.Entidades;
using WepApp_manha.Models;

namespace WepApp_manha.Controllers
{
    public class CategoriaController : Controller
    {
        private Contexto contexto;

        public CategoriaController(Contexto db)
        {
            contexto = db;
        }
        public IActionResult Lista()
        {
            return View(contexto.CATEGORIA.ToList());
        }

        public IActionResult Cadastro() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(CategoriaViewModel dados)
        {
            CategoriaEntidade entidade = new CategoriaEntidade();
            entidade.Nome = dados.Nome;
            entidade.Id = dados.Id;
            entidade.Ativo = dados.Ativo;

            entidade.Descricao = dados.Descricao;
            if(entidade.Id > 0 ) 
            {
                contexto.CATEGORIA.Update(entidade);
                contexto.SaveChanges();
            }
            else
            {
                contexto.CATEGORIA.Add(entidade);
                contexto.SaveChanges();
            }
           
            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id) 
        {
            CategoriaEntidade item = contexto.CATEGORIA.Find(id);
            if (item != null) 
            {
                contexto.CATEGORIA.Remove(item);
                contexto.SaveChanges();
            }

            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id)
        {
            CategoriaEntidade item = contexto.CATEGORIA.Find(id);
            if (item != null) 
            {
                return View(item);
            }else{
                return RedirectToAction("Lista");
            }
        }
    }
}
