using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8.Clases
{
    public class Restaurant
    {
        private string nombreDueño;
        private string nIdentificador;
        private string horaAtencion;

        private string mesaExclusiva; //mas sencillo usar string

        public Restaurant()
        {
        }

        public Restaurant(string nombreDueño, string nIdentificador, string horaAtencion, string mesaExclusiva)
        {
            this.NombreDueño = nombreDueño;
            this.NIdentificador = nIdentificador;
            this.HoraAtencion = horaAtencion;
            this.MesaExclusiva = mesaExclusiva;
        }

        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public string NIdentificador { get => nIdentificador; set => nIdentificador = value; }
        public string HoraAtencion { get => horaAtencion; set => horaAtencion = value; }
        public string MesaExclusiva { get => mesaExclusiva; set => mesaExclusiva = value; }

        public override string ToString()
        {
            Console.WriteLine("Restaurantes: dueño, numero identificador, hora de atencion y si tiene mesa exclusiva.");
            return NombreDueño + " " + nIdentificador + " " + horaAtencion + " " + MesaExclusiva;
        }

    }
}
