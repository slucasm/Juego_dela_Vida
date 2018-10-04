﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibreriaClases
{
    public class Fichero
    {

        //Celda[,] matriz;
        string nombrearchivo;

        public Fichero(string nombrearchivo)
        {
            this.nombrearchivo = nombrearchivo;
        }

        public void guardarrejilla(string archivo, Celda[,] matriz, int columnas, int filas, string nombreenfermedad, int reglaenfermedad)
        {
            int numberrows = matriz.GetLength(0);
            int numbercolumns = matriz.GetLength(1);
            StreamWriter fichero = new StreamWriter(archivo);
            fichero.Write(columnas);
            fichero.Write("\r\n");
            fichero.Write(filas);
            fichero.Write("\r\n");
            fichero.Write(nombreenfermedad);
            fichero.Write("\r\n");
            fichero.Write(reglaenfermedad);
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
        public Celda[,] abrirfichero(string nombrearchivo)
        {
            StreamReader fichero = new StreamReader(nombrearchivo);
            Enfermedad e = new Enfermedad();
            e.setnombre(fichero.ReadLine());
            e.setreglayainfect(Convert.ToInt32(fichero.ReadLine()));
            e.setreglanoinfect(Convert.ToInt32(fichero.ReadLine()));
            int columna = Convert.ToInt32(fichero.ReadLine());
            int fila = Convert.ToInt32(fichero.ReadLine());
            Celda[,] matriz = new Celda[fila, columna];
            string nombreenfermedad = fichero.ReadLine();
            int regla = Convert.ToInt32(fichero.ReadLine());

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
            return matriz;
        }

        public int abrirfilas(string archivo)
        {
            StreamReader fichero = new StreamReader(archivo);
            int columna = Convert.ToInt32(fichero.ReadLine());
            int fila = Convert.ToInt32(fichero.ReadLine());
            return fila;
        }
        public int abrircolumnas(string archivo)
        {
            StreamReader fichero = new StreamReader(archivo);
            int columna = Convert.ToInt32(fichero.ReadLine());
            return columna;
        }
        public string abrirnombre(string archivo)
        {
            StreamReader fichero = new StreamReader(archivo);
            int columna = Convert.ToInt32(fichero.ReadLine());
            int fila = Convert.ToInt32(fichero.ReadLine());
            string nombreenfermedad = fichero.ReadLine();
            return nombreenfermedad;
        }
        public int abrirregla(string archivo)
        {
            StreamReader fichero = new StreamReader(archivo);
            int columna = Convert.ToInt32(fichero.ReadLine());
            int fila = Convert.ToInt32(fichero.ReadLine());
            string nombreenfermedad = fichero.ReadLine();
            int regla = Convert.ToInt32(fichero.ReadLine());
            return regla;
        }


    }
}