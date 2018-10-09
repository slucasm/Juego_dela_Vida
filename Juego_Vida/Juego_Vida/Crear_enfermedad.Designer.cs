namespace Juego_Vida
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
            this.textBox_noinfect_regla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_numinfectadosalrededor = new System.Windows.Forms.Label();
            this.label_nombreenferemdad = new System.Windows.Forms.Label();
            this.textBox_yainfect_regla = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.button_crearenfermedad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_noinfect_regla
            // 
            this.textBox_noinfect_regla.Location = new System.Drawing.Point(331, 163);
            this.textBox_noinfect_regla.Name = "textBox_noinfect_regla";
            this.textBox_noinfect_regla.Size = new System.Drawing.Size(100, 20);
            this.textBox_noinfect_regla.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Celdas infectadas alrededor necesarias para infectarse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Si la celda no está infectada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Si la celda ya está infectada:";
            // 
            // label_numinfectadosalrededor
            // 
            this.label_numinfectadosalrededor.AutoSize = true;
            this.label_numinfectadosalrededor.Location = new System.Drawing.Point(22, 102);
            this.label_numinfectadosalrededor.Name = "label_numinfectadosalrededor";
            this.label_numinfectadosalrededor.Size = new System.Drawing.Size(294, 13);
            this.label_numinfectadosalrededor.TabIndex = 22;
            this.label_numinfectadosalrededor.Text = "Celdas infectadas alrededor necesarias para seguir infectado";
            // 
            // label_nombreenferemdad
            // 
            this.label_nombreenferemdad.AutoSize = true;
            this.label_nombreenferemdad.Location = new System.Drawing.Point(57, 43);
            this.label_nombreenferemdad.Name = "label_nombreenferemdad";
            this.label_nombreenferemdad.Size = new System.Drawing.Size(103, 13);
            this.label_nombreenferemdad.TabIndex = 21;
            this.label_nombreenferemdad.Text = "Nombre enfermedad";
            // 
            // textBox_yainfect_regla
            // 
            this.textBox_yainfect_regla.Location = new System.Drawing.Point(331, 102);
            this.textBox_yainfect_regla.Name = "textBox_yainfect_regla";
            this.textBox_yainfect_regla.Size = new System.Drawing.Size(100, 20);
            this.textBox_yainfect_regla.TabIndex = 20;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(187, 40);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 19;
            // 
            // button_crearenfermedad
            // 
            this.button_crearenfermedad.Location = new System.Drawing.Point(176, 198);
            this.button_crearenfermedad.Name = "button_crearenfermedad";
            this.button_crearenfermedad.Size = new System.Drawing.Size(121, 23);
            this.button_crearenfermedad.TabIndex = 18;
            this.button_crearenfermedad.Text = "Crear enfermedad";
            this.button_crearenfermedad.UseVisualStyleBackColor = true;
            this.button_crearenfermedad.Click += new System.EventHandler(this.button_crearenfermedad_Click);
            // 
            // Crear_enfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.textBox_noinfect_regla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_numinfectadosalrededor);
            this.Controls.Add(this.label_nombreenferemdad);
            this.Controls.Add(this.textBox_yainfect_regla);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_crearenfermedad);
            this.Name = "Crear_enfermedad";
            this.Text = "Crear_enfermedad";
            this.Load += new System.EventHandler(this.Crear_enfermedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_noinfect_regla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_numinfectadosalrededor;
        private System.Windows.Forms.Label label_nombreenferemdad;
        private System.Windows.Forms.TextBox textBox_yainfect_regla;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_crearenfermedad;
    }
}