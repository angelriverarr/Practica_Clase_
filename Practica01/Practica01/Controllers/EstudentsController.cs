using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using Practica01.Services;
//Angel Gabirel Mnejivar Rivera
namespace Practica01.Controllers
{
    public class EstudentsController : Controller
    {

        private IEstudents Estudents;

        public EstudentsController(IEstudents estudents)
        {
            Estudents = estudents;
        }

        public IActionResult Delete(int id) 
        {
            Estudiantes es = new Estudiantes();
            es.id = id;
            Estudents.DeleteStudent(es);
            return RedirectToAction ("Index");
        }
        public IActionResult Load (int id)
        {
            Estudiantes es = new Estudiantes();
            es.id = id;
            var listadlistadoEstudiante = Estudents.loadInformation(es);
           return View(listadlistadoEstudiante);

        }

        public IActionResult actu(Estudiantes es) 
        {

            Estudents.UpdateStudent(es);
            return RedirectToAction("Index");

        }

        public IActionResult Guardar()
        {



            return View();
        }

        public IActionResult Save(Estudiantes es)
        {

            Estudents.AddStudent(es);
            return RedirectToAction("Index");

        }


        public IActionResult Index()
        {
            Estudiantes es= new Estudiantes();
            //es.id = 1;
            //es.name = "Angell";
            //es.lastName = "Gabriel2";
            //Estudents.AddStudent(es); //para agregar
            //Estudents.DeleteStudent(es);//eliminar
            //Estudents.UpdateStudent(es); //actualizar ya ingresado
            //Estudents.GetAll();
            var listar = Estudents.GetAll();

            return View(listar);
        }
    }
}
