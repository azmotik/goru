namespace Goru.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Goru.Models;

public class PagesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult FourOFour()
    {
        return View("fourOfour");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}