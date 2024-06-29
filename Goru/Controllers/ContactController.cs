namespace Goru.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Goru.Models;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}    
    