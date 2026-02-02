using Microsoft.AspNetCore.Mvc;
using MvcCoreLinqToSql.Models;
using MvcCoreLinqToSql.Repositories;

namespace MvcCoreLinqToSql.Controllers
{
    public class EnfermosController : Controller
    {
        RepositoryEnfermos repo;
        public EnfermosController()
        {
            repo = new RepositoryEnfermos();
        }
        public IActionResult Index()
        {
            List<Enfermo> enfermos = repo.GetEnfermos();
            return View(enfermos);
        }
        public IActionResult Details(string inscripcion)
        {
            Enfermo enfermo = repo.FindEnfermo(inscripcion);
            return View(enfermo);
        }

        public async Task<IActionResult> Delete(string inscripcion)
        {
            await this.repo.DeleteEnfermo(inscripcion);
            return RedirectToAction("Index");
        }
    }
}
