using GridViewCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GridViewCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private DBcontext Context { get; }
        public HomeController(DBcontext _context)
        {
            this.Context = _context;
        }


        public IActionResult Index(int p = 1)
        {
            PagedResult<Employee> customers = this.Context.Employee.GetPaged(p, 10);
            return View(customers);
        }

    }
}
