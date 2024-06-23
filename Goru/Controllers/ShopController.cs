﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Goru.Models;

namespace Goru.Controllers;


public class ShopController : Controller
{
    public IActionResult Index()
    {
        return View("shop");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}