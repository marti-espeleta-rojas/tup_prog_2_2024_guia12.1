using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Despachos.Models
{
    public class Repartidor
    {
        public int Capacidad { get; private set; }
        public int Ocupacion { get; private set; }

        Stack<Paquete> entregas = new Stack<Paquete>();

        public Repartidor(int capacidad)
        {
            Capacidad = capacidad;
        }

        public Paquete Revisar()
        {
            return entregas.Peek();
        }

        public void Cargar(Paquete entrega)
        {
            entregas.Push(entrega);
            Ocupacion++;
        }

        public Paquete Descargar()
        {
            Ocupacion--;
            return entregas.Pop();
        }

        public bool TieneCapacidad()
        {
            bool tiene = true;
            if (entregas.Count >= Capacidad)
            {
                tiene = false;
            }
            return tiene;
        }
    }
}
