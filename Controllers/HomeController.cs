using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04o.Models;

namespace TP04o.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.DicPaquetes = ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {   ViewBag.Paquete = ORTWorld.Paquetes;
        ViewBag.Destinos = ORTWorld.ListaDestinos;
        ViewBag.Aereos = ORTWorld.ListaAereos;
        ViewBag.Hoteles = ORTWorld.ListaHoteles;
        ViewBag.Excursiones= ORTWorld.ListaExcursiones;
        ViewBag.Minimo = 1;
        ViewBag.Maximo = ORTWorld.ListaDestinos.Count;
        return View();
    }
    public IActionResult GuardarPaquete(int NumDestino, int NumHotel, int NumAereo, int NumExcusrion){
        
        Paquete paquete = new Paquete(ORTWorld.ListaHoteles[NumHotel-1],ORTWorld.ListaAereos[NumAereo-1],ORTWorld.ListaExcursiones[NumExcusrion-1]);
        if(ORTWorld.IngresarPaquete(ORTWorld.ListaAereos[NumDestino-1], paquete)){
            ORTWorld.Paquetes.Add(ORTWorld.ListaAereos[NumDestino-1], paquete);
        }
        else{
            return RedirectToAction("Error");
        }
        


        return RedirectToAction("Index");
    }
    public IActionResult Error(){

     ViewBag.Error = "Error.";

        return View();
    }
}
