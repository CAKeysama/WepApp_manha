using Microsoft.AspNetCore.Mvc;

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
            return View(db.CATEGORIA.ToList());
        }
    }
}
