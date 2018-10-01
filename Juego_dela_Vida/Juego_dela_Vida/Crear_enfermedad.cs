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
                originalForm.nombrenuevaenfermedad = textBox_nombre.Text;
                originalForm.reglanuevaenfermedad = Convert.ToInt32(textBox_numinfectadosalrededor.Text);
                originalForm.contadorenfermedades++;
                this.Close();
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }
    }
}
