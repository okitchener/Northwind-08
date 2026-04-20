using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
  // this controller depends on the NorthwindRepository
  private DataContext _dataContext;
  public OrderController(DataContext db) => _dataContext = db;
  public IActionResult Orders() => View(_dataContext.Orders.OrderBy(o => o.OrderId));
  public IActionResult Index(int id)
  {
     return View(_dataContext.Orders.OrderBy(o => o.OrderId));
  }
  }
