using Microsoft.AspNetCore.Mvc;

namespace Goru.Areas.AdminPanel.Controllers;

public class OrdersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}