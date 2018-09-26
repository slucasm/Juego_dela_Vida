﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Juego_dela_Vida
{
    class Rejilla
    {
        Celda[,] matriz;
        int numberrows;
        int numbercolumns;

        public DataTable creardatagrid(int numberrows, int numbercolumns)
        {

            DataTable tabla = new DataTable();
            for (int contadorrows = 0; contadorrows < numberrows; contadorrows++)
                tabla.Rows.Add();
            for (int contadorcolumns = 0; contadorcolumns < numbercolumns; contadorcolumns++)
                tabla.Columns.Add();
            return tabla;

        }

        public Celda[,] crearmatriz(int numberrows, int numbercolumns)
        {
            this.matriz = new Celda[numbercolumns, numbercolumns];
            this.numbercolumns = numbercolumns;
            this.numberrows = numberrows;
            return matriz;
        }


        public Celda[,] comprobarfuturo(Celda[,] matriz, int regla_numalrededor)
        {
            int fila = 0;

            while (fila < numberrows)
            {
                int columna = 0;
                while (columna < numbercolumns)
                {
                    if (fila == 0 & columna == 0)
                    {
                        if ((matriz[1, 0].comprobarcelda() + matriz[1, 1].comprobarcelda() + matriz[0, 1].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila == 0 & columna != 0 & columna != numbercolumns-1)
                    {
                        if ((matriz[fila, columna - 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda() + matriz[fila + 1, columna + 1].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila == 0 & columna == numbercolumns-1)
                    {
                        if ((matriz[fila, columna - 1].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila != 0 & columna == 0 & fila != numberrows-1)
                    {
                        if ((matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda() + matriz[fila + 1, columna + 1].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila != 0 & columna == numbercolumns-1 & fila != numberrows-1)
                    {
                        if ((matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila, columna - 1].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila == numberrows-1 & columna == 0)
                    {
                        if ((matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila == numberrows-1 & columna != numbercolumns-1 & columna != 0)
                    {
                        if ((matriz[fila, columna - 1].comprobarcelda() + matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }
                    else if (fila == numberrows-1 & columna == numbercolumns-1)
                    {
                        if ((matriz[fila, columna - 1].comprobarcelda() + matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila - 1, columna].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }
                    }

                    else if (fila != 0 & fila != numberrows-1 & columna != 0 & columna != numbercolumns-1)
                    {
                        if ((matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda() + matriz[fila + 1, columna + 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila, columna - 1].comprobarcelda()) >= regla_numalrededor)
                        {
                            matriz[fila, columna].infectarfuturo();
                        }
                        else
                        {
                            matriz[fila, columna].desinfectarfuturo();
                        }

                    }
                    columna++;
                }

                fila++;
            }
            return matriz;
        }

        public Celda[,] actualizarCeldas(Celda[,] matriz)
        {
            int i = 0;

            while (i < numberrows)
            {
                int j = 0;

                while (j < numbercolumns)
                {
                    int futuro = matriz[i, j].comprobarfuturo();
                    if (futuro == 1)
                    {
                        matriz[i, j].infectaractual();
                        matriz[i, j].desinfectarfuturo();
                    }
                    else
                    {
                        matriz[i, j].desinfectarfuturo();
                    }
                    j++;
                }
                i++;
            }
            return matriz;
        }
    }
}
