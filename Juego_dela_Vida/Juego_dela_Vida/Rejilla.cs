using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;

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
                        matriz[i, j].desinfectaractual();
                        matriz[i, j].desinfectarfuturo();
                    }
                    j++;
                }
                i++;
            }
            return matriz;
        }

        public void rejillactual(Celda[,] matriz)
        {
            int rowLength = matriz.GetLength(0);
            int colLength = matriz.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    MessageBox.Show(System.Convert.ToString(matriz[i, j].comprobarcelda()));
                }
                //Console.Write(Environment.NewLine + Environment.NewLine);
            }
            //Console.ReadLine();
        }

        public void guardarrejilla(string archivo, Celda[,] matriz)
        {
            StreamWriter fichero = new StreamWriter(archivo);

            for (int i = 0; i < numberrows; i++)
            {
                for (int j = 0; j < numbercolumns; j++)
                {
                    fichero.Write(matriz[i, j].comprobarcelda());
                }
                fichero.Write("\r\n");
            }
            fichero.Close();
        }
    }
}
