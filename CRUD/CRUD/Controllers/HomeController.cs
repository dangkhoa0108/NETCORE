using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext context;

        public HomeController(EmployeeContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<EmployeeModel> lstEmployeeModels = context.Set<EmployeeModel>().ToList().Select(child =>
                new EmployeeModel()
                {
                    EmployeeId = child.EmployeeId,
                    DepartmentId = child.DepartmentId,
                    EmployeeAge = child.EmployeeAge,
                    EmployeeName = child.EmployeeName
                });
            return View(lstEmployeeModels);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
