﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_Caroussel.Models;

namespace AMS23_Caroussel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Product()
    {
        return View();
    }

     public IActionResult Category()
    {
       
        
        return View();
    }
     public IActionResult Login(LoginModel loginModel)
    {
       var request = loginModel;
        
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
