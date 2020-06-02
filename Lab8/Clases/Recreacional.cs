using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    public class Recreacional
    {
        private string nombreDueño;
        private int nIdentificador;
        private string horaAtencion;

        public Recreacional(string nombreDueño, int nIdentificador, string horaAtencion)
        {
            this.NombreDueño = nombreDueño;
            this.NIdentificador = nIdentificador;
            this.HoraAtencion = horaAtencion;
        }

        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public int NIdentificador { get => nIdentificador; set => nIdentificador = value; }
        public string HoraAtencion { get => horaAtencion; set => horaAtencion = value; }
    }
}
