using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreEmptyPractica.AppHost.Controllers
{
    
    public class HomeController : Controller
    {
        RepositoryHospital repo = new RepositoryHospital();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            this.repo.DeleteHospital(id);
            return RedirectToAction("Index");
        }
    }
}
