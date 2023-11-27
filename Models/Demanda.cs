using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Models
{
    public class Demanda
    {
        public string IdCliente { get; set; }
        public double OrigenLatitud { get; set; }
        public double OrigenLongitud { get;set; }
        public double DestinoLatitud { get; set; }
        public double DestinoLongitud { get; set; }
        public int CantidadLibros { get; set; }
        public DateTime FechaCobertura { get; set; }

        public Demanda() { }

        public Demanda(string idCliente, double origenLatitud, double origenLongitud, double destinoLatitud, double destinoLongitud, int cantidadLibros, DateTime fechaCobertura)
        {
            IdCliente = idCliente;
            OrigenLatitud = origenLatitud;
            OrigenLongitud = origenLongitud;
            DestinoLatitud = destinoLatitud;
            DestinoLongitud = destinoLongitud;
            CantidadLibros = cantidadLibros;
            FechaCobertura = fechaCobertura;
        }
    }
}
