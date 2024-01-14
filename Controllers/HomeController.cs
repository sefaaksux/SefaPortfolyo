using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using SefaPortfolyo.Models;

namespace SefaPortfolyo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Hakkimda()
    {
        return View();
    }
    public IActionResult Iletisim()
    {
        return View();
    }
    
    public IActionResult Projelerim()
    {
        return View();
    }
}
