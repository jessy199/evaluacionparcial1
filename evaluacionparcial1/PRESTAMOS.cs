using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionparcial1
{
    class PRESTAMOS
    {
        int carnet;
        string codigodelibro;
        DateTime fechadeprestamo;
        DateTime fechadedevolucion;

        public int Carnet { get => carnet; set => carnet = value; }
        public string Codigodelibro { get => codigodelibro; set => codigodelibro = value; }
        public DateTime Fechadeprestamo { get => fechadeprestamo; set => fechadeprestamo = value; }
        public DateTime Fechadedevolucion { get => fechadedevolucion; set => fechadedevolucion = value; }
    }
}
