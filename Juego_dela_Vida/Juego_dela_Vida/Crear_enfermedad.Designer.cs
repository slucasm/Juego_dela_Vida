namespace Juego_dela_Vida
{
    partial class Crear_enfermedad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_crearenfermedad = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_numinfectadosalrededor = new System.Windows.Forms.TextBox();
            this.label_nombreenferemdad = new System.Windows.Forms.Label();
            this.label_numinfectadosalrededor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_crearenfermedad
            // 
            this.button_crearenfermedad.Location = new System.Drawing.Point(136, 166);
            this.button_crearenfermedad.Name = "button_crearenfermedad";
            this.button_crearenfermedad.Size = new System.Drawing.Size(121, 23);
            this.button_crearenfermedad.TabIndex = 0;
            this.button_crearenfermedad.Text = "Crear enfermedad";
            this.button_crearenfermedad.UseVisualStyleBackColor = true;
            this.button_crearenfermedad.Click += new System.EventHandler(this.button_crearenfermedad_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(177, 49);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 1;
            // 
            // textBox_numinfectadosalrededor
            // 
            this.textBox_numinfectadosalrededor.Location = new System.Drawing.Point(253, 104);
            this.textBox_numinfectadosalrededor.Name = "textBox_numinfectadosalrededor";
            this.textBox_numinfectadosalrededor.Size = new System.Drawing.Size(100, 20);
            this.textBox_numinfectadosalrededor.TabIndex = 2;
            // 
            // label_nombreenferemdad
            // 
            this.label_nombreenferemdad.AutoSize = true;
            this.label_nombreenferemdad.Location = new System.Drawing.Point(47, 52);
            this.label_nombreenferemdad.Name = "label_nombreenferemdad";
            this.label_nombreenferemdad.Size = new System.Drawing.Size(103, 13);
            this.label_nombreenferemdad.TabIndex = 3;
            this.label_nombreenferemdad.Text = "Nombre enfermedad";
            // 
            // label_numinfectadosalrededor
            // 
            this.label_numinfectadosalrededor.AutoSize = true;
            this.label_numinfectadosalrededor.Location = new System.Drawing.Point(12, 107);
            this.label_numinfectadosalrededor.Name = "label_numinfectadosalrededor";
            this.label_numinfectadosalrededor.Size = new System.Drawing.Size(235, 13);
            this.label_numinfectadosalrededor.TabIndex = 4;
            this.label_numinfectadosalrededor.Text = "Celdas infectados alrededor para estar infectado";
            // 
            // Crear_enfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 218);
            this.Controls.Add(this.label_numinfectadosalrededor);
            this.Controls.Add(this.label_nombreenferemdad);
            this.Controls.Add(this.textBox_numinfectadosalrededor);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_crearenfermedad);
            this.Name = "Crear_enfermedad";
            this.Text = "Crear_enfermedad";
            this.Load += new System.EventHandler(this.Crear_enfermedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_crearenfermedad;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_numinfectadosalrededor;
        private System.Windows.Forms.Label label_nombreenferemdad;
        private System.Windows.Forms.Label label_numinfectadosalrededor;
    }
}