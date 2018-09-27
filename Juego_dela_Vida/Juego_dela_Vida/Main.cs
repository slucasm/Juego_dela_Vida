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

        public string nombrenuevaenfermedad;
        public int reglanuevaenfermedad;
        public int contadorenfermedades = 0;

        string[] nombreenfermedades = new string[5];
        int[] reglasenfermedades = new int[5];
        

        private void Main_Load(object sender, EventArgs e)
        {
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
            Crear_enfermedad crearenfermedad = new Crear_enfermedad(this);
            crearenfermedad.Show();
        }

        private void button_ciclo_Click(object sender, EventArgs e)
        {
            int indicecombobox = comboBox1.SelectedIndex;
            matriz = rejilla.comprobarfuturo(matriz, reglasenfermedades[indicecombobox]);
            matriz = rejilla.actualizarCeldas(matriz);

            for (int i = 0; i < numberrows; i++)
            {
                for (int j = 0; j < numbercolumns; j++ )
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

        private void timer_simulacion_Tick(object sender, EventArgs e)
        {
            int indicecombobox = comboBox1.SelectedIndex;
            matriz = rejilla.comprobarfuturo(matriz, reglasenfermedades[indicecombobox]);
            matriz = rejilla.actualizarCeldas(matriz);

            for (int i = 0; i < numberrows; i++ )
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

        private void button_play_Click(object sender, EventArgs e)
        {
            timer_simulacion.Interval = 1000;
            timer_simulacion.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer_simulacion.Stop();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.ShowDialog();
            ofd.DefaultExt = "txt";
            ofd.Filter = "Archivo de texto(.txt)|*.txt";
            ofd.Title = "Guarda los datos";
            string nombre = ofd.FileName;
            rejilla.guardarrejilla(nombre, matriz, numbercolumns, numberrows, nombreenfermedades[comboBox1.SelectedIndex], reglasenfermedades[comboBox1.SelectedIndex]);
            MessageBox.Show("Data succesfully stored");
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            //MessageBox.Show(nombrenuevaenfermedad);
            for (int x = 1; x <= contadorenfermedades; x++)
            {
                Enfermedad nuevaenf = new Enfermedad();
                nuevaenf.creoenfermedad(nombrenuevaenfermedad, reglanuevaenfermedad);
                nombreenfermedades[x] = nuevaenf.damenombrenfermedad();
                reglasenfermedades[x] = nuevaenf.devolvernumeroinfectadosalrededor();
                comboBox1.Items.Add(nombreenfermedades[x]);
            }
        }

        private void button_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string nombre = ofd.SafeFileName;
            //matriz = rejilla.abrircelda(nombre);
            textBox_columnas.Text = Convert.ToString(rejilla.abrircolumna(nombre));
            textBox_filas.Text = Convert.ToString(rejilla.abrirfilas(nombre));
            if (string.Compare(rejilla.abrirnombre(nombre),"VIH")==1)
            {
            }
            else
            {
                nombreenfermedades[1] = rejilla.abrirnombre(nombre);
                reglasenfermedades[1] = rejilla.abrirregla(nombre);
            }
            //(matriz,label_columnas,label_filas,nombrenuevaenfermedad,reglanuevaenfermedad)=rejilla.abrirarchivo(nombre);
        }
        

    }
}
