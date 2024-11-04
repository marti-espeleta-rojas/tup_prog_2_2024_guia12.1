using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Despachos.Models
{
    public class Despachador
    {
        Repartidor camion; 
        Queue<Paquete> depositos = new Queue<Paquete>();

        public Paquete RecibirCorrespondencia(int dni, string nombre, string direccion)
        {
            Paquete pack = new Paquete(dni, nombre, direccion);
            depositos.Enqueue(pack);
            return pack;
        }

        public Repartidor PrepararCamion(int capacidad)
        {
            camion = new Repartidor(capacidad);
            return camion;
        }

        public Paquete CargarPaqueteAlCamion(Paquete pack)
        {
            bool tieneCapacidad = camion.TieneCapacidad();
            if (tieneCapacidad)
            {
                camion.Cargar(pack);
                return pack;
            }
            else
            {
                throw new CapacidadLimitadaException("No hay tamaño disponible en la estructura");
            }
        }
    }
}
