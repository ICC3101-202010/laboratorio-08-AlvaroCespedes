using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    public class Tienda
    {
        private string nombreDueño;
        private int nIdentificador;
        private string horaAtencion;

        private string categoria;

        public Tienda(string nombreDueño, int nIdentificador, string horaAtencion, string categoria)
        {
            this.NombreDueño = nombreDueño;
            this.NIdentificador = nIdentificador;
            this.HoraAtencion = horaAtencion;
            this.Categoria = categoria;
        }

        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public int NIdentificador { get => nIdentificador; set => nIdentificador = value; }
        public string HoraAtencion { get => horaAtencion; set => horaAtencion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
