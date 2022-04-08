using Practica01.Models;

namespace Practica01.Services

    
{
    public interface IOperaciones
    {
        Double Ejercicio(Acciones acciones);
        Double resta(Acciones acciones);
        Double Multiplicacion(Acciones acciones);
        Double Division(Acciones acciones);
    }
}
