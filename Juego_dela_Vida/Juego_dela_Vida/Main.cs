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
        Rejilla rejilla;
        int numbercolumns;
        int numberrows;

        public string nombrenuevaenfermedad;
        public int reglanuevaenfermedad;
        public int contadorenfermedades;

        string[] nombreenfermedades = new string[5];
        int[] reglasenfermedades = new int[5];


        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.nombreenfermedades = new string[5];
                this.reglasenfermedades = new int[5];
                for (int i = 0; i <= nombreenfermedades.Length; i++)
                {
                    Array.Clear(nombreenfermedades, 0, nombreenfermedades.Length);
                    Array.Clear(reglasenfermedades, 0, reglasenfermedades.Length);
                }

                this.contadorenfermedades = 1;
                DataTable tabla = new DataTable();
                this.tabla = tabla;
                dataGrid_infectados.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dataGrid_infectados.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                Enfermedad nueva = new Enfermedad();
                nueva.creoenfermedad("VIH", 4);
                nombreenfermedades[0] = Convert.ToString(nueva.damenombrenfermedad());
                reglasenfermedades[0] = nueva.devolvernumeroinfectadosalrededor();
                comboBox1.Items.Add(nombreenfermedades[0]);
                comboBox1.SelectedIndex = 0;
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
                int prueba = matriz[i, j].comprobarcelda();
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
                int indicecombobox = comboBox1.SelectedIndex;
                this.matriz = rejilla.comprobarfuturo(this.matriz, reglasenfermedades[indicecombobox]);
                this.matriz = rejilla.actualizarCeldas(matriz);

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
                int indicecombobox = comboBox1.SelectedIndex;
                matriz = rejilla.comprobarfuturo(matriz, reglasenfermedades[indicecombobox]);
                matriz = rejilla.actualizarCeldas(matriz);

                for (int i = 0; i < numberrows; i++)
                {
                    for (int j = 0; j < numbercolumns; j++)
                    {
                        if (matriz[i, j].comprobarcelda() == 1)
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

        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.ShowDialog();
                ofd.DefaultExt = "txt";
                ofd.Filter = "Archivos txt(*.txt)|*.txt";
                ofd.Title = "Guarda los datos";
                string nombre = ofd.FileName;
                Fichero n = new Fichero(nombre);
                n.guardarrejilla(nombre, matriz, numbercolumns, numberrows, nombreenfermedades[comboBox1.SelectedIndex], reglasenfermedades[comboBox1.SelectedIndex]);
                MessageBox.Show("Data succesfully stored");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            try
            {
                for (int x = 1; x < contadorenfermedades; x++)
                {
                    Enfermedad nuevaenf = new Enfermedad();
                    nuevaenf.creoenfermedad(nombrenuevaenfermedad, reglanuevaenfermedad);
                    nombreenfermedades[x] = nuevaenf.damenombrenfermedad();
                    reglasenfermedades[x] = nuevaenf.devolvernumeroinfectadosalrededor();
                    comboBox1.Items.Add(nombreenfermedades[x]);
                }
            }
            catch (Exception j)
            {
                MessageBox.Show(j.Message);
            }
        }

        private void button_abrir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos txt(*.txt)|*.txt";
                ofd.ShowDialog();
                string nombre = ofd.FileName;

                Fichero n = new Fichero(nombre);
                matriz = n.abrirfichero(nombre);
                this.matriz = matriz;
                textBox_columnas.Text = Convert.ToString(n.abrircolumnas(nombre));
                textBox_filas.Text = Convert.ToString(n.abrirfilas(nombre));
                if (string.Compare(n.abrirnombre(nombre), "VIH") == 1)
                {

                }
                else
                {
                    nombreenfermedades[contadorenfermedades] = n.abrirnombre(nombre);
                    reglasenfermedades[contadorenfermedades] = n.abrirregla(nombre);
                    comboBox1.Items.Add(n.abrirnombre(nombre));
                    comboBox1.SelectedIndex = comboBox1.Items.Count-1;

                }
                Rejilla r = new Rejilla();
                this.rejilla = r;
                tabla = r.creardatagrid(n.abrirfilas(nombre), n.abrircolumnas(nombre)); ;
                this.tabla = tabla;
                dataGrid_infectados.DataSource = tabla;
                this.numberrows = n.abrirfilas(nombre);
                this.numbercolumns = n.abrircolumnas(nombre);
                for (int i = 0; i < numberrows; i++)
                {
                    for (int j = 0; j < numbercolumns; j++)
                    {
                        if (matriz[i, j].comprobarcelda() == 1)
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
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }
    }
}
