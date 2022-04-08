using Practica01.Data;
using Practica01.Models;
using Practica01.Services;

namespace Practica01.Repository
{
    public class Students: IEstudents
    {
        private AplicationDBContext app;

        public Students(AplicationDBContext app)
        {
            this.app = app;
        }

        public void AddStudent(Estudiantes es)
        {
            app.Estudiantes.Add(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteStudent(Estudiantes es)
        {
            app.Estudiantes.Remove(es);
            app.SaveChanges();

            // throw new NotImplementedException();
        }

        public List<Models.Estudiantes> GetAll()
        {
           return app.Estudiantes.ToList();
            return new List<Models.Estudiantes>();
            //throw new NotImplementedException();
        }


        public Estudiantes loadInformation(Estudiantes es)
        {
            var listadoEstudiante = app.Estudiantes.Where(x => x.id==es.id).FirstOrDefault();
            return listadoEstudiante;
            //throw new NotImplementedException();
        }

        public void UpdateStudent(Models.Estudiantes es)
        {
            app.Estudiantes.Update(es);
            app.SaveChanges();
            // throw new NotImplementedException();
        }
    }
}
