using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaClases
{
    public class Celda
    {

        int infectado;
        int infectadofuturo;
        int celdasinfectadasalrededor;
        Enfermedad enfermedad;

        public Celda(int infectado, Enfermedad enfermedad)
        {
            this.infectado = infectado;
            this.enfermedad = enfermedad;
        }
        public void setCeldasInfAlrededor(int celdasinfalrededor)
        {
            this.celdasinfectadasalrededor = celdasinfalrededor;
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

        public void estado(int i)
        {
            this.infectado = i;
        }
        public void evolucionar()
        {
            if (infectado == 1)
                if (enfermedad.getreglayainfect() <= celdasinfectadasalrededor)
                    infectadofuturo = 1;
                else
                    infectadofuturo = 0;
            else
                if (enfermedad.getreglanoinfect() <= celdasinfectadasalrededor)
                    infectadofuturo = 1;
                else
                    infectadofuturo = 0;
        }
        public void actualizar()
        {
            this.infectado = infectadofuturo;
            this.infectadofuturo = 0;
        }
        public void setEnfermedad(Enfermedad enfermedad)
        {
            this.enfermedad = enfermedad;
        }
    }
}
