using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    [Route("[controller]")]
    public class SupermercadoController : Controller
    {
        private List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Atún VanCamps", Precio = 12.0, Imagen = "https://plazavea.vteximg.com.br/arquivos/ids/28513895-512-512/20390918.jpg" },
            new Producto { Id = 2, Nombre = "Queso menonita", Precio = 45.0, Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQyCTcKCA4aEyB1OLk42HpKH_XLAi31tQuVVw&s" }
        };

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View(_productos);
        }

        [HttpPost("AgregarAlCarrito/{id}")]
        public IActionResult AgregarAlCarrito(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                var carrito = HttpContext.Session.GetObjectFromJson<List<Elemento>>("carrito") ?? new List<Elemento>();
                var elemento = carrito.FirstOrDefault(e => e.Producto.Id == id);
                if (elemento != null)
                {
                    elemento.Cantidad++;
                }
                else
                {
                    carrito.Add(new Elemento { Producto = producto, Cantidad = 1 });
                }
                HttpContext.Session.SetObjectAsJson("carrito", carrito);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Carrito")]
        public IActionResult Carrito()
        {
            var carrito = HttpContext.Session.GetObjectFromJson<List<Elemento>>("carrito") ?? new List<Elemento>();
            return View(carrito);
        }

        [HttpPost("FinalizarCompra")]
        public IActionResult FinalizarCompra()
        {
            var carrito = HttpContext.Session.GetObjectFromJson<List<Elemento>>("carrito") ?? new List<Elemento>();
            double total = carrito.Sum(e => e.Producto.Precio * e.Cantidad);

            HttpContext.Session.Remove("carrito");

            ViewBag.Total = total;
            return View();
        }
    }

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, System.Text.Json.JsonSerializer.Serialize(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : System.Text.Json.JsonSerializer.Deserialize<T>(value);
        }
    }
}

