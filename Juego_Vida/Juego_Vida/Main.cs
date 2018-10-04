using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaClases;

namespace Juego_Vida
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DataTable tabla;
        public Celda[,] matriz;
        public Rejilla rejilla;
        int numbercolumns;
        int numberrows;

        public List<Enfermedad> listaenfermedades;
        public string nombrenuevaenfermedad;
        public int yainfectado_regla;
        public int noinfectado_regla;
        public Enfermedad enfermedad = new Enfermedad();

        private void Main_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable tabla = new DataTable();
                this.tabla = tabla;
                //dataGrid_infectados.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                //dataGrid_infectados.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                List<Enfermedad> listaenfermedades = new List<Enfermedad>();
                Enfermedad nueva = new Enfermedad("Dengue",4,7);
                listaenfermedades.Add(nueva);
                this.listaenfermedades = listaenfermedades;
                //nueva.setnombre("Dengue");
                //nueva.setreglanoinfect(4);
                //nueva.setreglayainfect(7);
                //listaenfermedades.Add(nueva);
                //listaenfermedades[0] = nueva;
                comboBox_enfermedades.Items.Add(nueva.getnombrenfermedad());
                comboBox_enfermedades.SelectedIndex = 0;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
       
        }

        private void button_creargrid_Click(object sender, EventArgs e)
        {
            try
            {
                this.numbercolumns = System.Convert.ToInt32(textBox_columnas.Text);
                this.numberrows = System.Convert.ToInt32(textBox_filas.Text);


                Rejilla rejilla = new Rejilla();
                this.rejilla = rejilla;
                tabla = rejilla.creardatagrid(numberrows, numbercolumns);
                dataGrid_infectados.DataSource = tabla;
                Celda[,] matriz = rejilla.crearmatriz(numberrows, numbercolumns);
                this.matriz = matriz;

                for (int i = 0; i < numbercolumns; i++)
                {
                    for (int j = 0; j < numberrows; j++)
                    {
                        matriz[i, j] = new Celda(0, enfermedad);
                        if (matriz[i, j].comprobarcelda() == 1)
                        {
                            dataGrid_infectados.Rows[j].Cells[i].Style.BackColor = Color.Green;
                        }
                        else
                        {

                        }
                    }
                }


            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void dataGrid_infectados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                int j = e.ColumnIndex;
                dataGrid_infectados.CurrentCell.Style.BackColor = Color.Green;
                matriz[i, j].infectaractual();
                dataGrid_infectados.ClearSelection();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void button_crearenfermedad_Click(object sender, EventArgs e)
        {
            try
            {
                Crear_enfermedad crearenfermedad = new Crear_enfermedad(this);
                crearenfermedad.Show();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button_ciclo_Click(object sender, EventArgs e)
        {
            try
            {
                this.rejilla.setEnfermedadceldas(matriz, listaenfermedades[comboBox_enfermedades.SelectedIndex]);
                this.matriz = rejilla.contarinfectadosalrededor(matriz);
                this.matriz = rejilla.evolucionar(matriz);
                this.matriz = rejilla.actualizar(matriz);
                for (int i = 0; i < numberrows; i++)
                {
                    for (int j = 0; j < numbercolumns; j++)
                    {
                        if (this.matriz[i, j].comprobarcelda() == 1)
                        {
                            dataGrid_infectados.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            dataGrid_infectados.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void timer_simulacion_Tick(object sender, EventArgs e)
        {
            try
            {
                rejilla.setEnfermedadceldas(matriz, listaenfermedades[comboBox_enfermedades.SelectedIndex]);
                this.matriz = rejilla.contarinfectadosalrededor(matriz);
                this.matriz = rejilla.evolucionar(matriz);
                this.matriz = rejilla.actualizar(matriz);

                for (int i = 0; i < numberrows; i++)
                {
                    for (int j = 0; j < numbercolumns; j++)
                    {
                        if (this.matriz[i, j].comprobarcelda() == 1)
                        {
                            dataGrid_infectados.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            dataGrid_infectados.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            try
            {
                timer_simulacion.Interval = 1000;
                timer_simulacion.Start();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                timer_simulacion.Stop();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void comboBox_enfermedades_DropDown(object sender, EventArgs e)
        {
            comboBox_enfermedades.Items.Clear();
            for (int i = 0; i < listaenfermedades.Count; i++)
            {
                comboBox_enfermedades.Items.Add(listaenfermedades[i].getnombrenfermedad());
            }

        }




    }
}
