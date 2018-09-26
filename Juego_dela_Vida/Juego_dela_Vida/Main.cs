using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Juego_dela_Vida
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DataTable tabla;
        Celda[,] matriz;
        //Crear_enfermedad crear_enfermedad = new Crear_enfermedad();
        Rejilla rejilla;
        //Enfermedad[] listaenfermedades;
        int numbercolumns;
        int numberrows;

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            this.tabla = tabla;
            dataGrid_infectados.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGrid_infectados.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            Enfermedad nuevaenf = new Enfermedad("VIH",4);
            comboBox1.Items.Add(nuevaenf.damenombrenfermedad());
            comboBox1.SelectedIndex = 0;
                //listaenfermedades[0].
                //this.listaenfermedades[0].enfermedad("VIH", 4);
        }

        private void button_creargrid_Click(object sender, EventArgs e)
        {
            this.numbercolumns = System.Convert.ToInt32(textBox_columnas.Text);
            this.numberrows = System.Convert.ToInt32(textBox_filas.Text);


            Rejilla rejilla = new Rejilla();
            this.rejilla = rejilla;
            tabla = rejilla.creardatagrid(numberrows, numbercolumns);
            dataGrid_infectados.DataSource = tabla;
            Celda[,] matriz = rejilla.crearmatriz(numberrows, numbercolumns);
            this.matriz = matriz;
            int i = 0;

            while (i < numbercolumns)
            {
                int j = 0;
                while (j < numberrows)
                {
                    matriz[i, j] = new Celda(numbercolumns, numberrows, 0);
                    if (matriz[i, j].comprobarcelda() == 1)
                    {
                        dataGrid_infectados.Rows[j].Cells[i].Style.BackColor = Color.Green;
                    }
                    else
                    {

                    }
                    j++;
                }
                i++;
            }


        }

        private void dataGrid_infectados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            dataGrid_infectados.CurrentCell.Style.BackColor = Color.Green;
            matriz[i, j].infectaractual();
            int prueba = matriz[i, j].comprobarcelda();
        }

        private void button_crearenfermedad_Click(object sender, EventArgs e)
        {
            Crear_enfermedad crearenfermedad = new Crear_enfermedad();
            crearenfermedad.Show();
        }

        private void button_ciclo_Click(object sender, EventArgs e)
        {
            matriz = rejilla.comprobarfuturo(matriz, 2);
            matriz = rejilla.actualizarCeldas(matriz);

            int i = 0;

            while (i < numberrows)
            {
                int j = 0;

                while (j < numbercolumns)
                {
                    if (matriz[i, j].comprobarcelda() == 1)
                    {
                        dataGrid_infectados.Rows[j].Cells[i].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        dataGrid_infectados.Rows[j].Cells[i].Style.BackColor = Color.White;
                    }
                    j++;
                }
                i++;
            }
        }


    }
}
