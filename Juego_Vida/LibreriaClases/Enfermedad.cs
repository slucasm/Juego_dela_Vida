using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaClases
{
    public class Enfermedad
    {

        int reglayainfect;
        int reglanoinfect;
        string nombre;

        public Enfermedad(string nombre, int reglayainfect, int reglanoinfect)
        {
            this.nombre = nombre;
            this.reglayainfect = reglayainfect;
            this.reglanoinfect = reglanoinfect;
        }
        public Enfermedad()
        {
        }
        public void creoenfermedad(string nombre, int reglayainfect, int reglanoinfect)
        {
            this.nombre = nombre;
            this.reglayainfect = reglayainfect;
            this.reglanoinfect = reglanoinfect;
        }

        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setreglayainfect(int reglayainfect)
        {
            this.reglayainfect = reglayainfect;
        }
        public void setreglanoinfect(int reglanoinfect)
        {
            this.reglanoinfect = reglanoinfect;
        }
        public int getreglayainfect()
        {
            return this.reglayainfect;
        }
        public int getreglanoinfect()
        {
            return this.reglanoinfect;
        }
        public string getnombrenfermedad()
        {
            return this.nombre;
        }

    }
}
