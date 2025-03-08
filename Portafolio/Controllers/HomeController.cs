using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var proyectos = ObtenerProyectos().Take(3).ToList();
        var model = new HomeIndexViewModel
        {
            Proyectos = proyectos
        };

        return View(model);
    }

    private List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>()
        {
            new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                ImagenURL = "/imagenes/amazon.png",
                Link = "https://www.amazon.com"
            },
            new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                ImagenURL = "/imagenes/nyt.png",
                Link = "https://www.nytimes.com"
            },
            new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                ImagenURL = "/imagenes/reddit.png",
                Link = "https://www.reddit.com"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en línea para comprar videojuegos",
                ImagenURL = "/imagenes/steam.png",
                Link = "https://store.steampowered.com/"
            }
        };
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
