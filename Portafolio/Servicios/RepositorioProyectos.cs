using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}
