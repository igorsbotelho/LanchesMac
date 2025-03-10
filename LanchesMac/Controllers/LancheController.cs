using LanchesMac.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            this._lancheRepository = lancheRepository;
        }

        public IActionResult ListaLanches()
        {
            var lanches = _lancheRepository.Lanches;

            var totalLanches = lanches.Count();
            ViewBag.Total = "Total de Lanches";
            ViewBag.TotalCount = totalLanches;

            return View(lanches);
        }
    }
}
