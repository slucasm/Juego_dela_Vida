using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibreriaClases
{
    public class Fichero
    {

        string nombrearchivo;

        public Fichero(string nombrearchivo)
        {
            this.nombrearchivo = nombrearchivo;
        }


        public void guardar(Celda[,] matriz,Enfermedad enfermedad)
        {
            int numberrows = matriz.GetLength(0);
            int numbercolumns = matriz.GetLength(1);
            StreamWriter fichero = new StreamWriter(this.nombrearchivo);
            fichero.Write(enfermedad.getnombrenfermedad());
            fichero.Write("\r\n");
            fichero.Write(enfermedad.getreglayainfect());
            fichero.Write("\r\n");
            fichero.Write(enfermedad.getreglanoinfect());
            fichero.Write("\r\n");
            fichero.Write(numbercolumns);
            fichero.Write("\r\n");
            fichero.Write(numberrows);
            fichero.Write("\r\n");
            
            for (int i = 0; i < numberrows; i++)
            {
                for (int j = 0; j < numbercolumns; j++)
                {
                    fichero.Write(matriz[i, j].comprobarcelda());
                    fichero.Write(" ");
                }
                fichero.Write("\r\n");
            }
            fichero.Close();
        }

        public Tuple<Celda[,],int, int, Enfermedad> abrir()
        {
            StreamReader fichero = new StreamReader(this.nombrearchivo);
            Enfermedad e = new Enfermedad();
            e.setnombre(fichero.ReadLine());
            e.setreglayainfect(Convert.ToInt32(fichero.ReadLine()));
            e.setreglanoinfect(Convert.ToInt32(fichero.ReadLine()));
            int columna = Convert.ToInt32(fichero.ReadLine());
            int fila = Convert.ToInt32(fichero.ReadLine());
            Celda[,] matriz = new Celda[fila, columna];

            for (int i = 0; i < fila; i++)
            {
                string linea = Convert.ToString(fichero.ReadLine());
                string[] trozos = linea.Split();
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = new Celda(Convert.ToInt32(trozos[j]), e);
                }
            }
            fichero.Close();
            return Tuple.Create(matriz,fila,columna,e);
        }
    }
}
