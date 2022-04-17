using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenTrongNgoc.Models;

namespace NguyenTrongNgoc.Controllers;

public class NguyenTrongNgoc : Controller
{
    private readonly ILogger<HomeController> _logger;

    public NguyenTrongNgoc(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult News()
    {
        return View();
    }

    public IActionResult Category()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}