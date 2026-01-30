using Microsoft.AspNetCore.Mvc;
using MvcCoreLinqToSql.Models;
using MvcCoreLinqToSql.Repositories;

namespace MvcCoreLinqToSql.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleado repo;

        public EmpleadosController()
        {
            this.repo = new RepositoryEmpleado();
        }
        public IActionResult Index()
        {
            List<Empleado> empleados =
                this.repo.GetEmpleados();
            return View(empleados);
        }

        public IActionResult Details(int id)
        {
            Empleado empleado =
                this.repo.FindEmpleado(id);
            return View(empleado);
        }
    }
}
