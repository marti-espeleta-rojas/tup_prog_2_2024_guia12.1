using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Despachos.Models
{
    public class Paquete
    {
        public int DNIRemitente { get; set; }
        public string NombreRemitente { get; set; }
        public string Direccion { get; set; }

        public Paquete(int dni, string nombre, string direccion)
        {
            DNIRemitente = dni;
            NombreRemitente = nombre;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"{DNIRemitente} - {NombreRemitente} - {Direccion}";
        }
    }
}
