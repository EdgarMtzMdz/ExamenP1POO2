using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
namespace ExamenParcial1POO2;

public class ProductController : Controller
{
    public ProductController()
    {
    }

    public ActionResult ProductList()
    {
        return View();
    }

     public IActionResult ProductAdd (ListaModel producto)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        return Redirect("producto");
       
    }
}