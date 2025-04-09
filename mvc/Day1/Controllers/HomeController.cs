using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Day1.Models;

namespace Day1.Controllers;

public class HomeController : Controller // inhert the conter class in homeController
//{
    // private readonly ILogger<HomeController> _logger; // logger is used to log the information
    // public HomeController(ILogger<HomeController> logger) // constructor of the class
    // {
    //     _logger = logger; // assign the logger to the private variable
    // }
    // public IActionResult Index() // action method to return the index view
    // {
    //     return View(); // return the view
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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
