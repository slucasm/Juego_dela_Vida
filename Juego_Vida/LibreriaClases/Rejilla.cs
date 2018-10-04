using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace LibreriaClases
{
    public class Rejilla
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

        public Celda[,] contarinfectadosalrededor(Celda[,] matriz)
        {
            int fila = 0;
            numberrows = matriz.GetLength(0);
            numbercolumns = matriz.GetLength(1);
            while (fila < numberrows)
            {
                int columna = 0;
                int contador = 0;
                while (columna < numbercolumns)
                {
                    if (fila == 0 & columna == 0)
                    {

                        contador = matriz[1, 0].comprobarcelda() + matriz[1, 1].comprobarcelda() + matriz[0, 1].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila == 0 & columna != 0 & columna != numbercolumns - 1)
                    {
                        contador = matriz[fila, columna - 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda() + matriz[fila + 1, columna + 1].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila == 0 & columna == numbercolumns - 1)
                    {
                        contador = matriz[fila, columna - 1].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila != 0 & columna == 0 & fila != numberrows - 1)
                    {
                        contador = matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda() + matriz[fila + 1, columna + 1].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila != 0 & columna == numbercolumns - 1 & fila != numberrows - 1)
                    {
                        contador = matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila, columna - 1].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila == numberrows - 1 & columna == 0)
                    {
                        contador = matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila == numberrows - 1 & columna != numbercolumns - 1 & columna != 0)
                    {
                        contador = matriz[fila, columna - 1].comprobarcelda() + matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }
                    else if (fila == numberrows - 1 & columna == numbercolumns - 1)
                    {
                        contador = matriz[fila, columna - 1].comprobarcelda() + matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila - 1, columna].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);
                    }

                    else if (fila != 0 & fila != numberrows - 1 & columna != 0 & columna != numbercolumns - 1)
                    {
                        contador = matriz[fila - 1, columna - 1].comprobarcelda() + matriz[fila - 1, columna].comprobarcelda() + matriz[fila - 1, columna + 1].comprobarcelda() + matriz[fila, columna + 1].comprobarcelda() + matriz[fila + 1, columna + 1].comprobarcelda() + matriz[fila + 1, columna].comprobarcelda() + matriz[fila + 1, columna - 1].comprobarcelda() + matriz[fila, columna - 1].comprobarcelda();
                        matriz[fila, columna].setCeldasInfAlrededor(contador);

                    }
                    columna++;
                }

                fila++;
            }
            return matriz;
        }

        public Celda[,] evolucionar(Celda[,] matriz)
        {
            for (int i = 0; i < numberrows; i++)
            {
                for (int j = 0; j < numbercolumns; j++)
                {
                    matriz[i, j].evolucionar();
                }
            }
            return matriz;
        }

        public Celda[,] actualizar(Celda[,] matriz)
        {
            for (int i = 0; i < numberrows; i++)
            {
                for (int j = 0; j < numbercolumns; j++)
                {
                    matriz[i, j].actualizar();
                }
            }
            return matriz;
        }

        public void setEnfermedadceldas(Celda[,] matriz,Enfermedad enfermedad)
        {
            for (int i = 0; i < numberrows; i++)
            {
                for (int j = 0; j < numbercolumns; j++)
                {
                    matriz[i, j].setEnfermedad(enfermedad);
                }
            }
        }




    }
}
