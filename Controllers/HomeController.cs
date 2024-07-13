using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GameLibraryAPI.Models;

namespace GameLibraryAPI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public void Index(){}
}