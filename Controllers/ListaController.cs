using Microsoft.AspNetCore.Mvc;

namespace  ExamenParcial1POO2;

public class ListaController : Controller
{
    public ListaController()
    {
    }

    public IActionResult Lista ()
    {
        List<ListaModel> lista = new List<ListaModel>();

        ListaModel l1 = new ListaModel();
        l1.Nombre = "Garza Sada";
        l1.NumAlumnos = 100;
        l1.Presupuesto = 11000;

        ListaModel l2 = new ListaModel();
        l2.Nombre = "Ocampo";
        l2.NumAlumnos = 150;
        l2.Presupuesto = 4444444;

        ListaModel l3 = new ListaModel();
        l3.Nombre = "Gonzalitos";
        l3.NumAlumnos = 250;
        l3.Presupuesto = 333333;

        lista.Add(l1);
        lista.Add(l2);
        lista.Add(l3);

        
        return View(lista);
    }

    
    public IActionResult ListaAdd (ListaModel lista)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        return Redirect("Lista");
       
    }

    
    public IActionResult ListaDelete ()
    {
        
        return View();
    }
}