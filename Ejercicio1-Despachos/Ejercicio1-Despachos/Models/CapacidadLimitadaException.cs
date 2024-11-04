using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Despachos.Models
{
    public class CapacidadLimitadaException : ApplicationException
    {
        public CapacidadLimitadaException() : base("No hay capacidad en la estructura") { }
        public CapacidadLimitadaException(string message) : base(message) { }
        public CapacidadLimitadaException(string message, Exception ez) : base(message, ez) { }
    }
}
