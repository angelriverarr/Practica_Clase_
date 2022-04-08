using Microsoft.AspNetCore.Mvc;
using Practica01.Bussines;
using Practica01.Models;
using System.Diagnostics;

namespace Practica01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        //importante sin una action no hay vista y viseversa
        public IActionResult Ejercicio(Acciones acciones)
        {
            //if (acciones.dato1 > 10 || acciones.dato2 > 10)
            //{
            //    return View("ErrornoMayores");
            //}

            //double resultado = acciones.dato1 + acciones.dato2;
            //ViewBag.datoN1V = acciones.dato1;
            //ViewBag.datoN2V = acciones.dato2;
            //ViewBag.variableaenviar = resultado;
            Operaciones op = new Operaciones();
            double resultado = op.Ejercicio(acciones);
            ViewBag.variableaenviar = resultado;
            return View();
        }
        public IActionResult ErrornoMayores()
        {
            return View();
        }
        public IActionResult resta(Acciones acciones)
        {
            //if (acciones.dato1 > 10 || acciones.dato2 > 10)
            //{
            //    return View("ErrornoMayores");
            //}

            //double resultado = acciones.dato1 - acciones.dato2;
            //ViewBag.datoR1V = acciones.dato1;
            //ViewBag.datoR2V = acciones.dato2;
            //ViewBag.variableaenviar = resultado;
            Operaciones op = new Operaciones();

            double resultado = op.resta(acciones);
            ViewBag.variableaenviar = resultado;
            return View();

        }
        public IActionResult Multiplicacion(Acciones acciones)
        {
            //    if (acciones.dato1 > 10 || acciones.dato2 > 10)
            //    {
            //        return View("ErrornoMayores");
            //    }

            //    double resultado = acciones.dato1 * acciones.dato2;
            //    ViewBag.datoM1V = acciones.dato1;
            //    ViewBag.datoM2V = acciones.dato2;
            //    ViewBag.variableaenviar = resultado;


            //OBJETO DE NEGOCIO
            Operaciones op = new Operaciones();

            double resultado = op.Multiplicacion(acciones);
            ViewBag.variableaenviar = resultado;
            return View();

        }
        public IActionResult Division(Acciones acciones)
        {
            //    if (acciones.dato1 > 10 || acciones.dato2 > 10)
            //    {
            //        return View("ErrornoMayores");
            //    }

            //    double resultado = acciones.dato1 / acciones.dato2;
            //    ViewBag.datoD1V = acciones.dato1;
            //    ViewBag.datoD2V = acciones.dato2;
            //    ViewBag.variableaenviar = resultado;

            Operaciones op = new Operaciones();

            double resultado = op.Division(acciones);
            ViewBag.variableaenviar = resultado;
            return View();

        }
        [HttpGet]
        public IActionResult PeticionTypeGet() 
        {

            return View();
        }

       
        public IActionResult SecondPage() 
        {


            return View();
        }



    }
}