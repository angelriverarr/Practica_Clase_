using Practica01.Models;
using Practica01.Services;

namespace Practica01.Bussines
{
    public class Operaciones : IOperaciones
    {
        public double Division(Acciones acciones)
        {
            return acciones.dato1 / acciones.dato2;
        }

        public double Ejercicio(Acciones acciones)
        {
            return acciones.dato1 + acciones.dato2;
        }

        public double Multiplicacion(Acciones acciones)
        {
            return acciones.dato1 * acciones.dato2;
        }

        public double resta(Acciones acciones)
        {
            return acciones.dato1 - acciones.dato2;
        }
    }
}
