using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    public class Cines
    {
        private string nombreDueño;
        private int nIdentificador;
        private string horaAtencion;

        private int nSillas;

        public Cines(string nombreDueño, int nIdentificador, string horaAtencion, int nSillas)
        {
            this.NombreDueño = nombreDueño;
            this.NIdentificador = nIdentificador;
            this.HoraAtencion = horaAtencion;
            this.NSillas = nSillas;
        }

        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public int NIdentificador { get => nIdentificador; set => nIdentificador = value; }
        public string HoraAtencion { get => horaAtencion; set => horaAtencion = value; }
        public int NSillas { get => nSillas; set => nSillas = value; }
    }
}
