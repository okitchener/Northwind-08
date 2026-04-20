using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Northwind.Models;

namespace Northwind.Controllers
{
    [Authorize(Roles = "northwind-admin")]
    public class EmployeeController : Controller
    {
        private readonly DbContext _context;

        public EmployeeController(DbContext context)
        {
            _context = context;
        }

        // GET: Employee
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        // Other actions...
    }
}
