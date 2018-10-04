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
    public partial class Crear_enfermedad : Form
    {
        Main originalForm;
        public Crear_enfermedad(Main incomingForm)
        {
            try
            {
                originalForm = incomingForm;
                InitializeComponent();
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void Crear_enfermedad_Load(object sender, EventArgs e)
        {

        }

        private void button_crearenfermedad_Click(object sender, EventArgs e)
        {
            try
            {
                

                string nombre = (textBox_nombre.Text);
                int reglaya = (Convert.ToInt32(textBox_yainfect_regla.Text));
                int reglano = (Convert.ToInt32(textBox_noinfect_regla.Text));
                Enfermedad nuevaenfermedad = new Enfermedad(nombre,reglaya,reglano);
                originalForm.listaenfermedades.Add(nuevaenfermedad);
                //originalForm.rejilla.setEnfermedadceldas(originalForm.matriz, nuevaenfermedad);
                this.Close();
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }
    }
}
