using Microsoft.AspNetCore.Mvc;

namespace TP4_Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View();
    }
    public IActionResult DetallePais(string pais)
    {
        ViewBag.Paisbuscado = Info.DetallePais(pais);
        return View("detallepais");
    }
}
