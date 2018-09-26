using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juego_dela_Vida
{
    class Celda
    {

        int columna;
        int fila;
        int infectado;
        int infectadofuturo;

        public Celda(int columna, int fila, int infectado)
        {
            this.columna = columna;
            this.fila = fila;
            this.infectado = infectado;
        }

        public void infectarfuturo()
        {
            this.infectadofuturo = 1;
        }
        public int comprobarcelda()
        {
            return infectado;
        }
        public void desinfectarfuturo()
        {
            this.infectadofuturo = 0;
        }

        public void infectaractual()
        {
            this.infectado = 1;
        }
        public void desinfectaractual()
        {
            this.infectado = 0;
        }
        public int comprobarfuturo()
        {
            return this.infectadofuturo;
        }
    }
}
