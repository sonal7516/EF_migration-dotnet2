using EF_migration_dotnet1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_migration_dotnet1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        ApplicationDbContext applicationDb = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<Employee> employees = applicationDb.Employees.ToList();

            return View(employees);
        }
    }
}