using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTercerSem
{
    class Serie
    {
        public string Titulo { get; set; }
        public int Año { get; set; }
        public string Genero { get; set; }
        public int Temporada { get; set; }
        public string Produccion { get; set; }
        public string Descripcion { get; set; }
        public int Rating { get; set; }

        public Serie(string titulo, int año, string genero, int temporada, string produccion, string descripcion, int rating )
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Temporada = temporada;
            this.Produccion = produccion;
            this.Descripcion = descripcion;
            this.Rating = rating;
        }
        public override string ToString()
        {
            return this.Titulo + "   " + this.Año;
        }
    }
}
