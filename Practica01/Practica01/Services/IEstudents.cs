using Practica01.Models;

namespace Practica01.Services
{
    public interface IEstudents
    {
        public void AddStudent(Estudiantes es);
        public void UpdateStudent(Estudiantes es);

        public void DeleteStudent(Estudiantes es);

       public List<Estudiantes> GetAll();

        public Estudiantes loadInformation(Estudiantes es);
    }
}
