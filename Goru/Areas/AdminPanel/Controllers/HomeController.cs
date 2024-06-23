using Microsoft.AspNetCore.Mvc;

namespace Goru.Areas.AdminPanel.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}