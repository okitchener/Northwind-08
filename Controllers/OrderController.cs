using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

public class OrderController : Controller
{
  // this controller depends on the NorthwindRepository
  private DataContext _dataContext;
  public OrderController(DataContext db) => _dataContext = db;
  public IActionResult Orders() => View(_dataContext.Orders.OrderBy(o => o.OrderId));
   [Authorize(Roles = "northwind-employee")]
   

  public IActionResult Index(int id)
  {
      ViewBag.CustomerNames = _dataContext.Customers
          .ToDictionary(c => c.CustomerId, c => c.CompanyName);

      ViewBag.EmployeeNames = _dataContext.Employees
          .ToDictionary(e => e.EmployeeId, e => e.FirstName + " " + e.LastName);

 return View(_dataContext.Orders.Where(o => o.ShippedDate == null).OrderBy(o => o.RequiredDate));
  }
  }
