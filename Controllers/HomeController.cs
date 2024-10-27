using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyNETWebApp.Models;

namespace MyNETWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Create a new instance of MyModel with sample data
        // var model = new MyModel
        // {
        //     Name = "Alice",
        //     Age = 25
        // };
        // return View(model); // Pass model to the view

        var author = new Author
        {
            Name ="Alice",
            Email = "alice@gmail.com",
            Nationality ="Bangladeshi"
        };
        return View(author);
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
