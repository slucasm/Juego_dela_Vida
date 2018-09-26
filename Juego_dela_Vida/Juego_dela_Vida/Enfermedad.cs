using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juego_dela_Vida
{
    class Enfermedad
    {
        int numerovecinosinfectados;
        string nombre;

        public Enfermedad(string nombre, int numero)
        {
            this.nombre = nombre;
            this.numerovecinosinfectados = numero;
        }
        public int devolvernumeroinfectadosalrededor()
        {
            return this.numerovecinosinfectados;
        }
        public string damenombrenfermedad()
        {
            return this.nombre;
        }
    }
}
